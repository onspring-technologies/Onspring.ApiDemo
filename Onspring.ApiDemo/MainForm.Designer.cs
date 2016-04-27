namespace Onspring.ApiDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseAddress = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGetRecords = new System.Windows.Forms.Button();
            this.txtGetRecordAppId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGetRecordRecordId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGetRecordFieldIds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGetRecordDataFormat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeleteRecordRecordId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDeleteRecordAppId = new System.Windows.Forms.TextBox();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnGetAppList = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGetFieldListAppId = new System.Windows.Forms.TextBox();
            this.btnGetFieldList = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdateRecordRecordId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdateRecordAppId = new System.Windows.Forms.TextBox();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddRecordAppId = new System.Windows.Forms.TextBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGetReportListAppId = new System.Windows.Forms.TextBox();
            this.btnGetReportList = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGetReportReportId = new System.Windows.Forms.TextBox();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.cbGetReportDataFormat = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbGetReportDataType = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtGetFieldFieldId = new System.Windows.Forms.TextBox();
            this.btnGetField = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGetRecordFilter = new System.Windows.Forms.TextBox();
            this.txtAddEditField1 = new System.Windows.Forms.TextBox();
            this.txtAddEditValue1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAddEditValue2 = new System.Windows.Forms.TextBox();
            this.txtAddEditField2 = new System.Windows.Forms.TextBox();
            this.txtAddEditValue3 = new System.Windows.Forms.TextBox();
            this.txtAddEditField3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtFileAppId = new System.Windows.Forms.TextBox();
            this.btnAddFileUsingPath = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtFileRecordId = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtFileFieldId = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtContentType = new System.Windows.Forms.TextBox();
            this.dlgSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.label27 = new System.Windows.Forms.Label();
            this.txtGetFileFileId = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtFileNotes = new System.Windows.Forms.TextBox();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.btnAddFileUsingStream = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Address";
            // 
            // txtBaseAddress
            // 
            this.txtBaseAddress.Location = new System.Drawing.Point(100, 12);
            this.txtBaseAddress.Name = "txtBaseAddress";
            this.txtBaseAddress.Size = new System.Drawing.Size(233, 20);
            this.txtBaseAddress.TabIndex = 1;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 415);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(955, 199);
            this.txtResults.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Results";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(395, 12);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(568, 20);
            this.txtApiKey.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Api Key";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(63, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 74;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGetRecords
            // 
            this.btnGetRecords.Location = new System.Drawing.Point(25, 125);
            this.btnGetRecords.Name = "btnGetRecords";
            this.btnGetRecords.Size = new System.Drawing.Size(135, 23);
            this.btnGetRecords.TabIndex = 21;
            this.btnGetRecords.Text = "Get Record(s)";
            this.btnGetRecords.UseVisualStyleBackColor = true;
            this.btnGetRecords.Click += new System.EventHandler(this.btnGetRecords_Click);
            // 
            // txtGetRecordAppId
            // 
            this.txtGetRecordAppId.Location = new System.Drawing.Point(216, 127);
            this.txtGetRecordAppId.Name = "txtGetRecordAppId";
            this.txtGetRecordAppId.Size = new System.Drawing.Size(50, 20);
            this.txtGetRecordAppId.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "App Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Record Id(s)";
            // 
            // txtGetRecordRecordId
            // 
            this.txtGetRecordRecordId.Location = new System.Drawing.Point(349, 127);
            this.txtGetRecordRecordId.Name = "txtGetRecordRecordId";
            this.txtGetRecordRecordId.Size = new System.Drawing.Size(50, 20);
            this.txtGetRecordRecordId.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Field Ids (optional)";
            // 
            // txtGetRecordFieldIds
            // 
            this.txtGetRecordFieldIds.Location = new System.Drawing.Point(501, 128);
            this.txtGetRecordFieldIds.Name = "txtGetRecordFieldIds";
            this.txtGetRecordFieldIds.Size = new System.Drawing.Size(50, 20);
            this.txtGetRecordFieldIds.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(771, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Data Format";
            // 
            // cbGetRecordDataFormat
            // 
            this.cbGetRecordDataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGetRecordDataFormat.FormattingEnabled = true;
            this.cbGetRecordDataFormat.Items.AddRange(new object[] {
            "",
            "Raw",
            "Formatted"});
            this.cbGetRecordDataFormat.Location = new System.Drawing.Point(842, 126);
            this.cbGetRecordDataFormat.Name = "cbGetRecordDataFormat";
            this.cbGetRecordDataFormat.Size = new System.Drawing.Size(121, 21);
            this.cbGetRecordDataFormat.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Record Id";
            // 
            // txtDeleteRecordRecordId
            // 
            this.txtDeleteRecordRecordId.Location = new System.Drawing.Point(349, 156);
            this.txtDeleteRecordRecordId.Name = "txtDeleteRecordRecordId";
            this.txtDeleteRecordRecordId.Size = new System.Drawing.Size(50, 20);
            this.txtDeleteRecordRecordId.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "App Id";
            // 
            // txtDeleteRecordAppId
            // 
            this.txtDeleteRecordAppId.Location = new System.Drawing.Point(216, 156);
            this.txtDeleteRecordAppId.Name = "txtDeleteRecordAppId";
            this.txtDeleteRecordAppId.Size = new System.Drawing.Size(50, 20);
            this.txtDeleteRecordAppId.TabIndex = 34;
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(25, 154);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(135, 23);
            this.btnDeleteRecord.TabIndex = 32;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnGetAppList
            // 
            this.btnGetAppList.Location = new System.Drawing.Point(25, 38);
            this.btnGetAppList.Name = "btnGetAppList";
            this.btnGetAppList.Size = new System.Drawing.Size(135, 23);
            this.btnGetAppList.TabIndex = 4;
            this.btnGetAppList.Text = "Get App List";
            this.btnGetAppList.UseVisualStyleBackColor = true;
            this.btnGetAppList.Click += new System.EventHandler(this.btnGetAppList_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "App Id";
            // 
            // txtGetFieldListAppId
            // 
            this.txtGetFieldListAppId.Location = new System.Drawing.Point(216, 69);
            this.txtGetFieldListAppId.Name = "txtGetFieldListAppId";
            this.txtGetFieldListAppId.Size = new System.Drawing.Size(50, 20);
            this.txtGetFieldListAppId.TabIndex = 7;
            // 
            // btnGetFieldList
            // 
            this.btnGetFieldList.Location = new System.Drawing.Point(25, 67);
            this.btnGetFieldList.Name = "btnGetFieldList";
            this.btnGetFieldList.Size = new System.Drawing.Size(135, 23);
            this.btnGetFieldList.TabIndex = 5;
            this.btnGetFieldList.Text = "Get Field List";
            this.btnGetFieldList.UseVisualStyleBackColor = true;
            this.btnGetFieldList.Click += new System.EventHandler(this.btnGetFieldList_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(403, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 18);
            this.label11.TabIndex = 45;
            this.label11.Text = "Field Data (for Update and Add)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Record Id";
            // 
            // txtUpdateRecordRecordId
            // 
            this.txtUpdateRecordRecordId.Location = new System.Drawing.Point(349, 185);
            this.txtUpdateRecordRecordId.Name = "txtUpdateRecordRecordId";
            this.txtUpdateRecordRecordId.Size = new System.Drawing.Size(50, 20);
            this.txtUpdateRecordRecordId.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "App Id";
            // 
            // txtUpdateRecordAppId
            // 
            this.txtUpdateRecordAppId.Location = new System.Drawing.Point(216, 185);
            this.txtUpdateRecordAppId.Name = "txtUpdateRecordAppId";
            this.txtUpdateRecordAppId.Size = new System.Drawing.Size(50, 20);
            this.txtUpdateRecordAppId.TabIndex = 39;
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(25, 183);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateRecord.TabIndex = 37;
            this.btnUpdateRecord.Text = "Update Record";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(172, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "App Id";
            // 
            // txtAddRecordAppId
            // 
            this.txtAddRecordAppId.Location = new System.Drawing.Point(216, 214);
            this.txtAddRecordAppId.Name = "txtAddRecordAppId";
            this.txtAddRecordAppId.Size = new System.Drawing.Size(50, 20);
            this.txtAddRecordAppId.TabIndex = 44;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(25, 212);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(135, 23);
            this.btnAddRecord.TabIndex = 42;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(172, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "App Id";
            // 
            // txtGetReportListAppId
            // 
            this.txtGetReportListAppId.Location = new System.Drawing.Point(216, 98);
            this.txtGetReportListAppId.Name = "txtGetReportListAppId";
            this.txtGetReportListAppId.Size = new System.Drawing.Size(50, 20);
            this.txtGetReportListAppId.TabIndex = 13;
            // 
            // btnGetReportList
            // 
            this.btnGetReportList.Location = new System.Drawing.Point(25, 96);
            this.btnGetReportList.Name = "btnGetReportList";
            this.btnGetReportList.Size = new System.Drawing.Size(135, 23);
            this.btnGetReportList.TabIndex = 11;
            this.btnGetReportList.Text = "Get Report List";
            this.btnGetReportList.UseVisualStyleBackColor = true;
            this.btnGetReportList.Click += new System.EventHandler(this.btnGetReportList_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(441, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Report Id";
            // 
            // txtGetReportReportId
            // 
            this.txtGetReportReportId.Location = new System.Drawing.Point(501, 99);
            this.txtGetReportReportId.Name = "txtGetReportReportId";
            this.txtGetReportReportId.Size = new System.Drawing.Size(50, 20);
            this.txtGetReportReportId.TabIndex = 16;
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(282, 96);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(135, 23);
            this.btnGetReport.TabIndex = 14;
            this.btnGetReport.Text = "Get Report Data";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReportData_Click);
            // 
            // cbGetReportDataFormat
            // 
            this.cbGetReportDataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGetReportDataFormat.FormattingEnabled = true;
            this.cbGetReportDataFormat.Items.AddRange(new object[] {
            "",
            "Raw",
            "Formatted"});
            this.cbGetReportDataFormat.Location = new System.Drawing.Point(842, 99);
            this.cbGetReportDataFormat.Name = "cbGetReportDataFormat";
            this.cbGetReportDataFormat.Size = new System.Drawing.Size(121, 21);
            this.cbGetReportDataFormat.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(771, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Data Format";
            // 
            // cbGetReportDataType
            // 
            this.cbGetReportDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGetReportDataType.FormattingEnabled = true;
            this.cbGetReportDataType.Items.AddRange(new object[] {
            "",
            "ReportData",
            "ChartData"});
            this.cbGetReportDataType.Location = new System.Drawing.Point(631, 98);
            this.cbGetReportDataType.Name = "cbGetReportDataType";
            this.cbGetReportDataType.Size = new System.Drawing.Size(121, 21);
            this.cbGetReportDataType.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(560, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Data Type";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(451, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Field Id";
            // 
            // txtGetFieldFieldId
            // 
            this.txtGetFieldFieldId.Location = new System.Drawing.Point(501, 70);
            this.txtGetFieldFieldId.Name = "txtGetFieldFieldId";
            this.txtGetFieldFieldId.Size = new System.Drawing.Size(50, 20);
            this.txtGetFieldFieldId.TabIndex = 10;
            // 
            // btnGetField
            // 
            this.btnGetField.Location = new System.Drawing.Point(282, 67);
            this.btnGetField.Name = "btnGetField";
            this.btnGetField.Size = new System.Drawing.Size(135, 23);
            this.btnGetField.TabIndex = 8;
            this.btnGetField.Text = "Get Field";
            this.btnGetField.UseVisualStyleBackColor = true;
            this.btnGetField.Click += new System.EventHandler(this.btnGetField_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(559, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Filter (if not 1 record)";
            // 
            // txtGetRecordFilter
            // 
            this.txtGetRecordFilter.Location = new System.Drawing.Point(668, 127);
            this.txtGetRecordFilter.Name = "txtGetRecordFilter";
            this.txtGetRecordFilter.Size = new System.Drawing.Size(97, 20);
            this.txtGetRecordFilter.TabIndex = 29;
            // 
            // txtAddEditField1
            // 
            this.txtAddEditField1.Location = new System.Drawing.Point(566, 187);
            this.txtAddEditField1.Name = "txtAddEditField1";
            this.txtAddEditField1.Size = new System.Drawing.Size(50, 20);
            this.txtAddEditField1.TabIndex = 48;
            // 
            // txtAddEditValue1
            // 
            this.txtAddEditValue1.Location = new System.Drawing.Point(622, 187);
            this.txtAddEditValue1.Name = "txtAddEditValue1";
            this.txtAddEditValue1.Size = new System.Drawing.Size(341, 20);
            this.txtAddEditValue1.TabIndex = 49;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(563, 171);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "Field Id";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(625, 171);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "Value";
            // 
            // txtAddEditValue2
            // 
            this.txtAddEditValue2.Location = new System.Drawing.Point(622, 212);
            this.txtAddEditValue2.Name = "txtAddEditValue2";
            this.txtAddEditValue2.Size = new System.Drawing.Size(341, 20);
            this.txtAddEditValue2.TabIndex = 51;
            // 
            // txtAddEditField2
            // 
            this.txtAddEditField2.Location = new System.Drawing.Point(566, 212);
            this.txtAddEditField2.Name = "txtAddEditField2";
            this.txtAddEditField2.Size = new System.Drawing.Size(50, 20);
            this.txtAddEditField2.TabIndex = 50;
            // 
            // txtAddEditValue3
            // 
            this.txtAddEditValue3.Location = new System.Drawing.Point(622, 238);
            this.txtAddEditValue3.Name = "txtAddEditValue3";
            this.txtAddEditValue3.Size = new System.Drawing.Size(341, 20);
            this.txtAddEditValue3.TabIndex = 53;
            // 
            // txtAddEditField3
            // 
            this.txtAddEditField3.Location = new System.Drawing.Point(566, 238);
            this.txtAddEditField3.Name = "txtAddEditField3";
            this.txtAddEditField3.Size = new System.Drawing.Size(50, 20);
            this.txtAddEditField3.TabIndex = 52;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(172, 272);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 59;
            this.label23.Text = "App Id";
            // 
            // txtFileAppId
            // 
            this.txtFileAppId.Location = new System.Drawing.Point(216, 269);
            this.txtFileAppId.Name = "txtFileAppId";
            this.txtFileAppId.Size = new System.Drawing.Size(50, 20);
            this.txtFileAppId.TabIndex = 60;
            // 
            // btnAddFileUsingPath
            // 
            this.btnAddFileUsingPath.Location = new System.Drawing.Point(25, 267);
            this.btnAddFileUsingPath.Name = "btnAddFileUsingPath";
            this.btnAddFileUsingPath.Size = new System.Drawing.Size(120, 23);
            this.btnAddFileUsingPath.TabIndex = 54;
            this.btnAddFileUsingPath.Text = "Add File Using Path";
            this.btnAddFileUsingPath.UseVisualStyleBackColor = true;
            this.btnAddFileUsingPath.Click += new System.EventHandler(this.btnAddFileUsingPath_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(156, 298);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 13);
            this.label24.TabIndex = 61;
            this.label24.Text = "Record Id";
            // 
            // txtFileRecordId
            // 
            this.txtFileRecordId.Location = new System.Drawing.Point(216, 295);
            this.txtFileRecordId.Name = "txtFileRecordId";
            this.txtFileRecordId.Size = new System.Drawing.Size(50, 20);
            this.txtFileRecordId.TabIndex = 62;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(169, 324);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 13);
            this.label25.TabIndex = 63;
            this.label25.Text = "Field Id";
            // 
            // txtFileFieldId
            // 
            this.txtFileFieldId.Location = new System.Drawing.Point(216, 321);
            this.txtFileFieldId.Name = "txtFileFieldId";
            this.txtFileFieldId.Size = new System.Drawing.Size(50, 20);
            this.txtFileFieldId.TabIndex = 64;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(284, 267);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(68, 23);
            this.btnSelectFile.TabIndex = 65;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(358, 269);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(605, 20);
            this.txtFilePath.TabIndex = 66;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(281, 298);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 13);
            this.label26.TabIndex = 67;
            this.label26.Text = "Content Type";
            // 
            // txtContentType
            // 
            this.txtContentType.Location = new System.Drawing.Point(358, 295);
            this.txtContentType.Name = "txtContentType";
            this.txtContentType.Size = new System.Drawing.Size(605, 20);
            this.txtContentType.TabIndex = 68;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(175, 350);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 13);
            this.label27.TabIndex = 72;
            this.label27.Text = "File Id";
            // 
            // txtGetFileFileId
            // 
            this.txtGetFileFileId.Location = new System.Drawing.Point(216, 347);
            this.txtGetFileFileId.Name = "txtGetFileFileId";
            this.txtGetFileFileId.Size = new System.Drawing.Size(50, 20);
            this.txtGetFileFileId.TabIndex = 73;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(298, 324);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 13);
            this.label28.TabIndex = 69;
            this.label28.Text = "File Notes";
            // 
            // txtFileNotes
            // 
            this.txtFileNotes.Location = new System.Drawing.Point(358, 321);
            this.txtFileNotes.Name = "txtFileNotes";
            this.txtFileNotes.Size = new System.Drawing.Size(605, 20);
            this.txtFileNotes.TabIndex = 70;
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(25, 345);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(120, 23);
            this.btnGetFile.TabIndex = 71;
            this.btnGetFile.Text = "Get File";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // btnAddFileUsingStream
            // 
            this.btnAddFileUsingStream.Location = new System.Drawing.Point(25, 296);
            this.btnAddFileUsingStream.Name = "btnAddFileUsingStream";
            this.btnAddFileUsingStream.Size = new System.Drawing.Size(120, 23);
            this.btnAddFileUsingStream.TabIndex = 55;
            this.btnAddFileUsingStream.Text = "Add File Using Stream";
            this.btnAddFileUsingStream.UseVisualStyleBackColor = true;
            this.btnAddFileUsingStream.Click += new System.EventHandler(this.btnAddFileUsingStream_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 630);
            this.Controls.Add(this.btnAddFileUsingStream);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtFileNotes);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtGetFileFileId);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtContentType);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtFileFieldId);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtFileRecordId);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtFileAppId);
            this.Controls.Add(this.btnAddFileUsingPath);
            this.Controls.Add(this.txtAddEditValue3);
            this.Controls.Add(this.txtAddEditField3);
            this.Controls.Add(this.txtAddEditValue2);
            this.Controls.Add(this.txtAddEditField2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtAddEditValue1);
            this.Controls.Add(this.txtAddEditField1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtGetRecordFilter);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtGetFieldFieldId);
            this.Controls.Add(this.btnGetField);
            this.Controls.Add(this.cbGetReportDataType);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbGetReportDataFormat);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtGetReportReportId);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtGetReportListAppId);
            this.Controls.Add(this.btnGetReportList);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtAddRecordAppId);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUpdateRecordRecordId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtUpdateRecordAppId);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGetFieldListAppId);
            this.Controls.Add(this.btnGetFieldList);
            this.Controls.Add(this.btnGetAppList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDeleteRecordRecordId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDeleteRecordAppId);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.cbGetRecordDataFormat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGetRecordFieldIds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGetRecordRecordId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGetRecordAppId);
            this.Controls.Add(this.btnGetRecords);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtBaseAddress);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Onspring API Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseAddress;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGetRecords;
        private System.Windows.Forms.TextBox txtGetRecordAppId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGetRecordRecordId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGetRecordFieldIds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGetRecordDataFormat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeleteRecordRecordId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDeleteRecordAppId;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnGetAppList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGetFieldListAppId;
        private System.Windows.Forms.Button btnGetFieldList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpdateRecordRecordId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpdateRecordAppId;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAddRecordAppId;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGetReportListAppId;
        private System.Windows.Forms.Button btnGetReportList;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGetReportReportId;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.ComboBox cbGetReportDataFormat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbGetReportDataType;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtGetFieldFieldId;
        private System.Windows.Forms.Button btnGetField;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtGetRecordFilter;
        private System.Windows.Forms.TextBox txtAddEditField1;
        private System.Windows.Forms.TextBox txtAddEditValue1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtAddEditValue2;
        private System.Windows.Forms.TextBox txtAddEditField2;
        private System.Windows.Forms.TextBox txtAddEditValue3;
        private System.Windows.Forms.TextBox txtAddEditField3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtFileAppId;
        private System.Windows.Forms.Button btnAddFileUsingPath;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtFileRecordId;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtFileFieldId;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtContentType;
        private System.Windows.Forms.OpenFileDialog dlgSelectFile;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtGetFileFileId;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtFileNotes;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Button btnAddFileUsingStream;
    }
}

