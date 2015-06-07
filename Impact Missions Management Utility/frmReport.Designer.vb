<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblWorkerRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dboImpact_MissionDataSet = New Project_Impact.dboImpact_MissionDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnViewReport = New MetroFramework.Controls.MetroButton()
        Me.tblWorkerRecordsTableAdapter = New Project_Impact.dboImpact_MissionDataSetTableAdapters.tblWorkerRecordsTableAdapter()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.btnExit = New MetroFramework.Controls.MetroButton()
        CType(Me.tblWorkerRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dboImpact_MissionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblWorkerRecordsBindingSource
        '
        Me.tblWorkerRecordsBindingSource.DataMember = "tblWorkerRecords"
        Me.tblWorkerRecordsBindingSource.DataSource = Me.dboImpact_MissionDataSet
        '
        'dboImpact_MissionDataSet
        '
        Me.dboImpact_MissionDataSet.DataSetName = "dboImpact_MissionDataSet"
        Me.dboImpact_MissionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Top
        ReportDataSource5.Name = "DataSet"
        ReportDataSource5.Value = Me.tblWorkerRecordsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Project_Impact.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(20, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(883, 599)
        Me.ReportViewer1.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(61, 673)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Name"
        '
        'btnViewReport
        '
        Me.btnViewReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewReport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnViewReport.Location = New System.Drawing.Point(623, 673)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(99, 29)
        Me.btnViewReport.TabIndex = 3
        Me.btnViewReport.Text = "View Report"
        Me.btnViewReport.UseSelectable = True
        '
        'tblWorkerRecordsTableAdapter
        '
        Me.tblWorkerRecordsTableAdapter.ClearBeforeFill = True
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(112, 673)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(106, 23)
        Me.txtName.TabIndex = 4
        Me.txtName.UseSelectable = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(755, 673)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 29)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseSelectable = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.CancelButton = Me.btnViewReport
        Me.ClientSize = New System.Drawing.Size(923, 725)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnViewReport)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReport"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Text = "Service Records Report"
        Me.TopMost = True
        CType(Me.tblWorkerRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dboImpact_MissionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblWorkerRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dboImpact_MissionDataSet As Project_Impact.dboImpact_MissionDataSet
    Friend WithEvents tblWorkerRecordsTableAdapter As Project_Impact.dboImpact_MissionDataSetTableAdapters.tblWorkerRecordsTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnViewReport As MetroFramework.Controls.MetroButton
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnExit As MetroFramework.Controls.MetroButton
End Class
