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
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.tBoxIdnum = New System.Windows.Forms.TextBox()
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
        Me.tBoxName = New System.Windows.Forms.TextBox()
        Me.lblEtc = New System.Windows.Forms.Label()
        Me.lblBAccount = New System.Windows.Forms.Label()
        Me.lblBName = New System.Windows.Forms.Label()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tBoxHeadname = New System.Windows.Forms.TextBox()
        Me.UserTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter()
        Me.UcommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UidnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UheadnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'tBoxIdnum
        '
        Me.tBoxIdnum.Location = New System.Drawing.Point(95, 85)
        Me.tBoxIdnum.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxIdnum.Name = "tBoxIdnum"
        Me.tBoxIdnum.Size = New System.Drawing.Size(114, 21)
        Me.tBoxIdnum.TabIndex = 52
        '
        'Button_OK
        '
        Me.Button_OK.Location = New System.Drawing.Point(419, 85)
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
        Me.lblAOE.Location = New System.Drawing.Point(519, 226)
        Me.lblAOE.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAOE.Name = "lblAOE"
        Me.lblAOE.Size = New System.Drawing.Size(69, 12)
        Me.lblAOE.TabIndex = 71
        Me.lblAOE.Text = "Add Or Edit"
        Me.lblAOE.Visible = False
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(319, 15)
        Me.Button_Clear.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(83, 53)
        Me.Button_Clear.TabIndex = 70
        Me.Button_Clear.Text = "비우기"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_GridView
        '
        Me.Button_GridView.Location = New System.Drawing.Point(419, 155)
        Me.Button_GridView.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_GridView.Name = "Button_GridView"
        Me.Button_GridView.Size = New System.Drawing.Size(278, 53)
        Me.Button_GridView.TabIndex = 69
        Me.Button_GridView.Text = "데이터 목록 보기"
        Me.Button_GridView.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(614, 85)
        Me.Button_Delete.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(83, 53)
        Me.Button_Delete.TabIndex = 68
        Me.Button_Delete.Text = "삭제"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Modify
        '
        Me.Button_Modify.Location = New System.Drawing.Point(517, 85)
        Me.Button_Modify.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Modify.Name = "Button_Modify"
        Me.Button_Modify.Size = New System.Drawing.Size(83, 53)
        Me.Button_Modify.TabIndex = 67
        Me.Button_Modify.Text = "수정"
        Me.Button_Modify.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(419, 85)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(83, 53)
        Me.Button_Add.TabIndex = 66
        Me.Button_Add.Text = "추가"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Search
        '
        Me.Button_Search.Location = New System.Drawing.Point(418, 15)
        Me.Button_Search.Margin = New System.Windows.Forms.Padding(1)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(278, 53)
        Me.Button_Search.TabIndex = 65
        Me.Button_Search.Text = "찾기"
        Me.Button_Search.UseVisualStyleBackColor = True
        '
        'tBoxComment
        '
        Me.tBoxComment.Location = New System.Drawing.Point(95, 191)
        Me.tBoxComment.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxComment.Multiline = True
        Me.tBoxComment.Name = "tBoxComment"
        Me.tBoxComment.Size = New System.Drawing.Size(308, 19)
        Me.tBoxComment.TabIndex = 57
        '
        'tBoxJongmok
        '
        Me.tBoxJongmok.Location = New System.Drawing.Point(289, 155)
        Me.tBoxJongmok.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxJongmok.Name = "tBoxJongmok"
        Me.tBoxJongmok.Size = New System.Drawing.Size(114, 21)
        Me.tBoxJongmok.TabIndex = 56
        '
        'tBoxType
        '
        Me.tBoxType.Location = New System.Drawing.Point(95, 155)
        Me.tBoxType.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxType.Name = "tBoxType"
        Me.tBoxType.Size = New System.Drawing.Size(114, 21)
        Me.tBoxType.TabIndex = 55
        '
        'tBoxAddr
        '
        Me.tBoxAddr.Location = New System.Drawing.Point(95, 120)
        Me.tBoxAddr.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxAddr.Name = "tBoxAddr"
        Me.tBoxAddr.Size = New System.Drawing.Size(308, 21)
        Me.tBoxAddr.TabIndex = 54
        '
        'tBoxName
        '
        Me.tBoxName.Location = New System.Drawing.Point(95, 50)
        Me.tBoxName.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxName.Name = "tBoxName"
        Me.tBoxName.Size = New System.Drawing.Size(114, 21)
        Me.tBoxName.TabIndex = 51
        '
        'lblEtc
        '
        Me.lblEtc.AutoSize = True
        Me.lblEtc.Location = New System.Drawing.Point(50, 193)
        Me.lblEtc.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblEtc.Name = "lblEtc"
        Me.lblEtc.Size = New System.Drawing.Size(37, 12)
        Me.lblEtc.TabIndex = 64
        Me.lblEtc.Text = "비고 :"
        '
        'lblBAccount
        '
        Me.lblBAccount.AutoSize = True
        Me.lblBAccount.Location = New System.Drawing.Point(242, 158)
        Me.lblBAccount.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBAccount.Name = "lblBAccount"
        Me.lblBAccount.Size = New System.Drawing.Size(37, 12)
        Me.lblBAccount.TabIndex = 63
        Me.lblBAccount.Text = "종목 :"
        '
        'lblBName
        '
        Me.lblBName.AutoSize = True
        Me.lblBName.Location = New System.Drawing.Point(50, 158)
        Me.lblBName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBName.Name = "lblBName"
        Me.lblBName.Size = New System.Drawing.Size(37, 12)
        Me.lblBName.TabIndex = 62
        Me.lblBName.Text = "업태 :"
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Location = New System.Drawing.Point(50, 121)
        Me.lblAddr.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(37, 12)
        Me.lblAddr.TabIndex = 61
        Me.lblAddr.Text = "주소 :"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(14, 88)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(73, 12)
        Me.lblPhone.TabIndex = 60
        Me.lblPhone.Text = "사업자번호 :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(38, 53)
        Me.lblName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 12)
        Me.lblName.TabIndex = 59
        Me.lblName.Text = "상호명 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "성명 :"
        '
        'tBoxHeadname
        '
        Me.tBoxHeadname.Location = New System.Drawing.Point(289, 85)
        Me.tBoxHeadname.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxHeadname.Name = "tBoxHeadname"
        Me.tBoxHeadname.Size = New System.Drawing.Size(114, 21)
        Me.tBoxHeadname.TabIndex = 53
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'UcommentDataGridViewTextBoxColumn
        '
        Me.UcommentDataGridViewTextBoxColumn.DataPropertyName = "u_comment"
        Me.UcommentDataGridViewTextBoxColumn.HeaderText = "u_comment"
        Me.UcommentDataGridViewTextBoxColumn.Name = "UcommentDataGridViewTextBoxColumn"
        '
        'UidnumDataGridViewTextBoxColumn
        '
        Me.UidnumDataGridViewTextBoxColumn.DataPropertyName = "u_idnum"
        Me.UidnumDataGridViewTextBoxColumn.HeaderText = "u_idnum"
        Me.UidnumDataGridViewTextBoxColumn.Name = "UidnumDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "u_jongmok"
        Me.DataGridViewTextBoxColumn1.HeaderText = "u_jongmok"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'UtypeDataGridViewTextBoxColumn
        '
        Me.UtypeDataGridViewTextBoxColumn.DataPropertyName = "u_type"
        Me.UtypeDataGridViewTextBoxColumn.HeaderText = "u_type"
        Me.UtypeDataGridViewTextBoxColumn.Name = "UtypeDataGridViewTextBoxColumn"
        '
        'UheadnameDataGridViewTextBoxColumn
        '
        Me.UheadnameDataGridViewTextBoxColumn.DataPropertyName = "u_headname"
        Me.UheadnameDataGridViewTextBoxColumn.HeaderText = "u_headname"
        Me.UheadnameDataGridViewTextBoxColumn.Name = "UheadnameDataGridViewTextBoxColumn"
        '
        'UaddressDataGridViewTextBoxColumn
        '
        Me.UaddressDataGridViewTextBoxColumn.DataPropertyName = "u_address"
        Me.UaddressDataGridViewTextBoxColumn.HeaderText = "u_address"
        Me.UaddressDataGridViewTextBoxColumn.Name = "UaddressDataGridViewTextBoxColumn"
        '
        'UnameDataGridViewTextBoxColumn
        '
        Me.UnameDataGridViewTextBoxColumn.DataPropertyName = "u_name"
        Me.UnameDataGridViewTextBoxColumn.HeaderText = "u_name"
        Me.UnameDataGridViewTextBoxColumn.Name = "UnameDataGridViewTextBoxColumn"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnameDataGridViewTextBoxColumn, Me.UaddressDataGridViewTextBoxColumn, Me.UheadnameDataGridViewTextBoxColumn, Me.UtypeDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.UidnumDataGridViewTextBoxColumn, Me.UcommentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UserBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 263)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(683, 216)
        Me.DataGridView1.TabIndex = 72
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 501)
        Me.Controls.Add(Me.tBoxHeadname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tBoxIdnum)
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
        Me.Controls.Add(Me.tBoxName)
        Me.Controls.Add(Me.lblEtc)
        Me.Controls.Add(Me.lblBAccount)
        Me.Controls.Add(Me.lblBName)
        Me.Controls.Add(Me.lblAddr)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximumSize = New System.Drawing.Size(730, 540)
        Me.MinimumSize = New System.Drawing.Size(730, 540)
        Me.Name = "UserForm"
        Me.Text = "사용자 관리"
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tBoxIdnum As System.Windows.Forms.TextBox
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
    Friend WithEvents tBoxName As System.Windows.Forms.TextBox
    Friend WithEvents lblEtc As System.Windows.Forms.Label
    Friend WithEvents lblBAccount As System.Windows.Forms.Label
    Friend WithEvents lblBName As System.Windows.Forms.Label
    Friend WithEvents lblAddr As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents UserTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter
    Friend WithEvents UphoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbaccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tBoxHeadname As System.Windows.Forms.TextBox
    Friend WithEvents UjongmokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SourceDBDataSet As ForkliftManager.SourceDBDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UcommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UidnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UheadnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UaddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
