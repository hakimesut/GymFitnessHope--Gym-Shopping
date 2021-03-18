Public Class frm_products_A173616

    Dim current_product_id As String

    Private Sub frm_products_A173616_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_GymFitnessHope_A173616.accdb;Persist Security Info=False;"

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

        get_current_product_id()


    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        pic_product.BackgroundImage.Dispose()

        frm_mainmenu_A173616.Show()
        Me.Close()

    End Sub

    Private Sub get_current_product_id()

        Dim current_row As Integer = grd_products.CurrentRow.Index

        current_product_id = grd_products(0, current_row).Value

        txt_id.Text = current_product_id

        pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")

    End Sub



    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick

        get_current_product_id()


    End Sub

    Private Sub btn_details_Click(sender As Object, e As EventArgs)
        frm_productsdetails.Show()
        Me.Close()

    End Sub
End Class