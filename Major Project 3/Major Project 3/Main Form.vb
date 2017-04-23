Option Explicit On
Option Strict On
Option Infer On

Public Class MainForm
    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ProductBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ProductDatabaseDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If button = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub moveNButton_Click(sender As Object, e As EventArgs) Handles moveNButton.Click
        'Moves to next product and vendor record
        Me.ProductBindingSource.MoveNext()

        'Joins vendor and product tables and writes the vendor name, vendor region, 
        Dim recordsQuery = From vendor In ProductDatabaseDataSet.Vendor, product In ProductDatabaseDataSet.Product
                           Where vendor.Vendor_ID = product.Vendor_ID And product.Vendor_ID = vendorIDComboBox.SelectedIndex
                           Select vendor
                           Distinct

        'Writes data out to interface.  
        For Each result In recordsQuery
            vendorNameLabel.Text = result.Vendor_Name
            vendorRegionLabel.Text = result.Vendor_Region
            classificationLabel.Text = result.Classification
            activeStatusLabel.Text = result.Active_Status
            cityLabel.Text = result.City
            stateLabel.Text = result.State
            zipCodeLabel.Text = result.Zip_Code.ToString
            countryLabel.Text = result.Country
            emailAddressLabel.Text = result.Email_Address
            phoneNumberLabel.Text = result.Phone_Number
            websiteAddressLabel.Text = result.Website_Address

            'addresses error due to DBNull values.
            Try
                notesLabel.Text = result.Notes
            Catch ex As StrongTypingException
                notesLabel.Text = String.Empty
            End Try
            'Addresses error due to DBNull values.
            Try
                contactNameLabel.Text = result.Contact_Name
            Catch ex As StrongTypingException
                contactNameLabel.Text = String.Empty
            End Try
        Next

    End Sub

End Class
