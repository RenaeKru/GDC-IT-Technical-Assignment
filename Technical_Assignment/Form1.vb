Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtValid.TextChanged

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtTBFilename.TextLength = 0 Then
            MessageBox.Show("Please enter a keyword to locate.")
            Return
        ElseIf txtTBFilename.TextLength > 0 Then
            Dim FileName = txtTBFilename.Text & ".csv"
            Dim FilePath = "C:\Users\Public" & "\" & FileName

            If System.IO.File.Exists(FilePath) Then                        ''''checking to see if the file exists
                Dim firstName As String
                Dim lastName As String
                Dim emailAddr As String
                MessageBox.Show("File name valid.")
                Dim validlst As List(Of String) = New List(Of String)()
                Dim invalidlst As List(Of String) = New List(Of String)()

                Dim tfp As New TextFieldParser(FilePath)                  '''''reading the file and reviewing emails
                tfp.Delimiters = New String() {","}
                tfp.TextFieldType = FieldType.Delimited

                tfp.ReadLine()
                While tfp.EndOfData = False
                    Dim fields = tfp.ReadFields()
                    firstName = fields(0)
                    lastName = fields(1)
                    emailAddr = fields(2)


                    If IsValidEmailFormat(emailAddr) = True Then          '''''reviewing email validity and adding to appropriate list
                        validlst.Add(emailAddr)
                    Else
                        invalidlst.Add(emailAddr)
                    End If
                End While

                For i As Integer = 0 To validlst.Count - 1            ''''generating valid email list
                    txtValid.Text &= validlst(i) & vbCrLf
                Next i

                For x As Integer = 0 To invalidlst.Count - 1        ''''''generating invalid email list
                    txtInvalid.Text &= invalidlst(x) & vbCrLf
                Next x
            Else
                MessageBox.Show("File name not found.")
            End If

            Return
        End If

    End Sub

    Function IsValidEmailFormat(ByVal s As String) As Boolean ''''stackoverflow.com/questions/1331084/how-do-i-validate-email-address-formatting-with-the-net-framework
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class