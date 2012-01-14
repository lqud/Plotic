<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diaImageZoom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picStatic = New System.Windows.Forms.PictureBox()
        CType(Me.picStatic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picStatic
        '
        Me.picStatic.Location = New System.Drawing.Point(12, 12)
        Me.picStatic.Name = "picStatic"
        Me.picStatic.Size = New System.Drawing.Size(223, 221)
        Me.picStatic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStatic.TabIndex = 1
        Me.picStatic.TabStop = False
        '
        'diaImageZoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 299)
        Me.Controls.Add(Me.picStatic)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "diaImageZoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "diaImageZoom"
        CType(Me.picStatic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picStatic As System.Windows.Forms.PictureBox

End Class
