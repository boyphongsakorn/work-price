Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim count As Integer = 0
        Dim price As Integer
        price = Val(TextBox1.Text) + 150
        While count = 0
            If price Mod 50 = 0 Then
                Label4.Text = "ราคาสรุป : " & price
                count = 1
            Else
                price = price + 1
                count = 0
            End If
        End While
    End Sub
End Class
