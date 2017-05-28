<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetting
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_TwitchID = New System.Windows.Forms.TextBox()
        Me.txt_UpdateTime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.txt_titleprefix = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_titlesuffix = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_AutoUpdate = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Twitch ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "업데이트 주기"
        '
        'txt_TwitchID
        '
        Me.txt_TwitchID.Location = New System.Drawing.Point(98, 20)
        Me.txt_TwitchID.Name = "txt_TwitchID"
        Me.txt_TwitchID.Size = New System.Drawing.Size(130, 21)
        Me.txt_TwitchID.TabIndex = 2
        '
        'txt_UpdateTime
        '
        Me.txt_UpdateTime.Location = New System.Drawing.Point(98, 54)
        Me.txt_UpdateTime.Name = "txt_UpdateTime"
        Me.txt_UpdateTime.Size = New System.Drawing.Size(130, 21)
        Me.txt_UpdateTime.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "초"
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(122, 270)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 5
        Me.btn_OK.Text = "확인"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(203, 270)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 6
        Me.btn_Cancel.Text = "취소"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'txt_titleprefix
        '
        Me.txt_titleprefix.Location = New System.Drawing.Point(98, 55)
        Me.txt_titleprefix.Name = "txt_titleprefix"
        Me.txt_titleprefix.Size = New System.Drawing.Size(130, 21)
        Me.txt_titleprefix.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "접두어"
        '
        'txt_titlesuffix
        '
        Me.txt_titlesuffix.Location = New System.Drawing.Point(98, 92)
        Me.txt_titlesuffix.Name = "txt_titlesuffix"
        Me.txt_titlesuffix.Size = New System.Drawing.Size(130, 21)
        Me.txt_titlesuffix.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "접미어"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_AutoUpdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_titlesuffix)
        Me.GroupBox1.Controls.Add(Me.txt_titleprefix)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 127)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "아프리카 방송 제목"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_UpdateTime)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_TwitchID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 100)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "기본 설정"
        '
        'cb_AutoUpdate
        '
        Me.cb_AutoUpdate.AutoSize = True
        Me.cb_AutoUpdate.Location = New System.Drawing.Point(100, 26)
        Me.cb_AutoUpdate.Name = "cb_AutoUpdate"
        Me.cb_AutoUpdate.Size = New System.Drawing.Size(128, 16)
        Me.cb_AutoUpdate.TabIndex = 11
        Me.cb_AutoUpdate.Text = "방송제목 자동 생성"
        Me.cb_AutoUpdate.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 306)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "설정"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_TwitchID As TextBox
    Friend WithEvents txt_UpdateTime As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_OK As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents txt_titleprefix As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_titlesuffix As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb_AutoUpdate As CheckBox
End Class
