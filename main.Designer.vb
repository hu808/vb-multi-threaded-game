<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.遊戲說明 = New System.Windows.Forms.Button()
        Me.進入遊戲 = New System.Windows.Forms.Button()
        Me.設定 = New System.Windows.Forms.Button()
        Me.重啟 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.餘額 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '遊戲說明
        '
        Me.遊戲說明.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.遊戲說明.Cursor = System.Windows.Forms.Cursors.Hand
        Me.遊戲說明.Font = New System.Drawing.Font("華康兒風體W4", 20.25!, System.Drawing.FontStyle.Bold)
        Me.遊戲說明.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.遊戲說明.Location = New System.Drawing.Point(458, 166)
        Me.遊戲說明.Margin = New System.Windows.Forms.Padding(2)
        Me.遊戲說明.Name = "遊戲說明"
        Me.遊戲說明.Size = New System.Drawing.Size(177, 62)
        Me.遊戲說明.TabIndex = 0
        Me.遊戲說明.Text = "遊戲說明"
        Me.遊戲說明.UseVisualStyleBackColor = False
        '
        '進入遊戲
        '
        Me.進入遊戲.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.進入遊戲.Cursor = System.Windows.Forms.Cursors.Hand
        Me.進入遊戲.Font = New System.Drawing.Font("華康兒風體W4", 20.25!, System.Drawing.FontStyle.Bold)
        Me.進入遊戲.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.進入遊戲.Location = New System.Drawing.Point(150, 166)
        Me.進入遊戲.Margin = New System.Windows.Forms.Padding(2)
        Me.進入遊戲.Name = "進入遊戲"
        Me.進入遊戲.Size = New System.Drawing.Size(177, 62)
        Me.進入遊戲.TabIndex = 1
        Me.進入遊戲.Text = "進入遊戲"
        Me.進入遊戲.UseVisualStyleBackColor = False
        '
        '設定
        '
        Me.設定.BackColor = System.Drawing.Color.Tomato
        Me.設定.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.設定.Cursor = System.Windows.Forms.Cursors.Hand
        Me.設定.Font = New System.Drawing.Font("華康兒風體W4", 15.75!, System.Drawing.FontStyle.Bold)
        Me.設定.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.設定.Location = New System.Drawing.Point(11, 11)
        Me.設定.Margin = New System.Windows.Forms.Padding(2)
        Me.設定.Name = "設定"
        Me.設定.Size = New System.Drawing.Size(71, 41)
        Me.設定.TabIndex = 3
        Me.設定.Text = "設定"
        Me.設定.UseVisualStyleBackColor = False
        '
        '重啟
        '
        Me.重啟.BackColor = System.Drawing.Color.Red
        Me.重啟.Cursor = System.Windows.Forms.Cursors.Hand
        Me.重啟.Font = New System.Drawing.Font("華康兒風體W4", 20.25!, System.Drawing.FontStyle.Bold)
        Me.重啟.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.重啟.Location = New System.Drawing.Point(710, 11)
        Me.重啟.Margin = New System.Windows.Forms.Padding(2)
        Me.重啟.Name = "重啟"
        Me.重啟.Size = New System.Drawing.Size(78, 62)
        Me.重啟.TabIndex = 4
        Me.重啟.Text = "重啟新局"
        Me.重啟.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(567, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "目前餘額(萬)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '餘額
        '
        Me.餘額.BackColor = System.Drawing.Color.Khaki
        Me.餘額.Font = New System.Drawing.Font("微軟正黑體", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.餘額.ForeColor = System.Drawing.Color.Maroon
        Me.餘額.Location = New System.Drawing.Point(567, 36)
        Me.餘額.Name = "餘額"
        Me.餘額.Size = New System.Drawing.Size(138, 60)
        Me.餘額.TabIndex = 6
        Me.餘額.Text = "100"
        Me.餘額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.期末.My.Resources.Resources.擷取
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.餘額)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.重啟)
        Me.Controls.Add(Me.設定)
        Me.Controls.Add(Me.進入遊戲)
        Me.Controls.Add(Me.遊戲說明)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "首頁"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 遊戲說明 As Button
    Friend WithEvents 進入遊戲 As Button
    Friend WithEvents 設定 As Button
    Friend WithEvents 重啟 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents 餘額 As Label
End Class
