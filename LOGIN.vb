Imports System.Data.OleDb
Public Class LOGIN

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

      

        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\vs1.mdb")

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT USERNAME,PASSWORD FROM tb WHERE USERNAME = '" & TextBox1.Text & "' AND [PASSWORD] = '" & TextBox2.Text & "' ", con)

        Dim user As String = ""

        Dim pass As String = ""

        
        con.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()

        If (sdr.Read() = True) Then

            Try
                user = sdr("USERNAME")

                pass = sdr("PASSWORD")

                MsgBox("Logged In Successfully!")
                Welcome.Show()
                Me.Hide()


            Catch ex As Exception
                MsgBox("Invalid username or password!", MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If

    End Sub

    Private Sub LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SIGNUP.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        HOMEPAGE.Show()
        Me.Close()
    End Sub
End Class
