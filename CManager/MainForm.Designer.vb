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
        Me.Button_ClientMod = New System.Windows.Forms.Button()
        Me.Button_UserMod = New System.Windows.Forms.Button()
        Me.Button_Deal = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_ClientMod
        '
        Me.Button_ClientMod.Location = New System.Drawing.Point(560, 37)
        Me.Button_ClientMod.Name = "Button_ClientMod"
        Me.Button_ClientMod.Size = New System.Drawing.Size(122, 103)
        Me.Button_ClientMod.TabIndex = 6
        Me.Button_ClientMod.Text = "업체" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "관리"
        Me.Button_ClientMod.UseVisualStyleBackColor = True
        '
        'Button_UserMod
        '
        Me.Button_UserMod.Location = New System.Drawing.Point(393, 37)
        Me.Button_UserMod.Name = "Button_UserMod"
        Me.Button_UserMod.Size = New System.Drawing.Size(122, 103)
        Me.Button_UserMod.TabIndex = 5
        Me.Button_UserMod.Text = "사용자" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "관리"
        Me.Button_UserMod.UseVisualStyleBackColor = True
        '
        'Button_Deal
        '
        Me.Button_Deal.Location = New System.Drawing.Point(55, 37)
        Me.Button_Deal.Name = "Button_Deal"
        Me.Button_Deal.Size = New System.Drawing.Size(122, 103)
        Me.Button_Deal.TabIndex = 4
        Me.Button_Deal.Text = "거래내역 입력"
        Me.Button_Deal.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 103)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "거래내역 출력"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(511, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "For Office 2010"
        '
        'btn_
        '
        Me.btn_.Location = New System.Drawing.Point(722, 37)
        Me.btn_.Name = "btn_"
        Me.btn_.Size = New System.Drawing.Size(122, 103)
        Me.btn_.TabIndex = 9
        Me.btn_.Text = "업체" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "관리"
        Me.btn_.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 183)
        Me.Controls.Add(Me.btn_)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_ClientMod)
        Me.Controls.Add(Me.Button_UserMod)
        Me.Controls.Add(Me.Button_Deal)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents Button_ClientMod As System.Windows.Forms.Button
    Friend WithEvents Button_UserMod As System.Windows.Forms.Button
    Friend WithEvents Button_Deal As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_ As System.Windows.Forms.Button

End Class
