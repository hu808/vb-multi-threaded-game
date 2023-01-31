Public Class explain
    Dim page = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()
    End Sub

    Private Sub 下一頁_Click(sender As Object, e As EventArgs) Handles 下一頁.Click
        Select Case page
            Case 1
                page = page + 1
                頁數.Text = "2/5"
                說明頁.Image = My.Resources.說明2
            Case 2
                page = page + 1
                頁數.Text = "3/5"
                說明頁.Image = My.Resources.說明3
            Case 3
                page = page + 1
                頁數.Text = "4/5"
                說明頁.Image = My.Resources.說明4
            Case 4
                page = page + 1
                頁數.Text = "5/5"
                說明頁.Image = My.Resources.說明5
            Case 5
                MsgBox("這是最後一頁囉 ~ ~", 0, "提醒")
        End Select
    End Sub

    Private Sub 上一頁_Click(sender As Object, e As EventArgs) Handles 上一頁.Click
        Select Case page
            Case 5
                page = page - 1
                頁數.Text = "4/5"
                說明頁.Image = My.Resources.說明4
            Case 4
                page = page - 1
                頁數.Text = "3/5"
                說明頁.Image = My.Resources.說明3
            Case 3
                page = page - 1
                頁數.Text = "2/5"
                說明頁.Image = My.Resources.說明2
            Case 2
                page = page - 1
                頁數.Text = "1/5"
                說明頁.Image = My.Resources.說明1
            Case 1
                MsgBox("這是第一頁喔 ~ ~", 0, "提醒")
        End Select
    End Sub
End Class