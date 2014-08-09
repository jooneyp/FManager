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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_wdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rBtn_ys = New System.Windows.Forms.RadioButton()
        Me.rBtn_cg = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_view
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_view.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_view.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView_view.Location = New System.Drawing.Point(10, 10)
        Me.DataGridView_view.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridView_view.Name = "DataGridView_view"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_view.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView_view.RowTemplate.Height = 37
        Me.DataGridView_view.Size = New System.Drawing.Size(549, 541)
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
        Me.cBox_client.Location = New System.Drawing.Point(79, 63)
        Me.cBox_client.Margin = New System.Windows.Forms.Padding(1)
        Me.cBox_client.Name = "cBox_client"
        Me.cBox_client.Size = New System.Drawing.Size(106, 20)
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
        Me.dtp_print.Location = New System.Drawing.Point(79, 25)
        Me.dtp_print.Margin = New System.Windows.Forms.Padding(1)
        Me.dtp_print.Name = "dtp_print"
        Me.dtp_print.Size = New System.Drawing.Size(106, 21)
        Me.dtp_print.TabIndex = 2
        '
        'btn_load
        '
        Me.btn_load.Location = New System.Drawing.Point(18, 132)
        Me.btn_load.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(167, 46)
        Me.btn_load.TabIndex = 4
        Me.btn_load.Text = "불러오기"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(585, 393)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(169, 54)
        Me.btn_print.TabIndex = 5
        Me.btn_print.Text = "출력하기"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'cBox_user
        '
        Me.cBox_user.DataSource = Me.UserBindingSource
        Me.cBox_user.DisplayMember = "u_headname"
        Me.cBox_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_user.FormattingEnabled = True
        Me.cBox_user.Location = New System.Drawing.Point(79, 98)
        Me.cBox_user.Margin = New System.Windows.Forms.Padding(2)
        Me.cBox_user.Name = "cBox_user"
        Me.cBox_user.Size = New System.Drawing.Size(106, 20)
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
        Me.lbl_client.Location = New System.Drawing.Point(32, 67)
        Me.lbl_client.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_client.Name = "lbl_client"
        Me.lbl_client.Size = New System.Drawing.Size(41, 12)
        Me.lbl_client.TabIndex = 7
        Me.lbl_client.Text = "업체명"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(32, 102)
        Me.lbl_user.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(41, 12)
        Me.lbl_user.TabIndex = 8
        Me.lbl_user.Text = "작업자"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "출력대상"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(595, 321)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "일자"
        '
        'dtp_date
        '
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_date.Location = New System.Drawing.Point(642, 315)
        Me.dtp_date.Margin = New System.Windows.Forms.Padding(1)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(112, 21)
        Me.dtp_date.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(583, 291)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "작성일자"
        '
        'dtp_wdate
        '
        Me.dtp_wdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_wdate.Location = New System.Drawing.Point(642, 286)
        Me.dtp_wdate.Margin = New System.Windows.Forms.Padding(1)
        Me.dtp_wdate.Name = "dtp_wdate"
        Me.dtp_wdate.Size = New System.Drawing.Size(112, 21)
        Me.dtp_wdate.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(641, 261)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "세금계산서"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_load)
        Me.GroupBox1.Controls.Add(Me.dtp_print)
        Me.GroupBox1.Controls.Add(Me.cBox_client)
        Me.GroupBox1.Controls.Add(Me.cBox_user)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_client)
        Me.GroupBox1.Controls.Add(Me.lbl_user)
        Me.GroupBox1.Location = New System.Drawing.Point(569, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 191)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'rBtn_ys
        '
        Me.rBtn_ys.AutoSize = True
        Me.rBtn_ys.Checked = True
        Me.rBtn_ys.Location = New System.Drawing.Point(618, 349)
        Me.rBtn_ys.Margin = New System.Windows.Forms.Padding(2)
        Me.rBtn_ys.Name = "rBtn_ys"
        Me.rBtn_ys.Size = New System.Drawing.Size(47, 16)
        Me.rBtn_ys.TabIndex = 12
        Me.rBtn_ys.TabStop = True
        Me.rBtn_ys.Text = "영수"
        Me.rBtn_ys.UseVisualStyleBackColor = True
        '
        'rBtn_cg
        '
        Me.rBtn_cg.AutoSize = True
        Me.rBtn_cg.Location = New System.Drawing.Point(680, 349)
        Me.rBtn_cg.Margin = New System.Windows.Forms.Padding(2)
        Me.rBtn_cg.Name = "rBtn_cg"
        Me.rBtn_cg.Size = New System.Drawing.Size(47, 16)
        Me.rBtn_cg.TabIndex = 13
        Me.rBtn_cg.TabStop = True
        Me.rBtn_cg.Text = "청구"
        Me.rBtn_cg.UseVisualStyleBackColor = True
        '
        'PrintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 561)
        Me.Controls.Add(Me.rBtn_ys)
        Me.Controls.Add(Me.rBtn_cg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_wdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.DataGridView_view)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "PrintForm"
        Me.Text = "거래내역 출력"
        CType(Me.DataGridView_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_wdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rBtn_ys As System.Windows.Forms.RadioButton
    Friend WithEvents rBtn_cg As System.Windows.Forms.RadioButton
End Class
