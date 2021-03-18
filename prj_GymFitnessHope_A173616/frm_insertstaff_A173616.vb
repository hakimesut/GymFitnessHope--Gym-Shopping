Public Class frm_insertstaff_A173616
    Private Sub frm_insertstaff_A173616_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A173616")

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Phone Number"

        txt_id.Text = generate_id()

    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A173616").Rows(0).Item("LASTID")

        '  MsgBox(lastmatric)

        Dim newid As String = "S" & Mid(lastid, 2) + 1

        Return newid

    End Function

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_A173616.Show()

        Me.Close()


    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_STAFF_A173616 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_number.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A173616")

            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_number.Text = ""


        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub lbl_insertname_Click(sender As Object, e As EventArgs) Handles lbl_insertname.Click

    End Sub
End Class