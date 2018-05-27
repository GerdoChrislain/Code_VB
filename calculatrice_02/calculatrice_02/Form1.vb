Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "+"
        gerdo3.Text = Val(gerdo1.Text) + (gerdo2.Text)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = "-"
        gerdo3.Text = Val(gerdo1.Text) - (gerdo2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "x"
        gerdo3.Text = Val(gerdo1.Text) * (gerdo2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = "/"
        gerdo3.Text = Val(gerdo1.Text) / (gerdo2.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        gerdo1.Text = ""
        gerdo2.Text = ""
        gerdo3.Text = ""
    End Sub
End Class
