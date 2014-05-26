<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeMod
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
        Me.cBoxCode = New System.Windows.Forms.ComboBox()
        Me.TonDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.TonDataTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.tonDataTableAdapter()
        Me.tBoxTons = New System.Windows.Forms.TextBox()
        Me.tBoxCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.TonDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cBoxCode
        '
        Me.cBoxCode.DataSource = Me.TonDataBindingSource
        Me.cBoxCode.DisplayMember = "code"
        Me.cBoxCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxCode.FormattingEnabled = True
        Me.cBoxCode.Location = New System.Drawing.Point(29, 41)
        Me.cBoxCode.Name = "cBoxCode"
        Me.cBoxCode.Size = New System.Drawing.Size(59, 20)
        Me.cBoxCode.TabIndex = 0
        '
        'TonDataBindingSource
        '
        Me.TonDataBindingSource.DataMember = "tonData"
        Me.TonDataBindingSource.DataSource = Me.SourceDBDataSet
        '
        'SourceDBDataSet
        '
        Me.SourceDBDataSet.DataSetName = "SourceDBDataSet"
        Me.SourceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TonDataTableAdapter
        '
        Me.TonDataTableAdapter.ClearBeforeFill = True
        '
        'tBoxTons
        '
        Me.tBoxTons.Location = New System.Drawing.Point(94, 41)
        Me.tBoxTons.Name = "tBoxTons"
        Me.tBoxTons.Size = New System.Drawing.Size(100, 21)
        Me.tBoxTons.TabIndex = 1
        '
        'tBoxCost
        '
        Me.tBoxCost.Location = New System.Drawing.Point(200, 41)
        Me.tBoxCost.Name = "tBoxCost"
        Me.tBoxCost.Size = New System.Drawing.Size(100, 21)
        Me.tBoxCost.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "코드"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "톤수"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "금액"
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(172, 77)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(61, 42)
        Me.btnMod.TabIndex = 6
        Me.btnMod.Text = "수정하기"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(239, 77)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 42)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "추가하기"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(239, 77)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(61, 42)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "확인"
        Me.btnOK.UseVisualStyleBackColor = True
        Me.btnOK.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(172, 77)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(61, 42)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "취소"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'CodeMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 134)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tBoxCost)
        Me.Controls.Add(Me.tBoxTons)
        Me.Controls.Add(Me.cBoxCode)
        Me.Name = "CodeMod"
        Me.Text = "코드 수정"
        CType(Me.TonDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cBoxCode As System.Windows.Forms.ComboBox
    Friend WithEvents SourceDBDataSet As ForkliftManager.SourceDBDataSet
    Friend WithEvents TonDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TonDataTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.tonDataTableAdapter
    Friend WithEvents tBoxTons As System.Windows.Forms.TextBox
    Friend WithEvents tBoxCost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
