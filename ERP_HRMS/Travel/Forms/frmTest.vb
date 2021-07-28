'Imports System.Management
Public Class frmTest
    Private Function SystemSerialNumber() As String
        ' Get the Windows Management Instrumentation object.
        Dim wmi As Object = GetObject("WinMgmts:")

        ' Get the "base boards" (mother boards).
        Dim serial_numbers As String = ""
        Dim mother_boards As Object = _
            wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers = _
            serial_numbers.Substring(2)

        Return serial_numbers
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Dim managementObjectSearcher = New ManagementObjectSearcher("Select * From Win32_BaseBoard")
        'For Each managementObject As var In managementObjectSearcher.Get()
        '    Console.WriteLine(managementObject("SerialNumber").ToString())
        'Next
        MsgBox(SystemSerialNumber)

        'Dim q As New SelectQuery("Win32_bios")
        'Dim search As New ManagementObjectSearcher(q)
        'Dim info As New ManagementObject

        'For Each info In search.Get
        '    MessageBox.Show("Serial Number: " & info("serialnumber").ToString & vbNewLine & vbNewLine & "Bios Version: " & info("version").ToString)
        'Next
    End Sub
End Class