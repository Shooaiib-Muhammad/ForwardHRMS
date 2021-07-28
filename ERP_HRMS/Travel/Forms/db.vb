Imports System.data
Imports System.IO
Imports SDO = System.Data.Odbc

Public Class db
    Public con As New SDO.OdbcConnection
    Public com As New SDO.OdbcCommand

    Public qry As String
    Public Rd As SDO.OdbcDataReader
    Public DA As New SDO.OdbcDataAdapter
    Public DA1 As New SDO.OdbcDataAdapter
    Public DA2 As New SDO.OdbcDataAdapter
    Public DS1 As New DataSet
    Public DS2 As New DataSet
    Dim a, b, c As String

    Public UID As Integer
    Public UN As String
    Public LD As Integer

    Public ComCH As New SDO.OdbcCommand
    Public RdCH As SDO.OdbcDataReader

    Public Sub saveImage(ByVal qry As String, ByVal arrayimage() As Byte)
        Try
            open()
            Dim objcommand As New SDO.OdbcCommand(qry, con)
            With objcommand
                .Parameters.Add(New SDO.OdbcParameter("@Picture", SDO.OdbcType.Binary)).Value = arrayimage
            End With
            com.CommandType = Data.CommandType.Text
            objcommand.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            close()
        End Try
    End Sub

    Public Sub open()
        'Dim conString As String = "Driver=" & a & ";Server=" & b & ";Database=" & c & ";"
        Dim conString As String = My.Settings.MyBUSCon
        Try
            If con.State = Data.ConnectionState.Closed Then
                con.ConnectionString = conString
                con.Open()
                com.Connection = con
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub close()
        Try
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Public Sub New()
    '    Using sr As StreamReader = New StreamReader("C:\MyReports\MIS-Setting.txt")
    '        a = sr.ReadLine
    '        b = sr.ReadLine
    '        c = sr.ReadLine
    '        sr.Close()
    '    End Using
    'End Sub
End Class
