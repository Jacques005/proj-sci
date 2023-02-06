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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.picChoc = New System.Windows.Forms.PictureBox()
        Me.picV = New System.Windows.Forms.PictureBox()
        Me.picS = New System.Windows.Forms.PictureBox()
        Me.picM = New System.Windows.Forms.PictureBox()
        Me.picC = New System.Windows.Forms.PictureBox()
        CType(Me.picChoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Chocolate", "Vanilla", "Mint", "Strawberry", "Chocolate Chip"})
        Me.ListBox1.Location = New System.Drawing.Point(501, 41)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(162, 134)
        Me.ListBox1.TabIndex = 0
        '
        'picChoc
        '
        Me.picChoc.Image = Global.stuff.My.Resources.Resources.download__10_
        Me.picChoc.Location = New System.Drawing.Point(215, 41)
        Me.picChoc.Name = "picChoc"
        Me.picChoc.Size = New System.Drawing.Size(205, 135)
        Me.picChoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoc.TabIndex = 1
        Me.picChoc.TabStop = False
        Me.picChoc.Visible = False
        '
        'picV
        '
        Me.picV.Image = Global.stuff.My.Resources.Resources.download__11_
        Me.picV.Location = New System.Drawing.Point(215, 41)
        Me.picV.Name = "picV"
        Me.picV.Size = New System.Drawing.Size(205, 135)
        Me.picV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picV.TabIndex = 2
        Me.picV.TabStop = False
        Me.picV.Visible = False
        '
        'picS
        '
        Me.picS.Image = Global.stuff.My.Resources.Resources.download__12_
        Me.picS.Location = New System.Drawing.Point(215, 41)
        Me.picS.Name = "picS"
        Me.picS.Size = New System.Drawing.Size(205, 135)
        Me.picS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picS.TabIndex = 3
        Me.picS.TabStop = False
        Me.picS.Visible = False
        '
        'picM
        '
        Me.picM.Image = Global.stuff.My.Resources.Resources.download__13_
        Me.picM.Location = New System.Drawing.Point(215, 41)
        Me.picM.Name = "picM"
        Me.picM.Size = New System.Drawing.Size(205, 135)
        Me.picM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picM.TabIndex = 4
        Me.picM.TabStop = False
        Me.picM.Visible = False
        '
        'picC
        '
        Me.picC.Image = Global.stuff.My.Resources.Resources.download__14_
        Me.picC.Location = New System.Drawing.Point(215, 41)
        Me.picC.Name = "picC"
        Me.picC.Size = New System.Drawing.Size(205, 135)
        Me.picC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC.TabIndex = 5
        Me.picC.TabStop = False
        Me.picC.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picC)
        Me.Controls.Add(Me.picM)
        Me.Controls.Add(Me.picS)
        Me.Controls.Add(Me.picV)
        Me.Controls.Add(Me.picChoc)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picChoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents picChoc As PictureBox
    Friend WithEvents picV As PictureBox
    Friend WithEvents picS As PictureBox
    Friend WithEvents picM As PictureBox
    Friend WithEvents picC As PictureBox
End Class
