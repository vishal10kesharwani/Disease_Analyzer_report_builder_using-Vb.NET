Public Class Blood_Report

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintDocument1.Print()





    End Sub


   

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Single = 10 'e.MarginBounds.Left
        Dim y As Single = 10 'e.MarginBounds.Top

        'put here your width
        Dim mWidth As Integer = Me.Width

        'put here your height
        Dim mHeight As Integer = Me.Height

        ' Create you
        Dim bmp As New Bitmap(mWidth, mHeight)

        ' X cordinate
        Dim fromLeft As Integer = 0

        ' Y cordinate
        Dim fromTop As Integer = 0


        Me.DrawToBitmap(bmp, New Rectangle(fromLeft, fromTop, mWidth, mHeight))

        'Get the A4 size 
        Dim limitX As Integer = e.PageBounds.Width
        'use this to reduce your screenshot for the A4 format page
        Dim reduceMe As Double = limitX / mWidth


        Dim bmoToPrint As New Bitmap(bmp, CInt(mWidth * reduceMe), CInt(mHeight * reduceMe))

        e.Graphics.DrawImage(bmoToPrint, x, y, bmoToPrint.Width, bmoToPrint.Height)

    End Sub

    Private Sub LineShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LineShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineShape4.Click, LineShape9.Click, LineShape12.Click, LineShape11.Click, LineShape10.Click

    End Sub














    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label37.Click

    End Sub
End Class