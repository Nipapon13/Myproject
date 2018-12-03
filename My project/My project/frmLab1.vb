Public Class frmLab1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name, salary, salary_year
        Dim year = 12
        name = TextBox1.Text
        salary = TextBox2.Text
        salary = salary * year
        Label7.Text = TextBox1.Text
        Label8.Text = TextBox2.Text
        Label9.Text = salary_year
    End Sub
End Class