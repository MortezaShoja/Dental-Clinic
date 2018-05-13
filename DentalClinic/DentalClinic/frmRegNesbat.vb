Public Class frmRegNesbat

    Private Sub NesbatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.NesbatBindingSource.EndEdit()
        Me.NesbatTableAdapter.Update(Me.ClinicDataSet.Nesbat)

    End Sub

    Private Sub frmRegNesbat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClinicDataSet.Nesbat' table. You can move, or remove it, as needed.
        Me.NesbatTableAdapter.Fill(Me.ClinicDataSet.Nesbat)
        'TODO: This line of code loads data into the 'ClinicDataSet.Nesbat' table. You can move, or remove it, as needed.
        Me.NesbatTableAdapter.Fill(Me.ClinicDataSet.Nesbat)

    End Sub

    Private Sub NesbatBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NesbatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NesbatBindingSource.EndEdit()
        Me.NesbatTableAdapter.Update(Me.ClinicDataSet.Nesbat)

    End Sub
End Class