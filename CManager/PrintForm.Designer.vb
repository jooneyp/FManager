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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SourceDBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.cBoxClient = New System.Windows.Forms.ComboBox()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.CBoxUser = New System.Windows.Forms.ComboBox()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter()
        Me.SourceDBDataSet1 = New ForkliftManager.SourceDBDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SourceDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DealBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter()
        Me.DealTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.dealTableAdapter()
        Me.rBtnClient = New System.Windows.Forms.RadioButton()
        Me.rBtnUser = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 143)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(707, 524)
        Me.DataGridView1.TabIndex = 0
        '
        'SourceDBDataSet
        '
        Me.SourceDBDataSet.DataSetName = "SourceDBDataSet"
        Me.SourceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cBoxClient
        '
        Me.cBoxClient.DataSource = Me.ClientBindingSource
        Me.cBoxClient.DisplayMember = "c_name"
        Me.cBoxClient.FormattingEnabled = True
        Me.cBoxClient.Location = New System.Drawing.Point(103, 29)
        Me.cBoxClient.Margin = New System.Windows.Forms.Padding(2)
        Me.cBoxClient.Name = "cBoxClient"
        Me.cBoxClient.Size = New System.Drawing.Size(159, 26)
        Me.cBoxClient.TabIndex = 1
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "client"
        Me.ClientBindingSource.DataSource = Me.SourceDBDataSet
        '
        'DTP
        '
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP.Location = New System.Drawing.Point(303, 79)
        Me.DTP.Margin = New System.Windows.Forms.Padding(2)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(159, 28)
        Me.DTP.TabIndex = 2
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(496, 66)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(112, 59)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "불러오기"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(623, 66)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(112, 59)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "출력하기"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'CBoxUser
        '
        Me.CBoxUser.DataSource = Me.UserBindingSource
        Me.CBoxUser.DisplayMember = "u_name"
        Me.CBoxUser.FormattingEnabled = True
        Me.CBoxUser.Location = New System.Drawing.Point(103, 81)
        Me.CBoxUser.Name = "CBoxUser"
        Me.CBoxUser.Size = New System.Drawing.Size(135, 26)
        Me.CBoxUser.TabIndex = 6
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "업체명"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "작업자"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(330, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
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
        'rBtnClient
        '
        Me.rBtnClient.AutoSize = True
        Me.rBtnClient.Location = New System.Drawing.Point(625, 28)
        Me.rBtnClient.Name = "rBtnClient"
        Me.rBtnClient.Size = New System.Drawing.Size(105, 22)
        Me.rBtnClient.TabIndex = 10
        Me.rBtnClient.Text = "업체기준"
        Me.rBtnClient.UseVisualStyleBackColor = True
        '
        'rBtnUser
        '
        Me.rBtnUser.AutoSize = True
        Me.rBtnUser.Location = New System.Drawing.Point(496, 28)
        Me.rBtnUser.Name = "rBtnUser"
        Me.rBtnUser.Size = New System.Drawing.Size(123, 22)
        Me.rBtnUser.TabIndex = 11
        Me.rBtnUser.TabStop = True
        Me.rBtnUser.Text = "작업자기준"
        Me.rBtnUser.UseVisualStyleBackColor = True
        '
        'PrintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 692)
        Me.Controls.Add(Me.rBtnUser)
        Me.Controls.Add(Me.rBtnClient)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBoxUser)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.cBoxClient)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PrintForm"
        Me.Text = "Print"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cBoxClient As System.Windows.Forms.ComboBox
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents CBoxUser As System.Windows.Forms.ComboBox
    Friend WithEvents SourceDBDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SourceDBDataSet As ForkliftManager.SourceDBDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter
    Friend WithEvents SourceDBDataSet1 As ForkliftManager.SourceDBDataSet
    Friend WithEvents DealBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DealTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.dealTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rBtnClient As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnUser As System.Windows.Forms.RadioButton
End Class
