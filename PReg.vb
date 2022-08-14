Imports System.Data.OleDb
Public Class PReg

    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
                MsgBox("All Fields are Required", MsgBoxStyle.Critical)
            Else
                dbcon()
                Dim cmd As New OleDbCommand("insert into patient (pid,fullname,age,addr,phone,email) values('" & TextBox1.Text & "','" & TextBox2.Text & "'," & TextBox3.Text & ",'" & TextBox5.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "' )")
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                MsgBox("Record Saved Successfully", MsgBoxStyle.Information)
                clear()
                Form3_Load(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Sub clear()

        Dim SalesID As New Random
        Dim numbers As Integer = SalesID.Next(1, 12345)
        Dim digitss As String = numbers.ToString("00000")
        TextBox1.Text = "PA-" & digitss

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub


    Private Sub Form3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        dbcon()


        Try

            Dim SalesID As New Random
            Dim numbers As Integer = SalesID.Next(1, 12345)
            Dim digitss As String = numbers.ToString("00000")
            TextBox1.Text = "PA-" & digitss



            Dim da As New OleDbDataAdapter("select * from patient", con)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Try
            Dim cmd As New OleDbCommand("delete from patient where pid='" & TextBox1.Text & "'")
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MsgBox("Patient Record Deleted Successfully", MsgBoxStyle.Information)
            Form3_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
            TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            TextBox5.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
            TextBox6.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton3.Click
        Dim cmd As New OleDbCommand("update patient set pid='" & TextBox1.Text & "',fullname='" & TextBox2.Text & "',age='" & TextBox3.Text & "',addr='" & TextBox5.Text & "',phone='" & TextBox4.Text & "',email='" & TextBox6.Text & "' where pid='" & TextBox1.Text & "'")
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        Form3_Load(sender, e)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton4.Click
        clear()
    End Sub
End Class