Public Class CustomerMaintenance
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMABooksDataSet.States' table. You can move, or remove it, as needed.
        Me.StatesTableAdapter.Fill(Me.MMABooksDataSet.States)
        'TODO: This line of code loads data into the 'MMABooksDataSet.Customers' table. You can move, or remove it, as needed.
        'Me.CustomersTableAdapter.Fill(Me.MMABooksDataSet.Customers)

        StateComboBox.SelectedIndex = -1

    End Sub

    Private Sub FillByCustomerIDToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByCustomerIDToolStripButton.Click
        Try
            Me.CustomersTableAdapter.FillByCustomerID(Me.MMABooksDataSet.Customers, CType(SelectedCustomerIDToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.CustomersBindingSource.CancelEdit()
    End Sub

    Private Sub btnGetAllCustomers_Click(sender As Object, e As EventArgs) Handles btnGetAllCustomers.Click
        Me.CustomersTableAdapter.Fill(Me.MMABooksDataSet.Customers)
    End Sub

    Private Sub FillByStateToolStripButton_Click_1(sender As Object, e As EventArgs) Handles FillByStateToolStripButton.Click
        Try
            Me.CustomersTableAdapter.FillByState(Me.MMABooksDataSet.Customers, StateToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
