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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label4 = New Label()
        ProgressBar1 = New ProgressBar()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(169, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(513, 84)
        Label1.TabIndex = 0
        Label1.Text = "HotelSoft System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tempus Sans ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(244, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(372, 35)
        Label2.TabIndex = 1
        Label2.Text = "Sistema de Gestión para Hoteles"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(70, 193)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(253, 234)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tempus Sans ITC", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(613, 253)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 42)
        Label3.TabIndex = 3
        Label3.Text = "Version 1.0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tempus Sans ITC", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(571, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(242, 42)
        Label4.TabIndex = 4
        Label4.Text = "Windows 10 64x"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(70, 450)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(713, 23)
        ProgressBar1.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(859, 517)
        Controls.Add(ProgressBar1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
