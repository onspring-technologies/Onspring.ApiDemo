# Onspring API Demo

Onspring.ApiDemo is a sample WinForms application that can be used to try out the [Onspring .NET SDK](https://github.com/onspring-technologies/onspring-api-sdk) features in a more visual way than typical API interaction.

## Prerequisites

- .NET 4.6.1 or later
- Visual Studio 2012 or later (for C# 5)

## Getting Started

1. Obtain an API key as described in the **API Key** section of [the SDK's README](https://github.com/onspring-technologies/onspring-api-sdk)
2. Build and run the sample project
3. Paste your API key into the **Api Key** field (top right)
4. Click the **Get App List** button (top left)

If everything went as planned, you will see the list of Onspring apps accessible to the API Key in the **Results** area at the bottom of the window.


## Test Drive

The buttons on the main form trigger calls to the Onspring API using the SDK, then create string output to display in the **Results** area at the bottom.  Some of the string manipulation (for parameters and the results) is included for demostration purposes and not necessarily something you would include in an actual API integration.  Each button is listed below, along with any related usage information.

### Get App List

**Prerequisites:** None

**Results:** App Ids and Names

### Get Field List

**Prerequisites:** Fill in the **App Id** field to the right of the button.  You may find App Ids using **Get App List**.

**Results:** Available information for each field, including Field Ids, which are useful for other buttons

### Get Field

**Prerequisites:** Fill in the **Field Id** field to the right of the button.  You may find Field Ids using **Get Field List**.

**Results:** Available information for the selected field

### Get Report List

**Prerequisites:** Fill in the **App Id** field to the right of the button.  You may find App Ids using **Get App List**.

**Results:** Id, Name, and AppId for each report.  Ids are useful for the **Get Report Data** button.

### Get Report Data

**Prerequisites:** Fill in the **Report Id** field to the right of the button.  You may find Report Ids using **Get Report List**.

**Optionally:** Select a Data Type and/or Data Format from the comboboxes to the right of the button.

**Results:** A list of Columns, along with a list of report Rows

### Get Record(s)

**Prerequisites:** Fill in the **App Id** field to the right of the button.  You may find App Ids using **Get App List**.

##### Optionally: 
- Enter one or more (comma-separated) record ids in the **Record Id(s)** field to the right of the button.
- Enter one or more (comma-separated) field ids in the **Field Ids** field to the right of the button.
- Enter a **Filter** expression (if **Record Id(s)** is empty or has more than one value).  See the [Full API Documentation](https://goo.gl/vgyHm2) for details.
- Select a Data Format from the combobox to the right of the button.

**Results:** Selected information for each record

### Delete Record

**_WARNING: If successful, this will delete the record from the Onspring instance to which you are connecting.  It cannot be undone._**

##### Prerequisites:
- Fill in the **App Id** and **Record Id** fields to the right of the button.  
- You may find App Ids using **Get App List** and Record Ids using **Get Record(s)**.

**Results:** The Location header which provides the URL to the remaining records

### Update Record

**_WARNING: If successful, this will update the record in the Onspring instance to which you are connecting._**

##### Prerequisites:
- Fill in the **App Id** and **Record Id** fields to the right of the button.  You may find App Ids using **Get App List** and Record Ids using **Get Record(s)**.
- Fill in at least one pair of **Field Id** and **Value** fields in the **Field Data** section to the right of the button.  You may find Field Ids using **Get Field List**.

**Results:** The Location header which provides the URL to the record that was updated

### Add Record

**_WARNING: If successful, this will add a record to the Onspring instance to which you are connecting._**

##### Prerequisites:
- Fill in the **App Id** field to the right of the button.  You may find App Ids using **Get App List**.
- Fill in at least one pair of **Field Id** and **Value** fields in the **Field Data** section to the right of the button.  You may find Field Ids using **Get Field List**.

**Results:** The Location header which provides the URL to the record that was added, plus the new RecordId by itself

### Add File Using Path/Add File Using Stream

These buttons use the same input fields, but demonstrate two different methods of adding a file to a record.

**_WARNING: If successful, this will add a file to a record in the Onspring instance to which you are connecting._**

##### Prerequisites:
- Fill in the **App Id** field to the right of the button.  You may find App Ids using **Get App List**.
- Fill in the **Record Id** field to the right of the button.  You may find Record Ids using **Get Record(s)**.
- Fill in the **Field Id** field to the right of the button.  You may find Field Ids using **Get Field List**.
- Click the **Select File** button and select the file you wish to add.

##### Optionally: 
- Change the **Content Type** field to the right of the button if necessary.
- Enter text into the **File Notes** field to the right of the button.

**Results:** The Location header which provides the URL to the file that was added, plus the new FileId by itself

### Get File

##### Prerequisites:
- Fill in the **App Id** field to the right and above the button.  You may find App Ids using **Get App List**.
- Fill in the **Record Id** field to the right and above the button.  You may find Record Ids using **Get Record(s)**.
- Fill in the **Field Id** field to the right and above the button.  You may find Field Ids using **Get Field List**.
- Fill in the **File Id** field to the right of the button.  You may find File Ids using **Get Record(s)**.

**Results:** The FileName, ContentType, and ContentLength of the file retrieved
