<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.설정SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.정보CtrlIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_status = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Twitch = New System.Windows.Forms.TextBox()
        Me.txt_Afreeca = New System.Windows.Forms.TextBox()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.ti_Check = New System.Windows.Forms.Timer(Me.components)
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.설정SToolStripMenuItem, Me.정보CtrlIToolStripMenuItem})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(426, 24)
        Me.menu.TabIndex = 2
        Me.menu.Text = "MenuStrip1"
        '
        '설정SToolStripMenuItem
        '
        Me.설정SToolStripMenuItem.Name = "설정SToolStripMenuItem"
        Me.설정SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.설정SToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.설정SToolStripMenuItem.Text = "설정(&S)"
        '
        '정보CtrlIToolStripMenuItem
        '
        Me.정보CtrlIToolStripMenuItem.Name = "정보CtrlIToolStripMenuItem"
        Me.정보CtrlIToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.정보CtrlIToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.정보CtrlIToolStripMenuItem.Text = "정보(&I)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "아프리카 Freecshot 실행 상태"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_status
        '
        Me.lb_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lb_status.ForeColor = System.Drawing.Color.Red
        Me.lb_status.Location = New System.Drawing.Point(135, 66)
        Me.lb_status.Name = "lb_status"
        Me.lb_status.Size = New System.Drawing.Size(168, 16)
        Me.lb_status.TabIndex = 4
        Me.lb_status.Text = "실행 중이지 않음"
        Me.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "현재 Twitch 방송제목"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "현재 Afreeca 방송제목"
        '
        'txt_Twitch
        '
        Me.txt_Twitch.Location = New System.Drawing.Point(155, 106)
        Me.txt_Twitch.Name = "txt_Twitch"
        Me.txt_Twitch.Size = New System.Drawing.Size(241, 21)
        Me.txt_Twitch.TabIndex = 7
        '
        'txt_Afreeca
        '
        Me.txt_Afreeca.Location = New System.Drawing.Point(155, 140)
        Me.txt_Afreeca.Name = "txt_Afreeca"
        Me.txt_Afreeca.Size = New System.Drawing.Size(241, 21)
        Me.txt_Afreeca.TabIndex = 8
        '
        'btn_Update
        '
        Me.btn_Update.Location = New System.Drawing.Point(12, 193)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(402, 23)
        Me.btn_Update.TabIndex = 10
        Me.btn_Update.Text = "자동 업데이트 시작"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'ti_Check
        '
        Me.ti_Check.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 230)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.txt_Afreeca)
        Me.Controls.Add(Me.txt_Twitch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lb_status)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menu)
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "Twitch to Afreeca"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu As MenuStrip
    Friend WithEvents 설정SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 정보CtrlIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_status As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Twitch As TextBox
    Friend WithEvents txt_Afreeca As TextBox
    Friend WithEvents btn_Update As Button
    Friend WithEvents ti_Check As Timer
End Class
