Public Class VisitiorsReports
    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass
    Dim EmpStatus As String
    Dim Flag As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Visitors\Visitors Report.rpt"
            If RadioButton2.Checked = True Then '' By date Range

                Filter = "{tbl_Gate_Visitors.EntryDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"


            ElseIf RadioButton3.Checked = True Then '' By Catagory
                Filter = "{tbl_Gate_Visitors.Category} = '" & ComboBox1.Text & "' And {tbl_Gate_Visitors.EntryDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"


            ElseIf RadioButton5.Checked = True Then '' By CNIC
                If TextBox1.Text.Length > 0 Then
                    Flag = False


                    Filter = "{tbl_Gate_Visitors.CNIC}  startswith  '" & TextBox1.Text & "' And {tbl_Gate_Visitors.EntryDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                Else
                    Flag = True



                End If

            ElseIf RadioButton4.Checked = True Then '' By Name
                If TextBox2.Text.Length > 0 Then
                    Flag = False
                    Filter = "{tbl_Gate_Visitors.Name}  startswith  '" & TextBox2.Text & "' And {tbl_Gate_Visitors.EntryDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                Else
                    Flag = True

                End If
            ElseIf RadioButton6.Checked = True Then  '' By Venhcle No
                If TextBox3.Text.Length > 0 Then
                    Flag = False
                    Filter = "{tbl_Gate_Visitors.VehicleNo}  startswith  '" & TextBox3.Text & "' And {tbl_Gate_Visitors.EntryDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                Else
                    Flag = True

                End If

            End If
        End If


        If Flag = True Then
            MessageBox.Show("Required Field is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadReports(Path, Filter, Param)
        End If

        '//Obj.LoadReports(Path, Filter, Param)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            ComboBox1.Enabled = True

        Else
            ComboBox1.Enabled = False

        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Label5.Text = "By CNIC :"
            TextBox1.Visible = True
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox1.Enabled = True
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox3.Clear()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Label5.Text = "By Name :"
            TextBox1.Visible = False
            TextBox2.Visible = True
            TextBox3.Visible = False
            TextBox1.Enabled = False
            TextBox2.Enabled = True
            TextBox3.Enabled = False
            TextBox1.Clear()
            TextBox3.Clear()
        End If

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            Label5.Text = "By Venicle No :"
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = True
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = True
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub
End Class