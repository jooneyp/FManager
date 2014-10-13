<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DealMod
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
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.ClientTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter()
        Me.cBox_user = New System.Windows.Forms.ComboBox()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cBox_tons = New System.Windows.Forms.ComboBox()
        Me.TonDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tBox_qty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TonDataTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.tonDataTableAdapter()
        Me.UserTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_cost = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tBox_dealID = New System.Windows.Forms.TextBox()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TonDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'cBox_user
        '
        Me.cBox_user.DataSource = Me.UserBindingSource
        Me.cBox_user.DisplayMember = "u_headname"
        Me.cBox_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_user.FormattingEnabled = True
        Me.cBox_user.Location = New System.Drawing.Point(62, 68)
        Me.cBox_user.Name = "cBox_user"
        Me.cBox_user.Size = New System.Drawing.Size(121, 20)
        Me.cBox_user.TabIndex = 3
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.SourceDBDataSet
        '
        'cBox_tons
        '
        Me.cBox_tons.DataSource = Me.TonDataBindingSource
        Me.cBox_tons.DisplayMember = "ton"
        Me.cBox_tons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_tons.FormattingEnabled = True
        Me.cBox_tons.Location = New System.Drawing.Point(62, 94)
        Me.cBox_tons.Name = "cBox_tons"
        Me.cBox_tons.Size = New System.Drawing.Size(121, 20)
        Me.cBox_tons.TabIndex = 4
        '
        'TonDataBindingSource
        '
        Me.TonDataBindingSource.DataMember = "tonData"
        Me.TonDataBindingSource.DataSource = Me.SourceDBDataSet
        '
        'tBox_qty
        '
        Me.tBox_qty.Location = New System.Drawing.Point(62, 120)
        Me.tBox_qty.Name = "tBox_qty"
        Me.tBox_qty.Size = New System.Drawing.Size(56, 21)
        Me.tBox_qty.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "거래일자"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "작업자"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "톤수"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "수량"
        '
        'dtp_date
        '
        Me.dtp_date.CustomFormat = "yyyy-mm-dd"
        Me.dtp_date.Location = New System.Drawing.Point(62, 41)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(121, 21)
        Me.dtp_date.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "확인"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "취소"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TonDataTableAdapter
        '
        Me.TonDataTableAdapter.ClearBeforeFill = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "합계"
        '
        'lbl_cost
        '
        Me.lbl_cost.AutoSize = True
        Me.lbl_cost.Location = New System.Drawing.Point(64, 151)
        Me.lbl_cost.Name = "lbl_cost"
        Me.lbl_cost.Size = New System.Drawing.Size(27, 12)
        Me.lbl_cost.TabIndex = 12
        Me.lbl_cost.Text = "0 원"
        Me.lbl_cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "거래번호"
        '
        'tBox_dealID
        '
        Me.tBox_dealID.Enabled = False
        Me.tBox_dealID.Location = New System.Drawing.Point(62, 14)
        Me.tBox_dealID.Name = "tBox_dealID"
        Me.tBox_dealID.ReadOnly = True
        Me.tBox_dealID.Size = New System.Drawing.Size(56, 21)
        Me.tBox_dealID.TabIndex = 1
        '
        'DealMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 215)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tBox_dealID)
        Me.Controls.Add(Me.lbl_cost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tBox_qty)
        Me.Controls.Add(Me.cBox_tons)
        Me.Controls.Add(Me.cBox_user)
        Me.Name = "DealMod"
        Me.Text = "DealMod"
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TonDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SourceDBDataSet As ForkliftManager.SourceDBDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter
    Friend WithEvents cBox_user As System.Windows.Forms.ComboBox
    Friend WithEvents cBox_tons As System.Windows.Forms.ComboBox
    Friend WithEvents tBox_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TonDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TonDataTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.tonDataTableAdapter
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_cost As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tBox_dealID As System.Windows.Forms.TextBox
End Class
