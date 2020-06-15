Imports System.IO.Ports '條碼槍要import IO
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.IO
Public Class Form1
    Dim strSerialReadScrew(50, 21) As Byte
    Dim strSerialReadBarCode As String
    Dim count As Integer
    Dim packet(50), check(50), Torpque(50), tolerance(50), HTorpque(50), slip(50), Floating(50) As Double
    Dim Torpque_unit(50), Operate_Model(50), result(50), time(50), set_time(50), time_now(50) As String
    Dim m_intLastStep, m_intNowStep As Integer
    Dim screwsum, screw_now, Reset, lastreset As Integer '紀錄有幾個螺絲
    Dim screw_NG As Integer
    Dim FilePath, strData As String
    Dim x As Integer = 0
    Dim m_wsMesTwTest As New ServiceReferenceTwMesTest.wsEQPSoapClient '測試區
    Dim m_wsMesTwProduction As New ServiceReferenceTwMesProduction.wsEQPSoapClient '正式區
    Dim m_strMesResult As String
    Dim AllInXmlStr As String
    Dim run As Boolean = False
    Dim Record As Boolean = False
    Dim BarcodeGun As Boolean = False

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            Dim wmi As Object = GetObject("winmgmts:\\.\root\cimv2")
            Dim devices As Object = wmi.ExecQuery("Select DeviceID, Name from Win32_PnPEntity") '只抓DeviceID和Name
            '測試時抓全部資料要 Select * from Win32_PnPEntity
            Dim strDeviceId As String
            'ScrewCOM.Text = "N/A"
            '讀螺絲機
            For Each d As Object In devices
                strDeviceId = IIf(IsDBNull(d.DeviceID), "N/A", d.DeviceID)
                If Strings.InStr(strDeviceId, "FTDIBUS\VID_0403+PID_6001+AI03O6NYA\0000") > 0 Then
                    If Strings.InStr(d.Name, "(") > 0 Then
                        Dim rm As MatchCollection
                        rm = Regex.Matches(d.Name, "\b(COM\w+)\b")
                        ScrewCOM.Text = rm(0).Value
                    End If
                End If
            Next
            '讀條碼機
            For Each d As Object In devices
                strDeviceId = IIf(IsDBNull(d.DeviceID), "N/A", d.DeviceID)
                If Strings.InStr(strDeviceId, "VID_0C2E&PID_090A") > 0 Then
                    If Strings.InStr(d.Name, "(") > 0 Then
                        Dim rm As MatchCollection
                        rm = Regex.Matches(d.Name, "\b(COM\w+)\b")
                        BarcodeCOM.Text = rm(0).Value
                    End If
                End If
            Next
        Catch ex As Exception
            'ScannerCOM.Text = "N/A"
        End Try
        '抓所有COMPORT 選擇繼電器COMPORT

    End Sub

    '掃新的條碼要清掉所有資料 
    Private Sub ComboBox1_MouseClick(sender As Object, e As EventArgs) Handles ComboBox1.MouseClick
        ComboBox1.Items.Clear()
        If screw_now > 0 Then
            For i = 1 To screw_now
                ComboBox1.Items.Add(i)
            Next
        End If
    End Sub
    Private Sub ScrewNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ScrewNum.KeyPress, Quantity.KeyPress
        If e.KeyChar = Chr(48) Or e.KeyChar = Chr(49) Or e.KeyChar = Chr(50) Or e.KeyChar = Chr(51) Or e.KeyChar = Chr(52) Or e.KeyChar = Chr(53) Or e.KeyChar = Chr(54) Or e.KeyChar = Chr(55) Or e.KeyChar = Chr(56) Or e.KeyChar = Chr(57) Or e.KeyChar = Chr(13) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Text = "螺絲:" & ComboBox1.Text & "/" & screwsum
        Label2.Text = "封包長度:" & packet(ComboBox1.Text - 1)
        Label3.Text = "校驗已鎖次數:" & check(ComboBox1.Text - 1)
        Label4.Text = "操作模式:" & Operate_Model(ComboBox1.Text - 1)
        Label5.Text = "允許誤差百分比:" & tolerance(ComboBox1.Text - 1) & "%"
        Label6.Text = "扭力的設定:" & Torpque(ComboBox1.Text - 1) & Torpque_unit(ComboBox1.Text - 1) '扭力數值&單位
        Label7.Text = "實際扭力:" & HTorpque(ComboBox1.Text - 1)
        Label8.Text = "鎖固時間設定:" & set_time(ComboBox1.Text - 1)
        Label9.Text = "鎖固時間:" & time(ComboBox1.Text - 1)
        Label10.Text = "鎖固結果:" & result(ComboBox1.Text - 1)   'PASS NG
        Label40.Text = "滑牙判斷百分比:" & slip(ComboBox1.Text - 1) & "%"
        Label26.Text = "浮鎖判斷百分比:" & Floating(ComboBox1.Text - 1) & "%"

    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        Try
            If BtnConnect.Text = "連線" Then
                BtnConnect.Text = "中斷連線"
                ScrewStatus.Text = ""
                SerialPort1.Close()
                SerialPort2.Close()
                SerialPort3.Close()
                SerialPort1.PortName = ScrewCOM.Text
                SerialPort2.PortName = BarcodeCOM.Text
                SerialPort3.PortName = RelayCom.Text
                SerialPort1.Open()
                SerialPort2.Open()
                SerialPort3.Open()
                SerialPort1.DiscardInBuffer()
                SerialPort1.DiscardOutBuffer()
                SerialPort2.DiscardInBuffer()
                SerialPort2.DiscardOutBuffer()
                SerialPort3.DiscardInBuffer()
                SerialPort3.DiscardOutBuffer()
                ScrewCOM.Enabled = False
                BarcodeCOM.Enabled = False
                RelayCom.Enabled = False
                ScrewNum.Enabled = False
                Timer1.Enabled = True
                Timer2.Enabled = False
                'Array.Clear(strSerialReadScrew, 0, 1122) '50*19 + 69 全部空位都清成0

                strSerialReadBarCode = ""

                modelNam.Enabled = False
                OrderNum.Enabled = False
                WkorderNum.Enabled = False
                Quantity.Enabled = False
                WkStationNam.Enabled = False
                TxtOpCode.Enabled = False

                RadioNoMes.Enabled = False
                RadioMesTest.Enabled = False
                RadioMesProduction.Enabled = False

                TestNoNg.Enabled = False
                ProductionNoNg.Enabled = False

                OvalShape1.BackColor = Color.FromKnownColor(KnownColor.Control)
                OvalShape1.BorderColor = Color.Black

                If modelNam.Text = "" Or OrderNum.Text = "" Or WkorderNum.Text = "" Or Quantity.Text = "" Or WkStationNam.Text = "" Or TxtOpCode.Text = "" Or ScrewNum.Text = "" Then
                    If modelNam.Text = "" Then
                        ScrewStatus.Text &= "機種名稱未填" & vbNewLine
                    End If
                    If OrderNum.Text = "" Then
                        ScrewStatus.Text &= "訂單號碼未填" & vbNewLine
                    End If
                    If WkorderNum.Text = "" Then
                        ScrewStatus.Text &= "工單號碼未填" & vbNewLine
                    End If
                    If Quantity.Text = "" Then
                        ScrewStatus.Text &= "排定生產數量未填" & vbNewLine
                    End If
                    If WkStationNam.Text = "" Then
                        ScrewStatus.Text &= "工作站站名未填" & vbNewLine
                    End If
                    If TxtOpCode.Text = "" Then
                        ScrewStatus.Text &= "作業員代碼未填" & vbNewLine
                    End If
                    If ScrewNum.Text = "" Then
                        ScrewStatus.Text &= "螺絲數量未填" & vbNewLine
                    End If
                    'MsgBox("匯出檔案失敗", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                    ScrewStatus.Text &= "啟動失敗，請確認表單是否填寫" & vbNewLine
                    Stops()
                Else
                    get_data()
                    RelayDefault() '繼電器切到都斷掉
                    BarcodeGun = True
                    Record = False
                    run = False
                End If
            Else
                Stops()
                LblBarCode.Text = ""
            End If
        Catch ex As Exception
            'MsgBox("COM Port 錯誤或未連接設備", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
            Form2.Show()
        Form2.Focus()

        Form2.Label1.Text = "COM Port 錯誤或未連接設備"
        Stops()
        End Try

    End Sub

    Sub Stops()
        BtnConnect.Text = "連線"
        SerialPort1.Close()
        SerialPort2.Close()
        SerialPort3.Close()
        Timer1.Enabled = False
        ScrewCOM.Enabled = True
        BarcodeCOM.Enabled = True
        RelayCom.Enabled = True
        ScrewNum.Enabled = True
        Timer2.Enabled = True

        modelNam.Enabled = True
        OrderNum.Enabled = True
        WkorderNum.Enabled = True
        Quantity.Enabled = True
        WkStationNam.Enabled = True
        TxtOpCode.Enabled = True

        RadioNoMes.Enabled = True
        RadioMesTest.Enabled = True
        RadioMesProduction.Enabled = True

        TestNoNg.Enabled = True
        ProductionNoNg.Enabled = True
        'Array.Clear(strSerialReadScrew, 0, 1122)
        RelayOpen()
        OvalShape1.BackColor = Color.FromKnownColor(KnownColor.Control)
        OvalShape1.BorderColor = Color.Black
        For Each sp As String In My.Computer.Ports.SerialPortNames
            RelayCom.Items.Add(sp)
        Next
        BarcodeGun = False
        Record = False
        run = True
    End Sub
    Sub get_data()
        '抓資料 抓產品NG和PASS的資料
        Dim Passtotal, NGtotal As Long
        Dim PassFile, NgFile As String
        Dim csvpassdata, csvngdata, Arrp(), Arrn() As String
        Dim srp, srn As StreamReader
        'My.Computer.FileSystem.CreateDirectory("D:\34972A_Measure\" & modelNam.Text)
        PassFile = "D:\Screw\" & modelNam.Text & "\" & WkorderNum.Text & "_PASS" & ".CSV"
        NgFile = "D:\Screw\" & modelNam.Text & "\" & WkorderNum.Text & "_NG" & ".CSV"
        If File.Exists(PassFile) = True Then
            Dim flp As New FileInfo(PassFile)

            srp = flp.OpenText
            Do While srp.Peek() >= 0
                'If sr.Peek() = -1 Then
                'If srn.ReadLine <> vbCrLf Then
                csvpassdata = (srp.ReadLine()) & vbNewLine '迴圈不用& 就只會抓到最後一個值
                'End If
                'End If
            Loop
            srp.Close()
            Arrp = Split(csvpassdata, ",")
            Passtotal = Arrp(10)
        Else
            Passtotal = 0
        End If

        If File.Exists(NgFile) = True Then
            Dim fln As New FileInfo(NgFile)

            srn = fln.OpenText
            Do While srn.Peek() >= 0
                'If sr.Peek() = -1 Then
                'If srn.ReadLine <> vbCrLf Then
                csvngdata = (srn.ReadLine()) & vbNewLine '迴圈不用& 就只會抓到最後一個值
                'End If
                'End If
            Loop
            srn.Close()
            Arrn = Split(csvngdata, ",")
            NGtotal = Arrn(10)
        Else
            NGtotal = 0
        End If

        '抓以生產的總數最大的表示就是最後一筆
        If Passtotal = 0 And NGtotal = 0 Then
            LblPASS.Text = 0
            LblNG.Text = 0
            LblTotal.Text = 0
        ElseIf Passtotal > NGtotal Then
            LblPASS.Text = Arrp(8)
            LblNG.Text = Arrp(9)
            LblTotal.Text = Arrp(10)
        Else
            LblPASS.Text = Arrn(8)
            LblNG.Text = Arrn(9)
            LblTotal.Text = Arrn(10)
        End If

    End Sub
    '鎖螺絲機
    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim strTemp As Byte
        If Record = True Then
            m_intLastStep = count
            count = count + 1
            For i = 0 To 21
                'Do Until sp.BytesToRead > 0
                '    '
                'Loop
                strTemp = sp.ReadByte()

                strSerialReadScrew(count, i) = strTemp

            Next
            m_intNowStep = count
        End If
        '''''count = screw_now
    End Sub
    '條碼接收
    Private Sub SerialPort2_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort2.DataReceived

        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim strTemp As String
        If BarcodeGun = True Then
            strTemp = sp.ReadExisting() '讀到serialporrt的文字'

            strSerialReadBarCode = strTemp

            count = -1 '條碼掃了就歸-1
        Else
            MsgBox("如有更換產品，請按重製鍵在掃條碼")
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        count = -1
        Timer2.Enabled = True
        Timer1.Enabled = False
        screw_NG = 0
        LblTotal.Text = 0
        LblPASS.Text = 0
        LblNG.Text = 0
        TestNoNg.Visible = False
        ProductionNoNg.Visible = False
        For Each sp As String In My.Computer.Ports.SerialPortNames
            RelayCom.Items.Add(sp)
        Next
        '如果我的程式關閉機台沒關閉重置的比對就會出問題
        ''''''screw_now=0
    End Sub
    '繼電器切Y00,Y01
    Sub RelayDefault()
        Dim Relay_Default12() As Byte = New Byte() {&H21, &HF, &H0, &H0, &H0, &H8, &H1, &H3}
        Dim Default12() As Byte
        Default12 = CRC16(Relay_Default12)
        ReDim Preserve Relay_Default12(Relay_Default12.GetUpperBound(0) + 2)
        Relay_Default12(8) = Default12(0)
        Relay_Default12(9) = Default12(1)
        SerialPort3.Close()
        SerialPort3.PortName = RelayCom.Text
        SerialPort3.Open()
        SerialPort3.DiscardInBuffer()
        SerialPort3.DiscardOutBuffer()
        SerialPort3.Write(Relay_Default12, 0, 10)

    End Sub

    Sub RelayOpen()
        Dim Relay_O12() As Byte = New Byte() {&H21, &HF, &H0, &H0, &H0, &H8, &H1, &H0}
        Dim Open12() As Byte
        Open12 = CRC16(Relay_O12)
        ReDim Preserve Relay_O12(Relay_O12.GetUpperBound(0) + 2)
        Relay_O12(8) = Open12(0)
        Relay_O12(9) = Open12(1)

        SerialPort3.Close()
        SerialPort3.PortName = RelayCom.Text
        SerialPort3.Open()
        SerialPort3.DiscardInBuffer()
        SerialPort3.DiscardOutBuffer()
        SerialPort3.Write(Relay_O12, 0, 10)

    End Sub
    Function CRC16(ByVal data() As Byte) As Byte()
        Dim CRC16Lo As Byte, CRC16Hi As Byte   'CRC暫存器 
        Dim CL As Byte, CH As Byte        '多項式碼&HA001 
        Dim SaveHi As Byte, SaveLo As Byte
        Dim i As Integer
        Dim Flag As Integer
        CRC16Lo = &HFF
        CRC16Hi = &HFF
        CL = &H1
        CH = &HA0
        For i = 0 To UBound(data)
            CRC16Lo = CRC16Lo Xor data(i) '每一個資料與CRC暫存器進行異或 
            For Flag = 0 To 7
                SaveHi = CRC16Hi
                SaveLo = CRC16Lo
                CRC16Hi = CRC16Hi \ 2      '高位右移一位 
                CRC16Lo = CRC16Lo \ 2      '低位右移一位 
                If ((SaveHi And &H1) = &H1) Then '如果高位字節最後一位為1 
                    CRC16Lo = CRC16Lo Or &H80   '則低位字節右移後前面補1 
                End If              '否則自動補0 
                If ((SaveLo And &H1) = &H1) Then '如果LSB為1，則與多項式碼進行異或 
                    CRC16Hi = CRC16Hi Xor CH
                    CRC16Lo = CRC16Lo Xor CL
                End If
            Next Flag
        Next i
        Dim ReturnData(1) As Byte
        ReturnData(0) = CRC16Lo       'CRC低位 
        ReturnData(1) = CRC16Hi       'CRC高位 
        'CRC16 = Hex(ReturnData(0)) & "," & Hex(ReturnData(1))
        CRC16 = ReturnData
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If run = True Then
            Exit Sub
        End If
        run = True
        'SerialPort1.DiscardInBuffer()
        'SerialPort1.DiscardOutBuffer()

        If strSerialReadBarCode <> "" Then
            RelayOpen()
            'SerialPort2.Close() '不關條碼機
            Record = True
            '如果有條碼 跑下面 鎖到一辦換條碼擋
            LblBarCode.Text = strSerialReadBarCode
            LblBarCode.Text = Replace(LblBarCode.Text, vbCr, "")
            LblBarCode.Text = Replace(LblBarCode.Text, vbLf, "")

            If count = 0 Then
                'screwsum = CInt(strSerialReadScrew(count, 18)) '螺絲總數
                screwsum = ScrewNum.Text
                BarcodeGun = False
                '條碼放在這裡能不能擋 只在j=0 時才換條碼

                '''''MES詢問??????'''''''''
                If RadioMesTest.Checked Or RadioMesProduction.Checked Then
                    Dim strMesResponse As String
                    strMesResponse = mesTestTESTUniCheckOutAsk(TxtOpCode.Text, "0", WkStationNam.Text, WkorderNum.Text, strSerialReadBarCode)
                    If strMesResponse <> "OK" Then

                        Form2.Show()
                        Form2.Focus()

                        Form2.Label1.Text = "MES錯誤請確認工單、條碼、工作站" & strMesResponse
                        strSerialReadBarCode = ""
                        Exit Sub

                    End If
                End If

                'If RadioMesProduction.Checked Then
                '    Dim strMesResponse As String
                '    strMesResponse = mesTestTESTUniCheckOutAsk(TxtOpCode.Text, "0", WkStationNam.Text, WkorderNum.Text, strSerialReadBarCode)
                '    If strMesResponse <> "OK" Then
                '        MsgBox("這個條碼不在此工作站")
                '        strSerialReadBarCode = ""
                '        Exit Sub
                '    End If
                'End If
                ''''''''''''''''''''''''''''''
            End If

            If count >= 0 Then
                '案下 螺絲復原成第一顆 中途停止時
                If strSerialReadScrew(count, 12) <> "&H00" Then
                    For i = 0 To 21
                        ScrewStatus.Text &= Hex(strSerialReadScrew(count, i)) & ", "
                    Next
                    ScrewStatus.Text &= vbNewLine
                    '先存入NG的資料 
                    count = count - 1 'j減掉這次的步驟後 存資料

                    If count > 0 Then '如果沒有任何資料就不用存了
                        LblNG.Text = Int(LblNG.Text) + 1
                        'If RadioMesTest.Checked Or RadioMesProduction.Checked Then
                        If (RadioMesTest.Checked And TestNoNg.Checked = False) Or (RadioMesProduction.Checked And ProductionNoNg.Checked = False) Then

                            Dim strMesResponse As String
                            strMesResponse = mesTestTESTUniCheckOut(TxtOpCode.Text, "0", WkStationNam.Text, WkorderNum.Text, LblBarCode.Text, "Ng")
                            If strMesResponse <> "OK" Then
                                'MsgBox("MES發生錯誤，請排除錯誤再測試" & strMesResponse)
                                Form2.Show()
                                Form2.Focus()

                                Form2.Label1.Text = "MES發生錯誤，請排除錯誤再測試" & strMesResponse
                            End If
                        End If
                        MyWriteFile(0)
                    End If

                    strSerialReadBarCode = ""
                    count = -1 '
                    screw_NG = 0
                    Record = False
                    'Label39.Text = "產品測試結果:"
                    'OvalShape1.BackColor = Color.FromKnownColor(KnownColor.Control)
                    'OvalShape1.BorderColor = Color.Black
                    SerialPort1.DiscardInBuffer()
                    SerialPort1.DiscardOutBuffer()
                    LblBarCode.Text = ""

                    'SerialPort2.PortName = BarcodeCOM.Text


                    SerialPort2.DiscardInBuffer()
                    SerialPort2.DiscardOutBuffer()
                    RelayDefault()
                    BarcodeGun = True
                    run = False
                    Exit Sub
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''

                '這邊以下都要j-1吧??
                '封包長度
                packet(count) = CDbl((CInt(strSerialReadScrew(count, 1)) << 8) + CInt(strSerialReadScrew(count, 2)))
                '校驗
                check(count) = CDbl(strSerialReadScrew(count, 3))
                '扭力單位
                If strSerialReadScrew(count, 4) = "&HF0" Then
                    Torpque_unit(count) = "NM"
                ElseIf strSerialReadScrew(count, 4) = "&H0F" Then
                    Torpque_unit(count) = "Kgfcm"
                Else
                    Torpque_unit(count) = "異常"
                End If
                '操作模式
                If strSerialReadScrew(count, 5) = "&HF0" Then
                    Operate_Model(count) = "管理者模式"
                ElseIf strSerialReadScrew(count, 5) = "&H0F" Then
                    Operate_Model(count) = "操作者模式"
                Else
                    Operate_Model(count) = "異常"
                End If
                '扭力設定
                Torpque(count) = CDbl(((CInt(strSerialReadScrew(count, 6)) << 8) + CInt(strSerialReadScrew(count, 7))) / 100.0)
                '允許誤差
                tolerance(count) = CDbl(strSerialReadScrew(count, 8))
                '最高扭力(實際扭力)
                HTorpque(count) = CDbl(((CInt(strSerialReadScrew(count, 9)) << 8) + CInt(strSerialReadScrew(count, 10))) / 100.0)
                '鎖固結果
                If strSerialReadScrew(count, 11) = "&HF0" Then
                    screw_NG = screw_NG + 1
                    result(count) = "NG"
                ElseIf strSerialReadScrew(count, 11) = "&H0F" Then
                    result(count) = "OK"
                ElseIf strSerialReadScrew(count, 11) = "&HFF" Then
                    screw_NG = screw_NG + 1
                    result(count) = "FL"
                Else
                    screw_NG = screw_NG + 1
                    result(count) = "滑牙或空轉"
                End If
                '鎖固時間
                Dim t As Double
                t = CDbl(((CInt(strSerialReadScrew(count, 13)) << 8) + CInt(strSerialReadScrew(count, 14))) / 100.0)
                time(count) = t & "ms"
                '鎖固時間設定
                Dim st As Double
                st = CDbl(((CInt(strSerialReadScrew(count, 15)) * 100.0) + CInt(strSerialReadScrew(count, 16))) / 100.0)
                set_time(count) = st & "ms"
                '目前是第幾顆螺絲
                screw_now = CInt(strSerialReadScrew(count, 17))
                'ComboBox1.Text = screw_now
                'ComboBox1_SelectedIndexChanged(New Object, New EventArgs)
                time_now(count) = Now.ToString("yyyy-MM-dd HH:mm:ss")

                '滑牙判斷百分比:
                slip(count) = CDbl(CInt(strSerialReadScrew(count, 19)))
                '浮鎖判斷百分比:
                Floating(count) = CDbl(CInt(strSerialReadScrew(count, 20)))
                'If screw_NG > 0 Then

                '    Label39.Text = "產品結果:NG"
                '    OvalShape1.BackColor = Color.Red
                '    OvalShape1.BorderColor = Color.Red
                'Else

                '    Label39.Text = "產品結果:PASS"
                '    OvalShape1.BackColor = Color.Green
                '    OvalShape1.BorderColor = Color.Green
                'End If
            End If

            If m_intLastStep <> m_intNowStep And count <> -1 Then
                Label22.Text = count
                If count = 0 Then
                    ScrewStatus.Text = ""
                End If
                For i = 0 To 21
                    ScrewStatus.Text &= Hex(strSerialReadScrew(count, i)) & ", "
                Next
                ScrewStatus.Text &= vbNewLine

                Label20.Text = "第" & count + 1 & "顆螺絲"
                Label19.Text = "封包長度:" & packet(count)
                Label18.Text = "校驗已鎖次數:" & check(count)
                Label17.Text = "操作模式:" & Operate_Model(count)
                Label16.Text = "允許誤差百分比:" & tolerance(count) & "%"
                Label15.Text = "扭力的設定:" & Torpque(count) & Torpque_unit(count)
                Label14.Text = "實際扭力:" & HTorpque(count)
                Label13.Text = "鎖固時間設定:" & set_time(count)
                Label12.Text = "鎖固時間:" & time(count)
                Label11.Text = "鎖固結果:" & result(count)
                Label34.Text = "滑牙判斷百分比:" & slip(count) & "%"
                Label25.Text = "浮鎖判斷百分比:" & Floating(count) & "%"
                If m_intNowStep = 0 Then
                    Label38.Text = "本次螺絲測量時間: " & time_now(m_intNowStep)
                Else
                    Label36.Text = "上次螺絲測量時間: " & time_now(m_intLastStep)
                    Label38.Text = "本次螺絲測量時間: " & time_now(m_intNowStep)
                End If

                m_intLastStep = m_intNowStep

            End If

            If count = screwsum - 1 And count <> -1 Then '產品結束 如果到達工作螺絲的數量
                '結束通通清掉
                '上傳MES還沒寫
                If screw_NG > 0 Then
                    '資料存入NG
                    LblNG.Text = Int(LblNG.Text) + 1
                    Label39.Text = "產品結果:NG"
                    OvalShape1.BackColor = Color.Red
                    OvalShape1.BorderColor = Color.Red
                    If (RadioMesTest.Checked And TestNoNg.Checked = False) Or (RadioMesProduction.Checked And ProductionNoNg.Checked = False) Then

                        Dim strMesResponse As String
                        strMesResponse = mesTestTESTUniCheckOut(TxtOpCode.Text, "0", WkStationNam.Text, WkorderNum.Text, LblBarCode.Text, "Ng")
                        If strMesResponse <> "OK" Then
                            'MsgBox("MES發生錯誤，請排除錯誤再測試" & strMesResponse)
                            Form2.Show()
                            Form2.Focus()

                            Form2.Label1.Text = "MES發生錯誤，請排除錯誤再測試" & strMesResponse
                        End If
                    End If
                    MyWriteFile(0)
                Else
                    '資料存入Pass
                    LblPASS.Text = Int(LblPASS.Text) + 1
                    Label39.Text = "產品結果:PASS"
                    OvalShape1.BackColor = Color.Green
                    OvalShape1.BorderColor = Color.Green
                    If RadioMesTest.Checked Or RadioMesProduction.Checked Then
                        Dim strMesResponse As String
                        strMesResponse = mesTestTESTUniCheckOut(TxtOpCode.Text, "0", WkStationNam.Text, WkorderNum.Text, LblBarCode.Text, "Pass")
                        If strMesResponse <> "OK" Then
                            'MsgBox("MES發生錯誤，請排除錯誤再測試" & strMesResponse)
                            Form2.Show()
                            Form2.Focus()

                            Form2.Label1.Text = "MES發生錯誤，請排除錯誤再測試" & strMesResponse
                        End If
                    End If
                    MyWriteFile(1)
                End If
                'For i = 0 To screwsum
                '    'packet(i) = 0
                '    'check(i) = 0
                '    'Torpque_unit(i) = ""

                'Next
                '掃新條碼在清掉
                strSerialReadBarCode = ""
                count = -1 '
                screw_NG = 0
                Record = False

                'Label39.Text = "產品測試結果:"
                'OvalShape1.BackColor = Color.FromKnownColor(KnownColor.Control)
                'OvalShape1.BorderColor = Color.Black
                'screwsum = 0
                RelayDefault()
                BarcodeGun = True
                'SerialPort2.PortName = BarcodeCOM.Text
                '不關條碼機

                SerialPort2.DiscardInBuffer()
                SerialPort2.DiscardOutBuffer()
            End If

        End If
        SerialPort1.DiscardInBuffer()
        SerialPort1.DiscardOutBuffer()
        run = False

    End Sub
    Sub MyWriteFile(WtF As Integer) '傳J存陣列
        LblTotal.Text = Int(LblNG.Text) + Int(LblPASS.Text)
        strData = ""
        If WtF = 1 Then
            FilePath = "D:\Screw\" & modelNam.Text & "\" & WkorderNum.Text & "_PASS" & ".CSV"
        ElseIf WtF = 0 Then
            FilePath = "D:\Screw\" & modelNam.Text & "\" & WkorderNum.Text & "_NG" & ".CSV"
        End If

        If File.Exists(FilePath) = True Then
            Using fs As IO.FileStream = New IO.FileStream(FilePath, FileMode.Append)
                Using sw As StreamWriter = New StreamWriter(fs, Encoding.Default)

                    ' sw.Write(str)   '第一行
                    For i = 0 To count
                        strData &= time_now(i) & "," & "=" & Chr(34) & modelNam.Text & Chr(34) & "," & "=" & Chr(34) & OrderNum.Text & Chr(34) &
                        "," & "=" & Chr(34) & WkorderNum.Text & Chr(34) & "," & Quantity.Text &
                        "," & "=" & Chr(34) & WkStationNam.Text & Chr(34) & "," & "=" & Chr(34) & TxtOpCode.Text & Chr(34) &
                        "," & "=" & Chr(34) & LblBarCode.Text & Chr(34) & "," & LblPASS.Text & "," & LblNG.Text &
                        "," & LblTotal.Text & "," & i + 1 & "," & packet(i) & "," & check(i) & "," & Operate_Model(i) & "," & tolerance(i) & "%" &
                        "," & Torpque(i) & Torpque_unit(i) & "," & HTorpque(i) & "," & set_time(i) & "," & time(i) & "," & result(i) & "," & vbNewLine

                    Next
                    sw.Write(strData)
                    sw.Flush()
                    sw.Close()
                End Using
            End Using
        Else
            My.Computer.FileSystem.CreateDirectory("D:\Screw\" & modelNam.Text)
            Using fs As IO.FileStream = New IO.FileStream(FilePath, FileMode.Append)
                Using sw As StreamWriter = New StreamWriter(fs, Encoding.Default)
                    sw.WriteLine("時間日期,機種名稱,訂單編號,工單號碼,工單排定生產數量,工作站站名,作業員代碼,產品條碼,PASS總數,NG總數,已生產總數," &
                     "第幾顆螺絲,封包長度,校驗已鎖次數,操作模式,允許誤差百分比,扭力的設定,實際扭力,鎖固時間設定,鎖固時間,鎖固結果,")

                    For i = 0 To count
                        strData &= time_now(i) & "," & "=" & Chr(34) & modelNam.Text & Chr(34) & "," & "=" & Chr(34) & OrderNum.Text & Chr(34) &
                        "," & "=" & Chr(34) & WkorderNum.Text & Chr(34) & "," & Quantity.Text &
                        "," & "=" & Chr(34) & WkStationNam.Text & Chr(34) & "," & "=" & Chr(34) & TxtOpCode.Text & Chr(34) &
                        "," & "=" & Chr(34) & LblBarCode.Text & Chr(34) & "," & LblPASS.Text & "," & LblNG.Text &
                        "," & LblTotal.Text & "," & i + 1 & "," & packet(i) & "," & check(i) & "," & Operate_Model(i) & "," & tolerance(i) & "%" &
                        "," & Torpque(i) & Torpque_unit(i) & "," & HTorpque(i) & "," & set_time(i) & "," & time(i) & "," & result(i) & "," & vbNewLine

                    Next
                    sw.Write(strData)
                    sw.Flush()
                    sw.Close()

                End Using
            End Using
        End If

    End Sub
    Private Sub form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MessageBox.Show("確定關閉視窗?", "警告", MessageBoxButtons.YesNo) = MsgBoxResult.No Then

            e.Cancel = True
        Else
            '確認關閉
            'MsgBox("HI")
            Try
                RelayOpen()
            Catch ex As Exception

            End Try

        End If

    End Sub
    Private Function mesProductionTestDBConnection() As Boolean
        Dim responseStr As String
        If x = 1 Then
            responseStr = m_wsMesTwTest.TestDBConnection("iMES")
        ElseIf x = 2 Then
            responseStr = m_wsMesTwProduction.TestDBConnection("iMES")
        End If
        If responseStr = "Test successfully, UserName:IMES, DataBase is oracle !" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function mesTestTESTUniCheckOutAsk(usernoStr As String, curusernoStr As String, opnoStr As String, monoStr As String, lotnoStr As String) As String
        Dim InXmlStr, responseStr As String
        InXmlStr = My.Resources.InXmlTemplateString
        InXmlStr = Replace(InXmlStr, "transactionidReplace", Now.Millisecond.ToString)
        InXmlStr = Replace(InXmlStr, "moduleidReplace", "請改自己模組名稱縮寫")
        InXmlStr = Replace(InXmlStr, "functionidReplace", "mesTestTESTUniCheckOut")
        InXmlStr = Replace(InXmlStr, "computernameReplace", My.Computer.Name)
        InXmlStr = Replace(InXmlStr, "curusernoReplace", curusernoStr)
        InXmlStr = Replace(InXmlStr, "sendtimeReplace", Format(Now, "yyyy-MM-dd HH:mm:ss"))
        InXmlStr = Replace(InXmlStr, "languagemodeReplace", "zh-CHT")
        InXmlStr = Replace(InXmlStr, "usernoReplace", usernoStr)
        InXmlStr = Replace(InXmlStr, "equitmentnoReplace", "")
        InXmlStr = Replace(InXmlStr, "monoReplace", monoStr)
        InXmlStr = Replace(InXmlStr, "opnoReplace", opnoStr)
        InXmlStr = Replace(InXmlStr, "lotnoReplace", lotnoStr)
        InXmlStr = Replace(InXmlStr, "resultReplace", "")
        'responseStr = m_wsMesTwTest.wsTESTUniCheckOut(InXmlStr)
        If x = 1 Then
            responseStr = m_wsMesTwTest.wsTESTUniCheckOut(InXmlStr)
        ElseIf x = 2 Then
            responseStr = m_wsMesTwProduction.wsTESTUniCheckOut(InXmlStr)
        End If
        If InStr(responseStr, "<result>1</result>") > 0 Then
            Return "OK"
        Else
            Return responseStr
        End If
    End Function
    Private Function mesTestTESTUniCheckOut(usernoStr As String, curusernoStr As String, opnoStr As String, monoStr As String, lotnoStr As String, resultStr As String) As String
        Dim InXmlStr, responseStr As String
        InXmlStr = My.Resources.InXmlTemplateString
        InXmlStr = Replace(InXmlStr, "transactionidReplace", Now.Millisecond.ToString)
        InXmlStr = Replace(InXmlStr, "moduleidReplace", "請改自己模組名稱縮寫")
        InXmlStr = Replace(InXmlStr, "functionidReplace", "mesTestTESTUniCheckOut")
        InXmlStr = Replace(InXmlStr, "computernameReplace", My.Computer.Name)
        InXmlStr = Replace(InXmlStr, "curusernoReplace", curusernoStr)
        InXmlStr = Replace(InXmlStr, "sendtimeReplace", Format(Now, "yyyy-MM-dd HH:mm:ss"))
        InXmlStr = Replace(InXmlStr, "languagemodeReplace", "zh-CHT")
        InXmlStr = Replace(InXmlStr, "usernoReplace", usernoStr)
        InXmlStr = Replace(InXmlStr, "equitmentnoReplace", "")
        InXmlStr = Replace(InXmlStr, "monoReplace", monoStr)
        InXmlStr = Replace(InXmlStr, "opnoReplace", opnoStr)
        InXmlStr = Replace(InXmlStr, "lotnoReplace", lotnoStr)
        InXmlStr = Replace(InXmlStr, "resultReplace", resultStr)
        If x = 1 Then
            responseStr = m_wsMesTwTest.wsTESTUniCheckOut(InXmlStr)
        ElseIf x = 2 Then
            responseStr = m_wsMesTwProduction.wsTESTUniCheckOut(InXmlStr)
        End If
        If InStr(responseStr, "<result>success</result>") > 0 Then
            Return "OK"
        Else
            Return responseStr
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strSerialReadBarCode = ComboBox2.Text
        count = -1
    End Sub
    Private Sub RadioNoMes_CheckedChanged(sender As Object, e As EventArgs) Handles RadioNoMes.CheckedChanged
        If RadioNoMes.Checked Then
            x = 0
        End If
    End Sub
    Private Sub RadioMesTest_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMesTest.CheckedChanged
        If RadioMesTest.Checked Then 'MES測試區被選擇 x=1 顯示是否開啟NG不上傳
            TestNoNg.Visible = True
            x = 1
        Else
            TestNoNg.Visible = False
            TestNoNg.Checked = False
        End If
    End Sub

    Private Sub RadioMesProduction_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMesProduction.CheckedChanged
        If RadioMesProduction.Checked Then 'MES正式區被選擇 x=1 顯示是否開啟NG不上傳
            ProductionNoNg.Visible = True
            x = 2
        Else
            ProductionNoNg.Visible = False
            ProductionNoNg.Checked = False
        End If
    End Sub
End Class
