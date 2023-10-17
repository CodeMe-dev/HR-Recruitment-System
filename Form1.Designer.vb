<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RecruitmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecruitmentStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CVsBankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecruitmentBillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(4, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(128, 398)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecruitmToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RecruitmToolStripMenuItem
        '
        Me.RecruitmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecruitmentStatusToolStripMenuItem, Me.CVsBankToolStripMenuItem, Me.RecruitmentBillsToolStripMenuItem})
        Me.RecruitmToolStripMenuItem.Image = Global.HR_Recruitment_System.My.Resources.Resources.icons8_recruitment_64__1_
        Me.RecruitmToolStripMenuItem.Name = "RecruitmToolStripMenuItem"
        Me.RecruitmToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.RecruitmToolStripMenuItem.Text = "Recruitment"
        '
        'RecruitmentStatusToolStripMenuItem
        '
        Me.RecruitmentStatusToolStripMenuItem.Image = Global.HR_Recruitment_System.My.Resources.Resources.icons8_recruitment_64
        Me.RecruitmentStatusToolStripMenuItem.Name = "RecruitmentStatusToolStripMenuItem"
        Me.RecruitmentStatusToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RecruitmentStatusToolStripMenuItem.Text = "Recruitment Status"
        '
        'CVsBankToolStripMenuItem
        '
        Me.CVsBankToolStripMenuItem.Image = Global.HR_Recruitment_System.My.Resources.Resources.icons8_resume_96
        Me.CVsBankToolStripMenuItem.Name = "CVsBankToolStripMenuItem"
        Me.CVsBankToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CVsBankToolStripMenuItem.Text = "CVs Bank"
        '
        'RecruitmentBillsToolStripMenuItem
        '
        Me.RecruitmentBillsToolStripMenuItem.Image = Global.HR_Recruitment_System.My.Resources.Resources.icons8_bill_96
        Me.RecruitmentBillsToolStripMenuItem.Name = "RecruitmentBillsToolStripMenuItem"
        Me.RecruitmentBillsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RecruitmentBillsToolStripMenuItem.Text = "Recruitment Bills"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HR_Recruitment_System.My.Resources.Resources.Gulf_Economic_Contracting_Company_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(4, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(800, 526)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HR - Recruitment System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RecruitmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecruitmentStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CVsBankToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecruitmentBillsToolStripMenuItem As ToolStripMenuItem
End Class
