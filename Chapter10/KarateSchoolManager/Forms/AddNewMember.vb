Public Class AddNewMember
    Private Sub MembersBindingSource1BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MembersBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.MembersDataSet)
    End Sub

    Private Sub AddNewMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MembersBindingSource1.AddNew()
        Date_JoinedDateTimePicker1.Value = Today()
    End Sub

    Private Sub SaveAndClose_Click(sender As Object, e As EventArgs) Handles SaveAndClose.Click
        Try
            Me.MembersBindingSource1.EndEdit()
            Me.MembersTableAdapter1.Update(MembersDataSet.Members)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Me, "Error:" & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CloseWithoutSaving_Click(sender As Object, e As EventArgs) Handles CloseWithoutSaving.Click
        Me.MembersBindingSource1.CancelEdit()
        Me.Close()
    End Sub

End Class