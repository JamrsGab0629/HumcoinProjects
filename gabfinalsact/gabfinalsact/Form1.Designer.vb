<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnOrder = New Button()
        btnAbout = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' btnOrder
        ' 
        btnOrder.Location = New Point(188, 172)
        btnOrder.Name = "btnOrder"
        btnOrder.Size = New Size(112, 65)
        btnOrder.TabIndex = 0
        btnOrder.Text = "Order"
        btnOrder.UseVisualStyleBackColor = True
        ' 
        ' btnAbout
        ' 
        btnAbout.Location = New Point(354, 172)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(89, 65)
        btnAbout.TabIndex = 1
        btnAbout.Text = "About Me"
        btnAbout.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(486, 172)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(90, 65)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(874, 513)
        Controls.Add(btnExit)
        Controls.Add(btnAbout)
        Controls.Add(btnOrder)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnOrder As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnExit As Button

End Class
