using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Onspring.ApiDemo.Properties;
using Onspring.API.SDK.Enums;
using Onspring.API.SDK.Helpers;
using Onspring.API.SDK.Models;
using Onspring.API.SDK.ResultValues;
// ReSharper disable UseStringInterpolation

namespace Onspring.ApiDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            txtBaseAddress.Text = Settings.Default.BaseAddress;
            txtApiKey.Text = Settings.Default.ApiKey;
        }

        private void AddLineToResults(string text)
        {
            txtResults.AppendText(text + Environment.NewLine);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResults.Clear();
        }

        private void ProcessRequest(Action action)
        {
            if (string.IsNullOrWhiteSpace(txtBaseAddress.Text))
            {
                MessageBox.Show("You must enter a Base Address");
                return;
            }
            try
            {
                UseWaitCursor = true;
                Settings.Default.BaseAddress = txtBaseAddress.Text;
                Settings.Default.ApiKey = txtApiKey.Text;
                Settings.Default.Save();
                action();
            }
            catch (Exception ex)
            {
                AddLineToResults("EXCEPTION: " + ex.Message);
            }
            finally
            {
                AddLineToResults(new string('=', 40));
                UseWaitCursor = false;
            }
        }

        private HttpHelper CreateHttpHelper()
        {
            return new HttpHelper(txtBaseAddress.Text, txtApiKey.Text);
        }

        private void btnGetAppList_Click(object sender, EventArgs e)
        {
            ProcessRequest(() =>
            {
                AddLineToResults("/apps");
                AddLineToResults("Id, Name");
                var helper = CreateHttpHelper();
                foreach (var app in helper.GetApps())
                {
                    AddLineToResults(string.Format("{0}, \"{1}\"", app.Id, app.Name));
                }
            });
        }

        private void btnGetFieldList_Click(object sender, EventArgs e)
        {
            ProcessRequest(() =>
            {
                AddLineToResults("/fields?appId=" + txtGetFieldListAppId.Text);
                AddFieldHeaderToResults();
                var helper = CreateHttpHelper();
                foreach (var field in helper.GetAppFields(int.Parse(txtGetFieldListAppId.Text)))
                {
                    AddFieldToResults(field);
                }
            });
        }

        private void btnGetField_Click(object sender, EventArgs e)
        {
            ProcessRequest(() =>
            {
                AddLineToResults("/fields/" + txtGetFieldFieldId.Text);
                var helper = CreateHttpHelper();
                var field = helper.GetAppField(int.Parse(txtGetFieldFieldId.Text));
                AddFieldHeaderToResults();
                AddFieldToResults(field);
            });
        }

        private void AddFieldHeaderToResults()
        {
            AddLineToResults("Id, AppId, Name, Type, Status, IsRequired, IsUnique");
        }

        private void AddFieldToResults(Field field)
        {
            AddLineToResults(string.Format("{0}, {1}, \"{2}\", {3}, {4}, {5}, {6}", field.Id, field.AppId, field.Name,
                field.Type, field.Status, field.IsRequired, field.IsUnique));
            var formulaField = field as FormulaField;
            if (formulaField != null)
            {
                AddLineToResults(string.Format("\tOutputType: {0}", formulaField.OutputType));
                if (formulaField.OutputType == FormulaOutputType.List)
                {
                    AddListValuesToResult(formulaField.Values);
                }
            }
            var listField = field as ListField;
            if (listField != null)
            {
                AddLineToResults(string.Format("\tMultiplicity: {0}", listField.Multiplicity));
                AddListValuesToResult(listField.Values);
            }
            var referenceField = field as ReferenceField;
            if (referenceField != null)
            {
                AddLineToResults(string.Format("\tMultiplicity: {0}", referenceField.Multiplicity));
            }
        }

        private void AddListValuesToResult(IReadOnlyList<ListValue> listValues)
        {
            AddLineToResults("\tListValues: Id, Name, SortOrder, NumericValue, Color");
            foreach (var value in listValues)
            {
                AddLineToResults(string.Format("\t{0}, \"{1}\", {2}, {3}, {4}", value.Id, value.Name, value.SortOrder,
                    value.NumericValue, value.Color));
            }
        }

        private void btnGetReportList_Click(object sender, EventArgs e)
        {
            ProcessRequest(() =>
            {
                AddLineToResults("/reports?appId=" + txtGetReportListAppId.Text);
                AddLineToResults("Id, AppId, Name");
                var helper = CreateHttpHelper();
                foreach (var report in helper.GetAppReports(int.Parse(txtGetReportListAppId.Text)))
                {
                    AddLineToResults(string.Format("{0}, {1}, \"{2}\"", report.Id, report.AppId, report.Name));
                }
            });
        }

        private void btnGetReportData_Click(object sender, EventArgs e)
        {
            ProcessRequest(() =>
            {
                var urlHelper = new UrlHelper(txtBaseAddress.Text);
                var reportId = int.Parse(txtGetReportReportId.Text);
                var dataType = ParseEnum<ReportDataType>(cbGetReportDataType.Text);
                var dataFormat = ParseEnum<DataFormat>(cbGetReportDataFormat.Text);
                AddLineToResults(urlHelper.GetReportDataUri(reportId, dataType, dataFormat).ToString());
                var helper = CreateHttpHelper();
                var reportData = helper.GetReportData(reportId, dataType, dataFormat);
                AddLineToResults(string.Join(", ", reportData.Columns));
                foreach (var row in reportData.Rows)
                {
                    AddLineToResults(string.Join(", ", row.Cells));
                }
            });
        }

        private void btnGetRecords_Click(object sender, EventArgs e)
        {
            ProcessRequest(() =>
            {
                var urlHelper = new UrlHelper(txtBaseAddress.Text);
                var appId = int.Parse(txtGetRecordAppId.Text);
                var fieldIds = string.IsNullOrWhiteSpace(txtGetRecordFieldIds.Text)
                    ? null
                    : txtGetRecordFieldIds.Text.Split(',').Select(int.Parse).ToArray();
                var dataFormat = ParseEnum<DataFormat>(cbGetRecordDataFormat.Text);
                var helper = CreateHttpHelper();
                int recordId;
                if (int.TryParse(txtGetRecordRecordId.Text, out recordId))
                {
                    AddLineToResults(urlHelper.GetAppRecordUri(appId, recordId, fieldIds, dataFormat).ToString());
                    var record = helper.GetAppRecord(appId, recordId, fieldIds, dataFormat);
                    AddRecordToResults(record);
                }
                else
                {
                    var recordIds = string.IsNullOrWhiteSpace(txtGetRecordRecordId.Text)
                        ? null
                        : txtGetRecordRecordId.Text.Split(',').Select(int.Parse).ToArray();
                    AddLineToResults(urlHelper.GetAppRecordsUri(appId, txtGetRecordFilter.Text, recordIds, fieldIds, dataFormat).ToString());
                    var records = helper.GetAppRecords(appId, txtGetRecordFilter.Text, recordIds, fieldIds, dataFormat);
                    foreach (var record in records)
                    {
                        AddRecordToResults(record);
                    }
                }
            });
        }

        private void AddRecordToResults(ResultRecord record)
        {
            AddLineToResults(string.Format("AppId: {0}, RecordId: {1}", record.AppId, record.RecordId));
            foreach (var wrapper in record.Values.WithFieldId())
            {
                AddLineToResults(string.Format("\tFieldId: {0}, Type: {1}, Value: {2}", wrapper.FieldId,
                    wrapper.Value.Type, GetResultValueString(wrapper.Value)));
            }
        }

        private string GetResultValueString(ResultValue value)
        {
            switch (value.Type)
            {
                case ResultValueType.String:
                    return value.AsString;
                case ResultValueType.Integer:
                    return string.Format("{0}", value.AsNullableInteger);
                case ResultValueType.Decimal:
                    return string.Format("{0}", value.AsNullableDecimal);
                case ResultValueType.Date:
                    return string.Format("{0}", value.AsNullableDateTime);
                case ResultValueType.TimeSpan:
                    var data = value.AsTimeSpanData;
                    return string.Format("Quantity: {0}, Increment: {1}, Recurrence: {2}, EndByDate: {3}, EndAfterOccurrences: {4}", 
                        data.Quantity, data.Increment, data.Recurrence, data.EndByDate, data.EndAfterOccurrences);
                case ResultValueType.Guid:
                    return string.Format("{0}", value.AsNullableGuid);
                case ResultValueType.StringList:
                    return GetListValueString(value.AsStringList);
                case ResultValueType.IntegerList:
                    return GetListValueString(value.AsIntegerList);
                case ResultValueType.GuidList:
                    return GetListValueString(value.AsGuidList);
                case ResultValueType.AttachmentList:
                    var attachmentFiles = value.AsAttachmentList.Select(f =>
                        string.Format("FileId: {0}, FileName: \"{1}\", Notes: \"{2}\"", f.FileId, f.FileName, f.Notes));
                    return GetListValueString(attachmentFiles);
                case ResultValueType.ScoringGroupList:
                    var scoringGroups = value.AsScoringGroupList.Select(g =>
                        string.Format("ListValueId: {0}, Name: \"{1}\", Score: {2}, MaximumScore: {3}", g.ListValueId,
                            g.Name, g.Score, g.MaximumScore));
                    return GetListValueString(scoringGroups);
                default:
                    // e.g., future types not supported in this version
                    return string.Format("Unsupported ResultValueType: {0}", value.Type);
            }
        }

        private string GetListValueString<T>(IEnumerable<T> values)
        {
            const string lineBreak = "\r\n\t\t";
            return lineBreak + string.Join(lineBreak, values);
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            ProcessRequest(() =>
            {
                AddLineToResults(string.Format("DELETE /records/{0}/{1}", txtDeleteRecordAppId.Text, txtDeleteRecordRecordId.Text));
                var helper = CreateHttpHelper();
                var result = helper.DeleteAppRecord(int.Parse(txtDeleteRecordAppId.Text), int.Parse(txtDeleteRecordRecordId.Text));
                AddLineToResults(string.Format("Location: {0}", result.Location));
            });
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            ProcessRequest(() =>
            {
                AddLineToResults(string.Format("PUT /records/{0}/{1}", txtUpdateRecordAppId.Text, txtUpdateRecordRecordId.Text));
                var helper = CreateHttpHelper();
                var result = helper.UpdateAppRecord(int.Parse(txtUpdateRecordAppId.Text), int.Parse(txtUpdateRecordRecordId.Text), GetAddEditValues());
                AddLineToResults(string.Format("Location: {0}", result.Location));
                foreach (var warning in result.Warnings)
                {
                    AddLineToResults(string.Format("Warning: {0}", warning));
                }
            });
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            ProcessRequest(() =>
            {
                AddLineToResults(string.Format("POST /records/{0}", txtAddRecordAppId.Text));
                var helper = CreateHttpHelper();
                var result = helper.CreateAppRecord(int.Parse(txtAddRecordAppId.Text), GetAddEditValues());
                AddLineToResults(string.Format("Location: {0}", result.Location));
                AddLineToResults(string.Format("RecordId: {0}", result.CreatedId));
                foreach (var warning in result.Warnings)
                {
                    AddLineToResults(string.Format("Warning: {0}", warning));
                }
            });
        }

        private FieldAddEditContainer GetAddEditValues()
        {
            var result = new FieldAddEditContainer();
            AddToValueContainerIfApplicable(result, txtAddEditField1, txtAddEditValue1);
            AddToValueContainerIfApplicable(result, txtAddEditField2, txtAddEditValue2);
            AddToValueContainerIfApplicable(result, txtAddEditField3, txtAddEditValue3);
            AddToValueContainerIfApplicable(result, txtAddEditField4, txtAddEditValue4);
            AddToValueContainerIfApplicable(result, txtAddEditField5, txtAddEditValue5);
            return result;
        }

        private void AddToValueContainerIfApplicable(FieldAddEditContainer container, TextBox field, TextBox value)
        {
            if (!string.IsNullOrWhiteSpace(field.Text))
            {
                container.Add(int.Parse(field.Text), value.Text);
            }
        }

        private static T? ParseEnum<T>(string value) where T : struct
        {
            return string.IsNullOrEmpty(value) ? default(T?) : (T?)Enum.Parse(typeof(T), value);
        }

    }
}
