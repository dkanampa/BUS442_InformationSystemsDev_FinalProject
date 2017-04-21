Public Class MainForm
    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductDatabaseDataSet)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductDatabaseDataSet.Vendor' table. You can move, or remove it, as needed.
        Me.VendorTableAdapter.Fill(Me.ProductDatabaseDataSet.Vendor)
        'TODO: This line of code loads data into the 'ProductDatabaseDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.ProductDatabaseDataSet.Product)

        'Reads vendor, active statues, and classification valid values and loads them into the listbox.
        For Each record As DataRow In Me.ProductDatabaseDataSet.Product
            vendorIDComboBox.Items.Add(record.Item("Vendor_ID").ToString)
        Next

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'Closes the application
        Me.Close()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'creates message box asking is user is sure they want to exit.
        Dim button As DialogResult
        button = MessageBox.Show("Are you sure you want to exit?", "Exit Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        'If user selects no, cancels the exit process.
        If button = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'closes the app
        Me.Close()
    End Sub
End Class
