<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorder_A173616
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_makeorder = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_orderid2 = New System.Windows.Forms.Label()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.cbb_staffid = New System.Windows.Forms.ComboBox()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_cusid2 = New System.Windows.Forms.Label()
        Me.btn_neworder = New System.Windows.Forms.Button()
        Me.txt_cusdate = New System.Windows.Forms.TextBox()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.lbl_cusdate = New System.Windows.Forms.Label()
        Me.lbl_cusname = New System.Windows.Forms.Label()
        Me.lbl_cusid = New System.Windows.Forms.Label()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.pic_id = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_proid2 = New System.Windows.Forms.Label()
        Me.lbl_subtotal2 = New System.Windows.Forms.Label()
        Me.btn_addtocart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.nud_quantity = New System.Windows.Forms.NumericUpDown()
        Me.txt_probrand = New System.Windows.Forms.TextBox()
        Me.txt_prowarr = New System.Windows.Forms.TextBox()
        Me.txt_prostock = New System.Windows.Forms.TextBox()
        Me.txt_procate = New System.Windows.Forms.TextBox()
        Me.txt_proprice = New System.Windows.Forms.TextBox()
        Me.txt_proname = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_warranty = New System.Windows.Forms.Label()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_category = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_proname = New System.Windows.Forms.Label()
        Me.lbl_proid = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grd_orderdetails = New System.Windows.Forms.DataGridView()
        Me.FLD_PRODUCT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_QUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.LBL_TOTAL = New System.Windows.Forms.Label()
        Me.lbl_rm2 = New System.Windows.Forms.Label()
        Me.lbl_total2 = New System.Windows.Forms.Label()
        Me.btn_vieworder = New System.Windows.Forms.Button()
        Me.grp_totalcust = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_productid = New System.Windows.Forms.ComboBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_id, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_totalcust.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Stencil", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(26, 43)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(99, 34)
        Me.btn_back.TabIndex = 0
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Stencil", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_title.Location = New System.Drawing.Point(518, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(460, 57)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "GYM FITNESS HOPE"
        '
        'lbl_makeorder
        '
        Me.lbl_makeorder.AutoSize = True
        Me.lbl_makeorder.BackColor = System.Drawing.Color.Transparent
        Me.lbl_makeorder.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_makeorder.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_makeorder.Location = New System.Drawing.Point(635, 66)
        Me.lbl_makeorder.Name = "lbl_makeorder"
        Me.lbl_makeorder.Size = New System.Drawing.Size(189, 31)
        Me.lbl_makeorder.TabIndex = 2
        Me.lbl_makeorder.Text = "MAKE ORDER"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.lbl_orderid2)
        Me.GroupBox1.Controls.Add(Me.lbl_orderid)
        Me.GroupBox1.Controls.Add(Me.cbb_staffid)
        Me.GroupBox1.Controls.Add(Me.lbl_staffid)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Informations"
        '
        'lbl_orderid2
        '
        Me.lbl_orderid2.AutoSize = True
        Me.lbl_orderid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid2.Location = New System.Drawing.Point(299, 39)
        Me.lbl_orderid2.Name = "lbl_orderid2"
        Me.lbl_orderid2.Size = New System.Drawing.Size(21, 15)
        Me.lbl_orderid2.TabIndex = 6
        Me.lbl_orderid2.Text = "ID"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Location = New System.Drawing.Point(219, 39)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(74, 15)
        Me.lbl_orderid.TabIndex = 5
        Me.lbl_orderid.Text = "ORDER ID"
        '
        'cbb_staffid
        '
        Me.cbb_staffid.FormattingEnabled = True
        Me.cbb_staffid.Location = New System.Drawing.Point(103, 38)
        Me.cbb_staffid.Name = "cbb_staffid"
        Me.cbb_staffid.Size = New System.Drawing.Size(71, 21)
        Me.cbb_staffid.TabIndex = 4
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.Location = New System.Drawing.Point(22, 39)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(66, 15)
        Me.lbl_staffid.TabIndex = 0
        Me.lbl_staffid.Text = "STAFF ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Controls.Add(Me.lbl_cusid2)
        Me.GroupBox2.Controls.Add(Me.btn_neworder)
        Me.GroupBox2.Controls.Add(Me.txt_cusdate)
        Me.GroupBox2.Controls.Add(Me.txt_cusname)
        Me.GroupBox2.Controls.Add(Me.lbl_cusdate)
        Me.GroupBox2.Controls.Add(Me.lbl_cusname)
        Me.GroupBox2.Controls.Add(Me.lbl_cusid)
        Me.GroupBox2.Controls.Add(Me.grd_customer)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(485, 266)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Informations"
        '
        'lbl_cusid2
        '
        Me.lbl_cusid2.AutoSize = True
        Me.lbl_cusid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cusid2.Location = New System.Drawing.Point(128, 160)
        Me.lbl_cusid2.Name = "lbl_cusid2"
        Me.lbl_cusid2.Size = New System.Drawing.Size(21, 15)
        Me.lbl_cusid2.TabIndex = 7
        Me.lbl_cusid2.Text = "ID"
        '
        'btn_neworder
        '
        Me.btn_neworder.BackColor = System.Drawing.Color.LightSalmon
        Me.btn_neworder.Font = New System.Drawing.Font("Stencil", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_neworder.Location = New System.Drawing.Point(302, 187)
        Me.btn_neworder.Name = "btn_neworder"
        Me.btn_neworder.Size = New System.Drawing.Size(98, 40)
        Me.btn_neworder.TabIndex = 6
        Me.btn_neworder.Text = "NEW ORDER"
        Me.btn_neworder.UseVisualStyleBackColor = False
        '
        'txt_cusdate
        '
        Me.txt_cusdate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txt_cusdate.Location = New System.Drawing.Point(131, 212)
        Me.txt_cusdate.Name = "txt_cusdate"
        Me.txt_cusdate.ReadOnly = True
        Me.txt_cusdate.Size = New System.Drawing.Size(124, 20)
        Me.txt_cusdate.TabIndex = 5
        '
        'txt_cusname
        '
        Me.txt_cusname.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txt_cusname.Location = New System.Drawing.Point(131, 182)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.ReadOnly = True
        Me.txt_cusname.Size = New System.Drawing.Size(124, 20)
        Me.txt_cusname.TabIndex = 4
        '
        'lbl_cusdate
        '
        Me.lbl_cusdate.AutoSize = True
        Me.lbl_cusdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cusdate.Location = New System.Drawing.Point(22, 212)
        Me.lbl_cusdate.Name = "lbl_cusdate"
        Me.lbl_cusdate.Size = New System.Drawing.Size(95, 15)
        Me.lbl_cusdate.TabIndex = 3
        Me.lbl_cusdate.Text = "ORDER DATE"
        '
        'lbl_cusname
        '
        Me.lbl_cusname.AutoSize = True
        Me.lbl_cusname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cusname.Location = New System.Drawing.Point(22, 187)
        Me.lbl_cusname.Name = "lbl_cusname"
        Me.lbl_cusname.Size = New System.Drawing.Size(46, 15)
        Me.lbl_cusname.TabIndex = 2
        Me.lbl_cusname.Text = "NAME"
        '
        'lbl_cusid
        '
        Me.lbl_cusid.AutoSize = True
        Me.lbl_cusid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cusid.Location = New System.Drawing.Point(22, 160)
        Me.lbl_cusid.Name = "lbl_cusid"
        Me.lbl_cusid.Size = New System.Drawing.Size(21, 15)
        Me.lbl_cusid.TabIndex = 1
        Me.lbl_cusid.Text = "ID"
        '
        'grd_customer
        '
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(15, 19)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.Size = New System.Drawing.Size(464, 127)
        Me.grd_customer.TabIndex = 0
        '
        'pic_id
        '
        Me.pic_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_id.Location = New System.Drawing.Point(632, 133)
        Me.pic_id.Name = "pic_id"
        Me.pic_id.Size = New System.Drawing.Size(215, 166)
        Me.pic_id.TabIndex = 5
        Me.pic_id.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox3.Controls.Add(Me.lbl_proid2)
        Me.GroupBox3.Controls.Add(Me.lbl_subtotal2)
        Me.GroupBox3.Controls.Add(Me.btn_addtocart)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lbl_subtotal)
        Me.GroupBox3.Controls.Add(Me.nud_quantity)
        Me.GroupBox3.Controls.Add(Me.txt_probrand)
        Me.GroupBox3.Controls.Add(Me.txt_prowarr)
        Me.GroupBox3.Controls.Add(Me.txt_prostock)
        Me.GroupBox3.Controls.Add(Me.txt_procate)
        Me.GroupBox3.Controls.Add(Me.txt_proprice)
        Me.GroupBox3.Controls.Add(Me.txt_proname)
        Me.GroupBox3.Controls.Add(Me.lbl_quantity)
        Me.GroupBox3.Controls.Add(Me.lbl_warranty)
        Me.GroupBox3.Controls.Add(Me.lbl_stock)
        Me.GroupBox3.Controls.Add(Me.lbl_brand)
        Me.GroupBox3.Controls.Add(Me.lbl_category)
        Me.GroupBox3.Controls.Add(Me.lbl_price)
        Me.GroupBox3.Controls.Add(Me.lbl_proname)
        Me.GroupBox3.Controls.Add(Me.lbl_proid)
        Me.GroupBox3.Location = New System.Drawing.Point(555, 377)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(379, 381)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Choose item(s)"
        '
        'lbl_proid2
        '
        Me.lbl_proid2.AutoSize = True
        Me.lbl_proid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proid2.Location = New System.Drawing.Point(134, 28)
        Me.lbl_proid2.Name = "lbl_proid2"
        Me.lbl_proid2.Size = New System.Drawing.Size(21, 15)
        Me.lbl_proid2.TabIndex = 20
        Me.lbl_proid2.Text = "ID"
        '
        'lbl_subtotal2
        '
        Me.lbl_subtotal2.AutoSize = True
        Me.lbl_subtotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbl_subtotal2.Location = New System.Drawing.Point(180, 286)
        Me.lbl_subtotal2.Name = "lbl_subtotal2"
        Me.lbl_subtotal2.Size = New System.Drawing.Size(72, 13)
        Me.lbl_subtotal2.TabIndex = 19
        Me.lbl_subtotal2.Text = "SUBTOTAL"
        '
        'btn_addtocart
        '
        Me.btn_addtocart.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btn_addtocart.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addtocart.Location = New System.Drawing.Point(148, 333)
        Me.btn_addtocart.Name = "btn_addtocart"
        Me.btn_addtocart.Size = New System.Drawing.Size(122, 33)
        Me.btn_addtocart.TabIndex = 18
        Me.btn_addtocart.Text = "ADD TO CART"
        Me.btn_addtocart.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(145, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "RM"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(23, 284)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(77, 15)
        Me.lbl_subtotal.TabIndex = 16
        Me.lbl_subtotal.Text = "SUBTOTAL"
        '
        'nud_quantity
        '
        Me.nud_quantity.Location = New System.Drawing.Point(134, 227)
        Me.nud_quantity.Name = "nud_quantity"
        Me.nud_quantity.Size = New System.Drawing.Size(167, 20)
        Me.nud_quantity.TabIndex = 15
        '
        'txt_probrand
        '
        Me.txt_probrand.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txt_probrand.Location = New System.Drawing.Point(134, 142)
        Me.txt_probrand.Name = "txt_probrand"
        Me.txt_probrand.ReadOnly = True
        Me.txt_probrand.Size = New System.Drawing.Size(167, 20)
        Me.txt_probrand.TabIndex = 14
        '
        'txt_prowarr
        '
        Me.txt_prowarr.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txt_prowarr.Location = New System.Drawing.Point(134, 197)
        Me.txt_prowarr.Name = "txt_prowarr"
        Me.txt_prowarr.ReadOnly = True
        Me.txt_prowarr.Size = New System.Drawing.Size(167, 20)
        Me.txt_prowarr.TabIndex = 13
        '
        'txt_prostock
        '
        Me.txt_prostock.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txt_prostock.Location = New System.Drawing.Point(134, 171)
        Me.txt_prostock.Name = "txt_prostock"
        Me.txt_prostock.ReadOnly = True
        Me.txt_prostock.Size = New System.Drawing.Size(167, 20)
        Me.txt_prostock.TabIndex = 12
        '
        'txt_procate
        '
        Me.txt_procate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txt_procate.Location = New System.Drawing.Point(134, 113)
        Me.txt_procate.Name = "txt_procate"
        Me.txt_procate.ReadOnly = True
        Me.txt_procate.Size = New System.Drawing.Size(167, 20)
        Me.txt_procate.TabIndex = 11
        '
        'txt_proprice
        '
        Me.txt_proprice.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txt_proprice.Location = New System.Drawing.Point(134, 83)
        Me.txt_proprice.Name = "txt_proprice"
        Me.txt_proprice.ReadOnly = True
        Me.txt_proprice.Size = New System.Drawing.Size(167, 20)
        Me.txt_proprice.TabIndex = 10
        '
        'txt_proname
        '
        Me.txt_proname.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txt_proname.Location = New System.Drawing.Point(134, 56)
        Me.txt_proname.Name = "txt_proname"
        Me.txt_proname.ReadOnly = True
        Me.txt_proname.Size = New System.Drawing.Size(167, 20)
        Me.txt_proname.TabIndex = 9
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(22, 227)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(73, 15)
        Me.lbl_quantity.TabIndex = 7
        Me.lbl_quantity.Text = "QUANTITY"
        '
        'lbl_warranty
        '
        Me.lbl_warranty.AutoSize = True
        Me.lbl_warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_warranty.Location = New System.Drawing.Point(20, 202)
        Me.lbl_warranty.Name = "lbl_warranty"
        Me.lbl_warranty.Size = New System.Drawing.Size(81, 15)
        Me.lbl_warranty.TabIndex = 6
        Me.lbl_warranty.Text = "WARRANTY"
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock.Location = New System.Drawing.Point(23, 171)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(52, 15)
        Me.lbl_stock.TabIndex = 5
        Me.lbl_stock.Text = "STOCK"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(23, 142)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(54, 15)
        Me.lbl_brand.TabIndex = 4
        Me.lbl_brand.Text = "BRAND"
        '
        'lbl_category
        '
        Me.lbl_category.AutoSize = True
        Me.lbl_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category.Location = New System.Drawing.Point(22, 113)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(79, 15)
        Me.lbl_category.TabIndex = 3
        Me.lbl_category.Text = "CATEGORY"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(22, 83)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(92, 15)
        Me.lbl_price.TabIndex = 2
        Me.lbl_price.Text = "PRICE IN RM"
        '
        'lbl_proname
        '
        Me.lbl_proname.AutoSize = True
        Me.lbl_proname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proname.Location = New System.Drawing.Point(22, 56)
        Me.lbl_proname.Name = "lbl_proname"
        Me.lbl_proname.Size = New System.Drawing.Size(46, 15)
        Me.lbl_proname.TabIndex = 1
        Me.lbl_proname.Text = "NAME"
        '
        'lbl_proid
        '
        Me.lbl_proid.AutoSize = True
        Me.lbl_proid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proid.Location = New System.Drawing.Point(23, 27)
        Me.lbl_proid.Name = "lbl_proid"
        Me.lbl_proid.Size = New System.Drawing.Size(91, 15)
        Me.lbl_proid.TabIndex = 0
        Me.lbl_proid.Text = "PRODUCT ID"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox4.Controls.Add(Me.grd_orderdetails)
        Me.GroupBox4.Controls.Add(Me.btn_confirm)
        Me.GroupBox4.Controls.Add(Me.btn_remove)
        Me.GroupBox4.Location = New System.Drawing.Point(947, 133)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(368, 208)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Item(s) on cart"
        '
        'grd_orderdetails
        '
        Me.grd_orderdetails.AllowUserToAddRows = False
        Me.grd_orderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FLD_PRODUCT_ID, Me.FLD_QUANTITY, Me.FLD_PRICE})
        Me.grd_orderdetails.Location = New System.Drawing.Point(6, 21)
        Me.grd_orderdetails.Name = "grd_orderdetails"
        Me.grd_orderdetails.ReadOnly = True
        Me.grd_orderdetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grd_orderdetails.Size = New System.Drawing.Size(337, 117)
        Me.grd_orderdetails.TabIndex = 129
        '
        'FLD_PRODUCT_ID
        '
        Me.FLD_PRODUCT_ID.HeaderText = "PRODUCT ID"
        Me.FLD_PRODUCT_ID.Name = "FLD_PRODUCT_ID"
        Me.FLD_PRODUCT_ID.ReadOnly = True
        '
        'FLD_QUANTITY
        '
        Me.FLD_QUANTITY.HeaderText = "QUANTITY"
        Me.FLD_QUANTITY.Name = "FLD_QUANTITY"
        Me.FLD_QUANTITY.ReadOnly = True
        '
        'FLD_PRICE
        '
        Me.FLD_PRICE.HeaderText = "PRICE (RM)"
        Me.FLD_PRICE.Name = "FLD_PRICE"
        Me.FLD_PRICE.ReadOnly = True
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_confirm.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.Location = New System.Drawing.Point(183, 153)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(150, 34)
        Me.btn_confirm.TabIndex = 2
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.Red
        Me.btn_remove.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_remove.Location = New System.Drawing.Point(11, 153)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(150, 34)
        Me.btn_remove.TabIndex = 1
        Me.btn_remove.Text = "REMOVE"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'LBL_TOTAL
        '
        Me.LBL_TOTAL.AutoSize = True
        Me.LBL_TOTAL.BackColor = System.Drawing.Color.Transparent
        Me.LBL_TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TOTAL.ForeColor = System.Drawing.Color.Maroon
        Me.LBL_TOTAL.Location = New System.Drawing.Point(6, 67)
        Me.LBL_TOTAL.Name = "LBL_TOTAL"
        Me.LBL_TOTAL.Size = New System.Drawing.Size(97, 29)
        Me.LBL_TOTAL.TabIndex = 9
        Me.LBL_TOTAL.Text = "TOTAL"
        '
        'lbl_rm2
        '
        Me.lbl_rm2.AutoSize = True
        Me.lbl_rm2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_rm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rm2.ForeColor = System.Drawing.Color.Navy
        Me.lbl_rm2.Location = New System.Drawing.Point(134, 67)
        Me.lbl_rm2.Name = "lbl_rm2"
        Me.lbl_rm2.Size = New System.Drawing.Size(52, 29)
        Me.lbl_rm2.TabIndex = 10
        Me.lbl_rm2.Text = "RM"
        '
        'lbl_total2
        '
        Me.lbl_total2.AutoSize = True
        Me.lbl_total2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total2.ForeColor = System.Drawing.Color.Navy
        Me.lbl_total2.Location = New System.Drawing.Point(192, 67)
        Me.lbl_total2.Name = "lbl_total2"
        Me.lbl_total2.Size = New System.Drawing.Size(97, 29)
        Me.lbl_total2.TabIndex = 11
        Me.lbl_total2.Text = "TOTAL"
        '
        'btn_vieworder
        '
        Me.btn_vieworder.BackColor = System.Drawing.Color.Khaki
        Me.btn_vieworder.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vieworder.Location = New System.Drawing.Point(1224, 539)
        Me.btn_vieworder.Name = "btn_vieworder"
        Me.btn_vieworder.Size = New System.Drawing.Size(141, 51)
        Me.btn_vieworder.TabIndex = 12
        Me.btn_vieworder.Text = "VIEW ORDER"
        Me.btn_vieworder.UseVisualStyleBackColor = False
        '
        'grp_totalcust
        '
        Me.grp_totalcust.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.grp_totalcust.Controls.Add(Me.LBL_TOTAL)
        Me.grp_totalcust.Controls.Add(Me.lbl_rm2)
        Me.grp_totalcust.Controls.Add(Me.lbl_total2)
        Me.grp_totalcust.Location = New System.Drawing.Point(947, 353)
        Me.grp_totalcust.Name = "grp_totalcust"
        Me.grp_totalcust.Size = New System.Drawing.Size(304, 141)
        Me.grp_totalcust.TabIndex = 13
        Me.grp_totalcust.TabStop = False
        Me.grp_totalcust.Text = "Total Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Pink
        Me.Label1.Location = New System.Drawing.Point(70, 580)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 58)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Please Click New Order First" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                   to Make An Order" &
    "!"
        '
        'cmb_productid
        '
        Me.cmb_productid.FormattingEnabled = True
        Me.cmb_productid.Location = New System.Drawing.Point(555, 336)
        Me.cmb_productid.Name = "cmb_productid"
        Me.cmb_productid.Size = New System.Drawing.Size(189, 21)
        Me.cmb_productid.TabIndex = 15
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Pink
        Me.btn_search.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(750, 320)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(171, 51)
        Me.btn_search.TabIndex = 16
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'frm_makeorder_A173616
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.prj_GymFitnessHope_A173616.My.Resources.Resources.old_black_background_grunge_texture_dark_wallpaper_blackboard_chalkboard_room_wall_1258_283131
        Me.ClientSize = New System.Drawing.Size(1399, 785)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.cmb_productid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grp_totalcust)
        Me.Controls.Add(Me.btn_vieworder)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.pic_id)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_makeorder)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_back)
        Me.Name = "frm_makeorder_A173616"
        Me.Text = "Make Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_id, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_totalcust.ResumeLayout(False)
        Me.grp_totalcust.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_makeorder As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents cbb_staffid As ComboBox
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_neworder As Button
    Friend WithEvents txt_cusdate As TextBox
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents lbl_cusdate As Label
    Friend WithEvents lbl_cusname As Label
    Friend WithEvents lbl_cusid As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents pic_id As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_remove As Button
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_warranty As Label
    Friend WithEvents lbl_stock As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_category As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_proname As Label
    Friend WithEvents lbl_proid As Label
    Friend WithEvents btn_addtocart As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents nud_quantity As NumericUpDown
    Friend WithEvents txt_probrand As TextBox
    Friend WithEvents txt_prowarr As TextBox
    Friend WithEvents txt_prostock As TextBox
    Friend WithEvents txt_procate As TextBox
    Friend WithEvents txt_proprice As TextBox
    Friend WithEvents txt_proname As TextBox
    Friend WithEvents btn_confirm As Button
    Friend WithEvents LBL_TOTAL As Label
    Friend WithEvents lbl_rm2 As Label
    Friend WithEvents lbl_orderid2 As Label
    Friend WithEvents lbl_subtotal2 As Label
    Friend WithEvents lbl_total2 As Label
    Friend WithEvents lbl_proid2 As Label
    Friend WithEvents lbl_cusid2 As Label
    Friend WithEvents grd_orderdetails As DataGridView
    Friend WithEvents FLD_PRODUCT_ID As DataGridViewTextBoxColumn
    Friend WithEvents FLD_QUANTITY As DataGridViewTextBoxColumn
    Friend WithEvents FLD_PRICE As DataGridViewTextBoxColumn
    Friend WithEvents btn_vieworder As Button
    Friend WithEvents grp_totalcust As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_productid As ComboBox
    Friend WithEvents btn_search As Button
End Class
