<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtValid = New TextBox()
        txtInvalid = New TextBox()
        btnSearch = New Button()
        txtTBFilename = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtValid
        ' 
        txtValid.Location = New Point(55, 162)
        txtValid.Multiline = True
        txtValid.Name = "txtValid"
        txtValid.PlaceholderText = "A list of valid emails will generate here"
        txtValid.Size = New Size(366, 153)
        txtValid.TabIndex = 0
        ' 
        ' txtInvalid
        ' 
        txtInvalid.Location = New Point(55, 365)
        txtInvalid.Multiline = True
        txtInvalid.Name = "txtInvalid"
        txtInvalid.PlaceholderText = "A list of invalid emails will generate here"
        txtInvalid.Size = New Size(366, 183)
        txtInvalid.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(327, 63)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 2
        btnSearch.Text = "&Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtTBFilename
        ' 
        txtTBFilename.Location = New Point(55, 65)
        txtTBFilename.Name = "txtTBFilename"
        txtTBFilename.PlaceholderText = "Enter file name here..."
        txtTBFilename.Size = New Size(231, 27)
        txtTBFilename.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(55, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 4
        Label1.Text = "Search for File"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(55, 329)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 20)
        Label2.TabIndex = 5
        Label2.Text = "Invalid Email Addresses"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(55, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 20)
        Label3.TabIndex = 6
        Label3.Text = "Valid Email Addresses"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 595)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTBFilename)
        Controls.Add(btnSearch)
        Controls.Add(txtInvalid)
        Controls.Add(txtValid)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtValid As TextBox
    Friend WithEvents txtInvalid As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtTBFilename As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
