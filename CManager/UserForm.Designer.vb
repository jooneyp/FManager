<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tBox7 = New System.Windows.Forms.TextBox()
        Me.Label_ = New System.Windows.Forms.Label()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_GridView = New System.Windows.Forms.Button()
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
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.tBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.UserTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.KeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UheadnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UjongmokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UidnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UcommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tBox7
        '
        Me.tBox7.Enabled = False
        Me.tBox7.Location = New System.Drawing.Point(568, 231)
        Me.tBox7.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox7.Name = "tBox7"
        Me.tBox7.Size = New System.Drawing.Size(114, 21)
        Me.tBox7.TabIndex = 7
        '
        'Label_
        '
        Me.Label_.AutoSize = True
        Me.Label_.Location = New System.Drawing.Point(512, 131)
        Me.Label_.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_.Name = "Label_"
        Me.Label_.Size = New System.Drawing.Size(53, 12)
        Me.Label_.TabIndex = 72
        Me.Label_.Text = "대표자명"
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(870, 263)
        Me.Button_Clear.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(83, 21)
        Me.Button_Clear.TabIndex = 70
        Me.Button_Clear.Text = "취소"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_GridView
        '
        Me.Button_GridView.Location = New System.Drawing.Point(402, 10)
        Me.Button_GridView.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_GridView.Name = "Button_GridView"
        Me.Button_GridView.Size = New System.Drawing.Size(83, 36)
        Me.Button_GridView.TabIndex = 69
        Me.Button_GridView.Text = "새로고침"
        Me.Button_GridView.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Enabled = False
        Me.Button_Delete.Location = New System.Drawing.Point(870, 158)
        Me.Button_Delete.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(83, 42)
        Me.Button_Delete.TabIndex = 68
        Me.Button_Delete.Text = "삭제"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Modify
        '
        Me.Button_Modify.Enabled = False
        Me.Button_Modify.Location = New System.Drawing.Point(870, 106)
        Me.Button_Modify.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Modify.Name = "Button_Modify"
        Me.Button_Modify.Size = New System.Drawing.Size(83, 42)
        Me.Button_Modify.TabIndex = 67
        Me.Button_Modify.Text = "수정"
        Me.Button_Modify.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(870, 54)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(83, 42)
        Me.Button_Add.TabIndex = 66
        Me.Button_Add.Text = "추가"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'tBox8
        '
        Me.tBox8.Enabled = False
        Me.tBox8.Location = New System.Drawing.Point(568, 266)
        Me.tBox8.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox8.Multiline = True
        Me.tBox8.Name = "tBox8"
        Me.tBox8.Size = New System.Drawing.Size(279, 19)
        Me.tBox8.TabIndex = 8
        '
        'tBox6
        '
        Me.tBox6.Enabled = False
        Me.tBox6.Location = New System.Drawing.Point(733, 196)
        Me.tBox6.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox6.Name = "tBox6"
        Me.tBox6.Size = New System.Drawing.Size(114, 21)
        Me.tBox6.TabIndex = 6
        '
        'tBox5
        '
        Me.tBox5.Enabled = False
        Me.tBox5.Location = New System.Drawing.Point(568, 196)
        Me.tBox5.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox5.Name = "tBox5"
        Me.tBox5.Size = New System.Drawing.Size(114, 21)
        Me.tBox5.TabIndex = 5
        '
        'tBox4
        '
        Me.tBox4.Enabled = False
        Me.tBox4.Location = New System.Drawing.Point(568, 161)
        Me.tBox4.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox4.Name = "tBox4"
        Me.tBox4.Size = New System.Drawing.Size(279, 21)
        Me.tBox4.TabIndex = 4
        '
        'tBox3
        '
        Me.tBox3.Enabled = False
        Me.tBox3.Location = New System.Drawing.Point(568, 126)
        Me.tBox3.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox3.Name = "tBox3"
        Me.tBox3.Size = New System.Drawing.Size(114, 21)
        Me.tBox3.TabIndex = 3
        '
        'tBox2
        '
        Me.tBox2.Location = New System.Drawing.Point(568, 91)
        Me.tBox2.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox2.Name = "tBox2"
        Me.tBox2.Size = New System.Drawing.Size(114, 21)
        Me.tBox2.TabIndex = 2
        '
        'Label_etc
        '
        Me.Label_etc.AutoSize = True
        Me.Label_etc.Location = New System.Drawing.Point(512, 269)
        Me.Label_etc.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_etc.Name = "Label_etc"
        Me.Label_etc.Size = New System.Drawing.Size(53, 12)
        Me.Label_etc.TabIndex = 64
        Me.Label_etc.Text = "계좌번호"
        '
        'Label_jongmok
        '
        Me.Label_jongmok.AutoSize = True
        Me.Label_jongmok.Location = New System.Drawing.Point(701, 200)
        Me.Label_jongmok.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_jongmok.Name = "Label_jongmok"
        Me.Label_jongmok.Size = New System.Drawing.Size(29, 12)
        Me.Label_jongmok.TabIndex = 63
        Me.Label_jongmok.Text = "종목"
        '
        'Label_type
        '
        Me.Label_type.AutoSize = True
        Me.Label_type.Location = New System.Drawing.Point(536, 200)
        Me.Label_type.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_type.Name = "Label_type"
        Me.Label_type.Size = New System.Drawing.Size(29, 12)
        Me.Label_type.TabIndex = 62
        Me.Label_type.Text = "업태"
        '
        'Label_addr
        '
        Me.Label_addr.AutoSize = True
        Me.Label_addr.Location = New System.Drawing.Point(500, 166)
        Me.Label_addr.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_addr.Name = "Label_addr"
        Me.Label_addr.Size = New System.Drawing.Size(65, 12)
        Me.Label_addr.TabIndex = 61
        Me.Label_addr.Text = "사업장주소"
        '
        'Label_identify_num
        '
        Me.Label_identify_num.AutoSize = True
        Me.Label_identify_num.Location = New System.Drawing.Point(500, 235)
        Me.Label_identify_num.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_identify_num.Name = "Label_identify_num"
        Me.Label_identify_num.Size = New System.Drawing.Size(65, 12)
        Me.Label_identify_num.TabIndex = 60
        Me.Label_identify_num.Text = "사업자번호"
        '
        'Label_company
        '
        Me.Label_company.AutoSize = True
        Me.Label_company.Location = New System.Drawing.Point(518, 96)
        Me.Label_company.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_company.Name = "Label_company"
        Me.Label_company.Size = New System.Drawing.Size(47, 12)
        Me.Label_company.TabIndex = 59
        Me.Label_company.Text = "*상호명"
        '
        'DataGridView
        '
        Me.DataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeyDataGridViewTextBoxColumn, Me.UnameDataGridViewTextBoxColumn, Me.UheadnameDataGridViewTextBoxColumn, Me.UaddressDataGridViewTextBoxColumn, Me.UtypeDataGridViewTextBoxColumn, Me.UjongmokDataGridViewTextBoxColumn, Me.UidnumDataGridViewTextBoxColumn, Me.UcommentDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.UserBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView.Location = New System.Drawing.Point(10, 56)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridView.Name = "DataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView.RowTemplate.Height = 37
        Me.DataGridView.Size = New System.Drawing.Size(475, 619)
        Me.DataGridView.TabIndex = 73
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.SourceDBDataSet
        '
        'SourceDBDataSet
        '
        Me.SourceDBDataSet.DataSetName = "SourceDBDataSet"
        Me.SourceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button_OK
        '
        Me.Button_OK.Location = New System.Drawing.Point(870, 210)
        Me.Button_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(83, 42)
        Me.Button_OK.TabIndex = 57
        Me.Button_OK.Text = "저장"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'tBox1
        '
        Me.tBox1.Enabled = False
        Me.tBox1.Location = New System.Drawing.Point(568, 56)
        Me.tBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.tBox1.Name = "tBox1"
        Me.tBox1.Size = New System.Drawing.Size(114, 21)
        Me.tBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(513, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 12)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "거래처ID"
        '
        'lblStat
        '
        Me.lblStat.AutoSize = True
        Me.lblStat.Location = New System.Drawing.Point(588, 110)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(0, 12)
        Me.lblStat.TabIndex = 76
        Me.lblStat.Visible = False
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(703, 90)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(129, 23)
        Me.btnSearch.TabIndex = 78
        Me.btnSearch.Text = "상호명으로 찾기"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'KeyDataGridViewTextBoxColumn
        '
        Me.KeyDataGridViewTextBoxColumn.DataPropertyName = "key"
        Me.KeyDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.KeyDataGridViewTextBoxColumn.Name = "KeyDataGridViewTextBoxColumn"
        Me.KeyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnameDataGridViewTextBoxColumn
        '
        Me.UnameDataGridViewTextBoxColumn.DataPropertyName = "u_name"
        Me.UnameDataGridViewTextBoxColumn.HeaderText = "상호명"
        Me.UnameDataGridViewTextBoxColumn.Name = "UnameDataGridViewTextBoxColumn"
        Me.UnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UheadnameDataGridViewTextBoxColumn
        '
        Me.UheadnameDataGridViewTextBoxColumn.DataPropertyName = "u_headname"
        Me.UheadnameDataGridViewTextBoxColumn.HeaderText = "대표자명"
        Me.UheadnameDataGridViewTextBoxColumn.Name = "UheadnameDataGridViewTextBoxColumn"
        Me.UheadnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UaddressDataGridViewTextBoxColumn
        '
        Me.UaddressDataGridViewTextBoxColumn.DataPropertyName = "u_address"
        Me.UaddressDataGridViewTextBoxColumn.HeaderText = "사업장주소"
        Me.UaddressDataGridViewTextBoxColumn.Name = "UaddressDataGridViewTextBoxColumn"
        Me.UaddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UtypeDataGridViewTextBoxColumn
        '
        Me.UtypeDataGridViewTextBoxColumn.DataPropertyName = "u_type"
        Me.UtypeDataGridViewTextBoxColumn.HeaderText = "업태"
        Me.UtypeDataGridViewTextBoxColumn.Name = "UtypeDataGridViewTextBoxColumn"
        Me.UtypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UjongmokDataGridViewTextBoxColumn
        '
        Me.UjongmokDataGridViewTextBoxColumn.DataPropertyName = "u_jongmok"
        Me.UjongmokDataGridViewTextBoxColumn.HeaderText = "종목"
        Me.UjongmokDataGridViewTextBoxColumn.Name = "UjongmokDataGridViewTextBoxColumn"
        Me.UjongmokDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UidnumDataGridViewTextBoxColumn
        '
        Me.UidnumDataGridViewTextBoxColumn.DataPropertyName = "u_idnum"
        Me.UidnumDataGridViewTextBoxColumn.HeaderText = "사업자번호"
        Me.UidnumDataGridViewTextBoxColumn.Name = "UidnumDataGridViewTextBoxColumn"
        Me.UidnumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UcommentDataGridViewTextBoxColumn
        '
        Me.UcommentDataGridViewTextBoxColumn.DataPropertyName = "u_comment"
        Me.UcommentDataGridViewTextBoxColumn.HeaderText = "계좌번호"
        Me.UcommentDataGridViewTextBoxColumn.Name = "UcommentDataGridViewTextBoxColumn"
        Me.UcommentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(973, 685)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblStat)
        Me.Controls.Add(Me.tBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.tBox7)
        Me.Controls.Add(Me.Label_)
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_GridView)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Modify)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.tBox8)
        Me.Controls.Add(Me.tBox6)
        Me.Controls.Add(Me.tBox5)
        Me.Controls.Add(Me.tBox4)
        Me.Controls.Add(Me.tBox3)
        Me.Controls.Add(Me.tBox2)
        Me.Controls.Add(Me.Label_etc)
        Me.Controls.Add(Me.Label_jongmok)
        Me.Controls.Add(Me.Label_type)
        Me.Controls.Add(Me.Label_addr)
        Me.Controls.Add(Me.Label_identify_num)
        Me.Controls.Add(Me.Label_company)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "UserForm"
        Me.Text = "사용자 관리"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label_ As System.Windows.Forms.Label
    Friend WithEvents Button_Clear As System.Windows.Forms.Button
    Friend WithEvents Button_GridView As System.Windows.Forms.Button
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
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ClientTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents tBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStat As System.Windows.Forms.Label
    Friend WithEvents SourceDBDataSet As ForkliftManager.SourceDBDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents KeyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UheadnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UaddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UjongmokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UidnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UcommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
