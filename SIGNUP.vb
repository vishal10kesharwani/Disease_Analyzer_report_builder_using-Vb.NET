Imports System.Data.OleDb
Public Class SIGNUP

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If CheckBox1.Checked Then

        Else
            ErrorProvider1.SetError(CheckBox1, "PLEASE VERIFY THIS CHECKBOX")
        End If

        Dim name1, name2, name3, uname, password, email, vsk As String

        name1 = TextBox1.Text
        name2 = TextBox2.Text
        name3 = TextBox3.Text

        uname = TextBox4.Text
        password = TextBox5.Text
        email = TextBox6.Text
        vsk = ComboBox1.SelectedItem

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Please Fill All The Box First !!!", MessageBoxIcon.Error)
        ElseIf TextBox4.TextLength And TextBox5.TextLength < 8 Then
            MsgBox("USERNAME AND PASSWORD SHOULD BE GREATER THAN 8 Characters !!!", MessageBoxIcon.Warning)
        Else
            Dim dbsource As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\CW\Documents\vs1.mdb"
            Dim conn = New OleDbConnection(dbsource)
            conn.Open()

            Dim str = "Insert into tb  Values ('" & name1 & "','" & name2 & "','" & name3 & "','" & uname & "','" & password & "','" & email & "','" & vsk & "') "
            Dim cmd As OleDbCommand = New OleDbCommand(str, conn)

            If cmd.ExecuteNonQuery() = 1 Then
                cmd.Dispose()
                conn.Close()

                MsgBox("USER REGISTERED SUCCESSFULLY")
                HOMEPAGE.Show()
                Me.Hide()
            Else
                MsgBox("SOMETHING WENT WRONG!", MessageBoxIcon.Error)

            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LOGIN.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        HOMEPAGE.Show()
        Me.Hide()

    End Sub

    Private Sub SIGNUP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class