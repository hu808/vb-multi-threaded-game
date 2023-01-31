Public Class run
    Dim THREAD1, THREAD2 As System.Threading.Thread
    Dim fishswim = 0, badswim = 0
    Dim a = 0, b = 0
    Private Sub 開始頁面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        爆炸.Visible = False
        變身.Visible = False
        Timer1.Enabled = False
        Me.CheckForIllegalCrossThreadCalls = False
        目前餘額.Text = main.money
        '隊伍
        If du.team = 0 Then
            選擇陣營.Text = "海斗方"
        ElseIf du.team = 1 Then
            選擇陣營.Text = "凱特方"
        End If
        '美人魚
        Select Case choice.fish
            Case 1
                海斗方.Image = My.Resources.游泳_粉1
                變身.Image = My.Resources.游泳_粉1
            Case 2
                海斗方.Image = My.Resources.游泳_藍1
                變身.Image = My.Resources.游泳_藍1
            Case 3
                海斗方.Image = My.Resources.游泳_深藍1
                變身.Image = My.Resources.游泳_深藍1
            Case 4
                海斗方.Image = My.Resources.游泳_紫1
                變身.Image = My.Resources.游泳_紫1
            Case 5
                海斗方.Image = My.Resources.游泳_橘1
                變身.Image = My.Resources.游泳_橘1
            Case 6
                海斗方.Image = My.Resources.游泳_黃1
                變身.Image = My.Resources.游泳_黃1
            Case 7
                海斗方.Image = My.Resources.游泳_綠1
                變身.Image = My.Resources.游泳_綠1
        End Select
        '反派
        Select Case bad.bad
            Case 1
                凱特方.Image = My.Resources.反派一_不動
                凱特方攻擊.Image = My.Resources.攻擊_反派一_1
            Case 2
                凱特方.Image = My.Resources.反派二_不動
                凱特方攻擊.Image = My.Resources.攻擊_反派二_1
            Case 3
                凱特方.Image = My.Resources.反派三_不動
                凱特方攻擊.Image = My.Resources.攻擊_反派三_1
            Case 4
                凱特方.Image = My.Resources.反派四_不動
                凱特方攻擊.Image = My.Resources.攻擊_反派四_1
            Case 5
                凱特方.Image = My.Resources.反派五_不動
                凱特方攻擊.Image = My.Resources.攻擊_反派五_1
        End Select
    End Sub

    Private Sub 回首頁_Click(sender As Object, e As EventArgs) Handles 回首頁.Click
        main.餘額.Text = main.money
        Me.Hide()
        main.Show()
    End Sub

    Private Sub 確認下注_Click(sender As Object, e As EventArgs) Handles 確認下注.Click
        If 賭金.Text = Nothing Then
            MsgBox("賭金不可為空", 0 + 64, "設立賭金")
        ElseIf Not IsNumeric(賭金.Text) Then
            MsgBox("欄位輸入必須為數值", 0 + 64, "設立賭金")
        ElseIf 賭金.Text < 1 Then
            MsgBox("賭金不可為負或為0", 0 + 64, "設立賭金")
        ElseIf 賭金.Text > main.money Then
            MsgBox("賭金不可大於資產", 0 + 64, "設立賭金")
        Else
            MsgBox("已設立賭金為" + 賭金.Text + "萬元", 0 + 64, "設立賭金")
            開始比賽.Enabled = True
        End If
    End Sub

    Private Sub 開始比賽_Click(sender As Object, e As EventArgs) Handles 開始比賽.Click
        爆炸.Visible = False
        變身.Visible = False
        '變身.Image = 海斗方.Image
        If main.money <= 0 Then
            MsgBox("餘額不足，請回首頁重啟遊戲...", 0 + 16, "You are broke...")
        ElseIf main.money < 賭金.Text Then
            MsgBox("餘額不足以支付賭金，請重新設定賭金...", 0 + 16, "Can't start...")
        Else
            回首頁.Enabled = False
            確認下注.Enabled = False
            開始比賽.Enabled = False
            THREAD1 = New System.Threading.Thread(AddressOf Me.COUNTUP)
            THREAD2 = New System.Threading.Thread(AddressOf Me.COUNTUP2)
            THREAD1.IsBackground = True
            THREAD2.IsBackground = True
            THREAD1.Start()
            THREAD2.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        b = b + 1
        If b < 5 Then
            If a = 0 Then
                變身.Image = 海斗方.Image
                a = 1
            Else
                變身.Image = Nothing
                a = 0
            End If
        Else
            Select Case choice.fish
                Case 1
                    變身.Image = My.Resources.變身_粉
                Case 2
                    變身.Image = My.Resources.變身_藍
                Case 3
                    變身.Image = My.Resources.變身_深藍
                Case 4
                    變身.Image = My.Resources.變身_紫
                Case 5
                    變身.Image = My.Resources.變身_橘
                Case 6
                    變身.Image = My.Resources.變身_黃
                Case 7
                    變身.Image = My.Resources.變身_綠
            End Select
            b = 0
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub COUNTUP()
        Try
            For t1 As Integer = 0 To 291
                'th1 = t1.ToString
                Label3.Text = 582 - t1 * 2
                凱特方攻擊.Left = t1 * 2 + 38
                If badswim = 0 Then
                    badswim = 1
                ElseIf badswim = 1 Then
                    badswim = 2
                ElseIf badswim = 2 Then
                    badswim = 3
                ElseIf badswim = 3 Then
                    badswim = 4
                ElseIf badswim = 4 Then
                    badswim = 5
                ElseIf badswim = 5 Then
                    badswim = 6
                ElseIf badswim = 6 Then
                    badswim = 7
                ElseIf badswim = 7 Then
                    badswim = 0
                End If
                If badswim = 0 Or badswim = 1 Or badswim = 2 Or badswim = 3 Then
                    Select Case bad.bad
                        Case 1
                            凱特方攻擊.Image = My.Resources.攻擊_反派一_1
                        Case 2
                            凱特方攻擊.Image = My.Resources.攻擊_反派二_1
                        Case 3
                            凱特方攻擊.Image = My.Resources.攻擊_反派三_1
                        Case 4
                            凱特方攻擊.Image = My.Resources.攻擊_反派四_1
                        Case 5
                            凱特方攻擊.Image = My.Resources.攻擊_反派五_1
                    End Select
                Else
                    Select Case bad.bad
                        Case 1
                            凱特方攻擊.Image = My.Resources.攻擊_反派一_2
                        Case 2
                            凱特方攻擊.Image = My.Resources.攻擊_反派二_2
                        Case 3
                            凱特方攻擊.Image = My.Resources.攻擊_反派三_2
                        Case 4
                            凱特方攻擊.Image = My.Resources.攻擊_反派四_2
                        Case 5
                            凱特方攻擊.Image = My.Resources.攻擊_反派五_2
                    End Select
                End If
            Next
            THREAD2.Suspend()
            Select Case du.team
                Case 0
                    爆炸.Visible = True
                    MsgBox("凱特方 Win !!! " & vbCrLf & "玩家陣營失敗 (✖╭╮✖)", 0, "You Lose your money")
                    main.money = main.money - 賭金.Text
                    目前餘額.Text = main.money
                    回首頁.Enabled = True
                    確認下注.Enabled = True
                    開始比賽.Enabled = True
                Case 1
                    爆炸.Visible = True
                    MsgBox("凱特方 Win !!! " & vbCrLf & "恭喜玩家陣營獲勝~ ~ ~Ｏ(≧▽≦)Ｏ", 0, "Win money")
                    main.money = main.money + 賭金.Text
                    目前餘額.Text = main.money
                    回首頁.Enabled = True
                    確認下注.Enabled = True
                    開始比賽.Enabled = True
            End Select
            If main.money >= 1000 Then
                MsgBox("恭喜玩家獲得" & """" & "賭神" & """" & "稱號" & vbCrLf & "   ✧*｡٩(ˊᗜˋ*)و✧*", 0, "獲得稱號")
            End If
        Catch ex As Exception
            THREAD2.Suspend()
            回首頁.Enabled = True
            確認下注.Enabled = True
            開始比賽.Enabled = True
            MsgBox("裁判暈倒了，比賽重新開始!!!" & vbCrLf & "      ╮(╯_╰)╭", 0, "例外事件")
            THREAD1.Suspend()
        End Try
    End Sub

    Private Sub COUNTUP2()
        Try
            For t2 As Integer = 0 To 291
                'th2 = t2.ToString
                Label4.Text = 582 - t2 * 2
                海斗方.Left = t2 * 2
                If fishswim = 0 Then
                    fishswim = 1
                ElseIf badswim = 1 Then
                    fishswim = 2
                ElseIf fishswim = 2 Then
                    fishswim = 3
                ElseIf fishswim = 3 Then
                    fishswim = 4
                ElseIf fishswim = 4 Then
                    fishswim = 5
                ElseIf fishswim = 5 Then
                    fishswim = 6
                ElseIf fishswim = 6 Then
                    fishswim = 7
                ElseIf fishswim = 7 Then
                    fishswim = 0
                End If
                If fishswim = 0 Or fishswim = 1 Or fishswim = 2 Or fishswim = 3 Then
                    Select Case choice.fish
                        Case 1
                            海斗方.Image = My.Resources.游泳_粉1
                        Case 2
                            海斗方.Image = My.Resources.游泳_藍1
                        Case 3
                            海斗方.Image = My.Resources.游泳_深藍1
                        Case 4
                            海斗方.Image = My.Resources.游泳_紫1
                        Case 5
                            海斗方.Image = My.Resources.游泳_橘1
                        Case 6
                            海斗方.Image = My.Resources.游泳_黃1
                        Case 7
                            海斗方.Image = My.Resources.游泳_綠1
                    End Select
                Else
                    Select Case choice.fish
                        Case 1
                            海斗方.Image = My.Resources.游泳_粉2
                        Case 2
                            海斗方.Image = My.Resources.游泳_藍2
                        Case 3
                            海斗方.Image = My.Resources.游泳_深藍2
                        Case 4
                            海斗方.Image = My.Resources.游泳_紫2
                        Case 5
                            海斗方.Image = My.Resources.游泳_橘2
                        Case 6
                            海斗方.Image = My.Resources.游泳_黃2
                        Case 7
                            海斗方.Image = My.Resources.游泳_綠2
                    End Select
                End If
            Next
            THREAD1.Suspend()
            Select Case du.team
                Case 0
                    變身.Visible = True
                    Timer1.Enabled = True
                    MsgBox("海斗方 Win !!! " & vbCrLf & "恭喜玩家陣營獲勝~ ~ ~Ｏ(≧▽≦)Ｏ", 0, "Win money")
                    main.money = main.money + 賭金.Text
                    目前餘額.Text = main.money
                    回首頁.Enabled = True
                    確認下注.Enabled = True
                    開始比賽.Enabled = True
                Case 1
                    變身.Visible = True
                    Timer1.Enabled = True
                    MsgBox("海斗方 Win !!! " & vbCrLf & "玩家陣營失敗 (✖╭╮✖)", 0, "You Lose your money")
                    main.money = main.money - 賭金.Text
                    目前餘額.Text = main.money
                    回首頁.Enabled = True
                    確認下注.Enabled = True
                    開始比賽.Enabled = True
            End Select
            If main.money >= 1000 Then
                MsgBox("恭喜玩家獲得" & """" & "賭神" & """" & "稱號" & vbCrLf & "   ✧*｡٩(ˊᗜˋ*)و✧*", 0, "獲得稱號")
            End If
        Catch ex As Exception
            THREAD1.Suspend()
            回首頁.Enabled = True
            確認下注.Enabled = True
            開始比賽.Enabled = True
            MsgBox("裁判暈倒了，比賽重新開始!!!" & vbCrLf & "      ╮(╯_╰)╭", 0, "例外事件")
            THREAD2.Suspend()
        End Try
    End Sub
End Class