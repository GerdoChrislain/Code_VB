Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "+"
        TextBox3.Text = Val(TextBox1.Text) + (TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "-"
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "x"
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "/"
        TextBox3.Text = Val(TextBox1.Text) / (TextBox2.Text)

    End Sub

    
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label1.Text = ""
        Label2.Text = ""
    End Sub
End Class
