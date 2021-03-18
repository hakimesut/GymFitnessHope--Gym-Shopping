<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateproducts_A173616
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_category = New System.Windows.Forms.Label()
        Me.txt_category = New System.Windows.Forms.TextBox()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.lbl_warranty = New System.Windows.Forms.Label()
        Me.txt_warranty = New System.Windows.Forms.TextBox()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.lbl_name1 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_photo = New System.Windows.Forms.TextBox()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(9, 35)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(84, 30)
        Me.btn_back.TabIndex = 0
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(154, 499)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(104, 37)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_id.Location = New System.Drawing.Point(9, 113)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(32, 17)
        Me.lbl_id.TabIndex = 12
        Me.lbl_id.Text = "ID :"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(8, 139)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(384, 21)
        Me.txt_id.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(7, 169)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "NAME :"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(8, 188)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(384, 21)
        Me.txt_name.TabIndex = 15
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_price.Location = New System.Drawing.Point(5, 217)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(58, 17)
        Me.lbl_price.TabIndex = 16
        Me.lbl_price.Text = "PRICE :"
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(8, 236)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(384, 21)
        Me.txt_price.TabIndex = 17
        '
        'lbl_category
        '
        Me.lbl_category.AutoSize = True
        Me.lbl_category.BackColor = System.Drawing.Color.Transparent
        Me.lbl_category.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_category.Location = New System.Drawing.Point(7, 268)
        Me.lbl_category.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(86, 17)
        Me.lbl_category.TabIndex = 18
        Me.lbl_category.Text = "CATEGORY :"
        '
        'txt_category
        '
        Me.txt_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_category.Location = New System.Drawing.Point(8, 287)
        Me.txt_category.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_category.Name = "txt_category"
        Me.txt_category.Size = New System.Drawing.Size(384, 21)
        Me.txt_category.TabIndex = 19
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_brand.Location = New System.Drawing.Point(7, 318)
        Me.lbl_brand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(63, 17)
        Me.lbl_brand.TabIndex = 20
        Me.lbl_brand.Text = "BRAND :"
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(8, 337)
        Me.txt_brand.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(384, 21)
        Me.txt_brand.TabIndex = 21
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.BackColor = System.Drawing.Color.Transparent
        Me.lbl_stock.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_stock.Location = New System.Drawing.Point(7, 370)
        Me.lbl_stock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(60, 17)
        Me.lbl_stock.TabIndex = 22
        Me.lbl_stock.Text = "STOCK :"
        '
        'txt_stock
        '
        Me.txt_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stock.Location = New System.Drawing.Point(8, 389)
        Me.txt_stock.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(384, 21)
        Me.txt_stock.TabIndex = 23
        '
        'lbl_warranty
        '
        Me.lbl_warranty.AutoSize = True
        Me.lbl_warranty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_warranty.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_warranty.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_warranty.Location = New System.Drawing.Point(6, 422)
        Me.lbl_warranty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_warranty.Name = "lbl_warranty"
        Me.lbl_warranty.Size = New System.Drawing.Size(91, 17)
        Me.lbl_warranty.TabIndex = 24
        Me.lbl_warranty.Text = "WARRANTY :"
        '
        'txt_warranty
        '
        Me.txt_warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_warranty.Location = New System.Drawing.Point(8, 440)
        Me.txt_warranty.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.Size = New System.Drawing.Size(384, 21)
        Me.txt_warranty.TabIndex = 25
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(406, 113)
        Me.grd_products.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        Me.grd_products.RowHeadersWidth = 51
        Me.grd_products.RowTemplate.Height = 24
        Me.grd_products.Size = New System.Drawing.Size(776, 381)
        Me.grd_products.TabIndex = 26
        '
        'lbl_name1
        '
        Me.lbl_name1.AutoSize = True
        Me.lbl_name1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name1.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_name1.Location = New System.Drawing.Point(331, 35)
        Me.lbl_name1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_name1.Name = "lbl_name1"
        Me.lbl_name1.Size = New System.Drawing.Size(423, 32)
        Me.lbl_name1.TabIndex = 27
        Me.lbl_name1.Text = "UPDATE AND DELETE PRODUCTS"
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(279, 499)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(102, 37)
        Me.btn_delete.TabIndex = 28
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(-1, 558)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(10, 10)
        Me.pic_product.TabIndex = 29
        Me.pic_product.TabStop = False
        '
        'txt_photo
        '
        Me.txt_photo.BackColor = System.Drawing.Color.Black
        Me.txt_photo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_photo.Location = New System.Drawing.Point(484, 544)
        Me.txt_photo.Name = "txt_photo"
        Me.txt_photo.Size = New System.Drawing.Size(10, 13)
        Me.txt_photo.TabIndex = 30
        '
        'frm_updateproducts_A173616
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_GymFitnessHope_A173616.My.Resources.Resources._360_F_119597487_SnvLBdheEGOxu05rMQ5tCzo250cRrTz9
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1213, 569)
        Me.Controls.Add(Me.txt_photo)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.lbl_name1)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.txt_warranty)
        Me.Controls.Add(Me.lbl_warranty)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.lbl_stock)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.txt_category)
        Me.Controls.Add(Me.lbl_category)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_back)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_updateproducts_A173616"
        Me.Text = "Update and Delete Products"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents lbl_category As Label
    Friend WithEvents txt_category As TextBox
    Friend WithEvents lbl_brand As Label
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents lbl_stock As Label
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents lbl_warranty As Label
    Friend WithEvents txt_warranty As TextBox
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents lbl_name1 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_photo As TextBox
End Class
