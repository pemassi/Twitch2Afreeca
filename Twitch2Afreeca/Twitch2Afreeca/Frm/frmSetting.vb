Public Class frmSetting

    Dim Unload_Bool As Boolean

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_TwitchID.Text = Twitch_ID
        txt_UpdateTime.Text = Ref_sec
        txt_titleprefix.Text = Afreeca_Prefix
        txt_titlesuffix.Text = Afreeca_Suffix
        cb_AutoUpdate.Checked = Auto_PreSuffix

    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click

        SaveSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.USER_ID, txt_TwitchID.Text)
        SaveSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.REFRESH_SECOND, txt_UpdateTime.Text)
        SaveSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.AFREECA_PREFIX, txt_titleprefix.Text)
        SaveSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.AFREECA_SUFFIX, txt_titlesuffix.Text)
        SaveSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.AUTO_PRESUFFIX, cb_AutoUpdate.Checked)

        Twitch_ID = txt_TwitchID.Text
        Ref_sec = txt_UpdateTime.Text
        Afreeca_Prefix = txt_titleprefix.Text
        Afreeca_Suffix = txt_titlesuffix.Text
        Auto_PreSuffix = cb_AutoUpdate.Checked

        MsgBox("설정 적용 완료." & vbCrLf & vbCrLf & "다음 부터 적용됩니다.", vbInformation, "완료")
        Me.Close()

    End Sub
End Class