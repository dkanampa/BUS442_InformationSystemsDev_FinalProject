'Project name: Major Project 3 - Product/Vendor Database Application
'Project purpose: Application is intergrated with a database, which can be manipulated and viewed via the interface.
'Created/revised by: David K. Anampa, Corita Adamo, Cecil Kinsey

Option Explicit On 'ensures that each variable is declared before its use by flagging any undeclared variables

Option Infer On 'ensures that every variable and constants is delcared with a data type

Option Strict On 'prevents implicit type conversion and data loss by variable values trying to fit the memory location

Public Class MainForm

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        'This saves any new entries to the database.

        Try
            'validates all inputs in the textboxes
            Me.Validate()

            'ends the edit after validation
            Me.ProductBindingSource.EndEdit()

            'update the database with the new updated info.
            Me.TableAdapterManager.UpdateAll(Me.ProductDatabaseDataSet)

        Catch ex As Exception

            'message box displayed after an error is found
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

        '*message box that appears during exit attempt is below in MainForm_FormClosing

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'creates message box asking the user if they are sure about exiting the application through whichever closing option.

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

    Private Sub movePButton_Click(sender As Object, e As EventArgs) Handles movePButton.Click
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
        psListBox.Items.Clear()

        'Writes out the Product Name and Product Cost in the listbox.
        For Each record As DataRow In ProductDatabaseDataSet.Product

            'Sets up an array to hold listview data.
            Dim tempString(1) As String
            Dim tempNode As ListViewItem
            tempString(0) = record.Item("Product_Name").ToString
            tempString(1) = Format(record.Item("YTD_Purchases"), "$###,###,###,##0.00")
            tempNode = New ListViewItem(tempString)

            'Adds items to listview
            ppListView.Items.Add(tempNode)

            'Addes purchases to eachother to get total purchase
            totalPurchase += CDbl(record.Item("YTD_Purchases"))
        Next

        'Calculates the average purchase amount.
        averagePurchase = totalPurchase / ppListView.Items.Count

        'Writes total purchases in total purchase textbox.
        totalLabel.Text = totalPurchase.ToString("c2")
        'Writes out average purchases in average purchase textbox.
        avgLabel.Text = averagePurchase.ToString("c2")

        'Finds the highest YTD purchase and assigns it to the maxPurchase variable.
        Dim maxPurchase As Double = Aggregate product In ProductDatabaseDataSet.Product
                                        Select product.YTD_Purchases Into Max()

        'Finds the lowest YTD purchase and assigns it to the minPurchase variable.
        Dim minPurchase As Double = Aggregate product In ProductDatabaseDataSet.Product
                                        Select product.YTD_Purchases Into Min()

        'Write out maxPurchase and min purchase to messagebox
        MessageBox.Show("Maximum purchase amount is " & maxPurchase.ToString("c2") & ". Minimum purchase amount is " & minPurchase.ToString("c2") & ".", "Maximum and Minimum Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub searchToolStripButton_Click(sender As Object, e As EventArgs) Handles searchToolStripButton.Click
        'button in the tool strip used to search via inputed product name

        'declaring variable
        Dim searchItem As String

        'turnes inputed search into string upparcase
        searchItem = searchToolStripTextBox.Text.ToUpper

        'turns the calculate button off during search
        calculateButton.Enabled = False

        'sets up the search procedure for the database
        Dim Search = From product In ProductDatabaseDataSet.Product
                     Where product.Product_Name.ToUpper Like "*" & searchItem & "*"
                     Select product

        Try
            'if nothing is found for search displays message stating so
            If Search.Count = 0 Then

                MessageBox.Show("Product Name Isn't Found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'if search is found then binds the search to be viewed on the interface
                Me.ProductBindingSource.DataSource = Search.AsDataView

            End If

        Catch ex As Exception
            'if any other error occures message appears. 
            MessageBox.Show(ex.Message, "Product Name Isn't Found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try


    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        'button in the tool strip used to search via inputed product name

        'declaring variable
        Dim searchItem As String

        'turnes inputed search into string upparcase
        searchItem = searchToolStripTextBox.Text.ToUpper

        'turns the calculate button off during search
        calculateButton.Enabled = False

        'sets up the search procedure for the database
        Dim Search = From product In ProductDatabaseDataSet.Product
                     Where product.Product_Name.ToUpper Like "*" & searchItem & "*"
                     Select product

        Try
            'if nothing is found for search displays message stating so
            If Search.Count = 0 Then

                MessageBox.Show("Product Name Isn't Found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'if search is found then binds the search to be viewed on the interface
                Me.ProductBindingSource.DataSource = Search.AsDataView

            End If

        Catch ex As Exception
            'if any other error occures message appears. 
            MessageBox.Show(ex.Message, "Product Name Isn't Found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try

    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        'the refresh button resets the database and interface after doing a search

        'turns on the calculate button since search turn it off
        calculateButton.Enabled = True

        'clears the search textbox 
        searchToolStripTextBox.Text = String.Empty

        'declaring variable
        Dim searchItem As String

        'turnes inputed search into string upparcase
        searchItem = searchToolStripTextBox.Text.ToUpper

        'sets up the search procedure for the database
        Dim Search = From product In ProductDatabaseDataSet.Product
                     Where product.Product_Name.ToUpper Like "*" & searchItem & "*"
                     Select product

        'if search is found then binds the search to be viewed on the interface
        Me.ProductBindingSource.DataSource = Search.AsDataView


    End Sub

    Private Sub ProductsSourcesInUSAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsSourcesInUSAToolStripMenuItem.Click
        'Finds products sourced in the USA and writes them to recordsQuerry
        Dim recordsQuery = From vendor In Me.ProductDatabaseDataSet.Vendor, product In Me.ProductDatabaseDataSet.Product
                           Where product.Vendor_ID = vendor.Vendor_ID And vendor.Country.ToUpper = "USA"
                           Select product, vendor

        'Clears listbox and listview prior to input.
        psListBox.Items.Clear()
        ppListView.Items.Clear()
        totalLabel.Text = String.Empty
        avgLabel.Text = String.Empty

        'write it to the interface.
        For Each result In recordsQuery
            psListBox.Items.Add(result.product.Product_Name & " From " & result.vendor.Vendor_Name)
        Next

    End Sub

    Private Sub ProductsSourcedInChinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsSourcedInChinaToolStripMenuItem.Click
        'Finds products sourced in the USA and writes them to recordsQuerry
        Dim recordsQuery = From vendor In Me.ProductDatabaseDataSet.Vendor, product In Me.ProductDatabaseDataSet.Product
                           Where product.Vendor_ID = vendor.Vendor_ID And vendor.Country.ToUpper = "CHI"
                           Select product, vendor

        'Clears listbox and listview prior to input.
        psListBox.Items.Clear()
        ppListView.Items.Clear()
        totalLabel.Text = String.Empty
        avgLabel.Text = String.Empty

        'write it to the interface.
        For Each result In recordsQuery
            psListBox.Items.Add(result.product.Product_Name & " From " & result.vendor.Vendor_Name)
        Next
    End Sub

    Private Sub ProductsSourcedInNewYorkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsSourcedInNewYorkToolStripMenuItem.Click
        'Finds products sourced in the USA and writes them to recordsQuerry
        Dim recordsQuery = From vendor In Me.ProductDatabaseDataSet.Vendor, product In Me.ProductDatabaseDataSet.Product
                           Where product.Vendor_ID = vendor.Vendor_ID And vendor.State.ToUpper = "NY"
                           Select product, vendor

        'Clears listbox and listview prior to input.
        psListBox.Items.Clear()
        ppListView.Items.Clear()
        totalLabel.Text = String.Empty
        avgLabel.Text = String.Empty

        'write it to the interface.
        For Each result In recordsQuery
            psListBox.Items.Add(result.product.Product_Name & " From " & result.vendor.Vendor_Name)
        Next
    End Sub

    Private Sub SortByAscendingOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortByAscendingOrderToolStripMenuItem.Click
        'Sorts product names in ascending order.
        Dim recordsQuery = From product In Me.ProductDatabaseDataSet.Product
                           Order By product.Product_Name Ascending
                           Select product

        ProductBindingSource.DataSource = recordsQuery.AsDataView
    End Sub

    Private Sub SortByDescendingOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortByDescendingOrderToolStripMenuItem.Click
        'Sorts Product Price by Descending Order
        Dim recordsQuery = From product In Me.ProductDatabaseDataSet.Product
                           Order By product.Product_Unit_Price Descending
                           Select product

        ProductBindingSource.DataSource = recordsQuery.AsDataView

    End Sub

    Private Sub ProductIDByDescendingOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductIDByDescendingOrderToolStripMenuItem.Click
        'Sorts Product ID by descending order.
        Dim recordsQuery = From product In Me.ProductDatabaseDataSet.Product
                           Order By product.Product_ID Descending
                           Select product

        ProductBindingSource.DataSource = recordsQuery.AsDataView
    End Sub

    Private Sub ProductCostByDescendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductCostByDescendingToolStripMenuItem.Click
        'Sorts Product ID by descending order.
        Dim recordsQuery = From product In Me.ProductDatabaseDataSet.Product
                           Order By product.Product_Cost Descending
                           Select product

        ProductBindingSource.DataSource = recordsQuery.AsDataView
    End Sub


    Private Sub ProductBrandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductBrandToolStripMenuItem.Click
        'Pulls product data from database with energizer brand and counts them. *counts as the new feature added to project*

        Dim recordsQuery As Integer = Aggregate product In Me.ProductDatabaseDataSet.Product
                                     Where product.Brand.ToUpper = "DURACELL"
                                        Into Count()

        MessageBox.Show("The are " & recordsQuery & " products with Duracell brand.")
    End Sub
End Class
