﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.productReorderLevelTextBox = New System.Windows.Forms.TextBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDatabaseDataSet = New Major_Project_3.ProductDatabaseDataSet()
        Me.ytdPurchasesTextBox = New System.Windows.Forms.TextBox()
        Me.discountTextBox = New System.Windows.Forms.TextBox()
        Me.brandTextBox = New System.Windows.Forms.TextBox()
        Me.productLineTextBox = New System.Windows.Forms.TextBox()
        Me.productLeadTimeTextBox = New System.Windows.Forms.TextBox()
        Me.quantityOnOrderTextBox = New System.Windows.Forms.TextBox()
        Me.quantityOnHandTextBox = New System.Windows.Forms.TextBox()
        Me.productCostTextBox = New System.Windows.Forms.TextBox()
        Me.productUnitPriceTextBox = New System.Windows.Forms.TextBox()
        Me.vendorIDComboBox = New System.Windows.Forms.ComboBox()
        Me.productIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductTableAdapter = New Major_Project_3.ProductDatabaseDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New Major_Project_3.ProductDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.VendorTableAdapter = New Major_Project_3.ProductDatabaseDataSetTableAdapters.VendorTableAdapter()
        Me.ProductBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.searchToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.searchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SortByAscendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductIDByDescendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortByDescendingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductCostByDescendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.contactNameLabel = New System.Windows.Forms.Label()
        Me.VendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.notesLabel = New System.Windows.Forms.Label()
        Me.activeStatusLabel = New System.Windows.Forms.Label()
        Me.classificationLabel = New System.Windows.Forms.Label()
        Me.websiteAddressLabel = New System.Windows.Forms.Label()
        Me.phoneNumberLabel = New System.Windows.Forms.Label()
        Me.emailAddressLabel = New System.Windows.Forms.Label()
        Me.countryLabel = New System.Windows.Forms.Label()
        Me.zipCodeLabel = New System.Windows.Forms.Label()
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.cityLabel = New System.Windows.Forms.Label()
        Me.vendorRegionLabel = New System.Windows.Forms.Label()
        Me.vendorNameLabel = New System.Windows.Forms.Label()
        Me.productNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.avgLabel = New System.Windows.Forms.Label()
        Me.ppListView = New System.Windows.Forms.ListView()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.psListBox = New System.Windows.Forms.ListBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.moveLButton = New System.Windows.Forms.Button()
        Me.moveFButton = New System.Windows.Forms.Button()
        Me.movePButton = New System.Windows.Forms.Button()
        Me.moveNButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsSourcesInUSAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsSourcedInChinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsSourcedInNewYorkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductBrandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(24, 27)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(66, 15)
        Label1.TabIndex = 0
        Label1.Text = "Product ID:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(24, 62)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(61, 15)
        Label2.TabIndex = 2
        Label2.Text = "Vendor ID:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(24, 96)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(105, 15)
        Label3.TabIndex = 4
        Label3.Text = "Product unit price:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(24, 130)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(77, 15)
        Label4.TabIndex = 6
        Label4.Text = "Product cost:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(24, 164)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(103, 15)
        Label5.TabIndex = 8
        Label5.Text = "Quantity on hand:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(24, 198)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(104, 15)
        Label6.TabIndex = 10
        Label6.Text = "Quantity on order:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(24, 232)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(104, 15)
        Label7.TabIndex = 12
        Label7.Text = "Product lead time:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(24, 300)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(74, 15)
        Label9.TabIndex = 16
        Label9.Text = "Product line:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(24, 332)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(41, 15)
        Label10.TabIndex = 18
        Label10.Text = "Brand:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(24, 366)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(57, 15)
        Label11.TabIndex = 20
        Label11.Text = "Discount:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(24, 400)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(88, 15)
        Label12.TabIndex = 22
        Label12.Text = "YTD purchases:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(24, 27)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(85, 15)
        Label13.TabIndex = 0
        Label13.Text = "Product name:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(24, 62)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(80, 15)
        Label14.TabIndex = 2
        Label14.Text = "Vendor name:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(24, 96)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(84, 15)
        Label15.TabIndex = 4
        Label15.Text = "Vendor region:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(24, 130)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(31, 15)
        Label16.TabIndex = 6
        Label16.Text = "City:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(24, 164)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(36, 15)
        Label17.TabIndex = 8
        Label17.Text = "State:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(24, 198)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(56, 15)
        Label18.TabIndex = 10
        Label18.Text = "Zip code:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(24, 232)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(53, 15)
        Label19.TabIndex = 12
        Label19.Text = "Country:"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(24, 266)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(82, 15)
        Label20.TabIndex = 14
        Label20.Text = "Email address:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(24, 300)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(89, 15)
        Label21.TabIndex = 16
        Label21.Text = "Phone number:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(24, 332)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(95, 15)
        Label22.TabIndex = 18
        Label22.Text = "Website address:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(24, 366)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(80, 15)
        Label23.TabIndex = 20
        Label23.Text = "Classification:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(24, 400)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(77, 15)
        Label24.TabIndex = 22
        Label24.Text = "Active status:"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(24, 432)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(41, 15)
        Label25.TabIndex = 24
        Label25.Text = "Notes:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Location = New System.Drawing.Point(24, 466)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(85, 15)
        Label26.TabIndex = 26
        Label26.Text = "Contact name:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(24, 266)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(120, 15)
        Label8.TabIndex = 14
        Label8.Text = "Product reorder level:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Me.productReorderLevelTextBox)
        Me.GroupBox1.Controls.Add(Label12)
        Me.GroupBox1.Controls.Add(Me.ytdPurchasesTextBox)
        Me.GroupBox1.Controls.Add(Label11)
        Me.GroupBox1.Controls.Add(Me.discountTextBox)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Me.brandTextBox)
        Me.GroupBox1.Controls.Add(Label9)
        Me.GroupBox1.Controls.Add(Me.productLineTextBox)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(Me.productLeadTimeTextBox)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Me.quantityOnOrderTextBox)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.quantityOnHandTextBox)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.productCostTextBox)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.productUnitPriceTextBox)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.vendorIDComboBox)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.productIDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 501)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'productReorderLevelTextBox
        '
        Me.productReorderLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Reorder_Level", True))
        Me.productReorderLevelTextBox.Location = New System.Drawing.Point(157, 263)
        Me.productReorderLevelTextBox.Name = "productReorderLevelTextBox"
        Me.productReorderLevelTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productReorderLevelTextBox.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.productReorderLevelTextBox, "The use of decimals are allowed")
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.ProductDatabaseDataSet
        '
        'ProductDatabaseDataSet
        '
        Me.ProductDatabaseDataSet.DataSetName = "ProductDatabaseDataSet"
        Me.ProductDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ytdPurchasesTextBox
        '
        Me.ytdPurchasesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "YTD_Purchases", True))
        Me.ytdPurchasesTextBox.Location = New System.Drawing.Point(157, 397)
        Me.ytdPurchasesTextBox.Name = "ytdPurchasesTextBox"
        Me.ytdPurchasesTextBox.Size = New System.Drawing.Size(116, 23)
        Me.ytdPurchasesTextBox.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.ytdPurchasesTextBox, "The use of decimals are allowed")
        '
        'discountTextBox
        '
        Me.discountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Discount", True))
        Me.discountTextBox.Location = New System.Drawing.Point(157, 363)
        Me.discountTextBox.Name = "discountTextBox"
        Me.discountTextBox.Size = New System.Drawing.Size(116, 23)
        Me.discountTextBox.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.discountTextBox, "Only insert as decimals")
        '
        'brandTextBox
        '
        Me.brandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Brand", True))
        Me.brandTextBox.Location = New System.Drawing.Point(157, 329)
        Me.brandTextBox.Name = "brandTextBox"
        Me.brandTextBox.Size = New System.Drawing.Size(116, 23)
        Me.brandTextBox.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.brandTextBox, "Insert text here")
        '
        'productLineTextBox
        '
        Me.productLineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Line", True))
        Me.productLineTextBox.Location = New System.Drawing.Point(157, 297)
        Me.productLineTextBox.Name = "productLineTextBox"
        Me.productLineTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productLineTextBox.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.productLineTextBox, "Insert text here")
        '
        'productLeadTimeTextBox
        '
        Me.productLeadTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Lead_Time", True))
        Me.productLeadTimeTextBox.Location = New System.Drawing.Point(157, 229)
        Me.productLeadTimeTextBox.Name = "productLeadTimeTextBox"
        Me.productLeadTimeTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productLeadTimeTextBox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.productLeadTimeTextBox, "The use of decimals are allowed")
        '
        'quantityOnOrderTextBox
        '
        Me.quantityOnOrderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Quantity_On_Order", True))
        Me.quantityOnOrderTextBox.Location = New System.Drawing.Point(157, 195)
        Me.quantityOnOrderTextBox.Name = "quantityOnOrderTextBox"
        Me.quantityOnOrderTextBox.Size = New System.Drawing.Size(116, 23)
        Me.quantityOnOrderTextBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.quantityOnOrderTextBox, "Enter only whole numbers")
        '
        'quantityOnHandTextBox
        '
        Me.quantityOnHandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Quantity_On_Hand", True))
        Me.quantityOnHandTextBox.Location = New System.Drawing.Point(157, 161)
        Me.quantityOnHandTextBox.Name = "quantityOnHandTextBox"
        Me.quantityOnHandTextBox.Size = New System.Drawing.Size(116, 23)
        Me.quantityOnHandTextBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.quantityOnHandTextBox, "Enter only whole numbers")
        '
        'productCostTextBox
        '
        Me.productCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Cost", True))
        Me.productCostTextBox.Location = New System.Drawing.Point(157, 127)
        Me.productCostTextBox.Name = "productCostTextBox"
        Me.productCostTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productCostTextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.productCostTextBox, "No symbols besides decimal point may be used.")
        '
        'productUnitPriceTextBox
        '
        Me.productUnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Unit_Price", True))
        Me.productUnitPriceTextBox.Location = New System.Drawing.Point(157, 93)
        Me.productUnitPriceTextBox.Name = "productUnitPriceTextBox"
        Me.productUnitPriceTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productUnitPriceTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.productUnitPriceTextBox, "No symbols besides decimal point may be used.")
        '
        'vendorIDComboBox
        '
        Me.vendorIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Vendor_ID", True))
        Me.vendorIDComboBox.FormattingEnabled = True
        Me.vendorIDComboBox.Location = New System.Drawing.Point(157, 59)
        Me.vendorIDComboBox.Name = "vendorIDComboBox"
        Me.vendorIDComboBox.Size = New System.Drawing.Size(116, 23)
        Me.vendorIDComboBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.vendorIDComboBox, "Select unique vendor id")
        '
        'productIDTextBox
        '
        Me.productIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_ID", True))
        Me.productIDTextBox.Location = New System.Drawing.Point(157, 25)
        Me.productIDTextBox.Name = "productIDTextBox"
        Me.productIDTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productIDTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.productIDTextBox, "Insert unique product id")
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = Major_Project_3.ProductDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorTableAdapter = Me.VendorTableAdapter
        '
        'VendorTableAdapter
        '
        Me.VendorTableAdapter.ClearBeforeFill = True
        '
        'ProductBindingNavigator
        '
        Me.ProductBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductBindingNavigator.BindingSource = Me.ProductBindingSource
        Me.ProductBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductBindingNavigatorSaveItem, Me.searchToolStripTextBox, Me.searchToolStripButton, Me.ToolStripDropDownButton1})
        Me.ProductBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.ProductBindingNavigator.MoveFirstItem = Nothing
        Me.ProductBindingNavigator.MoveLastItem = Nothing
        Me.ProductBindingNavigator.MoveNextItem = Nothing
        Me.ProductBindingNavigator.MovePreviousItem = Nothing
        Me.ProductBindingNavigator.Name = "ProductBindingNavigator"
        Me.ProductBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(1170, 25)
        Me.ProductBindingNavigator.TabIndex = 1
        Me.ProductBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductBindingNavigatorSaveItem
        '
        Me.ProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductBindingNavigatorSaveItem.Name = "ProductBindingNavigatorSaveItem"
        Me.ProductBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductBindingNavigatorSaveItem.Text = "Save Data"
        '
        'searchToolStripTextBox
        '
        Me.searchToolStripTextBox.Name = "searchToolStripTextBox"
        Me.searchToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        Me.searchToolStripTextBox.ToolTipText = "Insert item for search "
        '
        'searchToolStripButton
        '
        Me.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.searchToolStripButton.Image = CType(resources.GetObject("searchToolStripButton.Image"), System.Drawing.Image)
        Me.searchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.searchToolStripButton.Name = "searchToolStripButton"
        Me.searchToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.searchToolStripButton.Text = "ToolStripButton1"
        Me.searchToolStripButton.ToolTipText = "Search"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortByAscendingOrderToolStripMenuItem, Me.ProductIDByDescendingOrderToolStripMenuItem, Me.SortByDescendingOrderToolStripMenuItem, Me.ProductCostByDescendingToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'SortByAscendingOrderToolStripMenuItem
        '
        Me.SortByAscendingOrderToolStripMenuItem.Name = "SortByAscendingOrderToolStripMenuItem"
        Me.SortByAscendingOrderToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.SortByAscendingOrderToolStripMenuItem.Text = "Product Name by Ascending Order"
        '
        'ProductIDByDescendingOrderToolStripMenuItem
        '
        Me.ProductIDByDescendingOrderToolStripMenuItem.Name = "ProductIDByDescendingOrderToolStripMenuItem"
        Me.ProductIDByDescendingOrderToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.ProductIDByDescendingOrderToolStripMenuItem.Text = "Product ID by Descending Order"
        '
        'SortByDescendingOrderToolStripMenuItem
        '
        Me.SortByDescendingOrderToolStripMenuItem.Name = "SortByDescendingOrderToolStripMenuItem"
        Me.SortByDescendingOrderToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.SortByDescendingOrderToolStripMenuItem.Text = "Product Price by Descending Order"
        '
        'ProductCostByDescendingToolStripMenuItem
        '
        Me.ProductCostByDescendingToolStripMenuItem.Name = "ProductCostByDescendingToolStripMenuItem"
        Me.ProductCostByDescendingToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.ProductCostByDescendingToolStripMenuItem.Text = "Product Cost by Descending Order"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label26)
        Me.GroupBox2.Controls.Add(Me.contactNameLabel)
        Me.GroupBox2.Controls.Add(Label25)
        Me.GroupBox2.Controls.Add(Me.notesLabel)
        Me.GroupBox2.Controls.Add(Label24)
        Me.GroupBox2.Controls.Add(Me.activeStatusLabel)
        Me.GroupBox2.Controls.Add(Label23)
        Me.GroupBox2.Controls.Add(Me.classificationLabel)
        Me.GroupBox2.Controls.Add(Label22)
        Me.GroupBox2.Controls.Add(Me.websiteAddressLabel)
        Me.GroupBox2.Controls.Add(Label21)
        Me.GroupBox2.Controls.Add(Me.phoneNumberLabel)
        Me.GroupBox2.Controls.Add(Label20)
        Me.GroupBox2.Controls.Add(Me.emailAddressLabel)
        Me.GroupBox2.Controls.Add(Label19)
        Me.GroupBox2.Controls.Add(Me.countryLabel)
        Me.GroupBox2.Controls.Add(Label18)
        Me.GroupBox2.Controls.Add(Me.zipCodeLabel)
        Me.GroupBox2.Controls.Add(Label17)
        Me.GroupBox2.Controls.Add(Me.stateLabel)
        Me.GroupBox2.Controls.Add(Label16)
        Me.GroupBox2.Controls.Add(Me.cityLabel)
        Me.GroupBox2.Controls.Add(Label15)
        Me.GroupBox2.Controls.Add(Me.vendorRegionLabel)
        Me.GroupBox2.Controls.Add(Label14)
        Me.GroupBox2.Controls.Add(Me.vendorNameLabel)
        Me.GroupBox2.Controls.Add(Label13)
        Me.GroupBox2.Controls.Add(Me.productNameTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(337, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 501)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'contactNameLabel
        '
        Me.contactNameLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Contact_Name", True))
        Me.contactNameLabel.Location = New System.Drawing.Point(138, 463)
        Me.contactNameLabel.Name = "contactNameLabel"
        Me.contactNameLabel.Size = New System.Drawing.Size(116, 23)
        Me.contactNameLabel.TabIndex = 27
        Me.contactNameLabel.Text = "Label1"
        '
        'VendorBindingSource
        '
        Me.VendorBindingSource.DataMember = "Vendor"
        Me.VendorBindingSource.DataSource = Me.ProductDatabaseDataSet
        '
        'notesLabel
        '
        Me.notesLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Notes", True))
        Me.notesLabel.Location = New System.Drawing.Point(138, 429)
        Me.notesLabel.Name = "notesLabel"
        Me.notesLabel.Size = New System.Drawing.Size(116, 23)
        Me.notesLabel.TabIndex = 25
        Me.notesLabel.Text = "Label1"
        '
        'activeStatusLabel
        '
        Me.activeStatusLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Active_Status", True))
        Me.activeStatusLabel.Location = New System.Drawing.Point(138, 397)
        Me.activeStatusLabel.Name = "activeStatusLabel"
        Me.activeStatusLabel.Size = New System.Drawing.Size(116, 23)
        Me.activeStatusLabel.TabIndex = 23
        Me.activeStatusLabel.Text = "Label1"
        '
        'classificationLabel
        '
        Me.classificationLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Classification", True))
        Me.classificationLabel.Location = New System.Drawing.Point(138, 363)
        Me.classificationLabel.Name = "classificationLabel"
        Me.classificationLabel.Size = New System.Drawing.Size(116, 23)
        Me.classificationLabel.TabIndex = 21
        Me.classificationLabel.Text = "Label1"
        '
        'websiteAddressLabel
        '
        Me.websiteAddressLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Website_Address", True))
        Me.websiteAddressLabel.Location = New System.Drawing.Point(138, 329)
        Me.websiteAddressLabel.Name = "websiteAddressLabel"
        Me.websiteAddressLabel.Size = New System.Drawing.Size(116, 23)
        Me.websiteAddressLabel.TabIndex = 19
        Me.websiteAddressLabel.Text = "Label1"
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Phone_Number", True))
        Me.phoneNumberLabel.Location = New System.Drawing.Point(138, 297)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(116, 23)
        Me.phoneNumberLabel.TabIndex = 17
        Me.phoneNumberLabel.Text = "Label1"
        '
        'emailAddressLabel
        '
        Me.emailAddressLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Email_Address", True))
        Me.emailAddressLabel.Location = New System.Drawing.Point(138, 263)
        Me.emailAddressLabel.Name = "emailAddressLabel"
        Me.emailAddressLabel.Size = New System.Drawing.Size(116, 23)
        Me.emailAddressLabel.TabIndex = 15
        Me.emailAddressLabel.Text = "Label1"
        '
        'countryLabel
        '
        Me.countryLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Country", True))
        Me.countryLabel.Location = New System.Drawing.Point(138, 229)
        Me.countryLabel.Name = "countryLabel"
        Me.countryLabel.Size = New System.Drawing.Size(116, 23)
        Me.countryLabel.TabIndex = 13
        Me.countryLabel.Text = "Label1"
        '
        'zipCodeLabel
        '
        Me.zipCodeLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Zip_Code", True))
        Me.zipCodeLabel.Location = New System.Drawing.Point(138, 195)
        Me.zipCodeLabel.Name = "zipCodeLabel"
        Me.zipCodeLabel.Size = New System.Drawing.Size(116, 23)
        Me.zipCodeLabel.TabIndex = 11
        Me.zipCodeLabel.Text = "Label1"
        '
        'stateLabel
        '
        Me.stateLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "State", True))
        Me.stateLabel.Location = New System.Drawing.Point(138, 161)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(116, 23)
        Me.stateLabel.TabIndex = 9
        Me.stateLabel.Text = "Label1"
        '
        'cityLabel
        '
        Me.cityLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "City", True))
        Me.cityLabel.Location = New System.Drawing.Point(138, 127)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(116, 23)
        Me.cityLabel.TabIndex = 7
        Me.cityLabel.Text = "Label1"
        '
        'vendorRegionLabel
        '
        Me.vendorRegionLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Vendor_Region", True))
        Me.vendorRegionLabel.Location = New System.Drawing.Point(138, 93)
        Me.vendorRegionLabel.Name = "vendorRegionLabel"
        Me.vendorRegionLabel.Size = New System.Drawing.Size(116, 23)
        Me.vendorRegionLabel.TabIndex = 5
        Me.vendorRegionLabel.Text = "Label1"
        '
        'vendorNameLabel
        '
        Me.vendorNameLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Vendor_Name", True))
        Me.vendorNameLabel.Location = New System.Drawing.Point(138, 59)
        Me.vendorNameLabel.Name = "vendorNameLabel"
        Me.vendorNameLabel.Size = New System.Drawing.Size(116, 23)
        Me.vendorNameLabel.TabIndex = 3
        Me.vendorNameLabel.Text = "Label1"
        '
        'productNameTextBox
        '
        Me.productNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Name", True))
        Me.productNameTextBox.Location = New System.Drawing.Point(138, 24)
        Me.productNameTextBox.Name = "productNameTextBox"
        Me.productNameTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productNameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.productNameTextBox, "Insert text here")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.totalLabel)
        Me.GroupBox3.Controls.Add(Me.avgLabel)
        Me.GroupBox3.Controls.Add(Me.ppListView)
        Me.GroupBox3.Controls.Add(Me.exitButton)
        Me.GroupBox3.Controls.Add(Me.searchButton)
        Me.GroupBox3.Controls.Add(Me.refreshButton)
        Me.GroupBox3.Controls.Add(Me.calculateButton)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.psListBox)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Location = New System.Drawing.Point(684, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 598)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'totalLabel
        '
        Me.totalLabel.Location = New System.Drawing.Point(214, 443)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(116, 23)
        Me.totalLabel.TabIndex = 13
        '
        'avgLabel
        '
        Me.avgLabel.Location = New System.Drawing.Point(18, 443)
        Me.avgLabel.Name = "avgLabel"
        Me.avgLabel.Size = New System.Drawing.Size(116, 23)
        Me.avgLabel.TabIndex = 12
        '
        'ppListView
        '
        Me.ppListView.Location = New System.Drawing.Point(18, 255)
        Me.ppListView.Name = "ppListView"
        Me.ppListView.Size = New System.Drawing.Size(381, 139)
        Me.ppListView.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ppListView, "Display product name and purchase amount")
        Me.ppListView.UseCompatibleStateImageBehavior = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(309, 516)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(91, 47)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.exitButton, "Exit the application")
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(212, 516)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(91, 47)
        Me.searchButton.TabIndex = 10
        Me.searchButton.Text = "&Search"
        Me.ToolTip1.SetToolTip(Me.searchButton, "Search for item within dataset")
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(115, 516)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(91, 47)
        Me.refreshButton.TabIndex = 9
        Me.refreshButton.Text = "&Refresh"
        Me.ToolTip1.SetToolTip(Me.refreshButton, "Revert to original data after a search")
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(18, 516)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(91, 47)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.calculateButton, "Calculate the above mathmatical expressions")
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(210, 424)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(87, 15)
        Me.Label32.TabIndex = 6
        Me.Label32.Text = "Total purchase:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(18, 423)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 15)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "Average purchase:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(18, 237)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(108, 15)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Product purchases:"
        '
        'psListBox
        '
        Me.psListBox.FormattingEnabled = True
        Me.psListBox.ItemHeight = 15
        Me.psListBox.Location = New System.Drawing.Point(18, 55)
        Me.psListBox.Name = "psListBox"
        Me.psListBox.Size = New System.Drawing.Size(381, 154)
        Me.psListBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.psListBox, "Displays query results")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(18, 37)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 15)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Product sources:"
        '
        'moveLButton
        '
        Me.moveLButton.Location = New System.Drawing.Point(370, 20)
        Me.moveLButton.Name = "moveLButton"
        Me.moveLButton.Size = New System.Drawing.Size(91, 47)
        Me.moveLButton.TabIndex = 3
        Me.moveLButton.Text = "Move &Last"
        Me.ToolTip1.SetToolTip(Me.moveLButton, "Move to the last item in dataset")
        Me.moveLButton.UseVisualStyleBackColor = True
        '
        'moveFButton
        '
        Me.moveFButton.Location = New System.Drawing.Point(250, 20)
        Me.moveFButton.Name = "moveFButton"
        Me.moveFButton.Size = New System.Drawing.Size(91, 47)
        Me.moveFButton.TabIndex = 2
        Me.moveFButton.Text = "Move &First"
        Me.ToolTip1.SetToolTip(Me.moveFButton, "Move to the 1st item in dataset")
        Me.moveFButton.UseVisualStyleBackColor = True
        '
        'movePButton
        '
        Me.movePButton.Location = New System.Drawing.Point(18, 20)
        Me.movePButton.Name = "movePButton"
        Me.movePButton.Size = New System.Drawing.Size(91, 47)
        Me.movePButton.TabIndex = 0
        Me.movePButton.Text = "Move &Previous"
        Me.ToolTip1.SetToolTip(Me.movePButton, "Move to last viewed item in dataset")
        Me.movePButton.UseVisualStyleBackColor = True
        '
        'moveNButton
        '
        Me.moveNButton.Location = New System.Drawing.Point(135, 20)
        Me.moveNButton.Name = "moveNButton"
        Me.moveNButton.Size = New System.Drawing.Size(91, 47)
        Me.moveNButton.TabIndex = 1
        Me.moveNButton.Text = "Move &Next"
        Me.ToolTip1.SetToolTip(Me.moveNButton, "Move to the very next item in dataset")
        Me.moveNButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QueryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1170, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QueryToolStripMenuItem
        '
        Me.QueryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsSourcesInUSAToolStripMenuItem, Me.ProductsSourcedInChinaToolStripMenuItem, Me.ProductsSourcedInNewYorkToolStripMenuItem, Me.ProductBrandToolStripMenuItem})
        Me.QueryToolStripMenuItem.Name = "QueryToolStripMenuItem"
        Me.QueryToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.QueryToolStripMenuItem.Text = "Queries"
        Me.QueryToolStripMenuItem.ToolTipText = "Menu for Queries"
        '
        'ProductsSourcesInUSAToolStripMenuItem
        '
        Me.ProductsSourcesInUSAToolStripMenuItem.Name = "ProductsSourcesInUSAToolStripMenuItem"
        Me.ProductsSourcesInUSAToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.ProductsSourcesInUSAToolStripMenuItem.Text = "Products Sourced in USA"
        Me.ProductsSourcesInUSAToolStripMenuItem.ToolTipText = "Query of USA sourced products"
        '
        'ProductsSourcedInChinaToolStripMenuItem
        '
        Me.ProductsSourcedInChinaToolStripMenuItem.Name = "ProductsSourcedInChinaToolStripMenuItem"
        Me.ProductsSourcedInChinaToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.ProductsSourcedInChinaToolStripMenuItem.Text = "Products Sourced in China"
        Me.ProductsSourcedInChinaToolStripMenuItem.ToolTipText = "Query of China Sourced Products"
        '
        'ProductsSourcedInNewYorkToolStripMenuItem
        '
        Me.ProductsSourcedInNewYorkToolStripMenuItem.Name = "ProductsSourcedInNewYorkToolStripMenuItem"
        Me.ProductsSourcedInNewYorkToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.ProductsSourcedInNewYorkToolStripMenuItem.Text = "Products Sourced in New York"
        Me.ProductsSourcedInNewYorkToolStripMenuItem.ToolTipText = "Query of New York Sourced Products"
        '
        'ProductBrandToolStripMenuItem
        '
        Me.ProductBrandToolStripMenuItem.Name = "ProductBrandToolStripMenuItem"
        Me.ProductBrandToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.ProductBrandToolStripMenuItem.Text = "Number of Products with Duracell Brand"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.ExitToolStripMenuItem.ToolTipText = "Closes application"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.moveNButton)
        Me.GroupBox4.Controls.Add(Me.movePButton)
        Me.GroupBox4.Controls.Add(Me.moveFButton)
        Me.GroupBox4.Controls.Add(Me.moveLButton)
        Me.GroupBox4.Location = New System.Drawing.Point(105, 578)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(483, 82)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1170, 682)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ProductBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "DCC.Inc Product Information and Maintenance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProductDatabaseDataSet As ProductDatabaseDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As ProductDatabaseDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As ProductDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ytdPurchasesTextBox As TextBox
    Friend WithEvents discountTextBox As TextBox
    Friend WithEvents brandTextBox As TextBox
    Friend WithEvents productLineTextBox As TextBox
    Friend WithEvents productLeadTimeTextBox As TextBox
    Friend WithEvents quantityOnOrderTextBox As TextBox
    Friend WithEvents quantityOnHandTextBox As TextBox
    Friend WithEvents productCostTextBox As TextBox
    Friend WithEvents productUnitPriceTextBox As TextBox
    Friend WithEvents vendorIDComboBox As ComboBox
    Friend WithEvents productIDTextBox As TextBox
    Friend WithEvents VendorTableAdapter As ProductDatabaseDataSetTableAdapters.VendorTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents productNameTextBox As TextBox
    Friend WithEvents VendorBindingSource As BindingSource
    Friend WithEvents productReorderLevelTextBox As TextBox
    Friend WithEvents contactNameLabel As Label
    Friend WithEvents notesLabel As Label
    Friend WithEvents activeStatusLabel As Label
    Friend WithEvents classificationLabel As Label
    Friend WithEvents websiteAddressLabel As Label
    Friend WithEvents phoneNumberLabel As Label
    Friend WithEvents emailAddressLabel As Label
    Friend WithEvents countryLabel As Label
    Friend WithEvents zipCodeLabel As Label
    Friend WithEvents stateLabel As Label
    Friend WithEvents cityLabel As Label
    Friend WithEvents vendorRegionLabel As Label
    Friend WithEvents vendorNameLabel As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents exitButton As Button
    Friend WithEvents searchButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents calculateButton As Button
    Friend WithEvents moveLButton As Button
    Friend WithEvents moveFButton As Button
    Friend WithEvents movePButton As Button
    Friend WithEvents moveNButton As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents psListBox As ListBox
    Friend WithEvents Label27 As Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ppListView As ListView
    Friend WithEvents searchToolStripTextBox As ToolStripTextBox
    Friend WithEvents searchToolStripButton As ToolStripButton
    Friend WithEvents QueryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsSourcesInUSAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsSourcedInChinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsSourcedInNewYorkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents SortByAscendingOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductIDByDescendingOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortByDescendingOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductCostByDescendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductBrandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents avgLabel As Label
    Friend WithEvents totalLabel As Label
End Class
