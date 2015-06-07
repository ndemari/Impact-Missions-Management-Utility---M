Imports MetroFramework.Forms
Imports MetroFramework

Public Class frmReport
    Inherits MetroForm

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.tblWorkerRecordsTableAdapter.Fill(Me.dboImpact_MissionDataSet.tblWorkerRecords)
        Me.tblWorkerRecordsBindingSource.Sort = "ClockedIn"

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        Try
            Me.tblWorkerRecordsTableAdapter.FillByName(Me.dboImpact_MissionDataSet.tblWorkerRecords, txtName.Text)
            Me.tblWorkerRecordsBindingSource.Sort = "ClockedIn"

            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MetroMessageBox.Show(Me, "This error is probably due to entering the wrong name." & Environment.NewLine & ex.Message, "Service Record Report")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class