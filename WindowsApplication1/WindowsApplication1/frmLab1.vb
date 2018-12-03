Public Class frmLab1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name, salary, salaryyear
        Dim y = 12
        name = TextBox1.Text
        salary = TextBox2.Text
        salaryyear = salary * y


        Label4.Text = TextBox1.Text
        Label6.Text = TextBox2.Text
        Label7.Text = salaryyear



    End Sub
End Class
