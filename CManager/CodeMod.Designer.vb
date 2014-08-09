<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeMod
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
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TonDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.TonDataTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.tonDataTableAdapter()
        Me.tons1 = New System.Windows.Forms.TextBox()
        Me.cost1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.code1 = New System.Windows.Forms.TextBox()
        Me.code2 = New System.Windows.Forms.TextBox()
        Me.cost2 = New System.Windows.Forms.TextBox()
        Me.tons2 = New System.Windows.Forms.TextBox()
        Me.code3 = New System.Windows.Forms.TextBox()
        Me.cost3 = New System.Windows.Forms.TextBox()
        Me.tons3 = New System.Windows.Forms.TextBox()
        Me.code4 = New System.Windows.Forms.TextBox()
        Me.cost4 = New System.Windows.Forms.TextBox()
        Me.tons4 = New System.Windows.Forms.TextBox()
        Me.code8 = New System.Windows.Forms.TextBox()
        Me.cost8 = New System.Windows.Forms.TextBox()
        Me.tons8 = New System.Windows.Forms.TextBox()
        Me.code7 = New System.Windows.Forms.TextBox()
        Me.cost7 = New System.Windows.Forms.TextBox()
        Me.tons7 = New System.Windows.Forms.TextBox()
        Me.code6 = New System.Windows.Forms.TextBox()
        Me.cost6 = New System.Windows.Forms.TextBox()
        Me.tons6 = New System.Windows.Forms.TextBox()
        Me.code5 = New System.Windows.Forms.TextBox()
        Me.cost5 = New System.Windows.Forms.TextBox()
        Me.tons5 = New System.Windows.Forms.TextBox()
        Me.code10 = New System.Windows.Forms.TextBox()
        Me.cost10 = New System.Windows.Forms.TextBox()
        Me.tons10 = New System.Windows.Forms.TextBox()
        Me.code9 = New System.Windows.Forms.TextBox()
        Me.cost9 = New System.Windows.Forms.TextBox()
        Me.tons9 = New System.Windows.Forms.TextBox()
        Me.code14 = New System.Windows.Forms.TextBox()
        Me.cost14 = New System.Windows.Forms.TextBox()
        Me.tons14 = New System.Windows.Forms.TextBox()
        Me.code13 = New System.Windows.Forms.TextBox()
        Me.cost13 = New System.Windows.Forms.TextBox()
        Me.tons13 = New System.Windows.Forms.TextBox()
        Me.code12 = New System.Windows.Forms.TextBox()
        Me.cost12 = New System.Windows.Forms.TextBox()
        Me.tons12 = New System.Windows.Forms.TextBox()
        Me.code11 = New System.Windows.Forms.TextBox()
        Me.cost11 = New System.Windows.Forms.TextBox()
        Me.tons11 = New System.Windows.Forms.TextBox()
        Me.code18 = New System.Windows.Forms.TextBox()
        Me.cost18 = New System.Windows.Forms.TextBox()
        Me.tons18 = New System.Windows.Forms.TextBox()
        Me.code17 = New System.Windows.Forms.TextBox()
        Me.cost17 = New System.Windows.Forms.TextBox()
        Me.tons17 = New System.Windows.Forms.TextBox()
        Me.code16 = New System.Windows.Forms.TextBox()
        Me.cost16 = New System.Windows.Forms.TextBox()
        Me.tons16 = New System.Windows.Forms.TextBox()
        Me.code15 = New System.Windows.Forms.TextBox()
        Me.cost15 = New System.Windows.Forms.TextBox()
        Me.tons15 = New System.Windows.Forms.TextBox()
        Me.code20 = New System.Windows.Forms.TextBox()
        Me.cost20 = New System.Windows.Forms.TextBox()
        Me.tons20 = New System.Windows.Forms.TextBox()
        Me.code19 = New System.Windows.Forms.TextBox()
        Me.cost19 = New System.Windows.Forms.TextBox()
        Me.tons19 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.TonDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TonDataBindingSource
        '
        Me.TonDataBindingSource.DataMember = "tonData"
        Me.TonDataBindingSource.DataSource = Me.SourceDBDataSet
        '
        'SourceDBDataSet
        '
        Me.SourceDBDataSet.DataSetName = "SourceDBDataSet"
        Me.SourceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TonDataTableAdapter
        '
        Me.TonDataTableAdapter.ClearBeforeFill = True
        '
        'tons1
        '
        Me.tons1.Location = New System.Drawing.Point(66, 41)
        Me.tons1.Name = "tons1"
        Me.tons1.Size = New System.Drawing.Size(100, 21)
        Me.tons1.TabIndex = 1
        '
        'cost1
        '
        Me.cost1.Location = New System.Drawing.Point(172, 41)
        Me.cost1.Name = "cost1"
        Me.cost1.Size = New System.Drawing.Size(100, 21)
        Me.cost1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "코드"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "톤수"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "금액"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(498, 321)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(61, 42)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "확인"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(430, 321)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(61, 42)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "취소"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'code1
        '
        Me.code1.Location = New System.Drawing.Point(20, 41)
        Me.code1.Name = "code1"
        Me.code1.Size = New System.Drawing.Size(40, 21)
        Me.code1.TabIndex = 10
        Me.code1.Text = "a"
        Me.code1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'code2
        '
        Me.code2.Location = New System.Drawing.Point(20, 68)
        Me.code2.Name = "code2"
        Me.code2.Size = New System.Drawing.Size(40, 21)
        Me.code2.TabIndex = 13
        Me.code2.Text = "b"
        Me.code2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost2
        '
        Me.cost2.Location = New System.Drawing.Point(172, 68)
        Me.cost2.Name = "cost2"
        Me.cost2.Size = New System.Drawing.Size(100, 21)
        Me.cost2.TabIndex = 12
        '
        'tons2
        '
        Me.tons2.Location = New System.Drawing.Point(66, 68)
        Me.tons2.Name = "tons2"
        Me.tons2.Size = New System.Drawing.Size(100, 21)
        Me.tons2.TabIndex = 11
        '
        'code3
        '
        Me.code3.Location = New System.Drawing.Point(20, 95)
        Me.code3.Name = "code3"
        Me.code3.Size = New System.Drawing.Size(40, 21)
        Me.code3.TabIndex = 16
        Me.code3.Text = "c"
        Me.code3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost3
        '
        Me.cost3.Location = New System.Drawing.Point(172, 95)
        Me.cost3.Name = "cost3"
        Me.cost3.Size = New System.Drawing.Size(100, 21)
        Me.cost3.TabIndex = 15
        '
        'tons3
        '
        Me.tons3.Location = New System.Drawing.Point(66, 95)
        Me.tons3.Name = "tons3"
        Me.tons3.Size = New System.Drawing.Size(100, 21)
        Me.tons3.TabIndex = 14
        '
        'code4
        '
        Me.code4.Location = New System.Drawing.Point(20, 122)
        Me.code4.Name = "code4"
        Me.code4.Size = New System.Drawing.Size(40, 21)
        Me.code4.TabIndex = 19
        Me.code4.Text = "d"
        Me.code4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost4
        '
        Me.cost4.Location = New System.Drawing.Point(172, 122)
        Me.cost4.Name = "cost4"
        Me.cost4.Size = New System.Drawing.Size(100, 21)
        Me.cost4.TabIndex = 18
        '
        'tons4
        '
        Me.tons4.Location = New System.Drawing.Point(66, 122)
        Me.tons4.Name = "tons4"
        Me.tons4.Size = New System.Drawing.Size(100, 21)
        Me.tons4.TabIndex = 17
        '
        'code8
        '
        Me.code8.Location = New System.Drawing.Point(20, 230)
        Me.code8.Name = "code8"
        Me.code8.Size = New System.Drawing.Size(40, 21)
        Me.code8.TabIndex = 31
        Me.code8.Text = "h"
        Me.code8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost8
        '
        Me.cost8.Location = New System.Drawing.Point(172, 230)
        Me.cost8.Name = "cost8"
        Me.cost8.Size = New System.Drawing.Size(100, 21)
        Me.cost8.TabIndex = 30
        '
        'tons8
        '
        Me.tons8.Location = New System.Drawing.Point(66, 230)
        Me.tons8.Name = "tons8"
        Me.tons8.Size = New System.Drawing.Size(100, 21)
        Me.tons8.TabIndex = 29
        '
        'code7
        '
        Me.code7.Location = New System.Drawing.Point(20, 203)
        Me.code7.Name = "code7"
        Me.code7.Size = New System.Drawing.Size(40, 21)
        Me.code7.TabIndex = 28
        Me.code7.Text = "g"
        Me.code7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost7
        '
        Me.cost7.Location = New System.Drawing.Point(172, 203)
        Me.cost7.Name = "cost7"
        Me.cost7.Size = New System.Drawing.Size(100, 21)
        Me.cost7.TabIndex = 27
        '
        'tons7
        '
        Me.tons7.Location = New System.Drawing.Point(66, 203)
        Me.tons7.Name = "tons7"
        Me.tons7.Size = New System.Drawing.Size(100, 21)
        Me.tons7.TabIndex = 26
        '
        'code6
        '
        Me.code6.Location = New System.Drawing.Point(20, 176)
        Me.code6.Name = "code6"
        Me.code6.Size = New System.Drawing.Size(40, 21)
        Me.code6.TabIndex = 25
        Me.code6.Text = "f"
        Me.code6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost6
        '
        Me.cost6.Location = New System.Drawing.Point(172, 176)
        Me.cost6.Name = "cost6"
        Me.cost6.Size = New System.Drawing.Size(100, 21)
        Me.cost6.TabIndex = 24
        '
        'tons6
        '
        Me.tons6.Location = New System.Drawing.Point(66, 176)
        Me.tons6.Name = "tons6"
        Me.tons6.Size = New System.Drawing.Size(100, 21)
        Me.tons6.TabIndex = 23
        '
        'code5
        '
        Me.code5.Location = New System.Drawing.Point(20, 149)
        Me.code5.Name = "code5"
        Me.code5.Size = New System.Drawing.Size(40, 21)
        Me.code5.TabIndex = 22
        Me.code5.Text = "e"
        Me.code5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost5
        '
        Me.cost5.Location = New System.Drawing.Point(172, 149)
        Me.cost5.Name = "cost5"
        Me.cost5.Size = New System.Drawing.Size(100, 21)
        Me.cost5.TabIndex = 21
        '
        'tons5
        '
        Me.tons5.Location = New System.Drawing.Point(66, 149)
        Me.tons5.Name = "tons5"
        Me.tons5.Size = New System.Drawing.Size(100, 21)
        Me.tons5.TabIndex = 20
        '
        'code10
        '
        Me.code10.Location = New System.Drawing.Point(20, 284)
        Me.code10.Name = "code10"
        Me.code10.Size = New System.Drawing.Size(40, 21)
        Me.code10.TabIndex = 37
        Me.code10.Text = "j"
        Me.code10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost10
        '
        Me.cost10.Location = New System.Drawing.Point(172, 284)
        Me.cost10.Name = "cost10"
        Me.cost10.Size = New System.Drawing.Size(100, 21)
        Me.cost10.TabIndex = 36
        '
        'tons10
        '
        Me.tons10.Location = New System.Drawing.Point(66, 284)
        Me.tons10.Name = "tons10"
        Me.tons10.Size = New System.Drawing.Size(100, 21)
        Me.tons10.TabIndex = 35
        '
        'code9
        '
        Me.code9.Location = New System.Drawing.Point(20, 257)
        Me.code9.Name = "code9"
        Me.code9.Size = New System.Drawing.Size(40, 21)
        Me.code9.TabIndex = 34
        Me.code9.Text = "i"
        Me.code9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost9
        '
        Me.cost9.Location = New System.Drawing.Point(172, 257)
        Me.cost9.Name = "cost9"
        Me.cost9.Size = New System.Drawing.Size(100, 21)
        Me.cost9.TabIndex = 33
        '
        'tons9
        '
        Me.tons9.Location = New System.Drawing.Point(66, 257)
        Me.tons9.Name = "tons9"
        Me.tons9.Size = New System.Drawing.Size(100, 21)
        Me.tons9.TabIndex = 32
        '
        'code14
        '
        Me.code14.Location = New System.Drawing.Point(307, 122)
        Me.code14.Name = "code14"
        Me.code14.Size = New System.Drawing.Size(40, 21)
        Me.code14.TabIndex = 55
        Me.code14.Text = "n"
        Me.code14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost14
        '
        Me.cost14.Location = New System.Drawing.Point(459, 122)
        Me.cost14.Name = "cost14"
        Me.cost14.Size = New System.Drawing.Size(100, 21)
        Me.cost14.TabIndex = 54
        '
        'tons14
        '
        Me.tons14.Location = New System.Drawing.Point(353, 122)
        Me.tons14.Name = "tons14"
        Me.tons14.Size = New System.Drawing.Size(100, 21)
        Me.tons14.TabIndex = 53
        '
        'code13
        '
        Me.code13.Location = New System.Drawing.Point(307, 95)
        Me.code13.Name = "code13"
        Me.code13.Size = New System.Drawing.Size(40, 21)
        Me.code13.TabIndex = 52
        Me.code13.Text = "m"
        Me.code13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost13
        '
        Me.cost13.Location = New System.Drawing.Point(459, 95)
        Me.cost13.Name = "cost13"
        Me.cost13.Size = New System.Drawing.Size(100, 21)
        Me.cost13.TabIndex = 51
        '
        'tons13
        '
        Me.tons13.Location = New System.Drawing.Point(353, 95)
        Me.tons13.Name = "tons13"
        Me.tons13.Size = New System.Drawing.Size(100, 21)
        Me.tons13.TabIndex = 50
        '
        'code12
        '
        Me.code12.Location = New System.Drawing.Point(307, 68)
        Me.code12.Name = "code12"
        Me.code12.Size = New System.Drawing.Size(40, 21)
        Me.code12.TabIndex = 49
        Me.code12.Text = "l"
        Me.code12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost12
        '
        Me.cost12.Location = New System.Drawing.Point(459, 68)
        Me.cost12.Name = "cost12"
        Me.cost12.Size = New System.Drawing.Size(100, 21)
        Me.cost12.TabIndex = 48
        '
        'tons12
        '
        Me.tons12.Location = New System.Drawing.Point(353, 68)
        Me.tons12.Name = "tons12"
        Me.tons12.Size = New System.Drawing.Size(100, 21)
        Me.tons12.TabIndex = 47
        '
        'code11
        '
        Me.code11.Location = New System.Drawing.Point(307, 41)
        Me.code11.Name = "code11"
        Me.code11.Size = New System.Drawing.Size(40, 21)
        Me.code11.TabIndex = 46
        Me.code11.Text = "k"
        Me.code11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost11
        '
        Me.cost11.Location = New System.Drawing.Point(459, 41)
        Me.cost11.Name = "cost11"
        Me.cost11.Size = New System.Drawing.Size(100, 21)
        Me.cost11.TabIndex = 45
        '
        'tons11
        '
        Me.tons11.Location = New System.Drawing.Point(353, 41)
        Me.tons11.Name = "tons11"
        Me.tons11.Size = New System.Drawing.Size(100, 21)
        Me.tons11.TabIndex = 44
        '
        'code18
        '
        Me.code18.Location = New System.Drawing.Point(307, 230)
        Me.code18.Name = "code18"
        Me.code18.Size = New System.Drawing.Size(40, 21)
        Me.code18.TabIndex = 67
        Me.code18.Text = "r"
        Me.code18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost18
        '
        Me.cost18.Location = New System.Drawing.Point(459, 230)
        Me.cost18.Name = "cost18"
        Me.cost18.Size = New System.Drawing.Size(100, 21)
        Me.cost18.TabIndex = 66
        '
        'tons18
        '
        Me.tons18.Location = New System.Drawing.Point(353, 230)
        Me.tons18.Name = "tons18"
        Me.tons18.Size = New System.Drawing.Size(100, 21)
        Me.tons18.TabIndex = 65
        '
        'code17
        '
        Me.code17.Location = New System.Drawing.Point(307, 203)
        Me.code17.Name = "code17"
        Me.code17.Size = New System.Drawing.Size(40, 21)
        Me.code17.TabIndex = 64
        Me.code17.Text = "q"
        Me.code17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost17
        '
        Me.cost17.Location = New System.Drawing.Point(459, 203)
        Me.cost17.Name = "cost17"
        Me.cost17.Size = New System.Drawing.Size(100, 21)
        Me.cost17.TabIndex = 63
        '
        'tons17
        '
        Me.tons17.Location = New System.Drawing.Point(353, 203)
        Me.tons17.Name = "tons17"
        Me.tons17.Size = New System.Drawing.Size(100, 21)
        Me.tons17.TabIndex = 62
        '
        'code16
        '
        Me.code16.Location = New System.Drawing.Point(307, 176)
        Me.code16.Name = "code16"
        Me.code16.Size = New System.Drawing.Size(40, 21)
        Me.code16.TabIndex = 61
        Me.code16.Text = "p"
        Me.code16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost16
        '
        Me.cost16.Location = New System.Drawing.Point(459, 176)
        Me.cost16.Name = "cost16"
        Me.cost16.Size = New System.Drawing.Size(100, 21)
        Me.cost16.TabIndex = 60
        '
        'tons16
        '
        Me.tons16.Location = New System.Drawing.Point(353, 176)
        Me.tons16.Name = "tons16"
        Me.tons16.Size = New System.Drawing.Size(100, 21)
        Me.tons16.TabIndex = 59
        '
        'code15
        '
        Me.code15.Location = New System.Drawing.Point(307, 149)
        Me.code15.Name = "code15"
        Me.code15.Size = New System.Drawing.Size(40, 21)
        Me.code15.TabIndex = 58
        Me.code15.Text = "o"
        Me.code15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost15
        '
        Me.cost15.Location = New System.Drawing.Point(459, 149)
        Me.cost15.Name = "cost15"
        Me.cost15.Size = New System.Drawing.Size(100, 21)
        Me.cost15.TabIndex = 57
        '
        'tons15
        '
        Me.tons15.Location = New System.Drawing.Point(353, 149)
        Me.tons15.Name = "tons15"
        Me.tons15.Size = New System.Drawing.Size(100, 21)
        Me.tons15.TabIndex = 56
        '
        'code20
        '
        Me.code20.Location = New System.Drawing.Point(307, 284)
        Me.code20.Name = "code20"
        Me.code20.Size = New System.Drawing.Size(40, 21)
        Me.code20.TabIndex = 73
        Me.code20.Text = "t"
        Me.code20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost20
        '
        Me.cost20.Location = New System.Drawing.Point(459, 284)
        Me.cost20.Name = "cost20"
        Me.cost20.Size = New System.Drawing.Size(100, 21)
        Me.cost20.TabIndex = 72
        '
        'tons20
        '
        Me.tons20.Location = New System.Drawing.Point(353, 284)
        Me.tons20.Name = "tons20"
        Me.tons20.Size = New System.Drawing.Size(100, 21)
        Me.tons20.TabIndex = 71
        '
        'code19
        '
        Me.code19.Location = New System.Drawing.Point(307, 257)
        Me.code19.Name = "code19"
        Me.code19.Size = New System.Drawing.Size(40, 21)
        Me.code19.TabIndex = 70
        Me.code19.Text = "s"
        Me.code19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cost19
        '
        Me.cost19.Location = New System.Drawing.Point(459, 257)
        Me.cost19.Name = "cost19"
        Me.cost19.Size = New System.Drawing.Size(100, 21)
        Me.cost19.TabIndex = 69
        '
        'tons19
        '
        Me.tons19.Location = New System.Drawing.Point(353, 257)
        Me.tons19.Name = "tons19"
        Me.tons19.Size = New System.Drawing.Size(100, 21)
        Me.tons19.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(496, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "금액"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(391, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "톤수"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(314, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "코드"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(353, 347)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(64, 16)
        Me.CheckBox1.TabIndex = 77
        Me.CheckBox1.Text = "항상 위"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CodeMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 378)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.code20)
        Me.Controls.Add(Me.cost20)
        Me.Controls.Add(Me.tons20)
        Me.Controls.Add(Me.code19)
        Me.Controls.Add(Me.cost19)
        Me.Controls.Add(Me.tons19)
        Me.Controls.Add(Me.code18)
        Me.Controls.Add(Me.cost18)
        Me.Controls.Add(Me.tons18)
        Me.Controls.Add(Me.code17)
        Me.Controls.Add(Me.cost17)
        Me.Controls.Add(Me.tons17)
        Me.Controls.Add(Me.code16)
        Me.Controls.Add(Me.cost16)
        Me.Controls.Add(Me.tons16)
        Me.Controls.Add(Me.code15)
        Me.Controls.Add(Me.cost15)
        Me.Controls.Add(Me.tons15)
        Me.Controls.Add(Me.code14)
        Me.Controls.Add(Me.cost14)
        Me.Controls.Add(Me.tons14)
        Me.Controls.Add(Me.code13)
        Me.Controls.Add(Me.cost13)
        Me.Controls.Add(Me.tons13)
        Me.Controls.Add(Me.code12)
        Me.Controls.Add(Me.cost12)
        Me.Controls.Add(Me.tons12)
        Me.Controls.Add(Me.code11)
        Me.Controls.Add(Me.cost11)
        Me.Controls.Add(Me.tons11)
        Me.Controls.Add(Me.code10)
        Me.Controls.Add(Me.cost10)
        Me.Controls.Add(Me.tons10)
        Me.Controls.Add(Me.code9)
        Me.Controls.Add(Me.cost9)
        Me.Controls.Add(Me.tons9)
        Me.Controls.Add(Me.code8)
        Me.Controls.Add(Me.cost8)
        Me.Controls.Add(Me.tons8)
        Me.Controls.Add(Me.code7)
        Me.Controls.Add(Me.cost7)
        Me.Controls.Add(Me.tons7)
        Me.Controls.Add(Me.code6)
        Me.Controls.Add(Me.cost6)
        Me.Controls.Add(Me.tons6)
        Me.Controls.Add(Me.code5)
        Me.Controls.Add(Me.cost5)
        Me.Controls.Add(Me.tons5)
        Me.Controls.Add(Me.code4)
        Me.Controls.Add(Me.cost4)
        Me.Controls.Add(Me.tons4)
        Me.Controls.Add(Me.code3)
        Me.Controls.Add(Me.cost3)
        Me.Controls.Add(Me.tons3)
        Me.Controls.Add(Me.code2)
        Me.Controls.Add(Me.cost2)
        Me.Controls.Add(Me.tons2)
        Me.Controls.Add(Me.code1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cost1)
        Me.Controls.Add(Me.tons1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CodeMod"
        Me.Text = "코드 수정"
        CType(Me.TonDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SourceDBDataSet As ForkliftManager.SourceDBDataSet
    Friend WithEvents TonDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TonDataTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.tonDataTableAdapter
    Friend WithEvents tons1 As System.Windows.Forms.TextBox
    Friend WithEvents cost1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents code1 As System.Windows.Forms.TextBox
    Friend WithEvents code2 As System.Windows.Forms.TextBox
    Friend WithEvents cost2 As System.Windows.Forms.TextBox
    Friend WithEvents tons2 As System.Windows.Forms.TextBox
    Friend WithEvents code3 As System.Windows.Forms.TextBox
    Friend WithEvents cost3 As System.Windows.Forms.TextBox
    Friend WithEvents tons3 As System.Windows.Forms.TextBox
    Friend WithEvents code4 As System.Windows.Forms.TextBox
    Friend WithEvents cost4 As System.Windows.Forms.TextBox
    Friend WithEvents tons4 As System.Windows.Forms.TextBox
    Friend WithEvents code8 As System.Windows.Forms.TextBox
    Friend WithEvents cost8 As System.Windows.Forms.TextBox
    Friend WithEvents tons8 As System.Windows.Forms.TextBox
    Friend WithEvents code7 As System.Windows.Forms.TextBox
    Friend WithEvents cost7 As System.Windows.Forms.TextBox
    Friend WithEvents tons7 As System.Windows.Forms.TextBox
    Friend WithEvents code6 As System.Windows.Forms.TextBox
    Friend WithEvents cost6 As System.Windows.Forms.TextBox
    Friend WithEvents tons6 As System.Windows.Forms.TextBox
    Friend WithEvents code5 As System.Windows.Forms.TextBox
    Friend WithEvents cost5 As System.Windows.Forms.TextBox
    Friend WithEvents tons5 As System.Windows.Forms.TextBox
    Friend WithEvents code10 As System.Windows.Forms.TextBox
    Friend WithEvents cost10 As System.Windows.Forms.TextBox
    Friend WithEvents tons10 As System.Windows.Forms.TextBox
    Friend WithEvents code9 As System.Windows.Forms.TextBox
    Friend WithEvents cost9 As System.Windows.Forms.TextBox
    Friend WithEvents tons9 As System.Windows.Forms.TextBox
    Friend WithEvents code14 As System.Windows.Forms.TextBox
    Friend WithEvents cost14 As System.Windows.Forms.TextBox
    Friend WithEvents tons14 As System.Windows.Forms.TextBox
    Friend WithEvents code13 As System.Windows.Forms.TextBox
    Friend WithEvents cost13 As System.Windows.Forms.TextBox
    Friend WithEvents tons13 As System.Windows.Forms.TextBox
    Friend WithEvents code12 As System.Windows.Forms.TextBox
    Friend WithEvents cost12 As System.Windows.Forms.TextBox
    Friend WithEvents tons12 As System.Windows.Forms.TextBox
    Friend WithEvents code11 As System.Windows.Forms.TextBox
    Friend WithEvents cost11 As System.Windows.Forms.TextBox
    Friend WithEvents tons11 As System.Windows.Forms.TextBox
    Friend WithEvents code18 As System.Windows.Forms.TextBox
    Friend WithEvents cost18 As System.Windows.Forms.TextBox
    Friend WithEvents tons18 As System.Windows.Forms.TextBox
    Friend WithEvents code17 As System.Windows.Forms.TextBox
    Friend WithEvents cost17 As System.Windows.Forms.TextBox
    Friend WithEvents tons17 As System.Windows.Forms.TextBox
    Friend WithEvents code16 As System.Windows.Forms.TextBox
    Friend WithEvents cost16 As System.Windows.Forms.TextBox
    Friend WithEvents tons16 As System.Windows.Forms.TextBox
    Friend WithEvents code15 As System.Windows.Forms.TextBox
    Friend WithEvents cost15 As System.Windows.Forms.TextBox
    Friend WithEvents tons15 As System.Windows.Forms.TextBox
    Friend WithEvents code20 As System.Windows.Forms.TextBox
    Friend WithEvents cost20 As System.Windows.Forms.TextBox
    Friend WithEvents tons20 As System.Windows.Forms.TextBox
    Friend WithEvents code19 As System.Windows.Forms.TextBox
    Friend WithEvents cost19 As System.Windows.Forms.TextBox
    Friend WithEvents tons19 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
