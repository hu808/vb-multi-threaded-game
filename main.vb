Public Class main
    Public Shared money As Integer
    Private Sub 遊戲說明_Click(sender As Object, e As EventArgs) Handles 遊戲說明.Click
        Me.Hide()
        explain.Show()
    End Sub

    Private Sub 設定_Click(sender As Object, e As EventArgs) Handles 設定.Click
        setset.Show()
    End Sub
    Sub Music()
        My.Computer.Audio.Play(My.Resources.KODOU, AudioPlayMode.BackgroundLoop)
    End Sub

    Sub StopMusic()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Music()
        money = 100
        餘額.Text = money
    End Sub

    Private Sub main_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        StopMusic()
        Application.Exit()
    End Sub

    Private Sub 進入遊戲_Click(sender As Object, e As EventArgs) Handles 進入遊戲.Click
        If 餘額.Text <= 0 Then
            MsgBox("呵呵，餘額不足，請砍掉重練~", 0 + 16, "You are broke")
        Else
            du.Dispose()
            du.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub 重啟_Click(sender As Object, e As EventArgs) Handles 重啟.Click
        If MsgBox("是否確認重啟新局?", MsgBoxStyle.YesNo, "重啟") = MsgBoxResult.Yes Then
            money = 100
            餘額.Text = money
        End If
    End Sub
End Class