<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.ScrewCOM = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ScrewCOMPort = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.choice = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ScannerCOMPort = New System.Windows.Forms.Label()
        Me.BarcodeCOM = New System.Windows.Forms.TextBox()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.LblBarCode = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ScrewStatus = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.WkStationNam = New System.Windows.Forms.TextBox()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.LblNG = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.LblPASS = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxtOpCode = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.OrderNum = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.modelNam = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.WkorderNum = New System.Windows.Forms.TextBox()
        Me.RadioMesProduction = New System.Windows.Forms.RadioButton()
        Me.RadioMesTest = New System.Windows.Forms.RadioButton()
        Me.RadioNoMes = New System.Windows.Forms.RadioButton()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TestNoNg = New System.Windows.Forms.CheckBox()
        Me.ProductionNoNg = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.ScrewNum = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.RelayCom = New System.Windows.Forms.ComboBox()
        Me.SerialPort3 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label43 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        '
        'BtnConnect
        '
        Me.BtnConnect.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnConnect.Location = New System.Drawing.Point(752, 12)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(67, 67)
        Me.BtnConnect.TabIndex = 109
        Me.BtnConnect.Text = "連線"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'ScrewCOM
        '
        Me.ScrewCOM.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ScrewCOM.Location = New System.Drawing.Point(164, 17)
        Me.ScrewCOM.Margin = New System.Windows.Forms.Padding(2)
        Me.ScrewCOM.Name = "ScrewCOM"
        Me.ScrewCOM.Size = New System.Drawing.Size(90, 30)
        Me.ScrewCOM.TabIndex = 110
        '
        'Timer1
        '
        Me.Timer1.Interval = 800
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 161)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "螺絲:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 192)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "封包長度:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 222)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 19)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "校驗已鎖次數:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 254)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "操作模式:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 286)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 19)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "允許誤差百分比:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 320)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 19)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "扭力的設定:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 354)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 19)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "實際扭力:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 384)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 19)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "鎖固時間設定:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(49, 120)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(146, 27)
        Me.ComboBox1.TabIndex = 119
        '
        'ScrewCOMPort
        '
        Me.ScrewCOMPort.AutoSize = True
        Me.ScrewCOMPort.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ScrewCOMPort.Location = New System.Drawing.Point(20, 19)
        Me.ScrewCOMPort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ScrewCOMPort.Name = "ScrewCOMPort"
        Me.ScrewCOMPort.Size = New System.Drawing.Size(142, 19)
        Me.ScrewCOMPort.TabIndex = 120
        Me.ScrewCOMPort.Text = "螺絲機COM Port"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 417)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 19)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "鎖固時間:"
        '
        'choice
        '
        Me.choice.AutoSize = True
        Me.choice.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.choice.Location = New System.Drawing.Point(20, 87)
        Me.choice.Name = "choice"
        Me.choice.Size = New System.Drawing.Size(204, 19)
        Me.choice.TabIndex = 122
        Me.choice.Text = "選擇要查詢第幾個螺絲:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 448)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 19)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "鎖固結果:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(270, 448)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 19)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "鎖固結果:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(270, 417)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 19)
        Me.Label12.TabIndex = 134
        Me.Label12.Text = "鎖固時間:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(270, 384)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 19)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "鎖固時間設定:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(270, 354)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 19)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "實際扭力:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(270, 320)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 19)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "扭力的設定:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.Location = New System.Drawing.Point(270, 286)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(147, 19)
        Me.Label16.TabIndex = 130
        Me.Label16.Text = "允許誤差百分比:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.Location = New System.Drawing.Point(270, 254)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 19)
        Me.Label17.TabIndex = 129
        Me.Label17.Text = "操作模式:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.Location = New System.Drawing.Point(270, 222)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 19)
        Me.Label18.TabIndex = 128
        Me.Label18.Text = "校驗已鎖次數:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label19.Location = New System.Drawing.Point(270, 192)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 19)
        Me.Label19.TabIndex = 127
        Me.Label19.Text = "封包長度:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.Location = New System.Drawing.Point(270, 161)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 19)
        Me.Label20.TabIndex = 126
        Me.Label20.Text = "螺絲:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.Location = New System.Drawing.Point(272, 123)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 19)
        Me.Label21.TabIndex = 136
        Me.Label21.Text = "目前狀態"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(279, 94)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 12)
        Me.Label22.TabIndex = 137
        Me.Label22.Text = "Label22"
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'ScannerCOMPort
        '
        Me.ScannerCOMPort.AutoSize = True
        Me.ScannerCOMPort.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ScannerCOMPort.Location = New System.Drawing.Point(256, 24)
        Me.ScannerCOMPort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ScannerCOMPort.Name = "ScannerCOMPort"
        Me.ScannerCOMPort.Size = New System.Drawing.Size(142, 19)
        Me.ScannerCOMPort.TabIndex = 139
        Me.ScannerCOMPort.Text = "條碼機COM Port"
        '
        'BarcodeCOM
        '
        Me.BarcodeCOM.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BarcodeCOM.Location = New System.Drawing.Point(402, 17)
        Me.BarcodeCOM.Margin = New System.Windows.Forms.Padding(2)
        Me.BarcodeCOM.Name = "BarcodeCOM"
        Me.BarcodeCOM.Size = New System.Drawing.Size(91, 30)
        Me.BarcodeCOM.TabIndex = 138
        '
        'SerialPort2
        '
        '
        'LblBarCode
        '
        Me.LblBarCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblBarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblBarCode.Font = New System.Drawing.Font("新細明體", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblBarCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblBarCode.Location = New System.Drawing.Point(937, 13)
        Me.LblBarCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBarCode.Name = "LblBarCode"
        Me.LblBarCode.Size = New System.Drawing.Size(337, 74)
        Me.LblBarCode.TabIndex = 141
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label23.Location = New System.Drawing.Point(848, 24)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 19)
        Me.Label23.TabIndex = 140
        Me.Label23.Text = "產品條碼"
        '
        'ScrewStatus
        '
        Me.ScrewStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ScrewStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ScrewStatus.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ScrewStatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ScrewStatus.Location = New System.Drawing.Point(797, 120)
        Me.ScrewStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ScrewStatus.Name = "ScrewStatus"
        Me.ScrewStatus.Size = New System.Drawing.Size(477, 226)
        Me.ScrewStatus.TabIndex = 142
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"015", "A003", "A004", "A007", "A008", "A009", "A010", "A012"})
        Me.ComboBox2.Location = New System.Drawing.Point(583, 266)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(132, 20)
        Me.ComboBox2.TabIndex = 184
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(524, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 42)
        Me.Button1.TabIndex = 183
        Me.Button1.Text = "測試"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label38.Location = New System.Drawing.Point(524, 641)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(128, 19)
        Me.Label38.TabIndex = 182
        Me.Label38.Text = "本次測量時間:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label36.Location = New System.Drawing.Point(521, 608)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(128, 19)
        Me.Label36.TabIndex = 181
        Me.Label36.Text = "上次測量時間:"
        '
        'WkStationNam
        '
        Me.WkStationNam.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WkStationNam.Location = New System.Drawing.Point(1106, 460)
        Me.WkStationNam.Margin = New System.Windows.Forms.Padding(2)
        Me.WkStationNam.Name = "WkStationNam"
        Me.WkStationNam.Size = New System.Drawing.Size(168, 30)
        Me.WkStationNam.TabIndex = 180
        Me.WkStationNam.Text = "A-TEST-01(WEB)"
        '
        'Quantity
        '
        Me.Quantity.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Quantity.Location = New System.Drawing.Point(930, 460)
        Me.Quantity.Margin = New System.Windows.Forms.Padding(2)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(161, 30)
        Me.Quantity.TabIndex = 179
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblTotal.Location = New System.Drawing.Point(1106, 538)
        Me.LblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(168, 28)
        Me.LblTotal.TabIndex = 178
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label37.Location = New System.Drawing.Point(1116, 512)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(104, 19)
        Me.Label37.TabIndex = 177
        Me.Label37.Text = "已生產總數"
        '
        'LblNG
        '
        Me.LblNG.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNG.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblNG.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblNG.Location = New System.Drawing.Point(953, 538)
        Me.LblNG.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNG.Name = "LblNG"
        Me.LblNG.Size = New System.Drawing.Size(126, 28)
        Me.LblNG.TabIndex = 176
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label35.Location = New System.Drawing.Point(984, 512)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(73, 19)
        Me.Label35.TabIndex = 175
        Me.Label35.Text = "NG總數"
        '
        'LblPASS
        '
        Me.LblPASS.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblPASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPASS.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblPASS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblPASS.Location = New System.Drawing.Point(806, 538)
        Me.LblPASS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPASS.Name = "LblPASS"
        Me.LblPASS.Size = New System.Drawing.Size(125, 28)
        Me.LblPASS.TabIndex = 174
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label33.Location = New System.Drawing.Point(821, 512)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(90, 19)
        Me.Label33.TabIndex = 173
        Me.Label33.Text = "PASS總數"
        '
        'TxtOpCode
        '
        Me.TxtOpCode.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtOpCode.Location = New System.Drawing.Point(660, 538)
        Me.TxtOpCode.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtOpCode.Name = "TxtOpCode"
        Me.TxtOpCode.Size = New System.Drawing.Size(130, 30)
        Me.TxtOpCode.TabIndex = 172
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label32.Location = New System.Drawing.Point(657, 512)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 19)
        Me.Label32.TabIndex = 171
        Me.Label32.Text = "作業員工號"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label31.Location = New System.Drawing.Point(1116, 432)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 19)
        Me.Label31.TabIndex = 170
        Me.Label31.Text = "工作站站名"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label30.Location = New System.Drawing.Point(927, 432)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(180, 19)
        Me.Label30.TabIndex = 169
        Me.Label30.Text = "工單排定的生產數量"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label29.Location = New System.Drawing.Point(659, 432)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(85, 19)
        Me.Label29.TabIndex = 167
        Me.Label29.Text = "工單號碼"
        '
        'OrderNum
        '
        Me.OrderNum.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OrderNum.Location = New System.Drawing.Point(883, 380)
        Me.OrderNum.Margin = New System.Windows.Forms.Padding(2)
        Me.OrderNum.Name = "OrderNum"
        Me.OrderNum.Size = New System.Drawing.Size(391, 30)
        Me.OrderNum.TabIndex = 166
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label28.Location = New System.Drawing.Point(887, 354)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(85, 19)
        Me.Label28.TabIndex = 165
        Me.Label28.Text = "訂單號碼"
        '
        'modelNam
        '
        Me.modelNam.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.modelNam.Location = New System.Drawing.Point(660, 380)
        Me.modelNam.Margin = New System.Windows.Forms.Padding(2)
        Me.modelNam.Name = "modelNam"
        Me.modelNam.Size = New System.Drawing.Size(208, 30)
        Me.modelNam.TabIndex = 164
        Me.modelNam.Text = "9HS3089-2"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label27.Location = New System.Drawing.Point(659, 354)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 19)
        Me.Label27.TabIndex = 163
        Me.Label27.Text = "機種名稱"
        '
        'WkorderNum
        '
        Me.WkorderNum.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WkorderNum.Location = New System.Drawing.Point(660, 460)
        Me.WkorderNum.Margin = New System.Windows.Forms.Padding(2)
        Me.WkorderNum.Name = "WkorderNum"
        Me.WkorderNum.Size = New System.Drawing.Size(254, 30)
        Me.WkorderNum.TabIndex = 168
        Me.WkorderNum.Text = "JB20200225002"
        '
        'RadioMesProduction
        '
        Me.RadioMesProduction.AutoSize = True
        Me.RadioMesProduction.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioMesProduction.Location = New System.Drawing.Point(525, 211)
        Me.RadioMesProduction.Name = "RadioMesProduction"
        Me.RadioMesProduction.Size = New System.Drawing.Size(132, 20)
        Me.RadioMesProduction.TabIndex = 187
        Me.RadioMesProduction.Text = "MES_Production"
        Me.RadioMesProduction.UseVisualStyleBackColor = True
        '
        'RadioMesTest
        '
        Me.RadioMesTest.AutoSize = True
        Me.RadioMesTest.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioMesTest.Location = New System.Drawing.Point(525, 177)
        Me.RadioMesTest.Name = "RadioMesTest"
        Me.RadioMesTest.Size = New System.Drawing.Size(90, 20)
        Me.RadioMesTest.TabIndex = 186
        Me.RadioMesTest.Text = "MES_Test"
        Me.RadioMesTest.UseVisualStyleBackColor = True
        '
        'RadioNoMes
        '
        Me.RadioNoMes.AutoSize = True
        Me.RadioNoMes.Checked = True
        Me.RadioNoMes.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioNoMes.Location = New System.Drawing.Point(524, 144)
        Me.RadioNoMes.Name = "RadioNoMes"
        Me.RadioNoMes.Size = New System.Drawing.Size(136, 20)
        Me.RadioNoMes.TabIndex = 185
        Me.RadioNoMes.TabStop = True
        Me.RadioNoMes.Text = "我不要MESˋˊ"
        Me.RadioNoMes.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label24.Location = New System.Drawing.Point(793, 94)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(85, 19)
        Me.Label24.TabIndex = 143
        Me.Label24.Text = "目前狀態"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label39.Location = New System.Drawing.Point(25, 599)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(128, 19)
        Me.Label39.TabIndex = 189
        Me.Label39.Text = "產品測試結果:"
        '
        'TestNoNg
        '
        Me.TestNoNg.AutoSize = True
        Me.TestNoNg.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TestNoNg.Location = New System.Drawing.Point(621, 181)
        Me.TestNoNg.Name = "TestNoNg"
        Me.TestNoNg.Size = New System.Drawing.Size(81, 20)
        Me.TestNoNg.TabIndex = 190
        Me.TestNoNg.Text = "NG不上"
        Me.TestNoNg.UseVisualStyleBackColor = True
        '
        'ProductionNoNg
        '
        Me.ProductionNoNg.AutoSize = True
        Me.ProductionNoNg.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ProductionNoNg.Location = New System.Drawing.Point(665, 215)
        Me.ProductionNoNg.Name = "ProductionNoNg"
        Me.ProductionNoNg.Size = New System.Drawing.Size(81, 20)
        Me.ProductionNoNg.TabIndex = 191
        Me.ProductionNoNg.Text = "NG不上"
        Me.ProductionNoNg.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label25.Location = New System.Drawing.Point(270, 519)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(147, 19)
        Me.Label25.TabIndex = 195
        Me.Label25.Text = "浮鎖判斷百分比:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label26.Location = New System.Drawing.Point(25, 519)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(147, 19)
        Me.Label26.TabIndex = 194
        Me.Label26.Text = "浮鎖判斷百分比:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label34.Location = New System.Drawing.Point(270, 483)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(147, 19)
        Me.Label34.TabIndex = 193
        Me.Label34.Text = "滑牙判斷百分比:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label40.Location = New System.Drawing.Point(25, 483)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(147, 19)
        Me.Label40.TabIndex = 192
        Me.Label40.Text = "滑牙判斷百分比:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1295, 740)
        Me.ShapeContainer1.TabIndex = 196
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.Location = New System.Drawing.Point(230, 567)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(116, 110)
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label41.Location = New System.Drawing.Point(500, 66)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(141, 21)
        Me.Label41.TabIndex = 197
        Me.Label41.Text = "設定螺絲數量:"
        '
        'ScrewNum
        '
        Me.ScrewNum.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ScrewNum.Location = New System.Drawing.Point(648, 57)
        Me.ScrewNum.Margin = New System.Windows.Forms.Padding(2)
        Me.ScrewNum.Name = "ScrewNum"
        Me.ScrewNum.Size = New System.Drawing.Size(87, 30)
        Me.ScrewNum.TabIndex = 198
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label42.Location = New System.Drawing.Point(500, 20)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(142, 19)
        Me.Label42.TabIndex = 199
        Me.Label42.Text = "繼電器COM Port"
        '
        'RelayCom
        '
        Me.RelayCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RelayCom.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RelayCom.FormattingEnabled = True
        Me.RelayCom.Location = New System.Drawing.Point(648, 19)
        Me.RelayCom.Name = "RelayCom"
        Me.RelayCom.Size = New System.Drawing.Size(87, 27)
        Me.RelayCom.TabIndex = 201
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label43.Location = New System.Drawing.Point(535, 674)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(685, 57)
        Me.Label43.TabIndex = 202
        Me.Label43.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & "如果有問題需要協助請找 張老師(分機742) 或 明叡(分機743) 或俊緯(分機744)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 740)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.RelayCom)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.ScrewNum)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.ProductionNoNg)
        Me.Controls.Add(Me.TestNoNg)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.RadioMesProduction)
        Me.Controls.Add(Me.RadioMesTest)
        Me.Controls.Add(Me.RadioNoMes)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.WkStationNam)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.LblNG)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.LblPASS)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.TxtOpCode)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.WkorderNum)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.OrderNum)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.modelNam)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.ScrewStatus)
        Me.Controls.Add(Me.LblBarCode)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.ScannerCOMPort)
        Me.Controls.Add(Me.BarcodeCOM)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.choice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ScrewCOMPort)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ScrewCOM)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "鎖螺絲機測量"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents BtnConnect As Button
    Friend WithEvents ScrewCOM As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ScrewCOMPort As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents choice As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ScannerCOMPort As Label
    Friend WithEvents BarcodeCOM As TextBox
    Friend WithEvents SerialPort2 As IO.Ports.SerialPort
    Friend WithEvents LblBarCode As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents ScrewStatus As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents WkStationNam As TextBox
    Friend WithEvents Quantity As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents LblNG As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents LblPASS As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents TxtOpCode As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents OrderNum As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents modelNam As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents WkorderNum As TextBox
    Friend WithEvents RadioMesProduction As RadioButton
    Friend WithEvents RadioMesTest As RadioButton
    Friend WithEvents RadioNoMes As RadioButton
    Friend WithEvents Label24 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents TestNoNg As CheckBox
    Friend WithEvents ProductionNoNg As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents Label41 As Label
    Friend WithEvents ScrewNum As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents RelayCom As ComboBox
    Friend WithEvents SerialPort3 As IO.Ports.SerialPort
    Friend WithEvents Label43 As Label
End Class
