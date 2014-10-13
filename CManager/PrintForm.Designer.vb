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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView_view = New System.Windows.Forms.DataGridView()
        Me.DdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtonsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DealBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDBDataSet1 = New ForkliftManager.SourceDBDataSet()
        Me.SourceDBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.cBox_client = New System.Windows.Forms.ComboBox()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtp_print = New System.Windows.Forms.DateTimePicker()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.cBox_user = New System.Windows.Forms.ComboBox()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter()
        Me.lbl_client = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SourceDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        CType(Me.DealBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_view
        '
        Me.DataGridView_view.AutoGenerateColumns = False
        Me.DataGridView_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_view.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_view.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DdateDataGridViewTextBoxColumn, Me.DtonsDataGridViewTextBoxColumn, Me.DqtyDataGridViewTextBoxColumn, Me.DcostDataGridViewTextBoxColumn})
        Me.DataGridView_view.DataSource = Me.DealBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_view.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_view.Location = New System.Drawing.Point(10, 10)
        Me.DataGridView_view.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridView_view.Name = "DataGridView_view"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_view.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_view.RowTemplate.Height = 37
        Me.DataGridView_view.Size = New System.Drawing.Size(283, 457)
        Me.DataGridView_view.TabIndex = 0
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
        Me.DcostDataGridViewTextBoxColumn.HeaderText = "합계"
        Me.DcostDataGridViewTextBoxColumn.Name = "DcostDataGridViewTextBoxColumn"
        Me.DcostDataGridViewTextBoxColumn.ReadOnly = True
        Me.DcostDataGridViewTextBoxColumn.Width = 54
        '
        'DealBindingSource
        '
        Me.DealBindingSource.DataMember = "deal"
        Me.DealBindingSource.DataSource = Me.SourceDBDataSet1
        '
        'SourceDBDataSet1
        '
        Me.SourceDBDataSet1.DataSetName = "SourceDBDataSet"
        Me.SourceDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.cBox_client.TabIndex = 2
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
        Me.dtp_print.TabIndex = 1
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
        Me.btn_print.Location = New System.Drawing.Point(320, 349)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(169, 54)
        Me.btn_print.TabIndex = 9
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
        Me.cBox_user.TabIndex = 3
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
        Me.Label1.Location = New System.Drawing.Point(330, 277)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "일자"
        '
        'dtp_date
        '
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_date.Location = New System.Drawing.Point(377, 271)
        Me.dtp_date.Margin = New System.Windows.Forms.Padding(1)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(112, 21)
        Me.dtp_date.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 247)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "작성일자"
        '
        'dtp_wdate
        '
        Me.dtp_wdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_wdate.Location = New System.Drawing.Point(377, 242)
        Me.dtp_wdate.Margin = New System.Windows.Forms.Padding(1)
        Me.dtp_wdate.Name = "dtp_wdate"
        Me.dtp_wdate.Size = New System.Drawing.Size(112, 21)
        Me.dtp_wdate.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 217)
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
        Me.GroupBox1.Location = New System.Drawing.Point(304, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 191)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'rBtn_ys
        '
        Me.rBtn_ys.AutoSize = True
        Me.rBtn_ys.Location = New System.Drawing.Point(422, 307)
        Me.rBtn_ys.Margin = New System.Windows.Forms.Padding(2)
        Me.rBtn_ys.Name = "rBtn_ys"
        Me.rBtn_ys.Size = New System.Drawing.Size(47, 16)
        Me.rBtn_ys.TabIndex = 8
        Me.rBtn_ys.Text = "영수"
        Me.rBtn_ys.UseVisualStyleBackColor = True
        '
        'rBtn_cg
        '
        Me.rBtn_cg.AutoSize = True
        Me.rBtn_cg.Checked = True
        Me.rBtn_cg.Location = New System.Drawing.Point(357, 307)
        Me.rBtn_cg.Margin = New System.Windows.Forms.Padding(2)
        Me.rBtn_cg.Name = "rBtn_cg"
        Me.rBtn_cg.Size = New System.Drawing.Size(47, 16)
        Me.rBtn_cg.TabIndex = 7
        Me.rBtn_cg.TabStop = True
        Me.rBtn_cg.Text = "청구"
        Me.rBtn_cg.UseVisualStyleBackColor = True
        '
        'PrintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 476)
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
        CType(Me.DealBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtonsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DqtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DcostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
