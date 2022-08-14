Imports System.Data.OleDb
Public Class AddDetails




    Dim cat As String


    Sub diagonise()
        Try
            dbcon()
            Dim da As New OleDbDataAdapter("select * from diagnosis where prio=" & cat & "", con)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("You Have Malaria")
                Label13.Text = dt.Rows(0).Item("cure")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click


        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or ComboBox4.Text = "" Or ComboBox5.Text = "" Or ComboBox6.Text = "" Or ComboBox7.Text = "" Or ComboBox8.Text = "" Or ComboBox9.Text = "" Or ComboBox10.Text = "" Or ComboBox11.Text = "" Or Label16.Text.Count < 2 Then

            MsgBox("Please Fill All The Comboboxes", MsgBoxStyle.Information)

        Else
            If ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "NO" And
ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
     ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
     ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
     ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "NO" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
     ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
     ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
     ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
            ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "NO" And ComboBox5.Text = "NO" And
     ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "NO" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()
            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "LOW" And ComboBox2.Text = "NO" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "NO" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "NO" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "NO" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "NO" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "LOW" And ComboBox2.Text = "NO" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "NO" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "LOW" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "LOW" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "NO" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()


            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "LOW" And ComboBox2.Text = "NO" And ComboBox3.Text = "YES" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()


            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()


            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()


            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "LOW" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()


            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "NO" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "NO" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "LOW" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "NO" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "NO" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "NO" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "NO" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "LOW" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()


            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "NO" And ComboBox5.Text = "YES" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "YES" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "LOW" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "NO" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "NO" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "YES" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                MsgBox("YOU HAVE MALARIA. ")

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "NO" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()


            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "NO" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()


            ElseIf ComboBox1.Text = "HIGH" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "YES" Then
                diagonise()

            ElseIf ComboBox1.Text = "NORMAL" And ComboBox2.Text = "YES" And ComboBox3.Text = "YES" And ComboBox4.Text = "YES" And ComboBox5.Text = "NO" And
             ComboBox6.Text = "NO" And ComboBox7.Text = "NO" And ComboBox8.Text = "YES" And ComboBox9.Text = "YES" And ComboBox10.Text = "NO" Then
                diagonise()

            ElseIf ComboBox1.Text = "Low" And ComboBox2.Text = "No" And ComboBox3.Text = "No" And ComboBox4.Text = "No" And ComboBox5.Text = "No" And
             ComboBox6.Text = "No" And ComboBox7.Text = "No" And ComboBox8.Text = "No" And ComboBox9.Text = "No" And ComboBox10.Text = "No" Then
                MsgBox("You Dont Have Malaria  ")
            Else
                diagonise()
            End If


        End If
    End Sub





    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox11.SelectedIndexChanged

        If Val(ComboBox11.Text) < 17 Then
            cat = "1"
            Label19.Text = "You Are An Adolescent"
        End If
        If Val(ComboBox11.Text) > 17 Then
            cat = "2"
            Label19.Text = "You Are A Youth"
        End If
        If Val(ComboBox11.Text) > 29 Then
            cat = "3"
            Label19.Text = "You Are An Adult"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        dbcon()
        Dim da As New OleDb.OleDbDataAdapter("select * from patient where pid='" & TextBox1.Text & "'", con)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Label16.Text = dt.Rows(0).Item("fullname")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Try
            dbcon()
            Dim cmd As New OleDbCommand("insert into p_diagnosis_info(pid,symp1,symp2,symp3,symp4,symp5,symp6,symp7,symp8,symp9,symp10,cure,age,cate,dat)values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & ComboBox6.Text & "' ,'" & ComboBox7.Text & "','" & ComboBox8.Text & "','" & ComboBox9.Text & "','" & ComboBox10.Text & "','" & Label13.Text & "','" & ComboBox11.Text & "','" & cat & "','" & DateTimePicker1.Text & "')")
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MsgBox("Diagnosis Infomation Saved Successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub AddDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class