Imports System.Data.OleDb
Public Class Diagnosisreport


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Single = 10
        Dim y As Single = 10
        Dim mWidth As Integer = Me.Width
        Dim mHeight As Integer = Me.Height
        Dim bmp As New Bitmap(mWidth, mHeight)
        Dim fromLeft As Integer = 0
        Dim fromTop As Integer = 0
        Me.DrawToBitmap(bmp, New Rectangle(fromLeft, fromTop, mWidth, mHeight))
        Dim limitX As Integer = e.PageBounds.Width
        Dim reduceMe As Double = limitX / mWidth


        Dim bmoToPrint As New Bitmap(bmp, CInt(mWidth * reduceMe), CInt(mHeight * reduceMe))

        e.Graphics.DrawImage(bmoToPrint, x, y, bmoToPrint.Width, bmoToPrint.Height)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        PrintDocument1.Print()

    End Sub

    Private Sub Diagnosisreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class