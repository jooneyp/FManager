﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DealForm
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblDutyR = New System.Windows.Forms.Label()
        Me.lblFCostR = New System.Windows.Forms.Label()
        Me.lblDuty = New System.Windows.Forms.Label()
        Me.lblFCost = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTons = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblu_name = New System.Windows.Forms.Label()
        Me.lblc_name = New System.Windows.Forms.Label()
        Me.tBoxQty = New System.Windows.Forms.TextBox()
        Me.tBoxCost = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cBoxu_name = New System.Windows.Forms.ComboBox()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New ForkliftManager.SourceDBDataSet()
        Me.cBoxc_name = New System.Windows.Forms.ComboBox()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DealTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.dealTableAdapter()
        Me.ClientTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter()
        Me.UserTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter()
        Me.cBoxTons = New System.Windows.Forms.ComboBox()
        Me.TonDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TonDataTableAdapter = New ForkliftManager.SourceDBDataSetTableAdapters.tonDataTableAdapter()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TonDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(185, 222)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(61, 54)
        Me.btnSubmit.TabIndex = 38
        Me.btnSubmit.Text = "입력"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblDutyR
        '
        Me.lblDutyR.AutoSize = True
        Me.lblDutyR.Location = New System.Drawing.Point(95, 264)
        Me.lblDutyR.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDutyR.Name = "lblDutyR"
        Me.lblDutyR.Size = New System.Drawing.Size(30, 12)
        Me.lblDutyR.TabIndex = 37
        Me.lblDutyR.Text = "Duty"
        Me.lblDutyR.Visible = False
        '
        'lblFCostR
        '
        Me.lblFCostR.AutoSize = True
        Me.lblFCostR.Location = New System.Drawing.Point(95, 222)
        Me.lblFCostR.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFCostR.Name = "lblFCostR"
        Me.lblFCostR.Size = New System.Drawing.Size(31, 12)
        Me.lblFCostR.TabIndex = 36
        Me.lblFCostR.Text = "Cost"
        Me.lblFCostR.Visible = False
        '
        'lblDuty
        '
        Me.lblDuty.AutoSize = True
        Me.lblDuty.Location = New System.Drawing.Point(49, 264)
        Me.lblDuty.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDuty.Name = "lblDuty"
        Me.lblDuty.Size = New System.Drawing.Size(37, 12)
        Me.lblDuty.TabIndex = 35
        Me.lblDuty.Text = "세액 :"
        '
        'lblFCost
        '
        Me.lblFCost.AutoSize = True
        Me.lblFCost.Location = New System.Drawing.Point(23, 222)
        Me.lblFCost.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFCost.Name = "lblFCost"
        Me.lblFCost.Size = New System.Drawing.Size(61, 12)
        Me.lblFCost.TabIndex = 34
        Me.lblFCost.Text = "공급가액 :"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(211, 143)
        Me.lblQty.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(29, 12)
        Me.lblQty.TabIndex = 33
        Me.lblQty.Text = "수량"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(141, 143)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(29, 12)
        Me.lblCost.TabIndex = 32
        Me.lblCost.Text = "단가"
        '
        'lblTons
        '
        Me.lblTons.AutoSize = True
        Me.lblTons.Location = New System.Drawing.Point(43, 143)
        Me.lblTons.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTons.Name = "lblTons"
        Me.lblTons.Size = New System.Drawing.Size(29, 12)
        Me.lblTons.TabIndex = 31
        Me.lblTons.Text = "톤수"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(91, 80)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(29, 12)
        Me.lblDate.TabIndex = 30
        Me.lblDate.Text = "날짜"
        '
        'lblu_name
        '
        Me.lblu_name.AutoSize = True
        Me.lblu_name.Location = New System.Drawing.Point(189, 22)
        Me.lblu_name.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblu_name.Name = "lblu_name"
        Me.lblu_name.Size = New System.Drawing.Size(41, 12)
        Me.lblu_name.TabIndex = 29
        Me.lblu_name.Text = "작업자"
        '
        'lblc_name
        '
        Me.lblc_name.AutoSize = True
        Me.lblc_name.Location = New System.Drawing.Point(70, 22)
        Me.lblc_name.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblc_name.Name = "lblc_name"
        Me.lblc_name.Size = New System.Drawing.Size(41, 12)
        Me.lblc_name.TabIndex = 28
        Me.lblc_name.Text = "업체명"
        '
        'tBoxQty
        '
        Me.tBoxQty.Location = New System.Drawing.Point(211, 169)
        Me.tBoxQty.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxQty.Name = "tBoxQty"
        Me.tBoxQty.Size = New System.Drawing.Size(36, 21)
        Me.tBoxQty.TabIndex = 27
        Me.tBoxQty.Text = "1"
        '
        'tBoxCost
        '
        Me.tBoxCost.Location = New System.Drawing.Point(118, 169)
        Me.tBoxCost.Margin = New System.Windows.Forms.Padding(1)
        Me.tBoxCost.Name = "tBoxCost"
        Me.tBoxCost.Size = New System.Drawing.Size(79, 21)
        Me.tBoxCost.TabIndex = 26
        Me.tBoxCost.Text = "40000"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(26, 104)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(1)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(221, 21)
        Me.DateTimePicker1.TabIndex = 24
        '
        'cBoxu_name
        '
        Me.cBoxu_name.DataSource = Me.UserBindingSource
        Me.cBoxu_name.DisplayMember = "u_headname"
        Me.cBoxu_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxu_name.FormattingEnabled = True
        Me.cBoxu_name.Location = New System.Drawing.Point(169, 42)
        Me.cBoxu_name.Margin = New System.Windows.Forms.Padding(1)
        Me.cBoxu_name.Name = "cBoxu_name"
        Me.cBoxu_name.Size = New System.Drawing.Size(77, 20)
        Me.cBoxu_name.TabIndex = 23
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cBoxc_name
        '
        Me.cBoxc_name.DataSource = Me.ClientBindingSource
        Me.cBoxc_name.DisplayMember = "c_name"
        Me.cBoxc_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxc_name.FormattingEnabled = True
        Me.cBoxc_name.Location = New System.Drawing.Point(26, 42)
        Me.cBoxc_name.Margin = New System.Windows.Forms.Padding(1)
        Me.cBoxc_name.Name = "cBoxc_name"
        Me.cBoxc_name.Size = New System.Drawing.Size(130, 20)
        Me.cBoxc_name.TabIndex = 22
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "client"
        Me.ClientBindingSource.DataSource = Me.DBDataSet
        '
        'DealTableAdapter
        '
        Me.DealTableAdapter.ClearBeforeFill = True
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'cBoxTons
        '
        Me.cBoxTons.DataSource = Me.TonDataBindingSource
        Me.cBoxTons.DisplayMember = "ton"
        Me.cBoxTons.FormattingEnabled = True
        Me.cBoxTons.Location = New System.Drawing.Point(26, 170)
        Me.cBoxTons.Name = "cBoxTons"
        Me.cBoxTons.Size = New System.Drawing.Size(78, 20)
        Me.cBoxTons.TabIndex = 39
        '
        'TonDataBindingSource
        '
        Me.TonDataBindingSource.DataMember = "tonData"
        Me.TonDataBindingSource.DataSource = Me.DBDataSet
        '
        'TonDataTableAdapter
        '
        Me.TonDataTableAdapter.ClearBeforeFill = True
        '
        'DealForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 306)
        Me.Controls.Add(Me.cBoxTons)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblDutyR)
        Me.Controls.Add(Me.lblFCostR)
        Me.Controls.Add(Me.lblDuty)
        Me.Controls.Add(Me.lblFCost)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTons)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblu_name)
        Me.Controls.Add(Me.lblc_name)
        Me.Controls.Add(Me.tBoxQty)
        Me.Controls.Add(Me.tBoxCost)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cBoxu_name)
        Me.Controls.Add(Me.cBoxc_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximumSize = New System.Drawing.Size(292, 345)
        Me.MinimumSize = New System.Drawing.Size(292, 345)
        Me.Name = "DealForm"
        Me.Text = "거래내역 입력"
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TonDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblDutyR As System.Windows.Forms.Label
    Friend WithEvents lblFCostR As System.Windows.Forms.Label
    Friend WithEvents lblDuty As System.Windows.Forms.Label
    Friend WithEvents lblFCost As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblTons As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblu_name As System.Windows.Forms.Label
    Friend WithEvents lblc_name As System.Windows.Forms.Label
    Friend WithEvents tBoxQty As System.Windows.Forms.TextBox
    Friend WithEvents tBoxCost As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cBoxu_name As System.Windows.Forms.ComboBox
    Friend WithEvents cBoxc_name As System.Windows.Forms.ComboBox
    Friend WithEvents DealTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.dealTableAdapter
    Friend WithEvents DBDataSet As ForkliftManager.SourceDBDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.clientTableAdapter
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.userTableAdapter
    Friend WithEvents cBoxTons As System.Windows.Forms.ComboBox
    Friend WithEvents TonDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TonDataTableAdapter As ForkliftManager.SourceDBDataSetTableAdapters.tonDataTableAdapter
End Class
