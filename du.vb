Public Class du
    Public Shared team As Integer
    Private Sub 海斗_Click(sender As Object, e As EventArgs) Handles 海斗.Click
        team = 0
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Black
        PictureBox0.BackColor = Color.Red
        PictureBox1.BackColor = Color.Transparent
        確認.Enabled = True
    End Sub

    Private Sub 凱特_Click(sender As Object, e As EventArgs) Handles 凱特.Click
        team = 1
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Red
        PictureBox0.BackColor = Color.Transparent
        PictureBox1.BackColor = Color.Red
        確認.Enabled = True
    End Sub

    Private Sub 確認_Click(sender As Object, e As EventArgs) Handles 確認.Click

        If team = 0 Then
            MsgBox("恭喜玩家加入 海斗 陣營!!" & vbCrLf & "接下來請選擇出戰角色!!", 0, "陣營")
        ElseIf team = 1 Then
            MsgBox("恭喜玩家加入 凱特 陣營!!" & vbCrLf & "接下來請選擇出戰角色!!", 0, "陣營")
        End If
        Me.Hide()
        choice.Dispose()
        choice.Show()
    End Sub
End Class