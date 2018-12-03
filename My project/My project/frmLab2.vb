Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vistra, fristra As Integer
        Dim comvis, comfris, total, com As Long

        vistra = txtvis.Text
        fristra = txtfris.Text
        total = vistra + fristra
        lblSumsalse.Text = total

        comvis = txtvis.Text * 0.05
        comfris = txtfris.Text * 0.1
        com = comvis + comfris
        lblcom5.Text = comvis
        lblcom10.Text = comfris
        lblcomsum.Text = com

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
