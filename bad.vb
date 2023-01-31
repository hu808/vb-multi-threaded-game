Public Class bad
    Public Shared bad As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bad = 1
        Button6.Enabled = True
        PictureBox1.BackColor = Color.Red
        PictureBox2.BackColor = Color.Transparent
        PictureBox3.BackColor = Color.Transparent
        PictureBox4.BackColor = Color.Transparent
        PictureBox5.BackColor = Color.Transparent
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bad = 2
        Button6.Enabled = True
        PictureBox1.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Red
        PictureBox3.BackColor = Color.Transparent
        PictureBox4.BackColor = Color.Transparent
        PictureBox5.BackColor = Color.Transparent
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bad = 3
        Button6.Enabled = True
        PictureBox1.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        PictureBox3.BackColor = Color.Red
        PictureBox4.BackColor = Color.Transparent
        PictureBox5.BackColor = Color.Transparent
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bad = 4
        Button6.Enabled = True
        PictureBox1.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        PictureBox3.BackColor = Color.Transparent
        PictureBox4.BackColor = Color.Red
        PictureBox5.BackColor = Color.Transparent
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        bad = 5
        Button6.Enabled = True
        PictureBox1.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        PictureBox3.BackColor = Color.Transparent
        PictureBox4.BackColor = Color.Transparent
        PictureBox5.BackColor = Color.Red
    End Sub

    Private Sub 選擇_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case bad
            Case 1
                MsgBox("玩家已選擇凱特方出戰人員---蝙蝠小姐", 0, "凱特方出戰人員")
            Case 2
                MsgBox("玩家已選擇凱特方出戰人員---黑暗戀人-愛莉爾", 0, "凱特方出戰人員")
            Case 3
                MsgBox("玩家已選擇凱特方出戰人員---黑暗戀人-悠莉", 0, "凱特方出戰人員")
            Case 4
                MsgBox("玩家已選擇凱特方出戰人員---黑美人姐妹花-秀秀", 0, "凱特方出戰人員")
            Case 5
                MsgBox("玩家已選擇凱特方出戰人員---黑美人姐妹花-咪咪", 0, "凱特方出戰人員")
        End Select
        Me.Hide()
        run.Dispose()
        run.Show()
    End Sub
End Class