<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class explain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.說明頁 = New System.Windows.Forms.PictureBox()
        Me.下一頁 = New System.Windows.Forms.Button()
        Me.上一頁 = New System.Windows.Forms.Button()
        Me.頁數 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.說明頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("華康兒風體W4(P)", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 13)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "遊戲規則"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("華康勘亭流", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Pink
        Me.Button1.Location = New System.Drawing.Point(755, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.期末.My.Resources.Resources.貝殼
        Me.PictureBox1.Location = New System.Drawing.Point(27, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        '說明頁
        '
        Me.說明頁.BackColor = System.Drawing.Color.Transparent
        Me.說明頁.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.說明頁.Image = Global.期末.My.Resources.Resources.說明1
        Me.說明頁.Location = New System.Drawing.Point(174, 73)
        Me.說明頁.Margin = New System.Windows.Forms.Padding(2)
        Me.說明頁.Name = "說明頁"
        Me.說明頁.Size = New System.Drawing.Size(478, 322)
        Me.說明頁.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.說明頁.TabIndex = 5
        Me.說明頁.TabStop = False
        '
        '下一頁
        '
        Me.下一頁.BackColor = System.Drawing.Color.CornflowerBlue
        Me.下一頁.Cursor = System.Windows.Forms.Cursors.Hand
        Me.下一頁.Font = New System.Drawing.Font("華康勘亭流", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.下一頁.ForeColor = System.Drawing.Color.Pink
        Me.下一頁.Location = New System.Drawing.Point(644, 471)
        Me.下一頁.Margin = New System.Windows.Forms.Padding(2)
        Me.下一頁.Name = "下一頁"
        Me.下一頁.Size = New System.Drawing.Size(125, 45)
        Me.下一頁.TabIndex = 6
        Me.下一頁.Text = "Next>>>"
        Me.下一頁.UseVisualStyleBackColor = False
        '
        '上一頁
        '
        Me.上一頁.BackColor = System.Drawing.Color.CornflowerBlue
        Me.上一頁.Cursor = System.Windows.Forms.Cursors.Hand
        Me.上一頁.Font = New System.Drawing.Font("華康勘亭流", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.上一頁.ForeColor = System.Drawing.Color.Pink
        Me.上一頁.Location = New System.Drawing.Point(43, 471)
        Me.上一頁.Margin = New System.Windows.Forms.Padding(2)
        Me.上一頁.Name = "上一頁"
        Me.上一頁.Size = New System.Drawing.Size(125, 45)
        Me.上一頁.TabIndex = 7
        Me.上一頁.Text = "<<<Back"
        Me.上一頁.UseVisualStyleBackColor = False
        '
        '頁數
        '
        Me.頁數.AutoSize = True
        Me.頁數.BackColor = System.Drawing.Color.Transparent
        Me.頁數.Font = New System.Drawing.Font("華康芸風體W3", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.頁數.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.頁數.Location = New System.Drawing.Point(360, 471)
        Me.頁數.Name = "頁數"
        Me.頁數.Size = New System.Drawing.Size(95, 48)
        Me.頁數.TabIndex = 8
        Me.頁數.Text = "1/5"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.期末.My.Resources.Resources.書
        Me.PictureBox2.Location = New System.Drawing.Point(82, 51)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(646, 427)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'explain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.期末.My.Resources.Resources.背景2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 539)
        Me.Controls.Add(Me.頁數)
        Me.Controls.Add(Me.上一頁)
        Me.Controls.Add(Me.下一頁)
        Me.Controls.Add(Me.說明頁)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "explain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "遊戲說明"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.說明頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents 說明頁 As PictureBox
    Friend WithEvents 下一頁 As Button
    Friend WithEvents 上一頁 As Button
    Friend WithEvents 頁數 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
