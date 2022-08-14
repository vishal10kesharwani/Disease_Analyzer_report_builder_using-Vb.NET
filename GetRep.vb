Imports System.Data.OleDb

Public Class GetRep

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        dbcon()
        Dim da As New OleDbDataAdapter("select pid,dat from p_diagnosis_info where pid='" & TextBox1.Text & "'", con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        dbcon()
        Dim da As New OleDbDataAdapter("select * from p_diagnosis_info where pid='" & TextBox1.Text & "' and dat='" & DateTimePicker1.Text & "'", con)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Diagnosisreport.Show()
            Me.Hide()
            With Diagnosisreport
                .Label17.Text = dt.Rows(0).Item("symp1")
                .Label21.Text = dt.Rows(0).Item("symp2")
                .Label20.Text = dt.Rows(0).Item("symp3")
                .Label19.Text = dt.Rows(0).Item("symp4")
                .Label26.Text = dt.Rows(0).Item("symp5")
                .Label27.Text = dt.Rows(0).Item("symp6")
                .Label22.Text = dt.Rows(0).Item("symp7")
                .Label23.Text = dt.Rows(0).Item("symp8")
                .Label24.Text = dt.Rows(0).Item("symp9")
                .Label25.Text = dt.Rows(0).Item("symp10")
                .Label18.Text = dt.Rows(0).Item("cure")
                .Label30.Text = dt.Rows(0).Item("age")
                .Label31.Text = dt.Rows(0).Item("cate")
            End With
        End If

        Dim da2 As New OleDbDataAdapter("select * from patient where pid='" & TextBox1.Text & "'", con)
        Dim dt2 As New DataTable
        da2.Fill(dt2)
        If dt2.Rows.Count > 0 Then

            With Diagnosisreport

                .Label28.Text = dt2.Rows(0).Item("pid")
                .Label29.Text = dt2.Rows(0).Item("fullname")

            End With
        End If


    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Welcome.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class