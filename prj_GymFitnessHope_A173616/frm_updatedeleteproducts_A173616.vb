Imports System.IO
Public Class frm_updateproducts_A173616
    Dim img As Image
    Dim currentpicture As String
    Dim current_id As String
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_updateproducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_id()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A173616"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_products.DataSource = mydatatable

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Product Name"
        grd_products.Columns(2).HeaderText = "Price"
        grd_products.Columns(3).HeaderText = "Category"
        grd_products.Columns(4).HeaderText = "Brand"
        grd_products.Columns(5).HeaderText = "Stock"
        grd_products.Columns(6).HeaderText = "Warranty"
    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_category.Text = ""
        txt_brand.Text = ""
        txt_stock.Text = ""
        txt_warranty.Text = ""

    End Sub
    Private Sub get_current_id()

        Dim current_row As Integer = grd_products.CurrentRow.Index

        current_id = grd_products(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_category.Text = grd_products(3, current_row).Value
        txt_brand.Text = grd_products(4, current_row).Value
        txt_stock.Text = grd_products(5, current_row).Value
        txt_warranty.Text = grd_products(6, current_row).Value


        'pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")

        currentpicture = Application.StartupPath & "\pictures\" & txt_id.Text & ".jpg"
        txt_photo.Text = currentpicture

        Using file As New FileStream(currentpicture, FileMode.Open, FileAccess.Read)

            img = Image.FromStream(file)

        End Using

        pic_product.BackgroundImage = img

    End Sub



    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick

        get_current_id()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click




        run_sql_command("UPDATE TBL_PRODUCT_A173616 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRODUCT_PRICE=" &
                        txt_price.Text & ", FLD_CATEGORY='" & txt_category.Text & "' , FLD_BRAND='" & txt_brand.Text & "' , 
                         FLD_STOCK = '" & txt_stock.Text & "', FLD_WARRANTY = '" & txt_warranty.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")


        refresh_grid()

        clear_fields()

        get_current_id()




    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the products """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCT_A173616 WHERE
            FLD_PRODUCT_ID='" & current_id & "'")
            pic_product.BackgroundImage.Dispose()
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\pictures\" & txt_id.Text & ".jpg")




            Beep()
            MsgBox("The Product """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()



        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click


        frm_mainmenu_A173616.Show()
        Me.Close()


    End Sub
End Class