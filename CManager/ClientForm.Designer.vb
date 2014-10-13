<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button_GridView = New System.Windows.Forms.Button()
        Me.dgv_cliList = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.tBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tBox7 = New System.Windows.Forms.TextBox()
        Me.Label_ = New System.Windows.Forms.Label()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Modify = New System.Windows.Forms.Button()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.tBox8 = New System.Windows.Forms.TextBox()
        Me.tBox6 = New System.Windows.Forms.TextBox()
        Me.tBox5 = New System.Windows.Forms.TextBox()
        Me.tBox4 = New System.Windows.Forms.TextBox()
        Me.tBox3 = New System.Windows.Forms.TextBox()
        Me.tBox2 = New System.Windows.Forms.TextBox()
        Me.Label_etc = New System.Windows.Forms.Label()
        Me.Label_jongmok = New System.Windows.Forms.Label()
        Me.Label_type = New System.Windows.Forms.Label()
        Me.Label_addr = New System.Windows.Forms.Label()
        Me.Label_identify_num = New System.Windows.Forms.Label()
        Me.Label_company = New System.Windows.Forms.Label()
        Me.dgv_dealList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.d_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_dealMod = New System.Windows.Forms.Button()
        Me.btn_dealDel = New System.Windows.Forms.Button()
        Me.DdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtonsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DealBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.KeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheadnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CjongmokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CidnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CcommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter1 = New ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter()
        Me.DealTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.dealTableAdapter()
        CType(Me.dgv_cliList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dealList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_GridView
        '
        Me.Button_GridView.Location = New System.Drawing.Point(672, 610)
        Me.Button_GridView.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_GridView.Name = "Button_GridView"
        Me.Button_GridView.Size = New System.Drawing.Size(83, 46)
        Me.Button_GridView.TabIndex = 100
        Me.Button_GridView.Text = "새로고침"
        Me.Button_GridView.UseVisualStyleBackColor = True
        '
        'dgv_cliList
        '
        Me.dgv_cliList.AutoGenerateColumns = False
        Me.dgv_cliList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_cliList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_cliList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cliList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeyDataGridViewTextBoxColumn, Me.CnameDataGridViewTextBoxColumn, Me.CheadnameDataGridViewTextBoxColumn, Me.CaddressDataGridViewTextBoxColumn, Me.CtypeDataGridViewTextBoxColumn, Me.CjongmokDataGridViewTextBoxColumn, Me.CidnumDataGridViewTextBoxColumn, Me.CcommentDataGridViewTextBoxColumn})
        Me.dgv_cliList.DataSource = Me.ClientBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_cliList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_cliList.Location = New System.Drawing.Point(10, 10)
        Me.dgv_cliList.Margin = New System.Windows.Forms.Padding(1)
        Me.dgv_cliList.Name = "dgv_cliList"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_cliList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_cliList.RowTemplate.Height = 37
        Me.dgv_cliList.Size = New System.Drawing.Size(745, 592)
        Me.dgv_cliList.TabIndex = 73
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(986, 80)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(129, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "상호명으로 찾기"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblStat
        '
        Me.lblStat.AutoSize = True
        Me.lblStat.Location = New System.Drawing.Point(871, 64)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(0, 12)
        Me.lblStat.TabIndex = 100
        Me.lblStat.Visible = False
        '
        'tBox1
        '
        Me.tBox1.Enabled = False
        Me.tBox1.Location = New System.Drawing.Point(851, 11)
        Me.tBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox1.Name = "tBox1"
        Me.tBox1.Size = New System.Drawing.Size(114, 21)
        Me.tBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(796, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 12)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "거래처ID"
        '
        'tBox7
        '
        Me.tBox7.Enabled = False
        Me.tBox7.Location = New System.Drawing.Point(851, 46)
        Me.tBox7.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox7.Name = "tBox7"
        Me.tBox7.Size = New System.Drawing.Size(114, 21)
        Me.tBox7.TabIndex = 2
        '
        'Label_
        '
        Me.Label_.AutoSize = True
        Me.Label_.Location = New System.Drawing.Point(795, 121)
        Me.Label_.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_.Name = "Label_"
        Me.Label_.Size = New System.Drawing.Size(53, 12)
        Me.Label_.TabIndex = 98
        Me.Label_.Text = "대표자명"
        '
        'Button_OK
        '
        Me.Button_OK.Location = New System.Drawing.Point(1153, 166)
        Me.Button_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(137, 42)
        Me.Button_OK.TabIndex = 97
        Me.Button_OK.Text = "저장"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(1153, 219)
        Me.Button_Clear.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(137, 24)
        Me.Button_Clear.TabIndex = 98
        Me.Button_Clear.Text = "취소"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Enabled = False
        Me.Button_Delete.Location = New System.Drawing.Point(1153, 114)
        Me.Button_Delete.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(137, 42)
        Me.Button_Delete.TabIndex = 96
        Me.Button_Delete.Text = "삭제"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Modify
        '
        Me.Button_Modify.Enabled = False
        Me.Button_Modify.Location = New System.Drawing.Point(1153, 62)
        Me.Button_Modify.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Modify.Name = "Button_Modify"
        Me.Button_Modify.Size = New System.Drawing.Size(137, 42)
        Me.Button_Modify.TabIndex = 95
        Me.Button_Modify.Text = "수정"
        Me.Button_Modify.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(1153, 10)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(137, 42)
        Me.Button_Add.TabIndex = 94
        Me.Button_Add.Text = "추가"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'tBox8
        '
        Me.tBox8.Enabled = False
        Me.tBox8.Location = New System.Drawing.Point(851, 221)
        Me.tBox8.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox8.Name = "tBox8"
        Me.tBox8.Size = New System.Drawing.Size(279, 21)
        Me.tBox8.TabIndex = 8
        '
        'tBox6
        '
        Me.tBox6.Enabled = False
        Me.tBox6.Location = New System.Drawing.Point(1016, 186)
        Me.tBox6.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox6.Name = "tBox6"
        Me.tBox6.Size = New System.Drawing.Size(114, 21)
        Me.tBox6.TabIndex = 7
        '
        'tBox5
        '
        Me.tBox5.Enabled = False
        Me.tBox5.Location = New System.Drawing.Point(851, 186)
        Me.tBox5.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox5.Name = "tBox5"
        Me.tBox5.Size = New System.Drawing.Size(114, 21)
        Me.tBox5.TabIndex = 6
        '
        'tBox4
        '
        Me.tBox4.Enabled = False
        Me.tBox4.Location = New System.Drawing.Point(851, 151)
        Me.tBox4.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox4.Name = "tBox4"
        Me.tBox4.Size = New System.Drawing.Size(279, 21)
        Me.tBox4.TabIndex = 5
        '
        'tBox3
        '
        Me.tBox3.Enabled = False
        Me.tBox3.Location = New System.Drawing.Point(851, 116)
        Me.tBox3.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox3.Name = "tBox3"
        Me.tBox3.Size = New System.Drawing.Size(114, 21)
        Me.tBox3.TabIndex = 4
        '
        'tBox2
        '
        Me.tBox2.Location = New System.Drawing.Point(851, 81)
        Me.tBox2.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox2.Name = "tBox2"
        Me.tBox2.Size = New System.Drawing.Size(114, 21)
        Me.tBox2.TabIndex = 3
        '
        'Label_etc
        '
        Me.Label_etc.AutoSize = True
        Me.Label_etc.Location = New System.Drawing.Point(819, 225)
        Me.Label_etc.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_etc.Name = "Label_etc"
        Me.Label_etc.Size = New System.Drawing.Size(29, 12)
        Me.Label_etc.TabIndex = 93
        Me.Label_etc.Text = "비고"
        '
        'Label_jongmok
        '
        Me.Label_jongmok.AutoSize = True
        Me.Label_jongmok.Location = New System.Drawing.Point(984, 190)
        Me.Label_jongmok.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_jongmok.Name = "Label_jongmok"
        Me.Label_jongmok.Size = New System.Drawing.Size(29, 12)
        Me.Label_jongmok.TabIndex = 92
        Me.Label_jongmok.Text = "종목"
        '
        'Label_type
        '
        Me.Label_type.AutoSize = True
        Me.Label_type.Location = New System.Drawing.Point(819, 190)
        Me.Label_type.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_type.Name = "Label_type"
        Me.Label_type.Size = New System.Drawing.Size(29, 12)
        Me.Label_type.TabIndex = 91
        Me.Label_type.Text = "업태"
        '
        'Label_addr
        '
        Me.Label_addr.AutoSize = True
        Me.Label_addr.Location = New System.Drawing.Point(783, 156)
        Me.Label_addr.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_addr.Name = "Label_addr"
        Me.Label_addr.Size = New System.Drawing.Size(65, 12)
        Me.Label_addr.TabIndex = 90
        Me.Label_addr.Text = "사업장주소"
        '
        'Label_identify_num
        '
        Me.Label_identify_num.AutoSize = True
        Me.Label_identify_num.Location = New System.Drawing.Point(783, 50)
        Me.Label_identify_num.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_identify_num.Name = "Label_identify_num"
        Me.Label_identify_num.Size = New System.Drawing.Size(65, 12)
        Me.Label_identify_num.TabIndex = 89
        Me.Label_identify_num.Text = "사업자번호"
        '
        'Label_company
        '
        Me.Label_company.AutoSize = True
        Me.Label_company.Location = New System.Drawing.Point(801, 86)
        Me.Label_company.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_company.Name = "Label_company"
        Me.Label_company.Size = New System.Drawing.Size(47, 12)
        Me.Label_company.TabIndex = 88
        Me.Label_company.Text = "*상호명"
        '
        'dgv_dealList
        '
        Me.dgv_dealList.AutoGenerateColumns = False
        Me.dgv_dealList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dealList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DdateDataGridViewTextBoxColumn, Me.d_user, Me.DtonsDataGridViewTextBoxColumn, Me.DqtyDataGridViewTextBoxColumn, Me.DcostDataGridViewTextBoxColumn})
        Me.dgv_dealList.DataSource = Me.DealBindingSource
        Me.dgv_dealList.Location = New System.Drawing.Point(770, 273)
        Me.dgv_dealList.Name = "dgv_dealList"
        Me.dgv_dealList.RowTemplate.Height = 23
        Me.dgv_dealList.Size = New System.Drawing.Size(520, 329)
        Me.dgv_dealList.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.DataPropertyName = "deal_id"
        Me.Column1.HeaderText = "거래번호"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 78
        '
        'd_user
        '
        Me.d_user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.d_user.DataPropertyName = "d_user"
        Me.d_user.HeaderText = "작업자"
        Me.d_user.Name = "d_user"
        Me.d_user.ReadOnly = True
        Me.d_user.Width = 66
        '
        'btn_dealMod
        '
        Me.btn_dealMod.Location = New System.Drawing.Point(1137, 610)
        Me.btn_dealMod.Name = "btn_dealMod"
        Me.btn_dealMod.Size = New System.Drawing.Size(75, 46)
        Me.btn_dealMod.TabIndex = 104
        Me.btn_dealMod.Text = "수정"
        Me.btn_dealMod.UseVisualStyleBackColor = True
        '
        'btn_dealDel
        '
        Me.btn_dealDel.Location = New System.Drawing.Point(1215, 610)
        Me.btn_dealDel.Name = "btn_dealDel"
        Me.btn_dealDel.Size = New System.Drawing.Size(75, 46)
        Me.btn_dealDel.TabIndex = 105
        Me.btn_dealDel.Text = "삭제"
        Me.btn_dealDel.UseVisualStyleBackColor = True
        '
        'DdateDataGridViewTextBoxColumn
        '
        Me.DdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DdateDataGridViewTextBoxColumn.DataPropertyName = "d_date"
        Me.DdateDataGridViewTextBoxColumn.HeaderText = "거래일자"
        Me.DdateDataGridViewTextBoxColumn.Name = "DdateDataGridViewTextBoxColumn"
        Me.DdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DdateDataGridViewTextBoxColumn.Width = 78
        '
        'DtonsDataGridViewTextBoxColumn
        '
        Me.DtonsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DtonsDataGridViewTextBoxColumn.DataPropertyName = "d_tons"
        Me.DtonsDataGridViewTextBoxColumn.HeaderText = "톤수"
        Me.DtonsDataGridViewTextBoxColumn.Name = "DtonsDataGridViewTextBoxColumn"
        Me.DtonsDataGridViewTextBoxColumn.ReadOnly = True
        Me.DtonsDataGridViewTextBoxColumn.Width = 54
        '
        'DqtyDataGridViewTextBoxColumn
        '
        Me.DqtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DqtyDataGridViewTextBoxColumn.DataPropertyName = "d_qty"
        Me.DqtyDataGridViewTextBoxColumn.HeaderText = "수량"
        Me.DqtyDataGridViewTextBoxColumn.Name = "DqtyDataGridViewTextBoxColumn"
        Me.DqtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.DqtyDataGridViewTextBoxColumn.Width = 54
        '
        'DcostDataGridViewTextBoxColumn
        '
        Me.DcostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DcostDataGridViewTextBoxColumn.DataPropertyName = "d_cost"
        Me.DcostDataGridViewTextBoxColumn.HeaderText = "거래액"
        Me.DcostDataGridViewTextBoxColumn.Name = "DcostDataGridViewTextBoxColumn"
        Me.DcostDataGridViewTextBoxColumn.ReadOnly = True
        Me.DcostDataGridViewTextBoxColumn.Width = 66
        '
        'DealBindingSource
        '
        Me.DealBindingSource.DataMember = "deal"
        Me.DealBindingSource.DataSource = Me.SourceDBDataSet
        '
        'SourceDBDataSet
        '
        Me.SourceDBDataSet.DataSetName = "SourceDBDataSet"
        Me.SourceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KeyDataGridViewTextBoxColumn
        '
        Me.KeyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.KeyDataGridViewTextBoxColumn.DataPropertyName = "key"
        Me.KeyDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.KeyDataGridViewTextBoxColumn.Name = "KeyDataGridViewTextBoxColumn"
        Me.KeyDataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyDataGridViewTextBoxColumn.Width = 41
        '
        'CnameDataGridViewTextBoxColumn
        '
        Me.CnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CnameDataGridViewTextBoxColumn.DataPropertyName = "c_name"
        Me.CnameDataGridViewTextBoxColumn.HeaderText = "상호명"
        Me.CnameDataGridViewTextBoxColumn.Name = "CnameDataGridViewTextBoxColumn"
        Me.CnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CnameDataGridViewTextBoxColumn.Width = 66
        '
        'CheadnameDataGridViewTextBoxColumn
        '
        Me.CheadnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CheadnameDataGridViewTextBoxColumn.DataPropertyName = "c_headname"
        Me.CheadnameDataGridViewTextBoxColumn.HeaderText = "대표자명"
        Me.CheadnameDataGridViewTextBoxColumn.Name = "CheadnameDataGridViewTextBoxColumn"
        Me.CheadnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CheadnameDataGridViewTextBoxColumn.Width = 78
        '
        'CaddressDataGridViewTextBoxColumn
        '
        Me.CaddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CaddressDataGridViewTextBoxColumn.DataPropertyName = "c_address"
        Me.CaddressDataGridViewTextBoxColumn.HeaderText = "사업장주소"
        Me.CaddressDataGridViewTextBoxColumn.Name = "CaddressDataGridViewTextBoxColumn"
        Me.CaddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.CaddressDataGridViewTextBoxColumn.Width = 90
        '
        'CtypeDataGridViewTextBoxColumn
        '
        Me.CtypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CtypeDataGridViewTextBoxColumn.DataPropertyName = "c_type"
        Me.CtypeDataGridViewTextBoxColumn.HeaderText = "업태"
        Me.CtypeDataGridViewTextBoxColumn.Name = "CtypeDataGridViewTextBoxColumn"
        Me.CtypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CtypeDataGridViewTextBoxColumn.Width = 54
        '
        'CjongmokDataGridViewTextBoxColumn
        '
        Me.CjongmokDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CjongmokDataGridViewTextBoxColumn.DataPropertyName = "c_jongmok"
        Me.CjongmokDataGridViewTextBoxColumn.HeaderText = "종목"
        Me.CjongmokDataGridViewTextBoxColumn.Name = "CjongmokDataGridViewTextBoxColumn"
        Me.CjongmokDataGridViewTextBoxColumn.ReadOnly = True
        Me.CjongmokDataGridViewTextBoxColumn.Width = 54
        '
        'CidnumDataGridViewTextBoxColumn
        '
        Me.CidnumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CidnumDataGridViewTextBoxColumn.DataPropertyName = "c_idnum"
        Me.CidnumDataGridViewTextBoxColumn.HeaderText = "사업자번호"
        Me.CidnumDataGridViewTextBoxColumn.Name = "CidnumDataGridViewTextBoxColumn"
        Me.CidnumDataGridViewTextBoxColumn.ReadOnly = True
        Me.CidnumDataGridViewTextBoxColumn.Width = 90
        '
        'CcommentDataGridViewTextBoxColumn
        '
        Me.CcommentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CcommentDataGridViewTextBoxColumn.DataPropertyName = "c_comment"
        Me.CcommentDataGridViewTextBoxColumn.HeaderText = "비고"
        Me.CcommentDataGridViewTextBoxColumn.Name = "CcommentDataGridViewTextBoxColumn"
        Me.CcommentDataGridViewTextBoxColumn.ReadOnly = True
        Me.CcommentDataGridViewTextBoxColumn.Width = 54
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "client"
        Me.ClientBindingSource.DataSource = Me.SourceDBDataSet
        '
        'ClientTableAdapter1
        '
        Me.ClientTableAdapter1.ClearBeforeFill = True
        '
        'DealTableAdapter
        '
        Me.DealTableAdapter.ClearBeforeFill = True
        '
        'ClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 666)
        Me.Controls.Add(Me.tBox1)
        Me.Controls.Add(Me.btn_dealDel)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btn_dealMod)
        Me.Controls.Add(Me.Label_company)
        Me.Controls.Add(Me.dgv_dealList)
        Me.Controls.Add(Me.lblStat)
        Me.Controls.Add(Me.Label_identify_num)
        Me.Controls.Add(Me.dgv_cliList)
        Me.Controls.Add(Me.Label_addr)
        Me.Controls.Add(Me.Button_GridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Label_type)
        Me.Controls.Add(Me.tBox8)
        Me.Controls.Add(Me.tBox7)
        Me.Controls.Add(Me.tBox6)
        Me.Controls.Add(Me.Label_jongmok)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.Label_)
        Me.Controls.Add(Me.tBox5)
        Me.Controls.Add(Me.Label_etc)
        Me.Controls.Add(Me.Button_Modify)
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.tBox4)
        Me.Controls.Add(Me.tBox2)
        Me.Controls.Add(Me.tBox3)
        Me.Controls.Add(Me.Button_Clear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "ClientForm"
        Me.Text = "거래처 관리"
        CType(Me.dgv_cliList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dealList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_GridView As System.Windows.Forms.Button
    Friend WithEvents dgv_cliList As System.Windows.Forms.DataGridView
    Friend WithEvents ClientTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter
    Friend WithEvents SourceDBDataSet As ForkliftManager.SourceDBDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter1 As ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblStat As System.Windows.Forms.Label
    Friend WithEvents tBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label_ As System.Windows.Forms.Label
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents Button_Clear As System.Windows.Forms.Button
    Friend WithEvents Button_Delete As System.Windows.Forms.Button
    Friend WithEvents Button_Modify As System.Windows.Forms.Button
    Friend WithEvents Button_Add As System.Windows.Forms.Button
    Friend WithEvents tBox8 As System.Windows.Forms.TextBox
    Friend WithEvents tBox6 As System.Windows.Forms.TextBox
    Friend WithEvents tBox5 As System.Windows.Forms.TextBox
    Friend WithEvents tBox4 As System.Windows.Forms.TextBox
    Friend WithEvents tBox3 As System.Windows.Forms.TextBox
    Friend WithEvents tBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label_etc As System.Windows.Forms.Label
    Friend WithEvents Label_jongmok As System.Windows.Forms.Label
    Friend WithEvents Label_type As System.Windows.Forms.Label
    Friend WithEvents Label_addr As System.Windows.Forms.Label
    Friend WithEvents Label_identify_num As System.Windows.Forms.Label
    Friend WithEvents Label_company As System.Windows.Forms.Label
    Friend WithEvents dgv_dealList As System.Windows.Forms.DataGridView
    Friend WithEvents DealBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DealTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.dealTableAdapter
    Friend WithEvents btn_dealMod As System.Windows.Forms.Button
    Friend WithEvents btn_dealDel As System.Windows.Forms.Button
    Friend WithEvents KeyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheadnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CjongmokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CidnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CcommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents d_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtonsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DqtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DcostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
