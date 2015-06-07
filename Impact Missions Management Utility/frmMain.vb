Imports MetroFramework
Imports MetroFramework.Forms

Public Class frmMain
    Inherits MetroForm

    'Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        Me.Close()
    '        frmReport.Close()
    '    End If
    'End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim clockedIn As DateTime = DateTime.ParseExact(

        Me.dtpClockedIn.Text = Format(Now, "h:mm:ss tt")
        Me.dtpClockedOut.Text = Format(Now, "h:mm:ss tt")

        'TODO: This line of code loads data into the 'DboImpact_MissionDataSet.tblWorker' table. You can move, or remove it, as needed.
        Me.TblWorkerTableAdapter.Fill(Me.DboImpact_MissionDataSet.tblWorker)
        'TODO: This line of code loads data into the 'DboImpact_MissionDataSet.tblWorkerRecords' table. You can move, or remove it, as needed.
        Me.TblWorkerRecordsTableAdapter.Fill(Me.DboImpact_MissionDataSet.tblWorkerRecords)
        Me.TblWorkerTypeTableAdapter.Fill(Me.DboImpact_MissionDataSet.tblWorkerType)

        Call FillListBoxes()
    End Sub

    Private Sub ServiceRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceRecordsToolStripMenuItem.Click
        Dim newFrmReport As New frmReport
        newFrmReport.Show()
    End Sub

    Private Sub btnWIAdd_Click(sender As Object, e As EventArgs) Handles btnWIAdd.Click

        Try
            TblWorkerTableAdapter.InsertWorker(txtFirstName.Text,
                                               txtLastName.Text,
                                               txtPhoneNumber.Text,
                                               txtStreetAddress.Text,
                                               txtApt.Text,
                                               txtCity.Text,
                                               txtState.Text,
                                               txtZip.Text,
                                               CDec(txtHoursRequired.Text),
                                               lstWorkerType.SelectedIndex + 1)

            TblWorkerTableAdapter.Fill(Me.DboImpact_MissionDataSet.tblWorker)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Record")
        End Try

        Call FillListBoxes()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Dim intMajor As Integer = 2
        Dim intMajorR As Integer = 0
        Dim intMinor As Integer = 0
        Dim intMinorR As Integer = 0

        MetroMessageBox.Show(Me, "Author: Nick Demari" &
                        Environment.NewLine &
                        "Email: Icthos@gmail.com" &
                        Environment.NewLine &
                        "Application copyright: " &
                        My.Application.Info.Copyright,
                        "Version " & " " & intMajor.ToString & "." & intMajorR.ToString & "." & intMinor.ToString & "." & intMinorR.ToString)

    End Sub

    Private Sub btnSRDelete_Click(sender As Object, e As EventArgs) Handles btnSRDelete.Click

        Dim dlgButton As DialogResult
        dlgButton = MetroMessageBox.Show(Me, "Delete " & txtDeleteRecordID.Text.Trim & " ?", "Delete", MessageBoxButtons.YesNo)

        If dlgButton <> Windows.Forms.DialogResult.Yes Then
            Try

                TblWorkerRecordsTableAdapter.DeleteWorkerRecordID(CInt(txtDeleteRecordID.Text.Trim))
                TblWorkerRecordsTableAdapter.Fill(Me.DboImpact_MissionDataSet.tblWorkerRecords)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Delete Record")
            End Try
        End If

    End Sub

    Private Sub TblWorkerRecordsDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles TblWorkerRecordsDataGridView.CellEndEdit
        Me.Validate()
        Me.TblWorkerRecordsBindingSource.EndEdit()
        Me.TblWorkerRecordsTableAdapter.Update(Me.DboImpact_MissionDataSet)

        Call FillListBoxes()

        MetroMessageBox.Show(Me, "Row edit saved...")

    End Sub

    Private Sub TblWorkerDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles TblWorkerDataGridView.CellEndEdit
        Me.Validate()
        Me.TblWorkerRecordsBindingSource.EndEdit()
        Me.TblWorkerRecordsTableAdapter.Update(Me.DboImpact_MissionDataSet)

        Call FillListBoxes()

        MetroMessageBox.Show(Me, "Row edit saved...")
    End Sub

    Private Sub FillListBoxes()

        cbLastFirstName.Items.Clear()
        lstWorkerType.Items.Clear()

        For Each strFullName In DboImpact_MissionDataSet.tblWorker
            cbLastFirstName.Items.Add(strFullName.FirstName.ToString & " " & strFullName.LastName.ToString)
        Next

        For Each strWorkerType In DboImpact_MissionDataSet.tblWorkerType
            lstWorkerType.Items.Add(strWorkerType.TypeID.ToString & " " & strWorkerType.Type)
        Next

    End Sub

    Private Sub btnSRSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSRSaveEdit.Click
        Me.Validate()
        Me.TblWorkerRecordsBindingSource.EndEdit()
        Me.TblWorkerRecordsTableAdapter.Update(Me.DboImpact_MissionDataSet)

        Call FillListBoxes()

        MetroMessageBox.Show(Me, "Row edit saved...")
    End Sub

    Private Sub btnWISaveEdit_Click(sender As Object, e As EventArgs) Handles btnWISaveEdit.Click
        Me.Validate()
        Me.TblWorkerBindingSource.EndEdit()
        Me.TblWorkerTableAdapter.Update(Me.DboImpact_MissionDataSet)

        Call FillListBoxes()

        MetroMessageBox.Show(Me, "Row edit saved...")
    End Sub

    Private Sub btnSRAdd_Click_1(sender As Object, e As EventArgs) Handles btnSRAdd.Click
        Dim strCBOName As String = cbLastFirstName.SelectedItem
        Dim strNameArray As String() = strCBOName.Split(" ")

        Dim strClockedInDate1 As String() = MetroDateTime1.Value.ToString.Split(" ")
        Dim strClockedOutDate1 As String() = MetroDateTime2.Value.ToString.Split(" ")

        Dim strClockedInFormated As String = strClockedInDate1(0) & " " & dtpClockedIn.Text
        Dim strClockedOutFormated As String = strClockedOutDate1(0) & " " & dtpClockedOut.Text


        If CDate(strClockedInFormated) > CDate(strClockedOutFormated) Then
            MessageBox.Show("Clocked in date/time must be before clocked out date/time", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try

                TblWorkerRecordsTableAdapter.InsertWorkerRecord(TblWorkerTableAdapter.FillByWorkerID(strNameArray(0), strNameArray(1)), cbLastFirstName.SelectedItem, strClockedInFormated, strClockedOutFormated, CDec(txtWorkerQuality.Text))
                TblWorkerRecordsTableAdapter.Fill(Me.DboImpact_MissionDataSet.tblWorkerRecords)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Add Record")
            End Try
        End If

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        MetroContextMenu1.Show(btnReports, New Point(0, btnReports.Height))
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        MetroContextMenu2.Show(btnOptions, New Point(0, btnOptions.Height))
    End Sub
End Class