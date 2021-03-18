Public Class frm_insertcustomer_A173616
    Private Sub frm_insertcustomer_A173616_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_customers.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A173616")

        grd_customers.Columns(0).HeaderText = "Customer ID"
        grd_customers.Columns(1).HeaderText = "Customer Name"
        grd_customers.Columns(2).HeaderText = "Phone Number"
        grd_customers.Columns(3).HeaderText = "Address"

        txt_id.Text = generate_id()



    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A173616").Rows(0).Item("LASTID")

        '  MsgBox(lastmatric)

        Dim newid As String = "C" & Mid(lastid, 2) + 1

        Return newid

    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A173616 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_number.Text & "','" & txt_address.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_customers.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A173616")

            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_name.Text = ""
            txt_number.Text = ""
            txt_address.Text = ""

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try


    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_A173616.Show()
        Me.Close()



    End Sub
End Class