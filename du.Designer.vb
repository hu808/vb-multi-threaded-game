<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class du
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
        Me.凱特 = New System.Windows.Forms.Button()
        Me.海斗 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.確認 = New System.Windows.Forms.Button()
        Me.PictureBox0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '凱特
        '
        Me.凱特.BackgroundImage = Global.期末.My.Resources.Resources.凱特
        Me.凱特.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.凱特.Cursor = System.Windows.Forms.Cursors.Hand
        Me.凱特.Location = New System.Drawing.Point(306, 77)
        Me.凱特.Margin = New System.Windows.Forms.Padding(2)
        Me.凱特.Name = "凱特"
        Me.凱特.Size = New System.Drawing.Size(210, 161)
        Me.凱特.TabIndex = 3
        Me.凱特.UseVisualStyleBackColor = True
        '
        '海斗
        '
        Me.海斗.BackgroundImage = Global.期末.My.Resources.Resources.海斗
        Me.海斗.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.海斗.Cursor = System.Windows.Forms.Cursors.Hand
        Me.海斗.Location = New System.Drawing.Point(43, 77)
        Me.海斗.Margin = New System.Windows.Forms.Padding(2)
        Me.海斗.Name = "海斗"
        Me.海斗.Size = New System.Drawing.Size(210, 162)
        Me.海斗.TabIndex = 2
        Me.海斗.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("華康兒風體W4(P)", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "凱特隊"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("華康兒風體W4(P)", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "海斗隊"
        '
        '確認
        '
        Me.確認.BackColor = System.Drawing.Color.Tomato
        Me.確認.Cursor = System.Windows.Forms.Cursors.Hand
        Me.確認.Enabled = False
        Me.確認.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.確認.ForeColor = System.Drawing.Color.White
        Me.確認.Location = New System.Drawing.Point(238, 266)
        Me.確認.Name = "確認"
        Me.確認.Size = New System.Drawing.Size(83, 47)
        Me.確認.TabIndex = 4
        Me.確認.Text = "選擇"
        Me.確認.UseVisualStyleBackColor = False
        '
        'PictureBox0
        '
        Me.PictureBox0.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox0.Location = New System.Drawing.Point(38, 72)
        Me.PictureBox0.Name = "PictureBox0"
        Me.PictureBox0.Size = New System.Drawing.Size(220, 172)
        Me.PictureBox0.TabIndex = 19
        Me.PictureBox0.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(301, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 172)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'du
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.期末.My.Resources.Resources.遊戲背景_191224_0001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(564, 325)
        Me.Controls.Add(Me.確認)
        Me.Controls.Add(Me.凱特)
        Me.Controls.Add(Me.海斗)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox0)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "du"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請選擇陣營"
        CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 海斗 As Button
    Friend WithEvents 凱特 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents 確認 As Button
    Friend WithEvents PictureBox0 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
