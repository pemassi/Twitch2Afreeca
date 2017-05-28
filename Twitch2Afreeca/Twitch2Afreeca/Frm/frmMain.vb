Imports System.ComponentModel

Public Class frmMain

    Dim Afreeca_hWnd As IntPtr '// 아프리카 방제 텍스트박스 핸들
    Dim Previous_Title As String
    Dim Thread As Threading.Thread
    Delegate Sub Update_Titles_Invoke(Twitch As String, Afreeca As String)


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If GetSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.REFRESH_SECOND) = "" Then

            '// 초기 설정이 없는 경우, 기본 설정 저장.
            SaveSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.REFRESH_SECOND, 10)
            SaveSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.AUTO_PRESUFFIX, 0)

            Ref_sec = 10
            Auto_PreSuffix = False

        Else

            Twitch_ID = GetSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.USER_ID)
            Ref_sec = GetSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.REFRESH_SECOND)
            Afreeca_Prefix = GetSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.AFREECA_PREFIX)
            Afreeca_Suffix = GetSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.AFREECA_SUFFIX)
            Auto_PreSuffix = GetSetting(Setting.PROGRAM_NAME, Setting.SETTING, Setting.AUTO_PRESUFFIX)

        End If

        Check_FreecShot()

        txt_Afreeca.Enabled = False
        txt_Twitch.Enabled = False

    End Sub


    Private Sub Update_Titles(Twitch As String, Afreeca As String)


        If Me.txt_Twitch.InvokeRequired Or Me.txt_Afreeca.InvokeRequired Then
            Dim d As New Update_Titles_Invoke(AddressOf Update_Titles)
            Me.Invoke(d, New Object() {Twitch, Afreeca})
        Else
            Me.txt_Twitch.Text = Twitch
            Me.txt_Afreeca.Text = Afreeca
        End If


    End Sub

    Private Function Get_AfreecaHwnd() As Long

        Dim Temp_Hwnd As IntPtr
        Temp_Hwnd = API.FindWindow(Nothing, Afreeca_Caption) '// 아프리카 스튜디오 핸들
        Temp_Hwnd = API.FindWindowEx(Temp_Hwnd, IntPtr.Zero, Nothing, "BroadInfo Window") '// 아프리카 스튜디오 자식 창(방송정보)
        Temp_Hwnd = API.FindWindowEx(Temp_Hwnd, IntPtr.Zero, "CAFCEditCtrl", vbNullString) '// 아프리카 방제 수정 텍스트 박스

        Return Temp_Hwnd

    End Function

    Private Function Check_FreecShot() As Boolean

        Afreeca_hWnd = Get_AfreecaHwnd()

        If Afreeca_hWnd <> 0 Then
            lb_status.Text = "실행 중"
            lb_status.ForeColor = Color.Green

            ti_Check.Interval = 5000
            ti_Check.Enabled = True
            Return True
        Else
            lb_status.Text = "실행 중이지 않음"
            lb_status.ForeColor = Color.Red

            ti_Check.Interval = 1000
            ti_Check.Enabled = True
            Return False
        End If

    End Function

    Private Function Get_TwitchTitle(API_Bool As Boolean) As String
        Dim WinHttp As New WinHttp.WinHttpRequest
        Dim Title As String

        If API_Bool = True Then

            WinHttp.Open("GET", "https://api.twitch.tv/kraken/channels/" & Twitch_ID & "/?client_id=b9gfab38bjb7avyvgna7grv7njawln", True) '// 트위치 API 사용
            WinHttp.SetRequestHeader("User-Agent", "Mozilla/4.0 (Compatible; MSIE 8.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727")
            WinHttp.Send()
            WinHttp.WaitForResponse(10)

            Title = Split(Split(WinHttp.ResponseText, "," & Chr(34) & "status" & Chr(34) & ":" & Chr(34))(1), Chr(34))(0) '// 잘라서 트위치 방제 추출
            WinHttp.Abort()

        Else

            WinHttp.Open("GET", "https://www.twitch.tv/" & Twitch_ID, True) '// 트위치 API 사용안함
            WinHttp.SetRequestHeader("User-Agent", "Mozilla/4.0 (Compatible; MSIE 8.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727")
            WinHttp.Send()
            WinHttp.WaitForResponse(10)

            '// !! 트위치 방송 제목에 HTML 문법에 영향('/' 같은 것)을 주는 문자가 있는 경우 해결.
            Title = Split(Split(Split(WinHttp.ResponseText, "property='og:description'>")(0), "property='og:url'>")(1), "<meta content=")(1).Replace("""", "").Replace("'", "")
            'Title = Split(Split(Split(WinHttp.ResponseText, "' property='og:description'>")(0), " property='og:url'>")(1), "<meta content='")(1)

            WinHttp.Abort()

        End If

        Return Title

    End Function

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click

        If btn_Update.Text = "자동 업데이트 시작" Then

            If Twitch_ID = "" Then MsgBox("설정에서 Twitch ID를 설정해주세요.", vbExclamation, "오류") : Exit Sub
            If Check_FreecShot() = False Then MsgBox("FreecShot이 감지되지 않습니다.", vbExclamation, "오류") : Exit Sub

            Thread = New Threading.Thread(AddressOf Me.Thread_DoWork)

            Thread.Start()
            btn_Update.Text = "자동 업데이트 중지"

        Else

            Thread.Abort()
            btn_Update.Text = "자동 업데이트 시작"

        End If


    End Sub

    Private Function Update_AfreecaTitle(Title As String) As Boolean

        Afreeca_hWnd = Get_AfreecaHwnd()

        If Afreeca_hWnd <> 0 Then
            API.SendMessage(Afreeca_hWnd, WM_SETTEXT, 0&, Title) '// 합친 방제를 아프리카 텍스트 박스에 전송
            API.SendMessage(Afreeca_hWnd, WM_KEYUP, Keys.Return, 0) '// 엔터키 입력
            API.SendMessage(Afreeca_hWnd, WM_KEYDOWN, Keys.Return, 0) '// 엔터키 입력 중단 (떼기)
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub 설정SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 설정SToolStripMenuItem.Click

        frmSetting.ShowDialog()

    End Sub

    Private Sub Thread_DoWork()

        Do
            If Check_FreecShot() = True Then

                Dim Twitch_title As String
                Twitch_title = Get_TwitchTitle(False)

                If Previous_Title = Twitch_title Then

                    '//이전의 방송제목과 동일하기 때문에 무시함.

                Else

                    Previous_Title = Twitch_title

                    Dim Afreeca_Title As String
                    If Auto_PreSuffix = True Then
                        Afreeca_Title = "[생]" & Afreeca_Prefix & Twitch_title & Afreeca_Suffix
                    Else
                        Afreeca_Title = "[생]" & Twitch_title
                    End If

                    If Update_AfreecaTitle(Afreeca_Title) = False Then

                        MsgBox("업데이트 도중 오류가 발생하였습니다." & vbCrLf & "자동 업데이트를 중단합니다.", vbExclamation, "오류")
                        btn_Update.PerformClick()

                    End If

                    Update_Titles(Twitch_title, Afreeca_Title)

                End If

            Else

                MsgBox("FreecShot이 감지되지 않습니다." & vbCrLf & "자동 업데이트를 중단합니다.", vbExclamation, "오류")
                btn_Update.PerformClick()

            End If


            Threading.Thread.Sleep(Ref_sec * 1000)

        Loop

    End Sub

    Private Sub ti_Check_Tick(sender As Object, e As EventArgs) Handles ti_Check.Tick
        Check_FreecShot()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub 정보CtrlIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 정보CtrlIToolStripMenuItem.Click
        frmInfo.ShowDialog()
    End Sub
End Class
