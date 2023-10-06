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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TxtPhrase = New TextBox()
        TxtPos = New TextBox()
        TxtNumber = New TextBox()
        LblExtract = New TextBox()
        BtnExtact = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(189, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter a Phrase"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(189, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter the Starting Point"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(189, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(174, 15)
        Label3.TabIndex = 2
        Label3.Text = "Numberof Characters to Extract"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(189, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 15)
        Label4.TabIndex = 3
        Label4.Text = "Text Etracted"
        ' 
        ' TxtPhrase
        ' 
        TxtPhrase.Location = New Point(389, 43)
        TxtPhrase.Name = "TxtPhrase"
        TxtPhrase.Size = New Size(152, 23)
        TxtPhrase.TabIndex = 4
        ' 
        ' TxtPos
        ' 
        TxtPos.Location = New Point(389, 89)
        TxtPos.Name = "TxtPos"
        TxtPos.Size = New Size(100, 23)
        TxtPos.TabIndex = 5
        ' 
        ' TxtNumber
        ' 
        TxtNumber.Location = New Point(389, 141)
        TxtNumber.Name = "TxtNumber"
        TxtNumber.Size = New Size(100, 23)
        TxtNumber.TabIndex = 6
        ' 
        ' LblExtract
        ' 
        LblExtract.Location = New Point(389, 200)
        LblExtract.Name = "LblExtract"
        LblExtract.Size = New Size(100, 23)
        LblExtract.TabIndex = 7
        ' 
        ' BtnExtact
        ' 
        BtnExtact.Location = New Point(308, 271)
        BtnExtact.Name = "BtnExtact"
        BtnExtact.Size = New Size(75, 23)
        BtnExtact.TabIndex = 8
        BtnExtact.Text = "Extract"
        BtnExtact.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnExtact)
        Controls.Add(LblExtract)
        Controls.Add(TxtNumber)
        Controls.Add(TxtPos)
        Controls.Add(TxtPhrase)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPhrase As TextBox
    Friend WithEvents TxtPos As TextBox
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents LblExtract As TextBox
    Friend WithEvents BtnExtact As Button
End Class
