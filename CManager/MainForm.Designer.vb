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
        Me.SuspendLayout()
        '
        'Button_ClientMod
        '
        Me.Button_ClientMod.Location = New System.Drawing.Point(431, 28)
        Me.Button_ClientMod.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_ClientMod.Name = "Button_ClientMod"
        Me.Button_ClientMod.Size = New System.Drawing.Size(94, 77)
        Me.Button_ClientMod.TabIndex = 6
        Me.Button_ClientMod.Text = "업체" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "관리"
        Me.Button_ClientMod.UseVisualStyleBackColor = True
        '
        'Button_UserMod
        '
        Me.Button_UserMod.Location = New System.Drawing.Point(302, 28)
        Me.Button_UserMod.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_UserMod.Name = "Button_UserMod"
        Me.Button_UserMod.Size = New System.Drawing.Size(94, 77)
        Me.Button_UserMod.TabIndex = 5
        Me.Button_UserMod.Text = "사용자" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "관리"
        Me.Button_UserMod.UseVisualStyleBackColor = True
        '
        'Button_Deal
        '
        Me.Button_Deal.Location = New System.Drawing.Point(42, 28)
        Me.Button_Deal.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Deal.Name = "Button_Deal"
        Me.Button_Deal.Size = New System.Drawing.Size(94, 77)
        Me.Button_Deal.TabIndex = 4
        Me.Button_Deal.Text = "거래내역 입력"
        Me.Button_Deal.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 77)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "거래내역 출력"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(393, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "For Office 2010"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 150)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_ClientMod)
        Me.Controls.Add(Me.Button_UserMod)
        Me.Controls.Add(Me.Button_Deal)
        Me.Margin = New System.Windows.Forms.Padding(2)
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

End Class
