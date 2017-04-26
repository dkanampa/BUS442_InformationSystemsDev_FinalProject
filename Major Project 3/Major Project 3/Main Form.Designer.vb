<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.avgTextBox = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.minTextBox = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.maxTextBox = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.psListBox = New System.Windows.Forms.ListBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.moveLButton = New System.Windows.Forms.Button()
        Me.moveFButton = New System.Windows.Forms.Button()
        Me.movePButton = New System.Windows.Forms.Button()
        Me.moveNButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuerryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ppListView = New System.Windows.Forms.ListView()
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
        Label1.Location = New System.Drawing.Point(16, 32)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(66, 15)
        Label1.TabIndex = 0
        Label1.Text = "Product ID:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(16, 64)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(61, 15)
        Label2.TabIndex = 2
        Label2.Text = "Vendor ID:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(16, 107)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(105, 15)
        Label3.TabIndex = 4
        Label3.Text = "Product unit price:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(16, 143)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(77, 15)
        Label4.TabIndex = 6
        Label4.Text = "Product cost:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(16, 179)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(103, 15)
        Label5.TabIndex = 8
        Label5.Text = "Quantity on hand:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(16, 211)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(104, 15)
        Label6.TabIndex = 10
        Label6.Text = "Quantity on order:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(16, 246)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(104, 15)
        Label7.TabIndex = 12
        Label7.Text = "Product lead time:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(40, 295)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(74, 15)
        Label9.TabIndex = 14
        Label9.Text = "Product line:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(41, 325)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(41, 15)
        Label10.TabIndex = 16
        Label10.Text = "Brand:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(16, 381)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(57, 15)
        Label11.TabIndex = 18
        Label11.Text = "Discount:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(16, 422)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(88, 15)
        Label12.TabIndex = 20
        Label12.Text = "YTD purchases:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(19, 28)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(85, 15)
        Label13.TabIndex = 0
        Label13.Text = "Product name:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(26, 57)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(80, 15)
        Label14.TabIndex = 2
        Label14.Text = "Vendor name:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(30, 88)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(84, 15)
        Label15.TabIndex = 4
        Label15.Text = "Vendor region:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(34, 122)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(31, 15)
        Label16.TabIndex = 6
        Label16.Text = "City:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(38, 159)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(36, 15)
        Label17.TabIndex = 8
        Label17.Text = "State:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(38, 204)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(56, 15)
        Label18.TabIndex = 10
        Label18.Text = "Zip code:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(40, 233)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(53, 15)
        Label19.TabIndex = 12
        Label19.Text = "Country:"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(48, 275)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(82, 15)
        Label20.TabIndex = 14
        Label20.Text = "Email address:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(30, 301)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(89, 15)
        Label21.TabIndex = 16
        Label21.Text = "Phone number:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(20, 328)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(95, 15)
        Label22.TabIndex = 18
        Label22.Text = "Website address:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(30, 357)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(80, 15)
        Label23.TabIndex = 20
        Label23.Text = "Classification:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(37, 395)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(77, 15)
        Label24.TabIndex = 22
        Label24.Text = "Active status:"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(45, 423)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(41, 15)
        Label25.TabIndex = 24
        Label25.Text = "Notes:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Location = New System.Drawing.Point(54, 451)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(85, 15)
        Label26.TabIndex = 26
        Label26.Text = "Contact name:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(26, 272)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(120, 15)
        Label8.TabIndex = 22
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
        Me.GroupBox1.Size = New System.Drawing.Size(321, 501)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'productReorderLevelTextBox
        '
        Me.productReorderLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Reorder_Level", True))
        Me.productReorderLevelTextBox.Location = New System.Drawing.Point(169, 262)
        Me.productReorderLevelTextBox.Name = "productReorderLevelTextBox"
        Me.productReorderLevelTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productReorderLevelTextBox.TabIndex = 23
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
        Me.ytdPurchasesTextBox.Location = New System.Drawing.Point(125, 427)
        Me.ytdPurchasesTextBox.Name = "ytdPurchasesTextBox"
        Me.ytdPurchasesTextBox.Size = New System.Drawing.Size(116, 23)
        Me.ytdPurchasesTextBox.TabIndex = 21
        '
        'discountTextBox
        '
        Me.discountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Discount", True))
        Me.discountTextBox.Location = New System.Drawing.Point(125, 378)
        Me.discountTextBox.Name = "discountTextBox"
        Me.discountTextBox.Size = New System.Drawing.Size(116, 23)
        Me.discountTextBox.TabIndex = 19
        '
        'brandTextBox
        '
        Me.brandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Brand", True))
        Me.brandTextBox.Location = New System.Drawing.Point(92, 322)
        Me.brandTextBox.Name = "brandTextBox"
        Me.brandTextBox.Size = New System.Drawing.Size(116, 23)
        Me.brandTextBox.TabIndex = 17
        '
        'productLineTextBox
        '
        Me.productLineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Line", True))
        Me.productLineTextBox.Location = New System.Drawing.Point(128, 292)
        Me.productLineTextBox.Name = "productLineTextBox"
        Me.productLineTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productLineTextBox.TabIndex = 15
        '
        'productLeadTimeTextBox
        '
        Me.productLeadTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Lead_Time", True))
        Me.productLeadTimeTextBox.Location = New System.Drawing.Point(127, 238)
        Me.productLeadTimeTextBox.Name = "productLeadTimeTextBox"
        Me.productLeadTimeTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productLeadTimeTextBox.TabIndex = 13
        '
        'quantityOnOrderTextBox
        '
        Me.quantityOnOrderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Quantity_On_Order", True))
        Me.quantityOnOrderTextBox.Location = New System.Drawing.Point(128, 208)
        Me.quantityOnOrderTextBox.Name = "quantityOnOrderTextBox"
        Me.quantityOnOrderTextBox.Size = New System.Drawing.Size(116, 23)
        Me.quantityOnOrderTextBox.TabIndex = 11
        '
        'quantityOnHandTextBox
        '
        Me.quantityOnHandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Quantity_On_Hand", True))
        Me.quantityOnHandTextBox.Location = New System.Drawing.Point(125, 171)
        Me.quantityOnHandTextBox.Name = "quantityOnHandTextBox"
        Me.quantityOnHandTextBox.Size = New System.Drawing.Size(116, 23)
        Me.quantityOnHandTextBox.TabIndex = 9
        '
        'productCostTextBox
        '
        Me.productCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Cost", True))
        Me.productCostTextBox.Location = New System.Drawing.Point(127, 143)
        Me.productCostTextBox.Name = "productCostTextBox"
        Me.productCostTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productCostTextBox.TabIndex = 7
        '
        'productUnitPriceTextBox
        '
        Me.productUnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Unit_Price", True))
        Me.productUnitPriceTextBox.Location = New System.Drawing.Point(127, 107)
        Me.productUnitPriceTextBox.Name = "productUnitPriceTextBox"
        Me.productUnitPriceTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productUnitPriceTextBox.TabIndex = 5
        '
        'vendorIDComboBox
        '
        Me.vendorIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Vendor_ID", True))
        Me.vendorIDComboBox.FormattingEnabled = True
        Me.vendorIDComboBox.Location = New System.Drawing.Point(125, 61)
        Me.vendorIDComboBox.Name = "vendorIDComboBox"
        Me.vendorIDComboBox.Size = New System.Drawing.Size(140, 23)
        Me.vendorIDComboBox.TabIndex = 3
        '
        'productIDTextBox
        '
        Me.productIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_ID", True))
        Me.productIDTextBox.Location = New System.Drawing.Point(125, 28)
        Me.productIDTextBox.Name = "productIDTextBox"
        Me.productIDTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productIDTextBox.TabIndex = 1
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
        Me.ProductBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductBindingNavigatorSaveItem})
        Me.ProductBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.ProductBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductBindingNavigator.Name = "ProductBindingNavigator"
        Me.ProductBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(1333, 25)
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
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
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
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
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
        Me.GroupBox2.Location = New System.Drawing.Point(377, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 501)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'contactNameLabel
        '
        Me.contactNameLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Contact_Name", True))
        Me.contactNameLabel.Location = New System.Drawing.Point(152, 451)
        Me.contactNameLabel.Name = "contactNameLabel"
        Me.contactNameLabel.Size = New System.Drawing.Size(117, 27)
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
        Me.notesLabel.Location = New System.Drawing.Point(97, 423)
        Me.notesLabel.Name = "notesLabel"
        Me.notesLabel.Size = New System.Drawing.Size(117, 27)
        Me.notesLabel.TabIndex = 25
        Me.notesLabel.Text = "Label1"
        '
        'activeStatusLabel
        '
        Me.activeStatusLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Active_Status", True))
        Me.activeStatusLabel.Location = New System.Drawing.Point(129, 395)
        Me.activeStatusLabel.Name = "activeStatusLabel"
        Me.activeStatusLabel.Size = New System.Drawing.Size(117, 27)
        Me.activeStatusLabel.TabIndex = 23
        Me.activeStatusLabel.Text = "Label1"
        '
        'classificationLabel
        '
        Me.classificationLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Classification", True))
        Me.classificationLabel.Location = New System.Drawing.Point(120, 357)
        Me.classificationLabel.Name = "classificationLabel"
        Me.classificationLabel.Size = New System.Drawing.Size(117, 27)
        Me.classificationLabel.TabIndex = 21
        Me.classificationLabel.Text = "Label1"
        '
        'websiteAddressLabel
        '
        Me.websiteAddressLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Website_Address", True))
        Me.websiteAddressLabel.Location = New System.Drawing.Point(132, 328)
        Me.websiteAddressLabel.Name = "websiteAddressLabel"
        Me.websiteAddressLabel.Size = New System.Drawing.Size(117, 27)
        Me.websiteAddressLabel.TabIndex = 19
        Me.websiteAddressLabel.Text = "Label1"
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Phone_Number", True))
        Me.phoneNumberLabel.Location = New System.Drawing.Point(132, 301)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(117, 27)
        Me.phoneNumberLabel.TabIndex = 17
        Me.phoneNumberLabel.Text = "Label1"
        '
        'emailAddressLabel
        '
        Me.emailAddressLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Email_Address", True))
        Me.emailAddressLabel.Location = New System.Drawing.Point(143, 275)
        Me.emailAddressLabel.Name = "emailAddressLabel"
        Me.emailAddressLabel.Size = New System.Drawing.Size(117, 27)
        Me.emailAddressLabel.TabIndex = 15
        Me.emailAddressLabel.Text = "Label1"
        '
        'countryLabel
        '
        Me.countryLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Country", True))
        Me.countryLabel.Location = New System.Drawing.Point(100, 233)
        Me.countryLabel.Name = "countryLabel"
        Me.countryLabel.Size = New System.Drawing.Size(117, 27)
        Me.countryLabel.TabIndex = 13
        Me.countryLabel.Text = "Label1"
        '
        'zipCodeLabel
        '
        Me.zipCodeLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Zip_Code", True))
        Me.zipCodeLabel.Location = New System.Drawing.Point(107, 204)
        Me.zipCodeLabel.Name = "zipCodeLabel"
        Me.zipCodeLabel.Size = New System.Drawing.Size(117, 27)
        Me.zipCodeLabel.TabIndex = 11
        Me.zipCodeLabel.Text = "Label1"
        '
        'stateLabel
        '
        Me.stateLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "State", True))
        Me.stateLabel.Location = New System.Drawing.Point(86, 159)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(117, 27)
        Me.stateLabel.TabIndex = 9
        Me.stateLabel.Text = "Label1"
        '
        'cityLabel
        '
        Me.cityLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "City", True))
        Me.cityLabel.Location = New System.Drawing.Point(72, 122)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(117, 27)
        Me.cityLabel.TabIndex = 7
        Me.cityLabel.Text = "Label1"
        '
        'vendorRegionLabel
        '
        Me.vendorRegionLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Vendor_Region", True))
        Me.vendorRegionLabel.Location = New System.Drawing.Point(132, 88)
        Me.vendorRegionLabel.Name = "vendorRegionLabel"
        Me.vendorRegionLabel.Size = New System.Drawing.Size(117, 27)
        Me.vendorRegionLabel.TabIndex = 5
        Me.vendorRegionLabel.Text = "Label1"
        '
        'vendorNameLabel
        '
        Me.vendorNameLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Vendor_Name", True))
        Me.vendorNameLabel.Location = New System.Drawing.Point(120, 57)
        Me.vendorNameLabel.Name = "vendorNameLabel"
        Me.vendorNameLabel.Size = New System.Drawing.Size(117, 27)
        Me.vendorNameLabel.TabIndex = 3
        Me.vendorNameLabel.Text = "Label1"
        '
        'productNameTextBox
        '
        Me.productNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Name", True))
        Me.productNameTextBox.Location = New System.Drawing.Point(117, 24)
        Me.productNameTextBox.Name = "productNameTextBox"
        Me.productNameTextBox.Size = New System.Drawing.Size(116, 23)
        Me.productNameTextBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ppListView)
        Me.GroupBox3.Controls.Add(Me.exitButton)
        Me.GroupBox3.Controls.Add(Me.searchButton)
        Me.GroupBox3.Controls.Add(Me.refreshButton)
        Me.GroupBox3.Controls.Add(Me.calculateButton)
        Me.GroupBox3.Controls.Add(Me.totalTextBox)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.avgTextBox)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.minTextBox)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.maxTextBox)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.psListBox)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Location = New System.Drawing.Point(717, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(440, 611)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(315, 493)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(91, 47)
        Me.exitButton.TabIndex = 19
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(221, 493)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(91, 47)
        Me.searchButton.TabIndex = 18
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(124, 493)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(91, 47)
        Me.refreshButton.TabIndex = 17
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(27, 493)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(91, 47)
        Me.calculateButton.TabIndex = 16
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'totalTextBox
        '
        Me.totalTextBox.Location = New System.Drawing.Point(214, 445)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.Size = New System.Drawing.Size(116, 23)
        Me.totalTextBox.TabIndex = 11
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(210, 424)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(87, 15)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "Total purchase:"
        '
        'avgTextBox
        '
        Me.avgTextBox.Location = New System.Drawing.Point(30, 443)
        Me.avgTextBox.Name = "avgTextBox"
        Me.avgTextBox.Size = New System.Drawing.Size(116, 23)
        Me.avgTextBox.TabIndex = 9
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(26, 423)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 15)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Average purchase:"
        '
        'minTextBox
        '
        Me.minTextBox.Location = New System.Drawing.Point(214, 378)
        Me.minTextBox.Name = "minTextBox"
        Me.minTextBox.Size = New System.Drawing.Size(116, 23)
        Me.minTextBox.TabIndex = 7
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(210, 357)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(82, 15)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Min purchase:"
        '
        'maxTextBox
        '
        Me.maxTextBox.Location = New System.Drawing.Point(30, 378)
        Me.maxTextBox.Name = "maxTextBox"
        Me.maxTextBox.Size = New System.Drawing.Size(116, 23)
        Me.maxTextBox.TabIndex = 5
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(26, 357)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(83, 15)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Max purchase:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(25, 216)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(108, 15)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Product purchases:"
        '
        'psListBox
        '
        Me.psListBox.FormattingEnabled = True
        Me.psListBox.ItemHeight = 15
        Me.psListBox.Location = New System.Drawing.Point(27, 55)
        Me.psListBox.Name = "psListBox"
        Me.psListBox.Size = New System.Drawing.Size(381, 139)
        Me.psListBox.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(24, 37)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 15)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Product sources:"
        '
        'moveLButton
        '
        Me.moveLButton.Location = New System.Drawing.Point(327, 33)
        Me.moveLButton.Name = "moveLButton"
        Me.moveLButton.Size = New System.Drawing.Size(91, 47)
        Me.moveLButton.TabIndex = 15
        Me.moveLButton.Text = "Move Last"
        Me.moveLButton.UseVisualStyleBackColor = True
        '
        'moveFButton
        '
        Me.moveFButton.Location = New System.Drawing.Point(223, 33)
        Me.moveFButton.Name = "moveFButton"
        Me.moveFButton.Size = New System.Drawing.Size(91, 47)
        Me.moveFButton.TabIndex = 14
        Me.moveFButton.Text = "Move First"
        Me.moveFButton.UseVisualStyleBackColor = True
        '
        'movePButton
        '
        Me.movePButton.Location = New System.Drawing.Point(126, 33)
        Me.movePButton.Name = "movePButton"
        Me.movePButton.Size = New System.Drawing.Size(91, 47)
        Me.movePButton.TabIndex = 13
        Me.movePButton.Text = "Move Previous"
        Me.movePButton.UseVisualStyleBackColor = True
        '
        'moveNButton
        '
        Me.moveNButton.Location = New System.Drawing.Point(24, 33)
        Me.moveNButton.Name = "moveNButton"
        Me.moveNButton.Size = New System.Drawing.Size(91, 47)
        Me.moveNButton.TabIndex = 12
        Me.moveNButton.Text = "Move Next"
        Me.moveNButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuerryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1333, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuerryToolStripMenuItem
        '
        Me.QuerryToolStripMenuItem.Name = "QuerryToolStripMenuItem"
        Me.QuerryToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.QuerryToolStripMenuItem.Text = "Queries"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.moveNButton)
        Me.GroupBox4.Controls.Add(Me.movePButton)
        Me.GroupBox4.Controls.Add(Me.moveFButton)
        Me.GroupBox4.Controls.Add(Me.moveLButton)
        Me.GroupBox4.Location = New System.Drawing.Point(97, 569)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(483, 100)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'ppListView
        '
        Me.ppListView.Location = New System.Drawing.Point(27, 234)
        Me.ppListView.Name = "ppListView"
        Me.ppListView.Size = New System.Drawing.Size(381, 114)
        Me.ppListView.TabIndex = 21
        Me.ppListView.UseCompatibleStateImageBehavior = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 794)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ProductBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Form1"
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
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
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
    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents avgTextBox As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents minTextBox As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents maxTextBox As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents psListBox As ListBox
    Friend WithEvents Label27 As Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QuerryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ppListView As ListView
End Class
