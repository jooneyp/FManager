<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btn_clientMod = New System.Windows.Forms.Button()
        Me.btn_userMod = New System.Windows.Forms.Button()
        Me.btn_deal = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_Import = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_clientMod
        '
        Me.btn_clientMod.Location = New System.Drawing.Point(283, 18)
        Me.btn_clientMod.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clientMod.Name = "btn_clientMod"
        Me.btn_clientMod.Size = New System.Drawing.Size(66, 52)
        Me.btn_clientMod.TabIndex = 6
        Me.btn_clientMod.Text = "업체" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "관리"
        Me.btn_clientMod.UseVisualStyleBackColor = True
        '
        'btn_userMod
        '
        Me.btn_userMod.Location = New System.Drawing.Point(195, 18)
        Me.btn_userMod.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_userMod.Name = "btn_userMod"
        Me.btn_userMod.Size = New System.Drawing.Size(66, 52)
        Me.btn_userMod.TabIndex = 5
        Me.btn_userMod.Text = "사용자" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "관리"
        Me.btn_userMod.UseVisualStyleBackColor = True
        '
        'btn_deal
        '
        Me.btn_deal.Location = New System.Drawing.Point(20, 18)
        Me.btn_deal.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_deal.Name = "btn_deal"
        Me.btn_deal.Size = New System.Drawing.Size(66, 52)
        Me.btn_deal.TabIndex = 4
        Me.btn_deal.Text = "거래내역 입력"
        Me.btn_deal.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(107, 18)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(66, 52)
        Me.btn_print.TabIndex = 7
        Me.btn_print.Text = "거래내역 출력"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_Import
        '
        Me.btn_Import.Location = New System.Drawing.Point(372, 18)
        Me.btn_Import.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Import.Name = "btn_Import"
        Me.btn_Import.Size = New System.Drawing.Size(66, 52)
        Me.btn_Import.TabIndex = 9
        Me.btn_Import.Text = "가져오기"
        Me.btn_Import.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 86)
        Me.Controls.Add(Me.btn_Import)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_clientMod)
        Me.Controls.Add(Me.btn_userMod)
        Me.Controls.Add(Me.btn_deal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_clientMod As System.Windows.Forms.Button
    Friend WithEvents btn_userMod As System.Windows.Forms.Button
    Friend WithEvents btn_deal As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_Import As System.Windows.Forms.Button

End Class
