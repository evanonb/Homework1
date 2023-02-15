Public Class frmFrenchNumbers
    Private Sub frmFrenchNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFrench.Visible = False
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        lblFrench.Text = "un"
        lblFrench.Visible = True
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        lblFrench.Text = "deux"
        lblFrench.Visible = True
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lblFrench.Text = "trois"
        lblFrench.Visible = True
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lblFrench.Text = "quatre"
        lblFrench.Visible = True
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        lblFrench.Text = "cinq"
        lblFrench.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
