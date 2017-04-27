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

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductDatabaseDataSet.Vendor' table. You can move, or remove it, as needed.
        Me.VendorTableAdapter.Fill(Me.ProductDatabaseDataSet.Vendor)
        'TODO: This line of code loads data into the 'ProductDatabaseDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.ProductDatabaseDataSet.Product)

        'Reads vendor, active statues, and classification valid values and loads them into the listbox.
        For Each record As DataRow In Me.ProductDatabaseDataSet.Vendor
            vendorIDComboBox.Items.Add(record.Item("Vendor_ID").ToString)
        Next

        'Sorts the items in the combobox
        vendorIDComboBox.Sorted = True

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
        'Clears both notes and contact name label.
        contactNameLabel.Text = String.Empty
        notesLabel.Text = String.empty

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

    Private Sub movePButton_Click(sender As Object, e As EventArgs) Handles movePButton.Click
        'Clears both notes and contact name label.
        contactNameLabel.Text = String.Empty
        notesLabel.Text = String.Empty

        'Moves to next product and vendor record
        Me.ProductBindingSource.MovePrevious()

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

    Private Sub moveFButton_Click(sender As Object, e As EventArgs) Handles moveFButton.Click
        'Clears both notes and contact name label.
        contactNameLabel.Text = String.Empty
        notesLabel.Text = String.Empty

        'Moves to next product and vendor record
        Me.ProductBindingSource.MoveFirst()

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

    Private Sub moveLButton_Click(sender As Object, e As EventArgs) Handles moveLButton.Click
        'Clears both notes and contact name label.
        contactNameLabel.Text = String.Empty
        notesLabel.Text = String.Empty

        'Moves to next product and vendor record
        Me.ProductBindingSource.MoveLast()

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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Begins the closing procedure.
        Me.Close()
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        'Decalres totalPurchase variable
        Dim totalPurchase As Double
        Dim averagePurchase As Double

        'Finds the Product Name and Product Cost in the Product table and writes them to recordsQuery
        Dim recordsQuery = From product In ProductDatabaseDataSet.Product
                           Where product.Vendor_ID = vendorIDComboBox.SelectedIndex
                           Select product.Product_Name, product.YTD_Purchases
                           Distinct
        ' Set columnar mode
        ppListView.View = View.Details

        ' Set column header and width
        ppListView.Columns.Clear()
        ppListView.Columns.Add("Product name", 250)
        ppListView.Columns.Add("YTD Purchases", 100)

        ' Remove previous items
        ppListView.Items.Clear()

        'Writes out the Product Name and Product Cost in the listbox.
        For Each record As DataRow In ProductDatabaseDataSet.Product

            'Sets up an array to hold listview data.
            Dim tempString(1) As String
            Dim tempNode As ListViewItem
            tempString(0) = record.Item("Product_Name").ToString
            tempString(1) = record.Item("YTD_Purchases").ToString()
            tempNode = New ListViewItem(tempString)

            'Adds items to listview
            ppListView.Items.Add(tempNode)

            'Addes purchases to eachother to get total purchase
            totalPurchase += Val(tempNode.SubItems.Item(1).Text)
        Next

        'Calculates the average purchase amount.
        averagePurchase = totalPurchase / ppListView.Items.Count

        'Writes total purchases in total purchase textbox.
        totalTextBox.Text = totalPurchase.ToString("c2")
        'Writes out average purchases in average purchase textbox.
        avgTextBox.Text = averagePurchase.ToString("c2")

        'Finds the highest YTD purchase and assigns it to the maxPurchase variable.
        Dim maxPurchase As Double = Aggregate product In ProductDatabaseDataSet.Product
                                        Select product.YTD_Purchases Into Max()

        'Finds the lowest YTD purchase and assigns it to the minPurchase variable.
        Dim minPurchase As Double = Aggregate product In ProductDatabaseDataSet.Product
                                        Select product.YTD_Purchases Into Min()

        'Write out maxPurchase and min purchase to messagebox
        MessageBox.Show("Maximum purchase amount is " & maxPurchase.ToString("c2") & ". Minimum purchase amount is " & minPurchase.ToString("c2") & ".", "Maximum and Minimum Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click

    End Sub
End Class
