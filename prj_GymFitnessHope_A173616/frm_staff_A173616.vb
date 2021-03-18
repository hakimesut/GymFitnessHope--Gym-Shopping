Public Class frm_staff_A173616
    Private Sub frm_staff_A173616_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=DB_GymFitnessHope_A173616.accdb;Persist Security Info = False;"

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A173616"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Phone Number"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) 

        frm_insertstaff_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_updatedelete_Click(sender As Object, e As EventArgs) 

        frm_updatedeletestaff_A173616.Show()
        Me.Close()

    End Sub


End Class