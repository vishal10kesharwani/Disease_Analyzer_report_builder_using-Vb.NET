Imports System.Data.OleDb
Public Class Welcome

   
   

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        HOMEPAGE.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick

    End Sub

    Private Sub Welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DiagnosisTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagnosisTestToolStripMenuItem.Click
        AddDetails.Show()


    End Sub

    Private Sub ToolStripSplitButton2_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton2.ButtonClick

    End Sub

    Private Sub DiagnosisReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagnosisReportsToolStripMenuItem.Click
        GetRep.Show()


    End Sub

   

    Private Sub BloodReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BloodReportToolStripMenuItem.Click
       


    End Sub

    Private Sub BloodTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BloodTestToolStripMenuItem.Click
        Report.Show()
    End Sub

    Private Sub UrineReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GetRep.Show()

    End Sub

    Private Sub ToolStripLabel1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.ButtonClick

    End Sub

    Private Sub DiagnosisDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagnosisDetailsToolStripMenuItem.Click
        PReg.Show()
    End Sub

    Private Sub BloodDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Report.Show()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        MsgBox("Logout Successfully", MsgBoxStyle.Information)
        LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub ManualReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualReportToolStripMenuItem.Click
        Brep.Show()

    End Sub

    Private Sub CrystalReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportToolStripMenuItem.Click
        CryBrep.Show()

    End Sub
End Class