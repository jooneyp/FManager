<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintForm
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
        Me.DataGridView_view = New System.Windows.Forms.DataGridView()
        Me.SourceDBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.cBox_client = New System.Windows.Forms.ComboBox()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtp_print = New System.Windows.Forms.DateTimePicker()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.cBox_user = New System.Windows.Forms.ComboBox()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter()
        Me.SourceDBDataSet1 = New ForkliftManager.SourceDBDataSet()
        Me.lbl_client = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SourceDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DealBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter()
        Me.DealTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.dealTableAdapter()
        Me.rBtn_client = New System.Windows.Forms.RadioButton()
        Me.rBtn_user = New System.Windows.Forms.RadioButton()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.DataGridView_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_view
        '
        Me.DataGridView_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_view.Location = New System.Drawing.Point(20, 95)
        Me.DataGridView_view.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridView_view.Name = "DataGridView_view"
        Me.DataGridView_view.RowTemplate.Height = 37
        Me.DataGridView_view.Size = New System.Drawing.Size(549, 349)
        Me.DataGridView_view.TabIndex = 0
        '
        'SourceDBDataSet
        '
        Me.SourceDBDataSet.DataSetName = "SourceDBDataSet"
        Me.SourceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cBox_client
        '
        Me.cBox_client.DataSource = Me.ClientBindingSource
        Me.cBox_client.DisplayMember = "c_name"
        Me.cBox_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_client.FormattingEnabled = True
        Me.cBox_client.Location = New System.Drawing.Point(72, 19)
        Me.cBox_client.Margin = New System.Windows.Forms.Padding(1)
        Me.cBox_client.Name = "cBox_client"
        Me.cBox_client.Size = New System.Drawing.Size(112, 20)
        Me.cBox_client.TabIndex = 1
        Me.cBox_client.ValueMember = "c_name"
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "client"
        Me.ClientBindingSource.DataSource = Me.SourceDBDataSet
        '
        'dtp_print
        '
        Me.dtp_print.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_print.Location = New System.Drawing.Point(224, 45)
        Me.dtp_print.Margin = New System.Windows.Forms.Padding(1)
        Me.dtp_print.Name = "dtp_print"
        Me.dtp_print.Size = New System.Drawing.Size(112, 21)
        Me.dtp_print.TabIndex = 2
        '
        'btn_load
        '
        Me.btn_load.Location = New System.Drawing.Point(475, 41)
        Me.btn_load.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(78, 39)
        Me.btn_load.TabIndex = 4
        Me.btn_load.Text = "불러오기"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(375, 41)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(78, 39)
        Me.btn_print.TabIndex = 5
        Me.btn_print.Text = "출력하기"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'cBox_user
        '
        Me.cBox_user.DataSource = Me.UserBindingSource
        Me.cBox_user.DisplayMember = "u_name"
        Me.cBox_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_user.FormattingEnabled = True
        Me.cBox_user.Location = New System.Drawing.Point(72, 54)
        Me.cBox_user.Margin = New System.Windows.Forms.Padding(2)
        Me.cBox_user.Name = "cBox_user"
        Me.cBox_user.Size = New System.Drawing.Size(96, 20)
        Me.cBox_user.TabIndex = 6
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.SourceDBDataSet
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'SourceDBDataSet1
        '
        Me.SourceDBDataSet1.DataSetName = "SourceDBDataSet"
        Me.SourceDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_client
        '
        Me.lbl_client.AutoSize = True
        Me.lbl_client.Location = New System.Drawing.Point(17, 21)
        Me.lbl_client.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_client.Name = "lbl_client"
        Me.lbl_client.Size = New System.Drawing.Size(41, 12)
        Me.lbl_client.TabIndex = 7
        Me.lbl_client.Text = "업체명"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(17, 56)
        Me.lbl_user.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(41, 12)
        Me.lbl_user.TabIndex = 8
        Me.lbl_user.Text = "작업자"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "출력대상 월"
        '
        'SourceDBDataSetBindingSource
        '
        Me.SourceDBDataSetBindingSource.DataSource = Me.SourceDBDataSet
        Me.SourceDBDataSetBindingSource.Position = 0
        '
        'DealBindingSource
        '
        Me.DealBindingSource.DataMember = "deal"
        Me.DealBindingSource.DataSource = Me.SourceDBDataSet1
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'DealTableAdapter
        '
        Me.DealTableAdapter.ClearBeforeFill = True
        '
        'rBtn_client
        '
        Me.rBtn_client.AutoSize = True
        Me.rBtn_client.Location = New System.Drawing.Point(475, 14)
        Me.rBtn_client.Margin = New System.Windows.Forms.Padding(2)
        Me.rBtn_client.Name = "rBtn_client"
        Me.rBtn_client.Size = New System.Drawing.Size(71, 16)
        Me.rBtn_client.TabIndex = 10
        Me.rBtn_client.Text = "업체기준"
        Me.rBtn_client.UseVisualStyleBackColor = True
        '
        'rBtn_user
        '
        Me.rBtn_user.AutoSize = True
        Me.rBtn_user.Location = New System.Drawing.Point(375, 14)
        Me.rBtn_user.Margin = New System.Windows.Forms.Padding(2)
        Me.rBtn_user.Name = "rBtn_user"
        Me.rBtn_user.Size = New System.Drawing.Size(83, 16)
        Me.rBtn_user.TabIndex = 11
        Me.rBtn_user.TabStop = True
        Me.rBtn_user.Text = "작업자기준"
        Me.rBtn_user.UseVisualStyleBackColor = True
        '
        'PrintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 473)
        Me.Controls.Add(Me.rBtn_user)
        Me.Controls.Add(Me.rBtn_client)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.lbl_client)
        Me.Controls.Add(Me.cBox_user)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.dtp_print)
        Me.Controls.Add(Me.cBox_client)
        Me.Controls.Add(Me.DataGridView_view)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximumSize = New System.Drawing.Size(609, 512)
        Me.MinimumSize = New System.Drawing.Size(609, 512)
        Me.Name = "PrintForm"
        Me.Text = "거래내역 출력"
        CType(Me.DataGridView_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_view As System.Windows.Forms.DataGridView
    Friend WithEvents cBox_client As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_print As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_load As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents cBox_user As System.Windows.Forms.ComboBox
    Friend WithEvents SourceDBDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SourceDBDataSet As ForkliftManager.SourceDBDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter
    Friend WithEvents SourceDBDataSet1 As ForkliftManager.SourceDBDataSet
    Friend WithEvents DealBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DealTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.dealTableAdapter
    Friend WithEvents lbl_client As System.Windows.Forms.Label
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rBtn_client As System.Windows.Forms.RadioButton
    Friend WithEvents rBtn_user As System.Windows.Forms.RadioButton
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
