Public Class frm_order_A173616
    Private Sub frm_order_A173616_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=DB_GymFitnessHope_A173616.accdb;Persist Security Info = False;"

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A173616"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_order.DataSource = mydatatable

        grd_order.Columns(0).HeaderText = "Order ID"
        grd_order.Columns(1).HeaderText = "Order Date"
        grd_order.Columns(2).HeaderText = "Staff ID"
        grd_order.Columns(3).HeaderText = "Customer ID"






    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_A173616.Show()
        Me.Close()

    End Sub
End Class