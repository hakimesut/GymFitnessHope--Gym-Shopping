Public Class frm_makeorder_A173616
    Dim number1 As Double
    Dim c As String
    Dim duit As Double
    Dim num As Integer
    Dim current_code As String
    Dim current_code1 As String
    Dim current_code2 As String
    Private Sub frm_makeorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
        Dim current_date As String = Date.Now
        txt_cusdate.Text = current_date
        c = 100
        refresh_count()
        refresh_staff()
        btn_addtocart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False


        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A173616"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_productid.DataSource = mydatatable
        cmb_productid.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(cmb_productid.Text)
    End Sub

    Private Sub refresh_text(product As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A173616 WHERE FLD_PRODUCT_ID='" & product & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lbl_proid2.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_proname.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_proprice.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_PRICE")
        txt_procate.Text = mydatatable.Rows(0).Item("FLD_CATEGORY")
        txt_probrand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_prostock.Text = mydatatable.Rows(0).Item("FLD_STOCK")
        txt_prowarr.Text = mydatatable.Rows(0).Item("FLD_WARRANTY")
        lbl_subtotal2.Text = num * txt_proprice.Text

        Try

            pic_id.BackgroundImage = Image.FromFile("pictures/" & lbl_proid2.Text & ".jpg")

        Catch ex As Exception

            pic_id.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

        End Try
    End Sub
    ' Private Sub list_proid_MouseClick(sender As Object, e As MouseEventArgs)
    '    refresh_text(list_proid.Text)
    ' End Sub

    Private Sub nud_quantity_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nud_quantity.ValueChanged
        num = nud_quantity.Value
        number1 = txt_proprice.Text()
        lbl_subtotal2.Text = num * number1
    End Sub
    Private Sub refresh_grid()

        Dim mysql2 As String = "SELECT * FROM TBL_CUSTOMER_A173616"

        Dim mydatatable2 As New DataTable

        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)

        myreader2.Fill(mydatatable2)

        grd_customer.DataSource = mydatatable2

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Phone Number"
        grd_customer.Columns(3).HeaderText = "Address"

    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_customer.CurrentRow.Index

        current_code = grd_customer(0, current_row).Value

        lbl_cusid2.Text = current_code

        txt_cusname.Text = grd_customer(1, current_row).Value

    End Sub
    Private Sub grd_customer_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_customer.CellClick
        get_current_code()
    End Sub

    Private Sub refresh_staff()

        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A173616"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cbb_staffid.DataSource = mydatatable

        cbb_staffid.DisplayMember = "FLD_STAFF_ID"

    End Sub

    Private Sub refresh_count()

        Dim count As Integer = 1

        Dim mysql As String = "SELECT COUNT (FLD_ORDER_ID) As count_id FROM TBL_ORDER_A173616"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        count += mydatatable.Rows(0).Item("count_id")

        lbl_orderid2.Text = "D" + count.ToString("100")

    End Sub



    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        pic_id.BackgroundImage.Dispose()
        frm_mainmenu_A173616.Show()
        Me.Close()

    End Sub

    Private Sub btn_neworder_Click(sender As Object, e As EventArgs) Handles btn_neworder.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction
        Try

            Dim mysql As String = "INSERT INTO TBL_ORDER_A173616 (FLD_ORDER_ID, FLD_ORDER_DATE, FLD_CUSTOMER_ID, FLD_STAFF_ID) values (""" &
            lbl_orderid2.Text & """,""" & txt_cusdate.Text & """,""" & lbl_cusid2.Text & """,""" & cbb_staffid.Text & """)"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)

            mywriter.ExecuteNonQuery()
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("You can make new order now!")
            refresh_grid()
            grd_orderdetails.Rows.Clear()

        Catch ex As Exception

            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try

        btn_addtocart.Enabled = True
        btn_confirm.Enabled = True
        btn_remove.Enabled = True
        btn_neworder.Enabled = False

    End Sub

    Private Sub btn_addtocart_Click(sender As Object, e As EventArgs) Handles btn_addtocart.Click
        grd_orderdetails.Rows.Add(New String() {lbl_proid2.Text, nud_quantity.Value, lbl_subtotal2.Text})
        lbl_subtotal2.Text = ""
        nud_quantity.Value = 0
        lbl_total2.Text = ""
        refresh_price()
    End Sub
    Private Sub refresh_price()

        If grd_orderdetails.RowCount > 0 Then
            duit = 0

            For index As Integer = 0 To grd_orderdetails.RowCount - 1
                duit += Convert.ToDouble(grd_orderdetails.Rows(index).Cells(2).Value)
            Next

            lbl_total2.Text = duit

        ElseIf grd_orderdetails.RowCount = 1 Then

            lbl_total2.Text = "RM 0"

        End If

    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim delete_order = MsgBox("Confirm to delete this item from list?", MsgBoxStyle.YesNo)

        If delete_order = MsgBoxResult.Yes Then
            grd_orderdetails.Rows.Remove(grd_orderdetails.CurrentRow)
            refresh_price()
        Else
            refresh_price()
        End If
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()

        mytransaction = myconnection2.BeginTransaction
        Try
            For i As Integer = 0 To grd_orderdetails.RowCount - 1
                Dim productid As String = grd_orderdetails(0, i).Value
                Dim quantity As String = grd_orderdetails(1, i).Value
                Dim price As String = grd_orderdetails(2, i).Value

                Dim mysql As String = "Insert into TBL_ORDERDETAILS_A173616 (FLD_ORDER_ID, FLD_PRODUCT_ID, FLD_PRODUCT_QUANTITY, FLD_PRICE) values (""" & lbl_orderid2.Text & """,""" & productid & """, """ & quantity & """, """ & price & """)"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)


                mywriter.ExecuteNonQuery()

            Next
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("Transaction successful!")
            refresh_grid()
            grd_orderdetails.Rows.Clear()

        Catch ex As Exception
            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try

        btn_addtocart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False
        btn_neworder.Enabled = True
        nud_quantity.Value = 0
        lbl_total2.Text = "0"
        refresh_count()
    End Sub

    Private Sub btn_vieworder_Click(sender As Object, e As EventArgs) Handles btn_vieworder.Click

        pic_id.BackgroundImage.Dispose()
        frm_vieworder_A173616.Show()
        Me.Close()




    End Sub

    ' Private Sub cmb_productid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_productid.SelectedIndexChanged
    '   Try
    '     refresh_text(cmb_productid.Text)
    '  Catch ex As Exception

    '   End Try
    ' End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Try
            refresh_text(cmb_productid.Text)
        Catch ex As Exception
            Beep()
            MsgBox("The Product is Not Available")
        End Try
    End Sub
End Class