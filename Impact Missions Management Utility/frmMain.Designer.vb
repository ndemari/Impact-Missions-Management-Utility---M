<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblWorkerRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DboImpact_MissionDataSet = New Project_Impact.dboImpact_MissionDataSet()
        Me.TblWorkerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblWorkerRecordsTableAdapter = New Project_Impact.dboImpact_MissionDataSetTableAdapters.tblWorkerRecordsTableAdapter()
        Me.TableAdapterManager = New Project_Impact.dboImpact_MissionDataSetTableAdapters.TableAdapterManager()
        Me.TblWorkerTableAdapter = New Project_Impact.dboImpact_MissionDataSetTableAdapters.tblWorkerTableAdapter()
        Me.TblWorkerTypeTableAdapter = New Project_Impact.dboImpact_MissionDataSetTableAdapters.tblWorkerTypeTableAdapter()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.btnOptions = New MetroFramework.Controls.MetroButton()
        Me.MetroContextMenu2 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnReports = New MetroFramework.Controls.MetroButton()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ServiceRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpClockedOut = New MetroFramework.Controls.MetroTextBox()
        Me.dtpClockedIn = New MetroFramework.Controls.MetroTextBox()
        Me.MetroDateTime2 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.btnSRSaveEdit = New MetroFramework.Controls.MetroButton()
        Me.btnSRAdd = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSRDelete = New MetroFramework.Controls.MetroButton()
        Me.txtDeleteRecordID = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtWorkerQuality = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cbLastFirstName = New MetroFramework.Controls.MetroComboBox()
        Me.TblWorkerRecordsDataGridView = New MetroFramework.Controls.MetroGrid()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClockedInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClockedOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkQualityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.btnWISaveEdit = New MetroFramework.Controls.MetroButton()
        Me.btnWIAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtHoursRequired = New MetroFramework.Controls.MetroTextBox()
        Me.lstWorkerType = New MetroFramework.Controls.MetroComboBox()
        Me.txtPhoneNumber = New MetroFramework.Controls.MetroTextBox()
        Me.txtZip = New MetroFramework.Controls.MetroTextBox()
        Me.txtState = New MetroFramework.Controls.MetroTextBox()
        Me.txtApt = New MetroFramework.Controls.MetroTextBox()
        Me.txtCity = New MetroFramework.Controls.MetroTextBox()
        Me.txtStreetAddress = New MetroFramework.Controls.MetroTextBox()
        Me.txtLastName = New MetroFramework.Controls.MetroTextBox()
        Me.txtFirstName = New MetroFramework.Controls.MetroTextBox()
        Me.TblWorkerDataGridView = New MetroFramework.Controls.MetroGrid()
        Me.WorkerIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AptNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursRequredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkerTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        CType(Me.TblWorkerRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DboImpact_MissionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblWorkerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroContextMenu2.SuspendLayout()
        Me.MetroContextMenu1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblWorkerRecordsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.TblWorkerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblWorkerRecordsBindingSource
        '
        Me.TblWorkerRecordsBindingSource.DataMember = "tblWorkerRecords"
        Me.TblWorkerRecordsBindingSource.DataSource = Me.DboImpact_MissionDataSet
        '
        'DboImpact_MissionDataSet
        '
        Me.DboImpact_MissionDataSet.DataSetName = "dboImpact_MissionDataSet"
        Me.DboImpact_MissionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblWorkerBindingSource
        '
        Me.TblWorkerBindingSource.DataMember = "tblWorker"
        Me.TblWorkerBindingSource.DataSource = Me.DboImpact_MissionDataSet
        '
        'TblWorkerRecordsTableAdapter
        '
        Me.TblWorkerRecordsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblWorkerRecordsTableAdapter = Me.TblWorkerRecordsTableAdapter
        Me.TableAdapterManager.tblWorkerTableAdapter = Me.TblWorkerTableAdapter
        Me.TableAdapterManager.tblWorkerTypeTableAdapter = Me.TblWorkerTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project_Impact.dboImpact_MissionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblWorkerTableAdapter
        '
        Me.TblWorkerTableAdapter.ClearBeforeFill = True
        '
        'TblWorkerTypeTableAdapter
        '
        Me.TblWorkerTypeTableAdapter.ClearBeforeFill = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1210, 639)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.btnOptions)
        Me.MetroTabPage1.Controls.Add(Me.btnReports)
        Me.MetroTabPage1.Controls.Add(Me.dtpClockedOut)
        Me.MetroTabPage1.Controls.Add(Me.dtpClockedIn)
        Me.MetroTabPage1.Controls.Add(Me.MetroDateTime2)
        Me.MetroTabPage1.Controls.Add(Me.MetroDateTime1)
        Me.MetroTabPage1.Controls.Add(Me.btnSRSaveEdit)
        Me.MetroTabPage1.Controls.Add(Me.btnSRAdd)
        Me.MetroTabPage1.Controls.Add(Me.GroupBox1)
        Me.MetroTabPage1.Controls.Add(Me.txtWorkerQuality)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.Controls.Add(Me.cbLastFirstName)
        Me.MetroTabPage1.Controls.Add(Me.TblWorkerRecordsDataGridView)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1202, 597)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Time Sheet"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'btnOptions
        '
        Me.btnOptions.ContextMenuStrip = Me.MetroContextMenu2
        Me.btnOptions.Location = New System.Drawing.Point(1078, 397)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(99, 23)
        Me.btnOptions.TabIndex = 22
        Me.btnOptions.Text = "Options"
        Me.btnOptions.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnOptions.UseSelectable = True
        '
        'MetroContextMenu2
        '
        Me.MetroContextMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MetroContextMenu2.Name = "MetroContextMenu1"
        Me.MetroContextMenu2.Size = New System.Drawing.Size(108, 26)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnReports
        '
        Me.btnReports.ContextMenuStrip = Me.MetroContextMenu1
        Me.btnReports.Highlight = True
        Me.btnReports.Location = New System.Drawing.Point(914, 397)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(114, 23)
        Me.btnReports.TabIndex = 21
        Me.btnReports.Text = "Reports"
        Me.btnReports.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnReports.UseSelectable = True
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiceRecordsToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(195, 26)
        '
        'ServiceRecordsToolStripMenuItem
        '
        Me.ServiceRecordsToolStripMenuItem.Name = "ServiceRecordsToolStripMenuItem"
        Me.ServiceRecordsToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ServiceRecordsToolStripMenuItem.Text = "Service Records Report"
        '
        'dtpClockedOut
        '
        Me.dtpClockedOut.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.dtpClockedOut.Lines = New String(-1) {}
        Me.dtpClockedOut.Location = New System.Drawing.Point(328, 478)
        Me.dtpClockedOut.MaxLength = 32767
        Me.dtpClockedOut.Name = "dtpClockedOut"
        Me.dtpClockedOut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dtpClockedOut.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dtpClockedOut.SelectedText = ""
        Me.dtpClockedOut.Size = New System.Drawing.Size(99, 29)
        Me.dtpClockedOut.TabIndex = 20
        Me.dtpClockedOut.UseSelectable = True
        '
        'dtpClockedIn
        '
        Me.dtpClockedIn.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.dtpClockedIn.Lines = New String(-1) {}
        Me.dtpClockedIn.Location = New System.Drawing.Point(328, 397)
        Me.dtpClockedIn.MaxLength = 32767
        Me.dtpClockedIn.Name = "dtpClockedIn"
        Me.dtpClockedIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dtpClockedIn.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dtpClockedIn.SelectedText = ""
        Me.dtpClockedIn.Size = New System.Drawing.Size(99, 29)
        Me.dtpClockedIn.TabIndex = 19
        Me.dtpClockedIn.UseSelectable = True
        '
        'MetroDateTime2
        '
        Me.MetroDateTime2.AllowDrop = True
        Me.MetroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MetroDateTime2.Location = New System.Drawing.Point(189, 478)
        Me.MetroDateTime2.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime2.Name = "MetroDateTime2"
        Me.MetroDateTime2.Size = New System.Drawing.Size(102, 29)
        Me.MetroDateTime2.TabIndex = 18
        Me.MetroDateTime2.Value = New Date(2015, 1, 30, 0, 0, 0, 0)
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.AllowDrop = True
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MetroDateTime1.Location = New System.Drawing.Point(189, 397)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(102, 29)
        Me.MetroDateTime1.TabIndex = 17
        Me.MetroDateTime1.Value = New Date(2015, 1, 30, 0, 0, 0, 0)
        '
        'btnSRSaveEdit
        '
        Me.btnSRSaveEdit.Highlight = True
        Me.btnSRSaveEdit.Location = New System.Drawing.Point(473, 529)
        Me.btnSRSaveEdit.Name = "btnSRSaveEdit"
        Me.btnSRSaveEdit.Size = New System.Drawing.Size(81, 23)
        Me.btnSRSaveEdit.TabIndex = 16
        Me.btnSRSaveEdit.Text = "Save Edits"
        Me.btnSRSaveEdit.UseSelectable = True
        '
        'btnSRAdd
        '
        Me.btnSRAdd.Highlight = True
        Me.btnSRAdd.Location = New System.Drawing.Point(473, 478)
        Me.btnSRAdd.Name = "btnSRAdd"
        Me.btnSRAdd.Size = New System.Drawing.Size(81, 23)
        Me.btnSRAdd.TabIndex = 15
        Me.btnSRAdd.Text = "Add"
        Me.btnSRAdd.UseSelectable = True
        '
        'GroupBox1
        '
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.GroupBox1, True)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.btnSRDelete)
        Me.GroupBox1.Controls.Add(Me.txtDeleteRecordID)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(650, 375)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 132)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delete Record"
        '
        'btnSRDelete
        '
        Me.btnSRDelete.Location = New System.Drawing.Point(105, 92)
        Me.btnSRDelete.Name = "btnSRDelete"
        Me.btnSRDelete.Size = New System.Drawing.Size(81, 23)
        Me.btnSRDelete.TabIndex = 14
        Me.btnSRDelete.Text = "Delete"
        Me.btnSRDelete.UseSelectable = True
        '
        'txtDeleteRecordID
        '
        Me.txtDeleteRecordID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtDeleteRecordID.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDeleteRecordID.Lines = New String(-1) {}
        Me.txtDeleteRecordID.Location = New System.Drawing.Point(105, 41)
        Me.txtDeleteRecordID.MaxLength = 4
        Me.txtDeleteRecordID.Name = "txtDeleteRecordID"
        Me.txtDeleteRecordID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeleteRecordID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDeleteRecordID.SelectedText = ""
        Me.txtDeleteRecordID.Size = New System.Drawing.Size(81, 23)
        Me.txtDeleteRecordID.TabIndex = 13
        Me.txtDeleteRecordID.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDeleteRecordID.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(15, 41)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Record ID"
        '
        'txtWorkerQuality
        '
        Me.txtWorkerQuality.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtWorkerQuality.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtWorkerQuality.Lines = New String(-1) {}
        Me.txtWorkerQuality.Location = New System.Drawing.Point(473, 397)
        Me.txtWorkerQuality.MaxLength = 4
        Me.txtWorkerQuality.Name = "txtWorkerQuality"
        Me.txtWorkerQuality.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWorkerQuality.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtWorkerQuality.SelectedText = ""
        Me.txtWorkerQuality.Size = New System.Drawing.Size(81, 23)
        Me.txtWorkerQuality.TabIndex = 10
        Me.txtWorkerQuality.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtWorkerQuality.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(468, 375)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Worker Quality"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(189, 456)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Clocked In"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(189, 375)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Clocked In"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(0, 375)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Worker's Name"
        '
        'cbLastFirstName
        '
        Me.cbLastFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.cbLastFirstName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbLastFirstName.FormattingEnabled = True
        Me.cbLastFirstName.ItemHeight = 23
        Me.cbLastFirstName.Location = New System.Drawing.Point(0, 397)
        Me.cbLastFirstName.Name = "cbLastFirstName"
        Me.cbLastFirstName.Size = New System.Drawing.Size(121, 29)
        Me.cbLastFirstName.TabIndex = 3
        Me.cbLastFirstName.UseSelectable = True
        '
        'TblWorkerRecordsDataGridView
        '
        Me.TblWorkerRecordsDataGridView.AllowUserToAddRows = False
        Me.TblWorkerRecordsDataGridView.AllowUserToDeleteRows = False
        Me.TblWorkerRecordsDataGridView.AllowUserToResizeRows = False
        Me.TblWorkerRecordsDataGridView.AutoGenerateColumns = False
        Me.TblWorkerRecordsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblWorkerRecordsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblWorkerRecordsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TblWorkerRecordsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblWorkerRecordsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TblWorkerRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblWorkerRecordsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.WorkerIDDataGridViewTextBoxColumn, Me.FirstLastNameDataGridViewTextBoxColumn, Me.ClockedInDataGridViewTextBoxColumn, Me.ClockedOutDataGridViewTextBoxColumn, Me.WorkQualityDataGridViewTextBoxColumn})
        Me.TblWorkerRecordsDataGridView.DataSource = Me.TblWorkerRecordsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TblWorkerRecordsDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.TblWorkerRecordsDataGridView.EnableHeadersVisualStyles = False
        Me.TblWorkerRecordsDataGridView.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TblWorkerRecordsDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblWorkerRecordsDataGridView.Location = New System.Drawing.Point(0, 3)
        Me.TblWorkerRecordsDataGridView.Name = "TblWorkerRecordsDataGridView"
        Me.TblWorkerRecordsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblWorkerRecordsDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TblWorkerRecordsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.TblWorkerRecordsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblWorkerRecordsDataGridView.Size = New System.Drawing.Size(1202, 354)
        Me.TblWorkerRecordsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RecordID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RecordID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'WorkerIDDataGridViewTextBoxColumn
        '
        Me.WorkerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WorkerIDDataGridViewTextBoxColumn.DataPropertyName = "WorkerID"
        Me.WorkerIDDataGridViewTextBoxColumn.HeaderText = "WorkerID"
        Me.WorkerIDDataGridViewTextBoxColumn.Name = "WorkerIDDataGridViewTextBoxColumn"
        '
        'FirstLastNameDataGridViewTextBoxColumn
        '
        Me.FirstLastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstLastNameDataGridViewTextBoxColumn.DataPropertyName = "FirstLastName"
        Me.FirstLastNameDataGridViewTextBoxColumn.HeaderText = "FirstLastName"
        Me.FirstLastNameDataGridViewTextBoxColumn.Name = "FirstLastNameDataGridViewTextBoxColumn"
        '
        'ClockedInDataGridViewTextBoxColumn
        '
        Me.ClockedInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClockedInDataGridViewTextBoxColumn.DataPropertyName = "ClockedIn"
        Me.ClockedInDataGridViewTextBoxColumn.HeaderText = "ClockedIn"
        Me.ClockedInDataGridViewTextBoxColumn.Name = "ClockedInDataGridViewTextBoxColumn"
        '
        'ClockedOutDataGridViewTextBoxColumn
        '
        Me.ClockedOutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClockedOutDataGridViewTextBoxColumn.DataPropertyName = "ClockedOut"
        Me.ClockedOutDataGridViewTextBoxColumn.HeaderText = "ClockedOut"
        Me.ClockedOutDataGridViewTextBoxColumn.Name = "ClockedOutDataGridViewTextBoxColumn"
        '
        'WorkQualityDataGridViewTextBoxColumn
        '
        Me.WorkQualityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WorkQualityDataGridViewTextBoxColumn.DataPropertyName = "WorkQuality"
        Me.WorkQualityDataGridViewTextBoxColumn.HeaderText = "WorkQuality"
        Me.WorkQualityDataGridViewTextBoxColumn.Name = "WorkQualityDataGridViewTextBoxColumn"
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.btnWISaveEdit)
        Me.MetroTabPage2.Controls.Add(Me.btnWIAdd)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel15)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel14)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel13)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel12)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel11)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel10)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel9)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel8)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage2.Controls.Add(Me.txtHoursRequired)
        Me.MetroTabPage2.Controls.Add(Me.lstWorkerType)
        Me.MetroTabPage2.Controls.Add(Me.txtPhoneNumber)
        Me.MetroTabPage2.Controls.Add(Me.txtZip)
        Me.MetroTabPage2.Controls.Add(Me.txtState)
        Me.MetroTabPage2.Controls.Add(Me.txtApt)
        Me.MetroTabPage2.Controls.Add(Me.txtCity)
        Me.MetroTabPage2.Controls.Add(Me.txtStreetAddress)
        Me.MetroTabPage2.Controls.Add(Me.txtLastName)
        Me.MetroTabPage2.Controls.Add(Me.txtFirstName)
        Me.MetroTabPage2.Controls.Add(Me.TblWorkerDataGridView)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1202, 597)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Worker Information"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'btnWISaveEdit
        '
        Me.btnWISaveEdit.Highlight = True
        Me.btnWISaveEdit.Location = New System.Drawing.Point(615, 537)
        Me.btnWISaveEdit.Name = "btnWISaveEdit"
        Me.btnWISaveEdit.Size = New System.Drawing.Size(133, 23)
        Me.btnWISaveEdit.TabIndex = 24
        Me.btnWISaveEdit.Text = "Save Edits"
        Me.btnWISaveEdit.UseSelectable = True
        '
        'btnWIAdd
        '
        Me.btnWIAdd.Highlight = True
        Me.btnWIAdd.Location = New System.Drawing.Point(615, 483)
        Me.btnWIAdd.Name = "btnWIAdd"
        Me.btnWIAdd.Size = New System.Drawing.Size(133, 23)
        Me.btnWIAdd.TabIndex = 23
        Me.btnWIAdd.Text = "New Worker"
        Me.btnWIAdd.UseSelectable = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(464, 537)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(28, 19)
        Me.MetroLabel15.TabIndex = 22
        Me.MetroLabel15.Text = "Zip"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(342, 537)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel14.TabIndex = 21
        Me.MetroLabel14.Text = "State"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(221, 537)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(31, 19)
        Me.MetroLabel13.TabIndex = 20
        Me.MetroLabel13.Text = "City"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(221, 461)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel12.TabIndex = 19
        Me.MetroLabel12.Text = "Apartment"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(833, 382)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel11.TabIndex = 18
        Me.MetroLabel11.Text = "Hours Required"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(615, 382)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel10.TabIndex = 17
        Me.MetroLabel10.Text = "Worker Type"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(464, 382)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel9.TabIndex = 16
        Me.MetroLabel9.Text = "Phone Number"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(221, 382)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(144, 19)
        Me.MetroLabel8.TabIndex = 15
        Me.MetroLabel8.Text = "Street Address/PO Box"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(38, 461)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel7.TabIndex = 14
        Me.MetroLabel7.Text = "Last Name"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(38, 382)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel6.TabIndex = 13
        Me.MetroLabel6.Text = "First Name"
        '
        'txtHoursRequired
        '
        Me.txtHoursRequired.Lines = New String(-1) {}
        Me.txtHoursRequired.Location = New System.Drawing.Point(833, 407)
        Me.txtHoursRequired.MaxLength = 32767
        Me.txtHoursRequired.Name = "txtHoursRequired"
        Me.txtHoursRequired.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHoursRequired.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtHoursRequired.SelectedText = ""
        Me.txtHoursRequired.Size = New System.Drawing.Size(75, 23)
        Me.txtHoursRequired.TabIndex = 12
        Me.txtHoursRequired.UseSelectable = True
        '
        'lstWorkerType
        '
        Me.lstWorkerType.FormattingEnabled = True
        Me.lstWorkerType.ItemHeight = 23
        Me.lstWorkerType.Location = New System.Drawing.Point(615, 405)
        Me.lstWorkerType.Name = "lstWorkerType"
        Me.lstWorkerType.Size = New System.Drawing.Size(157, 29)
        Me.lstWorkerType.TabIndex = 11
        Me.lstWorkerType.UseSelectable = True
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Lines = New String(-1) {}
        Me.txtPhoneNumber.Location = New System.Drawing.Point(464, 407)
        Me.txtPhoneNumber.MaxLength = 32767
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhoneNumber.SelectedText = ""
        Me.txtPhoneNumber.Size = New System.Drawing.Size(75, 23)
        Me.txtPhoneNumber.TabIndex = 10
        Me.txtPhoneNumber.UseSelectable = True
        '
        'txtZip
        '
        Me.txtZip.Lines = New String(-1) {}
        Me.txtZip.Location = New System.Drawing.Point(464, 559)
        Me.txtZip.MaxLength = 32767
        Me.txtZip.Name = "txtZip"
        Me.txtZip.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtZip.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtZip.SelectedText = ""
        Me.txtZip.Size = New System.Drawing.Size(75, 23)
        Me.txtZip.TabIndex = 9
        Me.txtZip.UseSelectable = True
        '
        'txtState
        '
        Me.txtState.Lines = New String(-1) {}
        Me.txtState.Location = New System.Drawing.Point(342, 559)
        Me.txtState.MaxLength = 32767
        Me.txtState.Name = "txtState"
        Me.txtState.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtState.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtState.SelectedText = ""
        Me.txtState.Size = New System.Drawing.Size(75, 23)
        Me.txtState.TabIndex = 8
        Me.txtState.UseSelectable = True
        '
        'txtApt
        '
        Me.txtApt.Lines = New String(-1) {}
        Me.txtApt.Location = New System.Drawing.Point(221, 483)
        Me.txtApt.MaxLength = 32767
        Me.txtApt.Name = "txtApt"
        Me.txtApt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApt.SelectedText = ""
        Me.txtApt.Size = New System.Drawing.Size(75, 23)
        Me.txtApt.TabIndex = 7
        Me.txtApt.UseSelectable = True
        '
        'txtCity
        '
        Me.txtCity.Lines = New String(-1) {}
        Me.txtCity.Location = New System.Drawing.Point(221, 559)
        Me.txtCity.MaxLength = 32767
        Me.txtCity.Name = "txtCity"
        Me.txtCity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCity.SelectedText = ""
        Me.txtCity.Size = New System.Drawing.Size(75, 23)
        Me.txtCity.TabIndex = 6
        Me.txtCity.UseSelectable = True
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Lines = New String(-1) {}
        Me.txtStreetAddress.Location = New System.Drawing.Point(221, 407)
        Me.txtStreetAddress.MaxLength = 32767
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreetAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStreetAddress.SelectedText = ""
        Me.txtStreetAddress.Size = New System.Drawing.Size(144, 23)
        Me.txtStreetAddress.TabIndex = 5
        Me.txtStreetAddress.UseSelectable = True
        '
        'txtLastName
        '
        Me.txtLastName.Lines = New String(-1) {}
        Me.txtLastName.Location = New System.Drawing.Point(38, 486)
        Me.txtLastName.MaxLength = 32767
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(120, 23)
        Me.txtLastName.TabIndex = 4
        Me.txtLastName.UseSelectable = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Lines = New String(-1) {}
        Me.txtFirstName.Location = New System.Drawing.Point(38, 407)
        Me.txtFirstName.MaxLength = 32767
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(120, 23)
        Me.txtFirstName.TabIndex = 3
        Me.txtFirstName.UseSelectable = True
        '
        'TblWorkerDataGridView
        '
        Me.TblWorkerDataGridView.AllowUserToAddRows = False
        Me.TblWorkerDataGridView.AllowUserToDeleteRows = False
        Me.TblWorkerDataGridView.AllowUserToResizeRows = False
        Me.TblWorkerDataGridView.AutoGenerateColumns = False
        Me.TblWorkerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TblWorkerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblWorkerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TblWorkerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblWorkerDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.TblWorkerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblWorkerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WorkerIDDataGridViewTextBoxColumn1, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.StreetAddressDataGridViewTextBoxColumn, Me.AptNumberDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipDataGridViewTextBoxColumn, Me.HoursRequredDataGridViewTextBoxColumn, Me.WorkerTypeDataGridViewTextBoxColumn})
        Me.TblWorkerDataGridView.DataSource = Me.TblWorkerBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TblWorkerDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.TblWorkerDataGridView.EnableHeadersVisualStyles = False
        Me.TblWorkerDataGridView.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TblWorkerDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TblWorkerDataGridView.Location = New System.Drawing.Point(0, 3)
        Me.TblWorkerDataGridView.Name = "TblWorkerDataGridView"
        Me.TblWorkerDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TblWorkerDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.TblWorkerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.TblWorkerDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TblWorkerDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.TblWorkerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblWorkerDataGridView.Size = New System.Drawing.Size(1202, 354)
        Me.TblWorkerDataGridView.TabIndex = 2
        '
        'WorkerIDDataGridViewTextBoxColumn1
        '
        Me.WorkerIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WorkerIDDataGridViewTextBoxColumn1.DataPropertyName = "WorkerID"
        Me.WorkerIDDataGridViewTextBoxColumn1.HeaderText = "WorkerID"
        Me.WorkerIDDataGridViewTextBoxColumn1.Name = "WorkerIDDataGridViewTextBoxColumn1"
        Me.WorkerIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'StreetAddressDataGridViewTextBoxColumn
        '
        Me.StreetAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StreetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress"
        Me.StreetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress"
        Me.StreetAddressDataGridViewTextBoxColumn.Name = "StreetAddressDataGridViewTextBoxColumn"
        '
        'AptNumberDataGridViewTextBoxColumn
        '
        Me.AptNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AptNumberDataGridViewTextBoxColumn.DataPropertyName = "AptNumber"
        Me.AptNumberDataGridViewTextBoxColumn.HeaderText = "AptNumber"
        Me.AptNumberDataGridViewTextBoxColumn.Name = "AptNumberDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'ZipDataGridViewTextBoxColumn
        '
        Me.ZipDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ZipDataGridViewTextBoxColumn.DataPropertyName = "Zip"
        Me.ZipDataGridViewTextBoxColumn.HeaderText = "Zip"
        Me.ZipDataGridViewTextBoxColumn.Name = "ZipDataGridViewTextBoxColumn"
        '
        'HoursRequredDataGridViewTextBoxColumn
        '
        Me.HoursRequredDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HoursRequredDataGridViewTextBoxColumn.DataPropertyName = "HoursRequred"
        Me.HoursRequredDataGridViewTextBoxColumn.HeaderText = "HoursRequred"
        Me.HoursRequredDataGridViewTextBoxColumn.Name = "HoursRequredDataGridViewTextBoxColumn"
        '
        'WorkerTypeDataGridViewTextBoxColumn
        '
        Me.WorkerTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WorkerTypeDataGridViewTextBoxColumn.DataPropertyName = "WorkerType"
        Me.WorkerTypeDataGridViewTextBoxColumn.HeaderText = "WorkerType"
        Me.WorkerTypeDataGridViewTextBoxColumn.Name = "WorkerTypeDataGridViewTextBoxColumn"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BackImage = Global.Project_Impact.My.Resources.Resources.impactMissions
        Me.BackImagePadding = New System.Windows.Forms.Padding(400, 11, 0, 0)
        Me.BackMaxSize = 100
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1250, 722)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.Text = "Impact Missions Management Utility"
        CType(Me.TblWorkerRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DboImpact_MissionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblWorkerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroContextMenu2.ResumeLayout(False)
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblWorkerRecordsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.TblWorkerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DboImpact_MissionDataSet As Project_Impact.dboImpact_MissionDataSet
    Friend WithEvents TblWorkerRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblWorkerRecordsTableAdapter As Project_Impact.dboImpact_MissionDataSetTableAdapters.tblWorkerRecordsTableAdapter
    Friend WithEvents TableAdapterManager As Project_Impact.dboImpact_MissionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblWorkerTableAdapter As Project_Impact.dboImpact_MissionDataSetTableAdapters.tblWorkerTableAdapter
    Friend WithEvents TblWorkerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblWorkerTypeTableAdapter As Project_Impact.dboImpact_MissionDataSetTableAdapters.tblWorkerTypeTableAdapter
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbLastFirstName As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TblWorkerRecordsDataGridView As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TblWorkerDataGridView As MetroFramework.Controls.MetroGrid
    Friend WithEvents WorkerIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreetAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AptNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoursRequredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkerTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtWorkerQuality As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents btnSRSaveEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSRAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSRDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDeleteRecordID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtHoursRequired As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lstWorkerType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtPhoneNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtZip As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtState As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtApt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStreetAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLastName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFirstName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnWISaveEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnWIAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroDateTime2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpClockedIn As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpClockedOut As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnReports As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ServiceRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOptions As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroContextMenu2 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstLastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClockedInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClockedOutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkQualityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
