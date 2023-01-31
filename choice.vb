Public Class choice
    Public Shared fish As Integer
    '粉色1
    Private Sub choice粉_Click(sender As Object, e As EventArgs) Handles choice粉.Click
        fish = 1
        Lb說明.Visible = False
        粉.Visible = True
        藍.Visible = False
        深藍.Visible = False
        紫.Visible = False
        橘.Visible = False
        黃.Visible = False
        綠.Visible = False
        choice藍.Image = Nothing
        choice深藍.Image = Nothing
        choice紫.Image = Nothing
        choice橘.Image = Nothing
        choice黃.Image = Nothing
        choice綠.Image = Nothing
    End Sub
    Private Sub choice粉_MouseEnter(sender As Object, e As EventArgs) Handles choice粉.MouseEnter
        粉.Visible = True
        choice粉.Image = My.Resources.choice粉_去背
    End Sub
    Private Sub choice粉_MouseLeavek(sender As Object, e As EventArgs) Handles choice粉.MouseLeave
        If fish = 1 Then
        Else
            choice粉.Image = Nothing
            粉.Visible = False
        End If
    End Sub
    '藍色2
    Private Sub choice藍_Click(sender As Object, e As EventArgs) Handles choice藍.Click
        fish = 2
        Lb說明.Visible = False
        粉.Visible = False
        藍.Visible = True
        深藍.Visible = False
        紫.Visible = False
        橘.Visible = False
        黃.Visible = False
        綠.Visible = False
        choice粉.Image = Nothing
        choice深藍.Image = Nothing
        choice紫.Image = Nothing
        choice橘.Image = Nothing
        choice黃.Image = Nothing
        choice綠.Image = Nothing
    End Sub
    Private Sub choice藍_MouseEnter(sender As Object, e As EventArgs) Handles choice藍.MouseEnter
        藍.Visible = True
        choice藍.Image = My.Resources.choice藍_去背
    End Sub
    Private Sub choice藍_MouseLeave(sender As Object, e As EventArgs) Handles choice藍.MouseLeave
        If fish = 2 Then
        Else
            choice藍.Image = Nothing
            藍.Visible = False
        End If
    End Sub
    '深藍色3
    Private Sub choice深藍_Click(sender As Object, e As EventArgs) Handles choice深藍.Click
        fish = 3
        Lb說明.Visible = False
        粉.Visible = False
        藍.Visible = False
        深藍.Visible = True
        紫.Visible = False
        橘.Visible = False
        黃.Visible = False
        綠.Visible = False
        choice粉.Image = Nothing
        choice藍.Image = Nothing
        choice紫.Image = Nothing
        choice橘.Image = Nothing
        choice黃.Image = Nothing
        choice綠.Image = Nothing
    End Sub
    Private Sub choice深藍_MouseEnter(sender As Object, e As EventArgs) Handles choice深藍.MouseEnter
        深藍.Visible = True
        choice深藍.Image = My.Resources.choice深藍_去背
    End Sub
    Private Sub choice深藍_MouseLeavek(sender As Object, e As EventArgs) Handles choice深藍.MouseLeave
        If fish = 3 Then
        Else
            choice深藍.Image = Nothing
            深藍.Visible = False
        End If
    End Sub
    '紫色4
    Private Sub choice紫_Click(sender As Object, e As EventArgs) Handles choice紫.Click
        fish = 4
        Lb說明.Visible = False
        粉.Visible = False
        藍.Visible = False
        深藍.Visible = False
        紫.Visible = True
        橘.Visible = False
        黃.Visible = False
        綠.Visible = False
        choice粉.Image = Nothing
        choice藍.Image = Nothing
        choice深藍.Image = Nothing
        choice橘.Image = Nothing
        choice黃.Image = Nothing
        choice綠.Image = Nothing
    End Sub
    Private Sub choice紫_MouseEnter(sender As Object, e As EventArgs) Handles choice紫.MouseEnter
        紫.Visible = True
        choice紫.Image = My.Resources.choice紫_去背
    End Sub
    Private Sub choice紫_MouseLeavek(sender As Object, e As EventArgs) Handles choice紫.MouseLeave
        If fish = 4 Then
        Else
            choice紫.Image = Nothing
            紫.Visible = False
        End If
    End Sub
    '橘色5
    Private Sub choice橘_Click(sender As Object, e As EventArgs) Handles choice橘.Click
        fish = 5
        Lb說明.Visible = False
        粉.Visible = False
        藍.Visible = False
        深藍.Visible = False
        紫.Visible = False
        橘.Visible = True
        黃.Visible = False
        綠.Visible = False
        choice粉.Image = Nothing
        choice藍.Image = Nothing
        choice深藍.Image = Nothing
        choice紫.Image = Nothing
        choice黃.Image = Nothing
        choice綠.Image = Nothing
    End Sub
    Private Sub choice橘_MouseEnter(sender As Object, e As EventArgs) Handles choice橘.MouseEnter
        橘.Visible = True
        choice橘.Image = My.Resources.choice橘_去背
    End Sub
    Private Sub choice橘_MouseLeavek(sender As Object, e As EventArgs) Handles choice橘.MouseLeave
        If fish = 5 Then
        Else
            choice橘.Image = Nothing
            橘.Visible = False
        End If
    End Sub
    '黃色6
    Private Sub choice黃_Click(sender As Object, e As EventArgs) Handles choice黃.Click
        fish = 6
        Lb說明.Visible = False
        粉.Visible = False
        藍.Visible = False
        深藍.Visible = False
        紫.Visible = False
        橘.Visible = False
        黃.Visible = True
        綠.Visible = False
        choice粉.Image = Nothing
        choice藍.Image = Nothing
        choice深藍.Image = Nothing
        choice紫.Image = Nothing
        choice橘.Image = Nothing
        choice綠.Image = Nothing
    End Sub
    Private Sub choice黃_MouseEnter(sender As Object, e As EventArgs) Handles choice黃.MouseEnter
        黃.Visible = True
        choice黃.Image = My.Resources.choice黃_去背
    End Sub
    Private Sub choice黃_MouseLeavek(sender As Object, e As EventArgs) Handles choice黃.MouseLeave
        If fish = 6 Then
        Else
            choice黃.Image = Nothing
            黃.Visible = False
        End If
    End Sub
    '綠色7
    Private Sub choice綠_Click(sender As Object, e As EventArgs) Handles choice綠.Click
        fish = 7
        Lb說明.Visible = False
        粉.Visible = False
        藍.Visible = False
        深藍.Visible = False
        紫.Visible = False
        橘.Visible = False
        黃.Visible = False
        綠.Visible = True
        choice粉.Image = Nothing
        choice藍.Image = Nothing
        choice深藍.Image = Nothing
        choice紫.Image = Nothing
        choice橘.Image = Nothing
        choice黃.Image = Nothing
    End Sub
    Private Sub choice綠_MouseEnter(sender As Object, e As EventArgs) Handles choice綠.MouseEnter
        綠.Visible = True
        choice綠.Image = My.Resources.choice綠_去背
    End Sub
    Private Sub choice綠_MouseLeavek(sender As Object, e As EventArgs) Handles choice綠.MouseLeave
        If fish = 7 Then
        Else
            choice綠.Image = Nothing
            綠.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case fish
            Case 1
                MsgBox("玩家已選擇海斗方出戰人員---粉色珍珠-七海露亞", 0, "海斗方出戰美人魚公主")
            Case 2
                MsgBox("玩家已選擇海斗方出戰人員---水色珍珠-寶生波音", 0, "海斗方出戰美人魚公主")
            Case 3
                MsgBox("玩家已選擇海斗方出戰人員---藍色珍珠-加琳諾葳爾", 0, "海斗方出戰美人魚公主")
            Case 4
                MsgBox("玩家已選擇海斗方出戰人員---紫色珍珠-加琳香蓮", 0, "海斗方出戰美人魚公主")
            Case 5
                MsgBox("玩家已選擇海斗方出戰人員---橙色珍珠-織本沙羅", 0, "海斗方出戰美人魚公主")
            Case 6
                MsgBox("玩家已選擇海斗方出戰人員---黃色珍珠-夏奈可可", 0, "海斗方出戰美人魚公主")
            Case 7
                MsgBox("玩家已選擇海斗方出戰人員---碧色珍珠-洞院莉娜", 0, "海斗方出戰美人魚公主")
        End Select
        Me.Hide()
        bad.Dispose()
        bad.Show()
    End Sub
End Class