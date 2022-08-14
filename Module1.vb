Module Module1
    Public con As OleDb.OleDbConnection
    Public Sub dbcon()
        con = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\vs1.mdb")

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Sub main()
        con = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\CW\Documents\PDS.mdb")
        con = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\vs1.mdb")

    End Sub
End Module
