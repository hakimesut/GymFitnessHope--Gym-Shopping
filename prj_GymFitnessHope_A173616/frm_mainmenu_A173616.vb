Public Class frm_mainmenu_A173616
    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click

        frm_products_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click

        frm_order_A173616.Show()
        Me.Close()



    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click

        frm_customer_A173616.Show()
        Me.Close()



    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click

        frm_staff_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        frm_splashscreen_A173616.Show()
        Me.Close()


    End Sub

    Private Sub frm_mainmenu_A173616_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date
    End Sub

    Private Sub btn_updatestaff_Click(sender As Object, e As EventArgs) Handles btn_updatestaff.Click

        frm_updatedeletestaff_A173616.Show()
        Me.Close()



    End Sub

    Private Sub btn_addstaff_Click(sender As Object, e As EventArgs) Handles btn_addstaff.Click

        frm_insertstaff_A173616.Show()
        Me.Close()



    End Sub

    Private Sub btn_updatecust_Click(sender As Object, e As EventArgs) Handles btn_updatecust.Click

        frm_updatedeletecustomer_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_addcust_Click(sender As Object, e As EventArgs) Handles btn_addcust.Click

        frm_insertcustomer_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_addpro_Click(sender As Object, e As EventArgs) Handles btn_addpro.Click

        frm_insertproduct_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_detailpro_Click(sender As Object, e As EventArgs) Handles btn_detailpro.Click

        frm_productsdetails.Show()
        Me.Close()



    End Sub

    Private Sub btn_updatepro_Click(sender As Object, e As EventArgs) Handles btn_updatepro.Click

        frm_updateproducts_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        frm_makeorder_A173616.Show()
        Me.Close()


    End Sub

    Private Sub btn_vieworder_Click(sender As Object, e As EventArgs) Handles btn_vieworder.Click
        frm_vieworder_A173616.Show()
        Me.Close()


    End Sub
End Class
