Imports System.Data.OleDb

Public Class Brep
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged


        Try
            Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\vs1.mdb")
            con.Open()
            Dim query As String
            query = "select ID,name,doreq from VS"
            Dim olda As New OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            olda.Fill(ds, "VS")
            DataGridView1.DataSource = ds.Tables("VS")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Welcome.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\vs1.mdb")
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        cmd.CommandText = "select * from VS where ID= " & TextBox1.Text & ""
        con.Open()
        cmd.Connection = con
        dr = cmd.ExecuteReader
        dr.Read()
        Blood_Report.Show()
        Me.Hide()

        With Blood_Report
            .Label10.Text = dr.GetValue(1)
            .Label9.Text = dr.GetValue(4)
            .Label8.Text = dr.GetValue(6)
            .Label7.Text = dr.GetValue(7)
            .Label15.Text = dr.GetValue(3)
            .Label12.Text = dr.GetValue(8)
            .Label13.Text = dr.GetValue(5)

            .Label21.Text = dr.GetValue(9)
            .Label30.Text = dr.GetValue(10)
            .Label31.Text = dr.GetValue(11)
            .Label32.Text = dr.GetValue(12)
            .Label33.Text = dr.GetValue(13)
            .Label34.Text = dr.GetValue(14)
            .Label35.Text = dr.GetValue(15)


        End With


        dr.Close()
    End Sub

    Private Sub Brep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class