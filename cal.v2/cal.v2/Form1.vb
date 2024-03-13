Public Class Form1
    Dim num1, num2 As Double
    Dim value As Double
    Dim op As String

    Private Sub b_click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click

        Dim b As Button = sender

        If (TextBox1.Text = "0") Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If InStr(TextBox1.Text, ".") = 0 Then
            TextBox1.Text = TextBox1.Text + "."
        End If

    End Sub

    Private Sub ops(sender As Object, e As EventArgs) Handles MyBase.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click

        Dim ops As Button = sender

        num1 = TextBox1.Text
        Label1.Text = TextBox1.Text
        TextBox1.Clear()
        op = ops.Text
        Label1.Text = Label1.Text + "" + op

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)

        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        TextBox1.Clear()
        TextBox1.Text = "0"

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        num2 = TextBox1.Text
        Label1.Text = ""
        If op = "+" Then
            value = num1 + num2
            TextBox1.Text = value
        ElseIf op = "-" Then
            value = num1 - num2
            TextBox1.Text = value
        ElseIf op = "*" Then
            value = num1 * num2
            TextBox1.Text = value
        ElseIf op = "/" Then
            If num2 = 0 Then
                TextBox1.Text = "Invalid!"
            Else
                value = num1 / num2
                TextBox1.Text = value

            End If

        End If

    End Sub

End Class
