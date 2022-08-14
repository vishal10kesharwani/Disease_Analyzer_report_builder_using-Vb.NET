Imports System.Data.OleDb
Public Class Report


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Welcome.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()

        TextBox8.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox17.Clear()
        TextBox18.Clear()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\vs1.mdb")
        con.Open()
        Try

            Dim str = "Insert into VS ([ID],[name],[addr],[gender],[age],[cont],[DOB],[doreq],[noclient],[Hemoglobin],[WBC],[RBC],[neutrophils],[monocytes],[plateletts],[esr]) values('" & TextBox2.Text & "','" & TextBox1.Text & "','" & TextBox18.Text & "','" & ComboBox2.SelectedItem & "','" & ComboBox1.SelectedItem & "','" & TextBox8.Text & "','" & DateTimePicker1.Value & "','" & DateTimePicker2.Value & "','" & TextBox10.Text & "','" & ComboBox3.SelectedItem & "','" & TextBox15.Text & "','" & TextBox14.Text & "','" & TextBox13.Text & "','" & TextBox17.Text & "','" & TextBox12.Text & "','" & TextBox11.Text & "') "

            Dim cmd As OleDbCommand = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("REPORT INSERTED SUCCESSFULLY", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("SOMETHING WENT WRONG!", MessageBoxIcon.Error)
        End Try
    End Sub

 
End Class