Public Class frm_customer_A173616
    Private Sub frm_customer_A173616_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=DB_GymFitnessHope_A173616.accdb;Persist Security Info = False;"

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A173616"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customer.DataSource = mydatatable

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Phone Number"
        grd_customer.Columns(3).HeaderText = "Address"


    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_A173616.Show()
        Me.Close()

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) 

        frm_insertcustomer_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_updatedelete_Click(sender As Object, e As EventArgs) 

        frm_updatedeletecustomer_A173616.Show()
        Me.Close()



    End Sub
End Class