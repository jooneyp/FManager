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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.파일ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.보기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.사용자초기화ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.업체목록초기화ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.거래내역초기화ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.코드관리ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_clientMod
        '
        Me.btn_clientMod.Location = New System.Drawing.Point(90, 26)
        Me.btn_clientMod.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clientMod.Name = "btn_clientMod"
        Me.btn_clientMod.Size = New System.Drawing.Size(66, 52)
        Me.btn_clientMod.TabIndex = 2
        Me.btn_clientMod.Text = "거래처" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "관리"
        Me.btn_clientMod.UseVisualStyleBackColor = True
        '
        'btn_userMod
        '
        Me.btn_userMod.Location = New System.Drawing.Point(11, 26)
        Me.btn_userMod.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_userMod.Name = "btn_userMod"
        Me.btn_userMod.Size = New System.Drawing.Size(66, 52)
        Me.btn_userMod.TabIndex = 1
        Me.btn_userMod.Text = "사용자" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "관리"
        Me.btn_userMod.UseVisualStyleBackColor = True
        '
        'btn_deal
        '
        Me.btn_deal.Location = New System.Drawing.Point(169, 26)
        Me.btn_deal.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_deal.Name = "btn_deal"
        Me.btn_deal.Size = New System.Drawing.Size(66, 52)
        Me.btn_deal.TabIndex = 3
        Me.btn_deal.Text = "거래내역 입력"
        Me.btn_deal.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(248, 26)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(66, 52)
        Me.btn_print.TabIndex = 4
        Me.btn_print.Text = "거래내역 출력"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일ToolStripMenuItem, Me.보기ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(324, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '파일ToolStripMenuItem
        '
        Me.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem"
        Me.파일ToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.파일ToolStripMenuItem.Text = "거래내역 가져오기"
        '
        '보기ToolStripMenuItem
        '
        Me.보기ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.사용자초기화ToolStripMenuItem, Me.업체목록초기화ToolStripMenuItem, Me.거래내역초기화ToolStripMenuItem1, Me.코드관리ToolStripMenuItem})
        Me.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem"
        Me.보기ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.보기ToolStripMenuItem.Text = "설정"
        '
        '사용자초기화ToolStripMenuItem
        '
        Me.사용자초기화ToolStripMenuItem.Name = "사용자초기화ToolStripMenuItem"
        Me.사용자초기화ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.사용자초기화ToolStripMenuItem.Text = "사용자 초기화"
        Me.사용자초기화ToolStripMenuItem.Visible = False
        '
        '업체목록초기화ToolStripMenuItem
        '
        Me.업체목록초기화ToolStripMenuItem.Name = "업체목록초기화ToolStripMenuItem"
        Me.업체목록초기화ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.업체목록초기화ToolStripMenuItem.Text = "업체목록 초기화"
        Me.업체목록초기화ToolStripMenuItem.Visible = False
        '
        '거래내역초기화ToolStripMenuItem1
        '
        Me.거래내역초기화ToolStripMenuItem1.Name = "거래내역초기화ToolStripMenuItem1"
        Me.거래내역초기화ToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.거래내역초기화ToolStripMenuItem1.Text = "거래내역 초기화"
        Me.거래내역초기화ToolStripMenuItem1.Visible = False
        '
        '코드관리ToolStripMenuItem
        '
        Me.코드관리ToolStripMenuItem.Name = "코드관리ToolStripMenuItem"
        Me.코드관리ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.코드관리ToolStripMenuItem.Text = "코드 관리"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 87)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_clientMod)
        Me.Controls.Add(Me.btn_userMod)
        Me.Controls.Add(Me.btn_deal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "메인 메뉴"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_clientMod As System.Windows.Forms.Button
    Friend WithEvents btn_userMod As System.Windows.Forms.Button
    Friend WithEvents btn_deal As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 파일ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 보기ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 사용자초기화ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 업체목록초기화ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 거래내역초기화ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 코드관리ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
