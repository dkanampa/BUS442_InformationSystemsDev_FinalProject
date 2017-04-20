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
        Dim Product_IDLabel As System.Windows.Forms.Label
        Dim Vendor_IDLabel As System.Windows.Forms.Label
        Dim Active_StatusLabel As System.Windows.Forms.Label
        Dim Product_CostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim ClassificationLabel As System.Windows.Forms.Label
        Dim Product_Unit_PriceLabel As System.Windows.Forms.Label
        Dim Quantity_On_HandLabel As System.Windows.Forms.Label
        Dim Quantity_On_OrderLabel As System.Windows.Forms.Label
        Dim Product_Reorder_LevelLabel As System.Windows.Forms.Label
        Dim Product_Lead_TimeLabel As System.Windows.Forms.Label
        Dim Product_LineLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim YTD_PurchasesLabel As System.Windows.Forms.Label
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim Vendor_NameLabel As System.Windows.Forms.Label
        Dim Vendor_RegionLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim Zip_CodeLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Website_AddressLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim Contact_NameLabel As System.Windows.Forms.Label
        Me.ProductDatabaseDataSet = New Major_Project_3.ProductDatabaseDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New Major_Project_3.ProductDatabaseDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New Major_Project_3.ProductDatabaseDataSetTableAdapters.TableAdapterManager()
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
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Product_IDTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChinaQueriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Product_CostTextBox = New System.Windows.Forms.TextBox()
        Me.Active_StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.VendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vendor_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.VendorTableAdapter = New Major_Project_3.ProductDatabaseDataSetTableAdapters.VendorTableAdapter()
        Me.ClassificationComboBox = New System.Windows.Forms.ComboBox()
        Me.Product_Unit_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Quantity_On_HandTextBox = New System.Windows.Forms.TextBox()
        Me.Quantity_On_OrderTextBox = New System.Windows.Forms.TextBox()
        Me.Product_Reorder_LevelTextBox = New System.Windows.Forms.TextBox()
        Me.Product_Lead_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.Product_LineTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.YTD_PurchasesTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Product_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Vendor_NameLabel1 = New System.Windows.Forms.Label()
        Me.Vendor_RegionLabel1 = New System.Windows.Forms.Label()
        Me.CityLabel1 = New System.Windows.Forms.Label()
        Me.StateLabel1 = New System.Windows.Forms.Label()
        Me.Zip_CodeLabel1 = New System.Windows.Forms.Label()
        Me.CountryLabel1 = New System.Windows.Forms.Label()
        Me.Email_AddressLabel1 = New System.Windows.Forms.Label()
        Me.Phone_NumberLabel1 = New System.Windows.Forms.Label()
        Me.Website_AddressLabel1 = New System.Windows.Forms.Label()
        Me.NotesLabel1 = New System.Windows.Forms.Label()
        Me.Contact_NameLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.psListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ppListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.maxTextBox = New System.Windows.Forms.TextBox()
        Me.minTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.avgTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.moveNButton = New System.Windows.Forms.Button()
        Me.movePButton = New System.Windows.Forms.Button()
        Me.moveFButton = New System.Windows.Forms.Button()
        Me.moveLButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Product_IDLabel = New System.Windows.Forms.Label()
        Vendor_IDLabel = New System.Windows.Forms.Label()
        Active_StatusLabel = New System.Windows.Forms.Label()
        Product_CostLabel = New System.Windows.Forms.Label()
        ClassificationLabel = New System.Windows.Forms.Label()
        Product_Unit_PriceLabel = New System.Windows.Forms.Label()
        Quantity_On_HandLabel = New System.Windows.Forms.Label()
        Quantity_On_OrderLabel = New System.Windows.Forms.Label()
        Product_Reorder_LevelLabel = New System.Windows.Forms.Label()
        Product_Lead_TimeLabel = New System.Windows.Forms.Label()
        Product_LineLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        DiscountLabel = New System.Windows.Forms.Label()
        YTD_PurchasesLabel = New System.Windows.Forms.Label()
        Product_NameLabel = New System.Windows.Forms.Label()
        Vendor_NameLabel = New System.Windows.Forms.Label()
        Vendor_RegionLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        Zip_CodeLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Website_AddressLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        Contact_NameLabel = New System.Windows.Forms.Label()
        CType(Me.ProductDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Product_IDLabel
        '
        Product_IDLabel.AutoSize = True
        Product_IDLabel.Location = New System.Drawing.Point(19, 29)
        Product_IDLabel.Name = "Product_IDLabel"
        Product_IDLabel.Size = New System.Drawing.Size(66, 15)
        Product_IDLabel.TabIndex = 1
        Product_IDLabel.Text = "Product ID:"
        '
        'Vendor_IDLabel
        '
        Vendor_IDLabel.AutoSize = True
        Vendor_IDLabel.Location = New System.Drawing.Point(19, 58)
        Vendor_IDLabel.Name = "Vendor_IDLabel"
        Vendor_IDLabel.Size = New System.Drawing.Size(61, 15)
        Vendor_IDLabel.TabIndex = 2
        Vendor_IDLabel.Text = "Vendor ID:"
        '
        'Active_StatusLabel
        '
        Active_StatusLabel.AutoSize = True
        Active_StatusLabel.Location = New System.Drawing.Point(19, 86)
        Active_StatusLabel.Name = "Active_StatusLabel"
        Active_StatusLabel.Size = New System.Drawing.Size(78, 15)
        Active_StatusLabel.TabIndex = 4
        Active_StatusLabel.Text = "Active Status:"
        '
        'Product_CostLabel
        '
        Product_CostLabel.AutoSize = True
        Product_CostLabel.Location = New System.Drawing.Point(19, 115)
        Product_CostLabel.Name = "Product_CostLabel"
        Product_CostLabel.Size = New System.Drawing.Size(79, 15)
        Product_CostLabel.TabIndex = 6
        Product_CostLabel.Text = "Product Cost:"
        '
        'ProductDatabaseDataSet
        '
        Me.ProductDatabaseDataSet.DataSetName = "ProductDatabaseDataSet"
        Me.ProductDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.ProductDatabaseDataSet
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
        Me.TableAdapterManager.VendorTableAdapter = Nothing
        '
        'ProductBindingNavigator
        '
        Me.ProductBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductBindingNavigator.BindingSource = Me.ProductBindingSource
        Me.ProductBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductBindingNavigatorSaveItem, Me.ToolStripTextBox1, Me.ToolStripButton1, Me.ToolStripDropDownButton1})
        Me.ProductBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.ProductBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductBindingNavigator.Name = "ProductBindingNavigator"
        Me.ProductBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(1148, 25)
        Me.ProductBindingNavigator.TabIndex = 0
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
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'Product_IDTextBox
        '
        Me.Product_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_ID", True))
        Me.Product_IDTextBox.Location = New System.Drawing.Point(162, 25)
        Me.Product_IDTextBox.Name = "Product_IDTextBox"
        Me.Product_IDTextBox.Size = New System.Drawing.Size(140, 23)
        Me.Product_IDTextBox.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1148, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChinaQueriesToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ToolStripMenuItem1.Text = "Queries"
        '
        'ChinaQueriesToolStripMenuItem
        '
        Me.ChinaQueriesToolStripMenuItem.Name = "ChinaQueriesToolStripMenuItem"
        Me.ChinaQueriesToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ChinaQueriesToolStripMenuItem.Text = "China Queries"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(YTD_PurchasesLabel)
        Me.GroupBox1.Controls.Add(Me.YTD_PurchasesTextBox)
        Me.GroupBox1.Controls.Add(DiscountLabel)
        Me.GroupBox1.Controls.Add(Me.DiscountTextBox)
        Me.GroupBox1.Controls.Add(BrandLabel)
        Me.GroupBox1.Controls.Add(Me.BrandTextBox)
        Me.GroupBox1.Controls.Add(Product_LineLabel)
        Me.GroupBox1.Controls.Add(Me.Product_LineTextBox)
        Me.GroupBox1.Controls.Add(Product_Lead_TimeLabel)
        Me.GroupBox1.Controls.Add(Me.Product_Lead_TimeTextBox)
        Me.GroupBox1.Controls.Add(Product_Reorder_LevelLabel)
        Me.GroupBox1.Controls.Add(Me.Product_Reorder_LevelTextBox)
        Me.GroupBox1.Controls.Add(Quantity_On_OrderLabel)
        Me.GroupBox1.Controls.Add(Me.Quantity_On_OrderTextBox)
        Me.GroupBox1.Controls.Add(Quantity_On_HandLabel)
        Me.GroupBox1.Controls.Add(Me.Quantity_On_HandTextBox)
        Me.GroupBox1.Controls.Add(Product_Unit_PriceLabel)
        Me.GroupBox1.Controls.Add(Me.Product_Unit_PriceTextBox)
        Me.GroupBox1.Controls.Add(ClassificationLabel)
        Me.GroupBox1.Controls.Add(Me.ClassificationComboBox)
        Me.GroupBox1.Controls.Add(Product_CostLabel)
        Me.GroupBox1.Controls.Add(Me.Product_CostTextBox)
        Me.GroupBox1.Controls.Add(Active_StatusLabel)
        Me.GroupBox1.Controls.Add(Me.Active_StatusComboBox)
        Me.GroupBox1.Controls.Add(Vendor_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Vendor_IDComboBox)
        Me.GroupBox1.Controls.Add(Product_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Product_IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 454)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Product_CostTextBox
        '
        Me.Product_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Cost", True))
        Me.Product_CostTextBox.Location = New System.Drawing.Point(162, 112)
        Me.Product_CostTextBox.Name = "Product_CostTextBox"
        Me.Product_CostTextBox.Size = New System.Drawing.Size(140, 23)
        Me.Product_CostTextBox.TabIndex = 7
        '
        'Active_StatusComboBox
        '
        Me.Active_StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Active_Status", True))
        Me.Active_StatusComboBox.FormattingEnabled = True
        Me.Active_StatusComboBox.Location = New System.Drawing.Point(162, 83)
        Me.Active_StatusComboBox.Name = "Active_StatusComboBox"
        Me.Active_StatusComboBox.Size = New System.Drawing.Size(140, 23)
        Me.Active_StatusComboBox.TabIndex = 5
        '
        'VendorBindingSource
        '
        Me.VendorBindingSource.DataMember = "Vendor"
        Me.VendorBindingSource.DataSource = Me.ProductDatabaseDataSet
        '
        'Vendor_IDComboBox
        '
        Me.Vendor_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Vendor_ID", True))
        Me.Vendor_IDComboBox.FormattingEnabled = True
        Me.Vendor_IDComboBox.Location = New System.Drawing.Point(162, 54)
        Me.Vendor_IDComboBox.Name = "Vendor_IDComboBox"
        Me.Vendor_IDComboBox.Size = New System.Drawing.Size(140, 23)
        Me.Vendor_IDComboBox.TabIndex = 3
        '
        'VendorTableAdapter
        '
        Me.VendorTableAdapter.ClearBeforeFill = True
        '
        'ClassificationLabel
        '
        ClassificationLabel.AutoSize = True
        ClassificationLabel.Location = New System.Drawing.Point(19, 144)
        ClassificationLabel.Name = "ClassificationLabel"
        ClassificationLabel.Size = New System.Drawing.Size(80, 15)
        ClassificationLabel.TabIndex = 8
        ClassificationLabel.Text = "Classification:"
        '
        'ClassificationComboBox
        '
        Me.ClassificationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Classification", True))
        Me.ClassificationComboBox.FormattingEnabled = True
        Me.ClassificationComboBox.Location = New System.Drawing.Point(162, 141)
        Me.ClassificationComboBox.Name = "ClassificationComboBox"
        Me.ClassificationComboBox.Size = New System.Drawing.Size(140, 23)
        Me.ClassificationComboBox.TabIndex = 9
        '
        'Product_Unit_PriceLabel
        '
        Product_Unit_PriceLabel.AutoSize = True
        Product_Unit_PriceLabel.Location = New System.Drawing.Point(19, 173)
        Product_Unit_PriceLabel.Name = "Product_Unit_PriceLabel"
        Product_Unit_PriceLabel.Size = New System.Drawing.Size(106, 15)
        Product_Unit_PriceLabel.TabIndex = 10
        Product_Unit_PriceLabel.Text = "Product Unit Price:"
        '
        'Product_Unit_PriceTextBox
        '
        Me.Product_Unit_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Unit_Price", True))
        Me.Product_Unit_PriceTextBox.Location = New System.Drawing.Point(162, 170)
        Me.Product_Unit_PriceTextBox.Name = "Product_Unit_PriceTextBox"
        Me.Product_Unit_PriceTextBox.Size = New System.Drawing.Size(116, 23)
        Me.Product_Unit_PriceTextBox.TabIndex = 11
        '
        'Quantity_On_HandLabel
        '
        Quantity_On_HandLabel.AutoSize = True
        Quantity_On_HandLabel.Location = New System.Drawing.Point(19, 202)
        Quantity_On_HandLabel.Name = "Quantity_On_HandLabel"
        Quantity_On_HandLabel.Size = New System.Drawing.Size(107, 15)
        Quantity_On_HandLabel.TabIndex = 12
        Quantity_On_HandLabel.Text = "Quantity On Hand:"
        '
        'Quantity_On_HandTextBox
        '
        Me.Quantity_On_HandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Quantity_On_Hand", True))
        Me.Quantity_On_HandTextBox.Location = New System.Drawing.Point(162, 199)
        Me.Quantity_On_HandTextBox.Name = "Quantity_On_HandTextBox"
        Me.Quantity_On_HandTextBox.Size = New System.Drawing.Size(116, 23)
        Me.Quantity_On_HandTextBox.TabIndex = 13
        '
        'Quantity_On_OrderLabel
        '
        Quantity_On_OrderLabel.AutoSize = True
        Quantity_On_OrderLabel.Location = New System.Drawing.Point(19, 231)
        Quantity_On_OrderLabel.Name = "Quantity_On_OrderLabel"
        Quantity_On_OrderLabel.Size = New System.Drawing.Size(108, 15)
        Quantity_On_OrderLabel.TabIndex = 14
        Quantity_On_OrderLabel.Text = "Quantity On Order:"
        '
        'Quantity_On_OrderTextBox
        '
        Me.Quantity_On_OrderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Quantity_On_Order", True))
        Me.Quantity_On_OrderTextBox.Location = New System.Drawing.Point(162, 228)
        Me.Quantity_On_OrderTextBox.Name = "Quantity_On_OrderTextBox"
        Me.Quantity_On_OrderTextBox.Size = New System.Drawing.Size(116, 23)
        Me.Quantity_On_OrderTextBox.TabIndex = 15
        '
        'Product_Reorder_LevelLabel
        '
        Product_Reorder_LevelLabel.AutoSize = True
        Product_Reorder_LevelLabel.Location = New System.Drawing.Point(19, 260)
        Product_Reorder_LevelLabel.Name = "Product_Reorder_LevelLabel"
        Product_Reorder_LevelLabel.Size = New System.Drawing.Size(126, 15)
        Product_Reorder_LevelLabel.TabIndex = 16
        Product_Reorder_LevelLabel.Text = "Product Reorder Level:"
        '
        'Product_Reorder_LevelTextBox
        '
        Me.Product_Reorder_LevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Reorder_Level", True))
        Me.Product_Reorder_LevelTextBox.Location = New System.Drawing.Point(162, 257)
        Me.Product_Reorder_LevelTextBox.Name = "Product_Reorder_LevelTextBox"
        Me.Product_Reorder_LevelTextBox.Size = New System.Drawing.Size(116, 23)
        Me.Product_Reorder_LevelTextBox.TabIndex = 17
        '
        'Product_Lead_TimeLabel
        '
        Product_Lead_TimeLabel.AutoSize = True
        Product_Lead_TimeLabel.Location = New System.Drawing.Point(19, 289)
        Product_Lead_TimeLabel.Name = "Product_Lead_TimeLabel"
        Product_Lead_TimeLabel.Size = New System.Drawing.Size(110, 15)
        Product_Lead_TimeLabel.TabIndex = 18
        Product_Lead_TimeLabel.Text = "Product Lead Time:"
        '
        'Product_Lead_TimeTextBox
        '
        Me.Product_Lead_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Lead_Time", True))
        Me.Product_Lead_TimeTextBox.Location = New System.Drawing.Point(162, 286)
        Me.Product_Lead_TimeTextBox.Name = "Product_Lead_TimeTextBox"
        Me.Product_Lead_TimeTextBox.Size = New System.Drawing.Size(116, 23)
        Me.Product_Lead_TimeTextBox.TabIndex = 19
        '
        'Product_LineLabel
        '
        Product_LineLabel.AutoSize = True
        Product_LineLabel.Location = New System.Drawing.Point(19, 318)
        Product_LineLabel.Name = "Product_LineLabel"
        Product_LineLabel.Size = New System.Drawing.Size(77, 15)
        Product_LineLabel.TabIndex = 20
        Product_LineLabel.Text = "Product Line:"
        '
        'Product_LineTextBox
        '
        Me.Product_LineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Line", True))
        Me.Product_LineTextBox.Location = New System.Drawing.Point(162, 315)
        Me.Product_LineTextBox.Name = "Product_LineTextBox"
        Me.Product_LineTextBox.Size = New System.Drawing.Size(116, 23)
        Me.Product_LineTextBox.TabIndex = 21
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(19, 347)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(41, 15)
        BrandLabel.TabIndex = 22
        BrandLabel.Text = "Brand:"
        '
        'BrandTextBox
        '
        Me.BrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Brand", True))
        Me.BrandTextBox.Location = New System.Drawing.Point(162, 344)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(100, 23)
        Me.BrandTextBox.TabIndex = 23
        '
        'DiscountLabel
        '
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(19, 376)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(57, 15)
        DiscountLabel.TabIndex = 24
        DiscountLabel.Text = "Discount:"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Discount", True))
        Me.DiscountTextBox.Location = New System.Drawing.Point(162, 373)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(100, 23)
        Me.DiscountTextBox.TabIndex = 25
        '
        'YTD_PurchasesLabel
        '
        YTD_PurchasesLabel.AutoSize = True
        YTD_PurchasesLabel.Location = New System.Drawing.Point(19, 405)
        YTD_PurchasesLabel.Name = "YTD_PurchasesLabel"
        YTD_PurchasesLabel.Size = New System.Drawing.Size(88, 15)
        YTD_PurchasesLabel.TabIndex = 26
        YTD_PurchasesLabel.Text = "YTD Purchases:"
        '
        'YTD_PurchasesTextBox
        '
        Me.YTD_PurchasesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "YTD_Purchases", True))
        Me.YTD_PurchasesTextBox.Location = New System.Drawing.Point(162, 402)
        Me.YTD_PurchasesTextBox.Name = "YTD_PurchasesTextBox"
        Me.YTD_PurchasesTextBox.Size = New System.Drawing.Size(100, 23)
        Me.YTD_PurchasesTextBox.TabIndex = 27
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Contact_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Contact_NameLabel1)
        Me.GroupBox2.Controls.Add(NotesLabel)
        Me.GroupBox2.Controls.Add(Me.NotesLabel1)
        Me.GroupBox2.Controls.Add(Website_AddressLabel)
        Me.GroupBox2.Controls.Add(Me.Website_AddressLabel1)
        Me.GroupBox2.Controls.Add(Phone_NumberLabel)
        Me.GroupBox2.Controls.Add(Me.Phone_NumberLabel1)
        Me.GroupBox2.Controls.Add(Email_AddressLabel)
        Me.GroupBox2.Controls.Add(Me.Email_AddressLabel1)
        Me.GroupBox2.Controls.Add(CountryLabel)
        Me.GroupBox2.Controls.Add(Me.CountryLabel1)
        Me.GroupBox2.Controls.Add(Zip_CodeLabel)
        Me.GroupBox2.Controls.Add(Me.Zip_CodeLabel1)
        Me.GroupBox2.Controls.Add(StateLabel)
        Me.GroupBox2.Controls.Add(Me.StateLabel1)
        Me.GroupBox2.Controls.Add(CityLabel)
        Me.GroupBox2.Controls.Add(Me.CityLabel1)
        Me.GroupBox2.Controls.Add(Vendor_RegionLabel)
        Me.GroupBox2.Controls.Add(Me.Vendor_RegionLabel1)
        Me.GroupBox2.Controls.Add(Vendor_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Vendor_NameLabel1)
        Me.GroupBox2.Controls.Add(Product_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Product_NameTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(356, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 469)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Location = New System.Drawing.Point(15, 28)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(87, 15)
        Product_NameLabel.TabIndex = 0
        Product_NameLabel.Text = "Product Name:"
        '
        'Product_NameTextBox
        '
        Me.Product_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Product_Name", True))
        Me.Product_NameTextBox.Location = New System.Drawing.Point(130, 25)
        Me.Product_NameTextBox.Name = "Product_NameTextBox"
        Me.Product_NameTextBox.Size = New System.Drawing.Size(188, 23)
        Me.Product_NameTextBox.TabIndex = 1
        '
        'Vendor_NameLabel
        '
        Vendor_NameLabel.AutoSize = True
        Vendor_NameLabel.Location = New System.Drawing.Point(15, 68)
        Vendor_NameLabel.Name = "Vendor_NameLabel"
        Vendor_NameLabel.Size = New System.Drawing.Size(82, 15)
        Vendor_NameLabel.TabIndex = 2
        Vendor_NameLabel.Text = "Vendor Name:"
        '
        'Vendor_NameLabel1
        '
        Me.Vendor_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Vendor_Name", True))
        Me.Vendor_NameLabel1.Location = New System.Drawing.Point(130, 68)
        Me.Vendor_NameLabel1.Name = "Vendor_NameLabel1"
        Me.Vendor_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Vendor_NameLabel1.TabIndex = 3
        Me.Vendor_NameLabel1.Text = "Label1"
        '
        'Vendor_RegionLabel
        '
        Vendor_RegionLabel.AutoSize = True
        Vendor_RegionLabel.Location = New System.Drawing.Point(15, 91)
        Vendor_RegionLabel.Name = "Vendor_RegionLabel"
        Vendor_RegionLabel.Size = New System.Drawing.Size(87, 15)
        Vendor_RegionLabel.TabIndex = 4
        Vendor_RegionLabel.Text = "Vendor Region:"
        '
        'Vendor_RegionLabel1
        '
        Me.Vendor_RegionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Vendor_Region", True))
        Me.Vendor_RegionLabel1.Location = New System.Drawing.Point(130, 91)
        Me.Vendor_RegionLabel1.Name = "Vendor_RegionLabel1"
        Me.Vendor_RegionLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Vendor_RegionLabel1.TabIndex = 5
        Me.Vendor_RegionLabel1.Text = "Label1"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(15, 165)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(31, 15)
        CityLabel.TabIndex = 6
        CityLabel.Text = "City:"
        '
        'CityLabel1
        '
        Me.CityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "City", True))
        Me.CityLabel1.Location = New System.Drawing.Point(130, 165)
        Me.CityLabel1.Name = "CityLabel1"
        Me.CityLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CityLabel1.TabIndex = 7
        Me.CityLabel1.Text = "Label1"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(15, 188)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(36, 15)
        StateLabel.TabIndex = 8
        StateLabel.Text = "State:"
        '
        'StateLabel1
        '
        Me.StateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "State", True))
        Me.StateLabel1.Location = New System.Drawing.Point(130, 188)
        Me.StateLabel1.Name = "StateLabel1"
        Me.StateLabel1.Size = New System.Drawing.Size(100, 23)
        Me.StateLabel1.TabIndex = 9
        Me.StateLabel1.Text = "Label1"
        '
        'Zip_CodeLabel
        '
        Zip_CodeLabel.AutoSize = True
        Zip_CodeLabel.Location = New System.Drawing.Point(15, 211)
        Zip_CodeLabel.Name = "Zip_CodeLabel"
        Zip_CodeLabel.Size = New System.Drawing.Size(58, 15)
        Zip_CodeLabel.TabIndex = 10
        Zip_CodeLabel.Text = "Zip Code:"
        '
        'Zip_CodeLabel1
        '
        Me.Zip_CodeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Zip_Code", True))
        Me.Zip_CodeLabel1.Location = New System.Drawing.Point(130, 211)
        Me.Zip_CodeLabel1.Name = "Zip_CodeLabel1"
        Me.Zip_CodeLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Zip_CodeLabel1.TabIndex = 11
        Me.Zip_CodeLabel1.Text = "Label1"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(15, 234)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(53, 15)
        CountryLabel.TabIndex = 12
        CountryLabel.Text = "Country:"
        '
        'CountryLabel1
        '
        Me.CountryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Country", True))
        Me.CountryLabel1.Location = New System.Drawing.Point(130, 234)
        Me.CountryLabel1.Name = "CountryLabel1"
        Me.CountryLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CountryLabel1.TabIndex = 13
        Me.CountryLabel1.Text = "Label1"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Location = New System.Drawing.Point(15, 257)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(84, 15)
        Email_AddressLabel.TabIndex = 14
        Email_AddressLabel.Text = "Email Address:"
        '
        'Email_AddressLabel1
        '
        Me.Email_AddressLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Email_Address", True))
        Me.Email_AddressLabel1.Location = New System.Drawing.Point(130, 257)
        Me.Email_AddressLabel1.Name = "Email_AddressLabel1"
        Me.Email_AddressLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Email_AddressLabel1.TabIndex = 15
        Me.Email_AddressLabel1.Text = "Label1"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(15, 280)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(91, 15)
        Phone_NumberLabel.TabIndex = 16
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Phone_NumberLabel1
        '
        Me.Phone_NumberLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Phone_Number", True))
        Me.Phone_NumberLabel1.Location = New System.Drawing.Point(130, 280)
        Me.Phone_NumberLabel1.Name = "Phone_NumberLabel1"
        Me.Phone_NumberLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Phone_NumberLabel1.TabIndex = 17
        Me.Phone_NumberLabel1.Text = "Label1"
        '
        'Website_AddressLabel
        '
        Website_AddressLabel.AutoSize = True
        Website_AddressLabel.Location = New System.Drawing.Point(15, 303)
        Website_AddressLabel.Name = "Website_AddressLabel"
        Website_AddressLabel.Size = New System.Drawing.Size(97, 15)
        Website_AddressLabel.TabIndex = 18
        Website_AddressLabel.Text = "Website Address:"
        '
        'Website_AddressLabel1
        '
        Me.Website_AddressLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Website_Address", True))
        Me.Website_AddressLabel1.Location = New System.Drawing.Point(130, 303)
        Me.Website_AddressLabel1.Name = "Website_AddressLabel1"
        Me.Website_AddressLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Website_AddressLabel1.TabIndex = 19
        Me.Website_AddressLabel1.Text = "Label1"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(15, 326)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(41, 15)
        NotesLabel.TabIndex = 20
        NotesLabel.Text = "Notes:"
        '
        'NotesLabel1
        '
        Me.NotesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Notes", True))
        Me.NotesLabel1.Location = New System.Drawing.Point(130, 326)
        Me.NotesLabel1.Name = "NotesLabel1"
        Me.NotesLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NotesLabel1.TabIndex = 21
        Me.NotesLabel1.Text = "Label1"
        '
        'Contact_NameLabel
        '
        Contact_NameLabel.AutoSize = True
        Contact_NameLabel.Location = New System.Drawing.Point(15, 349)
        Contact_NameLabel.Name = "Contact_NameLabel"
        Contact_NameLabel.Size = New System.Drawing.Size(87, 15)
        Contact_NameLabel.TabIndex = 22
        Contact_NameLabel.Text = "Contact Name:"
        '
        'Contact_NameLabel1
        '
        Me.Contact_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorBindingSource, "Contact_Name", True))
        Me.Contact_NameLabel1.Location = New System.Drawing.Point(130, 349)
        Me.Contact_NameLabel1.Name = "Contact_NameLabel1"
        Me.Contact_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Contact_NameLabel1.TabIndex = 23
        Me.Contact_NameLabel1.Text = "Label1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.exitButton)
        Me.GroupBox3.Controls.Add(Me.searchButton)
        Me.GroupBox3.Controls.Add(Me.refreshButton)
        Me.GroupBox3.Controls.Add(Me.calculateButton)
        Me.GroupBox3.Controls.Add(Me.moveLButton)
        Me.GroupBox3.Controls.Add(Me.moveFButton)
        Me.GroupBox3.Controls.Add(Me.movePButton)
        Me.GroupBox3.Controls.Add(Me.moveNButton)
        Me.GroupBox3.Controls.Add(Me.totalTextBox)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.avgTextBox)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.minTextBox)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.maxTextBox)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ppListBox)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.psListBox)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(714, 60)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(379, 587)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product sources:"
        '
        'psListBox
        '
        Me.psListBox.FormattingEnabled = True
        Me.psListBox.ItemHeight = 15
        Me.psListBox.Location = New System.Drawing.Point(28, 54)
        Me.psListBox.Name = "psListBox"
        Me.psListBox.Size = New System.Drawing.Size(327, 124)
        Me.psListBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product purchases:"
        '
        'ppListBox
        '
        Me.ppListBox.FormattingEnabled = True
        Me.ppListBox.ItemHeight = 15
        Me.ppListBox.Location = New System.Drawing.Point(31, 224)
        Me.ppListBox.Name = "ppListBox"
        Me.ppListBox.Size = New System.Drawing.Size(324, 94)
        Me.ppListBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Max purchase:"
        '
        'maxTextBox
        '
        Me.maxTextBox.Location = New System.Drawing.Point(34, 362)
        Me.maxTextBox.Name = "maxTextBox"
        Me.maxTextBox.Size = New System.Drawing.Size(100, 23)
        Me.maxTextBox.TabIndex = 5
        '
        'minTextBox
        '
        Me.minTextBox.Location = New System.Drawing.Point(192, 362)
        Me.minTextBox.Name = "minTextBox"
        Me.minTextBox.Size = New System.Drawing.Size(100, 23)
        Me.minTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Min purchase:"
        '
        'avgTextBox
        '
        Me.avgTextBox.Location = New System.Drawing.Point(34, 419)
        Me.avgTextBox.Name = "avgTextBox"
        Me.avgTextBox.Size = New System.Drawing.Size(100, 23)
        Me.avgTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 401)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Average purchase:"
        '
        'totalTextBox
        '
        Me.totalTextBox.Location = New System.Drawing.Point(192, 420)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.Size = New System.Drawing.Size(100, 23)
        Me.totalTextBox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total purchase:"
        '
        'moveNButton
        '
        Me.moveNButton.Location = New System.Drawing.Point(25, 469)
        Me.moveNButton.Name = "moveNButton"
        Me.moveNButton.Size = New System.Drawing.Size(78, 41)
        Me.moveNButton.TabIndex = 12
        Me.moveNButton.Text = "Move Next"
        Me.moveNButton.UseVisualStyleBackColor = True
        '
        'movePButton
        '
        Me.movePButton.Location = New System.Drawing.Point(109, 469)
        Me.movePButton.Name = "movePButton"
        Me.movePButton.Size = New System.Drawing.Size(78, 41)
        Me.movePButton.TabIndex = 13
        Me.movePButton.Text = "Move Previous"
        Me.movePButton.UseVisualStyleBackColor = True
        '
        'moveFButton
        '
        Me.moveFButton.Location = New System.Drawing.Point(193, 469)
        Me.moveFButton.Name = "moveFButton"
        Me.moveFButton.Size = New System.Drawing.Size(78, 41)
        Me.moveFButton.TabIndex = 14
        Me.moveFButton.Text = "Move First"
        Me.moveFButton.UseVisualStyleBackColor = True
        '
        'moveLButton
        '
        Me.moveLButton.Location = New System.Drawing.Point(277, 469)
        Me.moveLButton.Name = "moveLButton"
        Me.moveLButton.Size = New System.Drawing.Size(78, 41)
        Me.moveLButton.TabIndex = 15
        Me.moveLButton.Text = "Move Last"
        Me.moveLButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(25, 516)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(78, 41)
        Me.calculateButton.TabIndex = 16
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(109, 516)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(78, 41)
        Me.refreshButton.TabIndex = 17
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(193, 516)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(78, 41)
        Me.searchButton.TabIndex = 18
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(277, 516)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(78, 41)
        Me.exitButton.TabIndex = 19
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 672)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProductBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Form1"
        CType(Me.ProductDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents Product_IDTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ChinaQueriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Vendor_IDComboBox As ComboBox
    Friend WithEvents VendorBindingSource As BindingSource
    Friend WithEvents VendorTableAdapter As ProductDatabaseDataSetTableAdapters.VendorTableAdapter
    Friend WithEvents Product_CostTextBox As TextBox
    Friend WithEvents Active_StatusComboBox As ComboBox
    Friend WithEvents YTD_PurchasesTextBox As TextBox
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents BrandTextBox As TextBox
    Friend WithEvents Product_LineTextBox As TextBox
    Friend WithEvents Product_Lead_TimeTextBox As TextBox
    Friend WithEvents Product_Reorder_LevelTextBox As TextBox
    Friend WithEvents Quantity_On_OrderTextBox As TextBox
    Friend WithEvents Quantity_On_HandTextBox As TextBox
    Friend WithEvents Product_Unit_PriceTextBox As TextBox
    Friend WithEvents ClassificationComboBox As ComboBox
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Website_AddressLabel1 As Label
    Friend WithEvents Phone_NumberLabel1 As Label
    Friend WithEvents Email_AddressLabel1 As Label
    Friend WithEvents CountryLabel1 As Label
    Friend WithEvents Zip_CodeLabel1 As Label
    Friend WithEvents StateLabel1 As Label
    Friend WithEvents CityLabel1 As Label
    Friend WithEvents Vendor_RegionLabel1 As Label
    Friend WithEvents Vendor_NameLabel1 As Label
    Friend WithEvents Product_NameTextBox As TextBox
    Friend WithEvents Contact_NameLabel1 As Label
    Friend WithEvents NotesLabel1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents avgTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents minTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents maxTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ppListBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents psListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents searchButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents calculateButton As Button
    Friend WithEvents moveLButton As Button
    Friend WithEvents moveFButton As Button
    Friend WithEvents movePButton As Button
    Friend WithEvents moveNButton As Button
End Class
