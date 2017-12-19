Public Class Form1


    Private Sub Explorateur_Click(sender As Object, e As EventArgs) Handles Explorateur.Click
        ' Explorateur.BackColor = Color.FromArgb(0, 102, 204)
    End Sub

    Private Sub Masque_Click(sender As Object, e As EventArgs) Handles Masque.Click
        If Panel_Left.Width = 148 Then
            Panel_Left.Width = 41
            Iron_Text.Visible = False

        Else
            Panel_Left.Width = 148
            Iron_Text.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Explorateur.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class
