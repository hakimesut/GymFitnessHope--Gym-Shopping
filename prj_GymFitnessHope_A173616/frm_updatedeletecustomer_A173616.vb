Public Class frm_updatedeletecustomer_A173616


    Dim current_id As String
    Private Sub frm_updatedeletecustomer_A173616_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_id()

    End Sub

    Private Sub refresh_grid()

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

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_number.Text = ""
        txt_address.Text = ""

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_customer.CurrentRow.Index

        current_id = grd_customer(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_customer(1, current_row).Value
        txt_number.Text = grd_customer(2, current_row).Value
        txt_address.Text = grd_customer(3, current_row).Value



    End Sub



    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick

        get_current_id()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click




        run_sql_command("UPDATE TBL_CUSTOMER_A173616 SET FLD_CUSTOMER_NAME='" & txt_name.Text & "', FLD_CUSTOMER_PHONE_NUMBER='" &
                          txt_number.Text & "', FLD_CUSTOMER_ADDRESS = '" & txt_address.Text & "' WHERE FLD_CUSTOMER_ID='" & current_id & "'")

        refresh_grid()

        clear_fields()

        get_current_id()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER_A173616 WHERE
            FLD_CUSTOMER_ID='" & current_id & "'")

            Beep()
            MsgBox("The customer """ & current_id & """ has been successfully deleted.")

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