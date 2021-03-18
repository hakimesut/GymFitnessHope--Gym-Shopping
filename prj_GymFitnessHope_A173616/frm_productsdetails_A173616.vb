Public Class frm_productsdetails
    Private Sub frm_productsdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_A173616"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        list_productid.DataSource = mydatatable

        list_productid.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(list_productid.Text)


    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A173616 WHERE FLD_PRODUCT_ID='" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_PRICE")
        txt_category.Text = mydatatable.Rows(0).Item("FLD_CATEGORY")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_stock.Text = mydatatable.Rows(0).Item("FLD_STOCK")
        txt_warranty.Text = mydatatable.Rows(0).Item("FLD_WARRANTY")



        pic_id.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")

    End Sub



    Private Sub list_productid_MouseClick(sender As Object, e As MouseEventArgs) Handles list_productid.MouseClick

        refresh_text(list_productid.Text)

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        pic_id.BackgroundImage.Dispose()

        frm_mainmenu_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs)

        frm_insertproduct_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs)

        frm_updateproducts_A173616.Show()
        Me.Close()
    End Sub
End Class