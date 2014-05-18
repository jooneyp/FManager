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
        Me.tBoxIden = New System.Windows.Forms.TextBox()
        Me.Label_ = New System.Windows.Forms.Label()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.lblAOE = New System.Windows.Forms.Label()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_GridView = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Modify = New System.Windows.Forms.Button()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Button_Search = New System.Windows.Forms.Button()
        Me.tBoxComment = New System.Windows.Forms.TextBox()
        Me.tBoxJongmok = New System.Windows.Forms.TextBox()
        Me.tBoxType = New System.Windows.Forms.TextBox()
        Me.tBoxAddr = New System.Windows.Forms.TextBox()
        Me.tBoxHeadname = New System.Windows.Forms.TextBox()
        Me.tBoxName = New System.Windows.Forms.TextBox()
        Me.Label_etc = New System.Windows.Forms.Label()
        Me.Label_jongmok = New System.Windows.Forms.Label()
        Me.Label_type = New System.Windows.Forms.Label()
        Me.Label_addr = New System.Windows.Forms.Label()
        Me.Label_identify_num = New System.Windows.Forms.Label()
        Me.Label_company = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheadnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CjongmokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CidnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CcommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.ClientTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tBoxIden
        '
        Me.tBoxIden.Location = New System.Drawing.Point(101, 85)
        Me.tBoxIden.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxIden.Name = "tBoxIden"
        Me.tBoxIden.Size = New System.Drawing.Size(114, 21)
        Me.tBoxIden.TabIndex = 51
        '
        'Label_
        '
        Me.Label_.AutoSize = True
        Me.Label_.Location = New System.Drawing.Point(249, 87)
        Me.Label_.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_.Name = "Label_"
        Me.Label_.Size = New System.Drawing.Size(37, 12)
        Me.Label_.TabIndex = 72
        Me.Label_.Text = "성명 :"
        '
        'Button_OK
        '
        Me.Button_OK.Location = New System.Drawing.Point(423, 85)
        Me.Button_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(181, 53)
        Me.Button_OK.TabIndex = 57
        Me.Button_OK.Text = "저장하기"
        Me.Button_OK.UseVisualStyleBackColor = True
        Me.Button_OK.Visible = False
        '
        'lblAOE
        '
        Me.lblAOE.AutoSize = True
        Me.lblAOE.Location = New System.Drawing.Point(525, 227)
        Me.lblAOE.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAOE.Name = "lblAOE"
        Me.lblAOE.Size = New System.Drawing.Size(69, 12)
        Me.lblAOE.TabIndex = 71
        Me.lblAOE.Text = "Add Or Edit"
        Me.lblAOE.Visible = False
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(325, 15)
        Me.Button_Clear.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(83, 53)
        Me.Button_Clear.TabIndex = 70
        Me.Button_Clear.Text = "비우기"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_GridView
        '
        Me.Button_GridView.Location = New System.Drawing.Point(423, 156)
        Me.Button_GridView.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_GridView.Name = "Button_GridView"
        Me.Button_GridView.Size = New System.Drawing.Size(278, 53)
        Me.Button_GridView.TabIndex = 69
        Me.Button_GridView.Text = "데이터 목록 보기"
        Me.Button_GridView.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(619, 85)
        Me.Button_Delete.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(83, 53)
        Me.Button_Delete.TabIndex = 68
        Me.Button_Delete.Text = "삭제"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Modify
        '
        Me.Button_Modify.Location = New System.Drawing.Point(521, 85)
        Me.Button_Modify.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Modify.Name = "Button_Modify"
        Me.Button_Modify.Size = New System.Drawing.Size(83, 53)
        Me.Button_Modify.TabIndex = 67
        Me.Button_Modify.Text = "수정"
        Me.Button_Modify.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(423, 85)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(83, 53)
        Me.Button_Add.TabIndex = 66
        Me.Button_Add.Text = "추가"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Search
        '
        Me.Button_Search.Location = New System.Drawing.Point(423, 15)
        Me.Button_Search.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(278, 53)
        Me.Button_Search.TabIndex = 65
        Me.Button_Search.Text = "찾기"
        Me.Button_Search.UseVisualStyleBackColor = True
        '
        'tBoxComment
        '
        Me.tBoxComment.Location = New System.Drawing.Point(101, 191)
        Me.tBoxComment.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxComment.Multiline = True
        Me.tBoxComment.Name = "tBoxComment"
        Me.tBoxComment.Size = New System.Drawing.Size(308, 19)
        Me.tBoxComment.TabIndex = 56
        '
        'tBoxJongmok
        '
        Me.tBoxJongmok.Location = New System.Drawing.Point(295, 155)
        Me.tBoxJongmok.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxJongmok.Name = "tBoxJongmok"
        Me.tBoxJongmok.Size = New System.Drawing.Size(114, 21)
        Me.tBoxJongmok.TabIndex = 55
        '
        'tBoxType
        '
        Me.tBoxType.Location = New System.Drawing.Point(101, 155)
        Me.tBoxType.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxType.Name = "tBoxType"
        Me.tBoxType.Size = New System.Drawing.Size(114, 21)
        Me.tBoxType.TabIndex = 54
        '
        'tBoxAddr
        '
        Me.tBoxAddr.Location = New System.Drawing.Point(101, 120)
        Me.tBoxAddr.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxAddr.Name = "tBoxAddr"
        Me.tBoxAddr.Size = New System.Drawing.Size(308, 21)
        Me.tBoxAddr.TabIndex = 53
        '
        'tBoxHeadname
        '
        Me.tBoxHeadname.Location = New System.Drawing.Point(295, 85)
        Me.tBoxHeadname.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxHeadname.Name = "tBoxHeadname"
        Me.tBoxHeadname.Size = New System.Drawing.Size(114, 21)
        Me.tBoxHeadname.TabIndex = 52
        '
        'tBoxName
        '
        Me.tBoxName.Location = New System.Drawing.Point(101, 50)
        Me.tBoxName.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxName.Name = "tBoxName"
        Me.tBoxName.Size = New System.Drawing.Size(114, 21)
        Me.tBoxName.TabIndex = 50
        '
        'Label_etc
        '
        Me.Label_etc.AutoSize = True
        Me.Label_etc.Location = New System.Drawing.Point(55, 193)
        Me.Label_etc.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_etc.Name = "Label_etc"
        Me.Label_etc.Size = New System.Drawing.Size(37, 12)
        Me.Label_etc.TabIndex = 64
        Me.Label_etc.Text = "비고 :"
        '
        'Label_jongmok
        '
        Me.Label_jongmok.AutoSize = True
        Me.Label_jongmok.Location = New System.Drawing.Point(249, 158)
        Me.Label_jongmok.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_jongmok.Name = "Label_jongmok"
        Me.Label_jongmok.Size = New System.Drawing.Size(37, 12)
        Me.Label_jongmok.TabIndex = 63
        Me.Label_jongmok.Text = "종목 :"
        '
        'Label_type
        '
        Me.Label_type.AutoSize = True
        Me.Label_type.Location = New System.Drawing.Point(55, 159)
        Me.Label_type.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_type.Name = "Label_type"
        Me.Label_type.Size = New System.Drawing.Size(37, 12)
        Me.Label_type.TabIndex = 62
        Me.Label_type.Text = "업태 :"
        '
        'Label_addr
        '
        Me.Label_addr.AutoSize = True
        Me.Label_addr.Location = New System.Drawing.Point(17, 123)
        Me.Label_addr.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_addr.Name = "Label_addr"
        Me.Label_addr.Size = New System.Drawing.Size(73, 12)
        Me.Label_addr.TabIndex = 61
        Me.Label_addr.Text = "사업장주소 :"
        '
        'Label_identify_num
        '
        Me.Label_identify_num.AutoSize = True
        Me.Label_identify_num.Location = New System.Drawing.Point(17, 89)
        Me.Label_identify_num.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_identify_num.Name = "Label_identify_num"
        Me.Label_identify_num.Size = New System.Drawing.Size(73, 12)
        Me.Label_identify_num.TabIndex = 60
        Me.Label_identify_num.Text = "사업자번호 :"
        '
        'Label_company
        '
        Me.Label_company.AutoSize = True
        Me.Label_company.Location = New System.Drawing.Point(55, 54)
        Me.Label_company.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label_company.Name = "Label_company"
        Me.Label_company.Size = New System.Drawing.Size(37, 12)
        Me.Label_company.TabIndex = 59
        Me.Label_company.Text = "상호 :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CnameDataGridViewTextBoxColumn, Me.CaddressDataGridViewTextBoxColumn, Me.CheadnameDataGridViewTextBoxColumn, Me.CtypeDataGridViewTextBoxColumn, Me.CjongmokDataGridViewTextBoxColumn, Me.CidnumDataGridViewTextBoxColumn, Me.CcommentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 263)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(685, 209)
        Me.DataGridView1.TabIndex = 73
        '
        'CnameDataGridViewTextBoxColumn
        '
        Me.CnameDataGridViewTextBoxColumn.DataPropertyName = "c_name"
        Me.CnameDataGridViewTextBoxColumn.HeaderText = "c_name"
        Me.CnameDataGridViewTextBoxColumn.Name = "CnameDataGridViewTextBoxColumn"
        '
        'CaddressDataGridViewTextBoxColumn
        '
        Me.CaddressDataGridViewTextBoxColumn.DataPropertyName = "c_address"
        Me.CaddressDataGridViewTextBoxColumn.HeaderText = "c_address"
        Me.CaddressDataGridViewTextBoxColumn.Name = "CaddressDataGridViewTextBoxColumn"
        '
        'CheadnameDataGridViewTextBoxColumn
        '
        Me.CheadnameDataGridViewTextBoxColumn.DataPropertyName = "c_headname"
        Me.CheadnameDataGridViewTextBoxColumn.HeaderText = "c_headname"
        Me.CheadnameDataGridViewTextBoxColumn.Name = "CheadnameDataGridViewTextBoxColumn"
        '
        'CtypeDataGridViewTextBoxColumn
        '
        Me.CtypeDataGridViewTextBoxColumn.DataPropertyName = "c_type"
        Me.CtypeDataGridViewTextBoxColumn.HeaderText = "c_type"
        Me.CtypeDataGridViewTextBoxColumn.Name = "CtypeDataGridViewTextBoxColumn"
        '
        'CjongmokDataGridViewTextBoxColumn
        '
        Me.CjongmokDataGridViewTextBoxColumn.DataPropertyName = "c_jongmok"
        Me.CjongmokDataGridViewTextBoxColumn.HeaderText = "c_jongmok"
        Me.CjongmokDataGridViewTextBoxColumn.Name = "CjongmokDataGridViewTextBoxColumn"
        '
        'CidnumDataGridViewTextBoxColumn
        '
        Me.CidnumDataGridViewTextBoxColumn.DataPropertyName = "c_idnum"
        Me.CidnumDataGridViewTextBoxColumn.HeaderText = "c_idnum"
        Me.CidnumDataGridViewTextBoxColumn.Name = "CidnumDataGridViewTextBoxColumn"
        '
        'CcommentDataGridViewTextBoxColumn
        '
        Me.CcommentDataGridViewTextBoxColumn.DataPropertyName = "c_comment"
        Me.CcommentDataGridViewTextBoxColumn.HeaderText = "c_comment"
        Me.CcommentDataGridViewTextBoxColumn.Name = "CcommentDataGridViewTextBoxColumn"
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "client"
        Me.ClientBindingSource.DataSource = Me.SourceDBDataSet
        '
        'SourceDBDataSet
        '
        Me.SourceDBDataSet.DataSetName = "SourceDBDataSet"
        Me.SourceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'ClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 501)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tBoxIden)
        Me.Controls.Add(Me.Label_)
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.lblAOE)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_GridView)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Modify)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.Button_Search)
        Me.Controls.Add(Me.tBoxComment)
        Me.Controls.Add(Me.tBoxJongmok)
        Me.Controls.Add(Me.tBoxType)
        Me.Controls.Add(Me.tBoxAddr)
        Me.Controls.Add(Me.tBoxHeadname)
        Me.Controls.Add(Me.tBoxName)
        Me.Controls.Add(Me.Label_etc)
        Me.Controls.Add(Me.Label_jongmok)
        Me.Controls.Add(Me.Label_type)
        Me.Controls.Add(Me.Label_addr)
        Me.Controls.Add(Me.Label_identify_num)
        Me.Controls.Add(Me.Label_company)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximumSize = New System.Drawing.Size(739, 540)
        Me.MinimumSize = New System.Drawing.Size(739, 540)
        Me.Name = "ClientForm"
        Me.Text = "업체 관리"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents tBoxIden As System.Windows.Forms.TextBox
    Friend WithEvents Label_ As System.Windows.Forms.Label
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents lblAOE As System.Windows.Forms.Label
    Friend WithEvents Button_Clear As System.Windows.Forms.Button
    Friend WithEvents Button_GridView As System.Windows.Forms.Button
    Friend WithEvents Button_Delete As System.Windows.Forms.Button
    Friend WithEvents Button_Modify As System.Windows.Forms.Button
    Friend WithEvents Button_Add As System.Windows.Forms.Button
    Friend WithEvents Button_Search As System.Windows.Forms.Button
    Friend WithEvents tBoxComment As System.Windows.Forms.TextBox
    Friend WithEvents tBoxJongmok As System.Windows.Forms.TextBox
    Friend WithEvents tBoxType As System.Windows.Forms.TextBox
    Friend WithEvents tBoxAddr As System.Windows.Forms.TextBox
    Friend WithEvents tBoxHeadname As System.Windows.Forms.TextBox
    Friend WithEvents tBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label_etc As System.Windows.Forms.Label
    Friend WithEvents Label_jongmok As System.Windows.Forms.Label
    Friend WithEvents Label_type As System.Windows.Forms.Label
    Friend WithEvents Label_addr As System.Windows.Forms.Label
    Friend WithEvents Label_identify_num As System.Windows.Forms.Label
    Friend WithEvents Label_company As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SourceDBDataSet As ForkliftManager.SourceDBDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter
    Friend WithEvents CnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheadnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CjongmokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CidnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CcommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
