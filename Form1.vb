Public Class Form1
    Dim recruitmentStatus As New HR_Recruitment_System.recruitmentStatus

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RecruitmentStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecruitmentStatusToolStripMenuItem.Click
        If recruitmentStatus Is Nothing OrElse recruitmentStatus.IsDisposed Then
            recruitmentStatus = New HR_Recruitment_System.recruitmentStatus
        End If
        recruitmentStatus.Show()
        Me.Hide()
    End Sub
End Class
