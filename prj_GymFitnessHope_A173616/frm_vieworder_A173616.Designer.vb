<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworder_A173616
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
        Me.lbl_nameshop = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.grd_orderdetails = New System.Windows.Forms.DataGridView()
        Me.lbl_thanks = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_custid = New System.Windows.Forms.TextBox()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.cbb_orderid = New System.Windows.Forms.ComboBox()
        Me.lbl_cusid = New System.Windows.Forms.Label()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.lbl_orderid2 = New System.Windows.Forms.Label()
        Me.lbl_orderid3 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_totalvalue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nameshop
        '
        Me.lbl_nameshop.AutoSize = True
        Me.lbl_nameshop.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nameshop.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nameshop.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_nameshop.Location = New System.Drawing.Point(318, 65)
        Me.lbl_nameshop.Name = "lbl_nameshop"
        Me.lbl_nameshop.Size = New System.Drawing.Size(355, 34)
        Me.lbl_nameshop.TabIndex = 0
        Me.lbl_nameshop.Text = "GYM FITNESS HOPE SHOP"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_address.Location = New System.Drawing.Point(246, 99)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(503, 66)
        Me.lbl_address.TabIndex = 1
        Me.lbl_address.Text = "       No.1272,Persiaran 3/7,Taman Chandan Putri 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                      33000, " &
    "Kuala Kangsar, Perak" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                Tel: 012-4375531" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'grd_orderdetails
        '
        Me.grd_orderdetails.AllowUserToAddRows = False
        Me.grd_orderdetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grd_orderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdetails.Location = New System.Drawing.Point(324, 257)
        Me.grd_orderdetails.Name = "grd_orderdetails"
        Me.grd_orderdetails.ReadOnly = True
        Me.grd_orderdetails.Size = New System.Drawing.Size(348, 308)
        Me.grd_orderdetails.TabIndex = 2
        '
        'lbl_thanks
        '
        Me.lbl_thanks.AutoSize = True
        Me.lbl_thanks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_thanks.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_thanks.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_thanks.Location = New System.Drawing.Point(245, 657)
        Me.lbl_thanks.Name = "lbl_thanks"
        Me.lbl_thanks.Size = New System.Drawing.Size(570, 29)
        Me.lbl_thanks.TabIndex = 4
        Me.lbl_thanks.Text = "THANK YOU VERY MUCH TO BUY FROM OUR SHOP!"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Stencil", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(12, 53)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(101, 36)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.txt_custid)
        Me.GroupBox1.Controls.Add(Me.txt_staffid)
        Me.GroupBox1.Controls.Add(Me.cbb_orderid)
        Me.GroupBox1.Controls.Add(Me.lbl_cusid)
        Me.GroupBox1.Controls.Add(Me.lbl_staffid)
        Me.GroupBox1.Controls.Add(Me.lbl_orderid)
        Me.GroupBox1.Location = New System.Drawing.Point(128, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 55)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'txt_custid
        '
        Me.txt_custid.Location = New System.Drawing.Point(587, 19)
        Me.txt_custid.Name = "txt_custid"
        Me.txt_custid.ReadOnly = True
        Me.txt_custid.Size = New System.Drawing.Size(117, 20)
        Me.txt_custid.TabIndex = 5
        '
        'txt_staffid
        '
        Me.txt_staffid.Location = New System.Drawing.Point(336, 19)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.ReadOnly = True
        Me.txt_staffid.Size = New System.Drawing.Size(115, 20)
        Me.txt_staffid.TabIndex = 4
        '
        'cbb_orderid
        '
        Me.cbb_orderid.FormattingEnabled = True
        Me.cbb_orderid.Location = New System.Drawing.Point(122, 20)
        Me.cbb_orderid.Name = "cbb_orderid"
        Me.cbb_orderid.Size = New System.Drawing.Size(106, 21)
        Me.cbb_orderid.TabIndex = 3
        '
        'lbl_cusid
        '
        Me.lbl_cusid.AutoSize = True
        Me.lbl_cusid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cusid.Location = New System.Drawing.Point(469, 21)
        Me.lbl_cusid.Name = "lbl_cusid"
        Me.lbl_cusid.Size = New System.Drawing.Size(102, 15)
        Me.lbl_cusid.TabIndex = 2
        Me.lbl_cusid.Text = "CUSTOMER ID"
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.Location = New System.Drawing.Point(251, 21)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(66, 15)
        Me.lbl_staffid.TabIndex = 1
        Me.lbl_staffid.Text = "STAFF ID"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Location = New System.Drawing.Point(31, 20)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(74, 15)
        Me.lbl_orderid.TabIndex = 0
        Me.lbl_orderid.Text = "ORDER ID"
        '
        'lbl_orderid2
        '
        Me.lbl_orderid2.AutoSize = True
        Me.lbl_orderid2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_orderid2.Location = New System.Drawing.Point(184, 588)
        Me.lbl_orderid2.Name = "lbl_orderid2"
        Me.lbl_orderid2.Size = New System.Drawing.Size(107, 24)
        Me.lbl_orderid2.TabIndex = 8
        Me.lbl_orderid2.Text = "ORDER ID"
        '
        'lbl_orderid3
        '
        Me.lbl_orderid3.AutoSize = True
        Me.lbl_orderid3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid3.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_orderid3.Location = New System.Drawing.Point(297, 588)
        Me.lbl_orderid3.Name = "lbl_orderid3"
        Me.lbl_orderid3.Size = New System.Drawing.Size(155, 24)
        Me.lbl_orderid3.TabIndex = 9
        Me.lbl_orderid3.Text = "ORDER VALUE"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_total.Location = New System.Drawing.Point(552, 588)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(77, 24)
        Me.lbl_total.TabIndex = 10
        Me.lbl_total.Text = "TOTAL"
        '
        'lbl_totalvalue
        '
        Me.lbl_totalvalue.AutoSize = True
        Me.lbl_totalvalue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totalvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalvalue.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_totalvalue.Location = New System.Drawing.Point(644, 588)
        Me.lbl_totalvalue.Name = "lbl_totalvalue"
        Me.lbl_totalvalue.Size = New System.Drawing.Size(150, 24)
        Me.lbl_totalvalue.TabIndex = 11
        Me.lbl_totalvalue.Text = "TOTAL VALUE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(387, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 34)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ORDER INVOICE"
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.Salmon
        Me.btn_print.Font = New System.Drawing.Font("Stencil", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_print.Location = New System.Drawing.Point(421, 737)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(140, 32)
        Me.btn_print.TabIndex = 13
        Me.btn_print.Text = "PRINT INVOICE"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'frm_vieworder_A173616
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_GymFitnessHope_A173616.My.Resources.Resources.v475_katie_101_abstractblackandwhitebg_1
        Me.ClientSize = New System.Drawing.Size(954, 801)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_totalvalue)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_orderid3)
        Me.Controls.Add(Me.lbl_orderid2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_thanks)
        Me.Controls.Add(Me.grd_orderdetails)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.lbl_nameshop)
        Me.Name = "frm_vieworder_A173616"
        Me.Text = "View Order"
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_nameshop As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents grd_orderdetails As DataGridView
    Friend WithEvents lbl_thanks As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_custid As TextBox
    Friend WithEvents txt_staffid As TextBox
    Friend WithEvents cbb_orderid As ComboBox
    Friend WithEvents lbl_cusid As Label
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents lbl_orderid2 As Label
    Friend WithEvents lbl_orderid3 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_totalvalue As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_print As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
