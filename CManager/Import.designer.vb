<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Import
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
        Me.lbl_wait = New System.Windows.Forms.Label()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.lbl_prog = New System.Windows.Forms.Label()
        Me.lbl_complete = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_wait
        '
        Me.lbl_wait.AutoSize = True
        Me.lbl_wait.Location = New System.Drawing.Point(137, 90)
        Me.lbl_wait.Name = "lbl_wait"
        Me.lbl_wait.Size = New System.Drawing.Size(69, 12)
        Me.lbl_wait.TabIndex = 0
        Me.lbl_wait.Text = "작업 대기중"
        Me.lbl_wait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(30, 12)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(176, 60)
        Me.btn_open.TabIndex = 34
        Me.btn_open.Text = "파일 열기.."
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'lbl_prog
        '
        Me.lbl_prog.AutoSize = True
        Me.lbl_prog.Location = New System.Drawing.Point(105, 90)
        Me.lbl_prog.Name = "lbl_prog"
        Me.lbl_prog.Size = New System.Drawing.Size(137, 12)
        Me.lbl_prog.TabIndex = 36
        Me.lbl_prog.Text = "작업중입니다.. (    /    )"
        Me.lbl_prog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_prog.Visible = False
        '
        'lbl_complete
        '
        Me.lbl_complete.AutoSize = True
        Me.lbl_complete.Location = New System.Drawing.Point(108, 90)
        Me.lbl_complete.Name = "lbl_complete"
        Me.lbl_complete.Size = New System.Drawing.Size(133, 12)
        Me.lbl_complete.TabIndex = 37
        Me.lbl_complete.Text = "작업이 완료되었습니다!"
        Me.lbl_complete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_complete.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(212, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 60)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "코드 편집.."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 121)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_complete)
        Me.Controls.Add(Me.lbl_prog)
        Me.Controls.Add(Me.btn_open)
        Me.Controls.Add(Me.lbl_wait)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Import"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "가져오기"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_wait As System.Windows.Forms.Label
    Friend WithEvents btn_open As System.Windows.Forms.Button
    Friend WithEvents lbl_prog As System.Windows.Forms.Label
    Friend WithEvents lbl_complete As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
