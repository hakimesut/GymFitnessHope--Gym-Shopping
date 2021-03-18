Public Class frm_vieworder_A173616
    Dim t As Double
    Dim p As Double
    Dim bmp As Bitmap


    Private Sub frm_vieworder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A173616"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cbb_orderid.DataSource = mydatatable
        cbb_orderid.DisplayMember = "FLD_ORDER_ID"

        refresh_text(cbb_orderid.Text)
        refresh_grid()
        refresh_price()
    End Sub

    Private Sub refresh_text(ByVal orderId As String)

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A173616 WHERE FLD_ORDER_ID='" & orderId & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_custid.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        txt_staffid.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT FLD_PRODUCT_ID, FLD_PRODUCT_QUANTITY, FLD_PRICE FROM TBL_ORDERDETAILS_A173616 where FLD_ORDER_ID like""%" & cbb_orderid.Text & "%"""
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        grd_orderdetails.DataSource = mydatatable

        grd_orderdetails.Columns(0).HeaderText = "Product ID"
        grd_orderdetails.Columns(1).HeaderText = "Order Quantity"
        grd_orderdetails.Columns(2).HeaderText = "Total price (RM)"

    End Sub

    Private Sub cbb_orderid_MouseClick(sender As System.Object, e As System.EventArgs) Handles cbb_orderid.MouseClick
        refresh_text(cbb_orderid.Text)
    End Sub

    Private Sub cbb_orderid_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbb_orderid.SelectedIndexChanged
        refresh_grid()
        lbl_orderid3.Text = cbb_orderid.Text
        refresh_price()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A173616.Show()
        Me.Close()

    End Sub

    Private Sub refresh_price()

        If grd_orderdetails.RowCount > 1 Then
            t = 0
            p = 0
            For index As Integer = 0 To grd_orderdetails.RowCount - 1
                t += Convert.ToDouble(grd_orderdetails.Rows(index).Cells(2).Value)
            Next
            lbl_totalvalue.Text = "RM " & t

        Else
            For index2 As Integer = 0 To grd_orderdetails.RowCount = 0


                p += Convert.ToDouble(grd_orderdetails.Rows(index2).Cells(2).Value)
            Next
            lbl_totalvalue.Text = "RM " & p
        End If

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim graphic As Graphics
        bmp = New Bitmap(Me.Width - 10, Me.Height)
        graphic = Graphics.FromImage(bmp)
        graphic.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, bmp.Size)
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("custom", Me.Width, Me.Height)
        ' PrintDocument1.PrinterSettings.PrintToFile = True
        '' PrintDocument1.PrinterSettings.PrintFileName = "ghvgh"
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
        PrintDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF"
        PrintDocument1.PrinterSettings.PrintFileName = "GymFitnessHope.pdf"
    End Sub
End Class