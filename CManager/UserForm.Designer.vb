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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UaddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbaccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UcommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.tBoxPhone = New System.Windows.Forms.TextBox()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.lblAOE = New System.Windows.Forms.Label()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_GridView = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Modify = New System.Windows.Forms.Button()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Button_Search = New System.Windows.Forms.Button()
        Me.tBoxEtc = New System.Windows.Forms.TextBox()
        Me.tBoxBAccount = New System.Windows.Forms.TextBox()
        Me.tBoxBName = New System.Windows.Forms.TextBox()
        Me.tBoxAddr = New System.Windows.Forms.TextBox()
        Me.tBoxName = New System.Windows.Forms.TextBox()
        Me.lblEtc = New System.Windows.Forms.Label()
        Me.lblBAccount = New System.Windows.Forms.Label()
        Me.lblBName = New System.Windows.Forms.Label()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.UserTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnameDataGridViewTextBoxColumn, Me.UphoneDataGridViewTextBoxColumn, Me.UaddrDataGridViewTextBoxColumn, Me.UbnameDataGridViewTextBoxColumn, Me.UbaccountDataGridViewTextBoxColumn, Me.UcommentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UserBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 394)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(976, 324)
        Me.DataGridView1.TabIndex = 72
        '
        'UnameDataGridViewTextBoxColumn
        '
        Me.UnameDataGridViewTextBoxColumn.DataPropertyName = "u_name"
        Me.UnameDataGridViewTextBoxColumn.HeaderText = "u_name"
        Me.UnameDataGridViewTextBoxColumn.Name = "UnameDataGridViewTextBoxColumn"
        '
        'UphoneDataGridViewTextBoxColumn
        '
        Me.UphoneDataGridViewTextBoxColumn.DataPropertyName = "u_phone"
        Me.UphoneDataGridViewTextBoxColumn.HeaderText = "u_phone"
        Me.UphoneDataGridViewTextBoxColumn.Name = "UphoneDataGridViewTextBoxColumn"
        '
        'UaddrDataGridViewTextBoxColumn
        '
        Me.UaddrDataGridViewTextBoxColumn.DataPropertyName = "u_addr"
        Me.UaddrDataGridViewTextBoxColumn.HeaderText = "u_addr"
        Me.UaddrDataGridViewTextBoxColumn.Name = "UaddrDataGridViewTextBoxColumn"
        '
        'UbnameDataGridViewTextBoxColumn
        '
        Me.UbnameDataGridViewTextBoxColumn.DataPropertyName = "u_bname"
        Me.UbnameDataGridViewTextBoxColumn.HeaderText = "u_bname"
        Me.UbnameDataGridViewTextBoxColumn.Name = "UbnameDataGridViewTextBoxColumn"
        '
        'UbaccountDataGridViewTextBoxColumn
        '
        Me.UbaccountDataGridViewTextBoxColumn.DataPropertyName = "u_baccount"
        Me.UbaccountDataGridViewTextBoxColumn.HeaderText = "u_baccount"
        Me.UbaccountDataGridViewTextBoxColumn.Name = "UbaccountDataGridViewTextBoxColumn"
        '
        'UcommentDataGridViewTextBoxColumn
        '
        Me.UcommentDataGridViewTextBoxColumn.DataPropertyName = "u_comment"
        Me.UcommentDataGridViewTextBoxColumn.HeaderText = "u_comment"
        Me.UcommentDataGridViewTextBoxColumn.Name = "UcommentDataGridViewTextBoxColumn"
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
        'tBoxPhone
        '
        Me.tBoxPhone.Location = New System.Drawing.Point(136, 127)
        Me.tBoxPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.tBoxPhone.Name = "tBoxPhone"
        Me.tBoxPhone.Size = New System.Drawing.Size(161, 28)
        Me.tBoxPhone.TabIndex = 52
        '
        'Button_OK
        '
        Me.Button_OK.Location = New System.Drawing.Point(598, 127)
        Me.Button_OK.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(258, 79)
        Me.Button_OK.TabIndex = 57
        Me.Button_OK.Text = "저장하기"
        Me.Button_OK.UseVisualStyleBackColor = True
        Me.Button_OK.Visible = False
        '
        'lblAOE
        '
        Me.lblAOE.AutoSize = True
        Me.lblAOE.Location = New System.Drawing.Point(742, 339)
        Me.lblAOE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAOE.Name = "lblAOE"
        Me.lblAOE.Size = New System.Drawing.Size(100, 18)
        Me.lblAOE.TabIndex = 71
        Me.lblAOE.Text = "Add Or Edit"
        Me.lblAOE.Visible = False
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(456, 23)
        Me.Button_Clear.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(118, 80)
        Me.Button_Clear.TabIndex = 70
        Me.Button_Clear.Text = "비우기"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_GridView
        '
        Me.Button_GridView.Location = New System.Drawing.Point(598, 233)
        Me.Button_GridView.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_GridView.Name = "Button_GridView"
        Me.Button_GridView.Size = New System.Drawing.Size(397, 80)
        Me.Button_GridView.TabIndex = 69
        Me.Button_GridView.Text = "데이터 목록 보기"
        Me.Button_GridView.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(877, 127)
        Me.Button_Delete.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(118, 79)
        Me.Button_Delete.TabIndex = 68
        Me.Button_Delete.Text = "삭제"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Modify
        '
        Me.Button_Modify.Location = New System.Drawing.Point(738, 127)
        Me.Button_Modify.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Modify.Name = "Button_Modify"
        Me.Button_Modify.Size = New System.Drawing.Size(118, 79)
        Me.Button_Modify.TabIndex = 67
        Me.Button_Modify.Text = "수정"
        Me.Button_Modify.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(598, 127)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(118, 79)
        Me.Button_Add.TabIndex = 66
        Me.Button_Add.Text = "추가"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Search
        '
        Me.Button_Search.Location = New System.Drawing.Point(597, 23)
        Me.Button_Search.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(397, 80)
        Me.Button_Search.TabIndex = 65
        Me.Button_Search.Text = "찾기"
        Me.Button_Search.UseVisualStyleBackColor = True
        '
        'tBoxEtc
        '
        Me.tBoxEtc.Location = New System.Drawing.Point(136, 287)
        Me.tBoxEtc.Margin = New System.Windows.Forms.Padding(2)
        Me.tBoxEtc.Multiline = True
        Me.tBoxEtc.Name = "tBoxEtc"
        Me.tBoxEtc.Size = New System.Drawing.Size(438, 26)
        Me.tBoxEtc.TabIndex = 56
        '
        'tBoxBAccount
        '
        Me.tBoxBAccount.Location = New System.Drawing.Point(413, 233)
        Me.tBoxBAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.tBoxBAccount.Name = "tBoxBAccount"
        Me.tBoxBAccount.Size = New System.Drawing.Size(161, 28)
        Me.tBoxBAccount.TabIndex = 55
        '
        'tBoxBName
        '
        Me.tBoxBName.Location = New System.Drawing.Point(136, 233)
        Me.tBoxBName.Margin = New System.Windows.Forms.Padding(2)
        Me.tBoxBName.Name = "tBoxBName"
        Me.tBoxBName.Size = New System.Drawing.Size(161, 28)
        Me.tBoxBName.TabIndex = 54
        '
        'tBoxAddr
        '
        Me.tBoxAddr.Location = New System.Drawing.Point(136, 180)
        Me.tBoxAddr.Margin = New System.Windows.Forms.Padding(2)
        Me.tBoxAddr.Name = "tBoxAddr"
        Me.tBoxAddr.Size = New System.Drawing.Size(438, 28)
        Me.tBoxAddr.TabIndex = 53
        '
        'tBoxName
        '
        Me.tBoxName.Location = New System.Drawing.Point(136, 75)
        Me.tBoxName.Margin = New System.Windows.Forms.Padding(2)
        Me.tBoxName.Name = "tBoxName"
        Me.tBoxName.Size = New System.Drawing.Size(161, 28)
        Me.tBoxName.TabIndex = 51
        '
        'lblEtc
        '
        Me.lblEtc.AutoSize = True
        Me.lblEtc.Location = New System.Drawing.Point(72, 289)
        Me.lblEtc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEtc.Name = "lblEtc"
        Me.lblEtc.Size = New System.Drawing.Size(56, 18)
        Me.lblEtc.TabIndex = 64
        Me.lblEtc.Text = "비고 :"
        '
        'lblBAccount
        '
        Me.lblBAccount.AutoSize = True
        Me.lblBAccount.Location = New System.Drawing.Point(310, 236)
        Me.lblBAccount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBAccount.Name = "lblBAccount"
        Me.lblBAccount.Size = New System.Drawing.Size(92, 18)
        Me.lblBAccount.TabIndex = 63
        Me.lblBAccount.Text = "계좌번호 :"
        '
        'lblBName
        '
        Me.lblBName.AutoSize = True
        Me.lblBName.Location = New System.Drawing.Point(52, 235)
        Me.lblBName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBName.Name = "lblBName"
        Me.lblBName.Size = New System.Drawing.Size(74, 18)
        Me.lblBName.TabIndex = 62
        Me.lblBName.Text = "은행명 :"
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Location = New System.Drawing.Point(72, 182)
        Me.lblAddr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(56, 18)
        Me.lblAddr.TabIndex = 61
        Me.lblAddr.Text = "주소 :"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(33, 130)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(92, 18)
        Me.lblPhone.TabIndex = 60
        Me.lblPhone.Text = "전화번호 :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(72, 77)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(56, 18)
        Me.lblName.TabIndex = 59
        Me.lblName.Text = "이름 :"
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 735)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tBoxPhone)
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.lblAOE)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_GridView)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Modify)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.Button_Search)
        Me.Controls.Add(Me.tBoxEtc)
        Me.Controls.Add(Me.tBoxBAccount)
        Me.Controls.Add(Me.tBoxBName)
        Me.Controls.Add(Me.tBoxAddr)
        Me.Controls.Add(Me.tBoxName)
        Me.Controls.Add(Me.lblEtc)
        Me.Controls.Add(Me.lblBAccount)
        Me.Controls.Add(Me.lblBName)
        Me.Controls.Add(Me.lblAddr)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1036, 791)
        Me.MinimumSize = New System.Drawing.Size(1036, 791)
        Me.Name = "UserForm"
        Me.Text = "UserForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tBoxPhone As System.Windows.Forms.TextBox
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents lblAOE As System.Windows.Forms.Label
    Friend WithEvents Button_Clear As System.Windows.Forms.Button
    Friend WithEvents Button_GridView As System.Windows.Forms.Button
    Friend WithEvents Button_Delete As System.Windows.Forms.Button
    Friend WithEvents Button_Modify As System.Windows.Forms.Button
    Friend WithEvents Button_Add As System.Windows.Forms.Button
    Friend WithEvents Button_Search As System.Windows.Forms.Button
    Friend WithEvents tBoxEtc As System.Windows.Forms.TextBox
    Friend WithEvents tBoxBAccount As System.Windows.Forms.TextBox
    Friend WithEvents tBoxBName As System.Windows.Forms.TextBox
    Friend WithEvents tBoxAddr As System.Windows.Forms.TextBox
    Friend WithEvents tBoxName As System.Windows.Forms.TextBox
    Friend WithEvents lblEtc As System.Windows.Forms.Label
    Friend WithEvents lblBAccount As System.Windows.Forms.Label
    Friend WithEvents lblBName As System.Windows.Forms.Label
    Friend WithEvents lblAddr As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents SourceDBDataSet As ForkliftManager.SourceDBDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter
    Friend WithEvents UnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UphoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UaddrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbaccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UcommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
