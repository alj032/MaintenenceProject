﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.studInfoButton = New System.Windows.Forms.Button()
        Me.reportsButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.advisingButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'studInfoButton
        '
        Me.studInfoButton.Location = New System.Drawing.Point(133, 147)
        Me.studInfoButton.Name = "studInfoButton"
        Me.studInfoButton.Size = New System.Drawing.Size(113, 54)
        Me.studInfoButton.TabIndex = 0
        Me.studInfoButton.Text = "Enter Student Information"
        Me.studInfoButton.UseVisualStyleBackColor = True
        Me.studInfoButton.Visible = False
        '
        'reportsButton
        '
        Me.reportsButton.Location = New System.Drawing.Point(133, 207)
        Me.reportsButton.Name = "reportsButton"
        Me.reportsButton.Size = New System.Drawing.Size(113, 65)
        Me.reportsButton.TabIndex = 1
        Me.reportsButton.Text = "View Reports"
        Me.reportsButton.UseVisualStyleBackColor = True
        Me.reportsButton.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LoginButton)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(94, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(54, 72)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 23)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'advisingButton
        '
        Me.advisingButton.Location = New System.Drawing.Point(133, 278)
        Me.advisingButton.Name = "advisingButton"
        Me.advisingButton.Size = New System.Drawing.Size(113, 53)
        Me.advisingButton.TabIndex = 3
        Me.advisingButton.Text = "Advising"
        Me.advisingButton.UseVisualStyleBackColor = True
        Me.advisingButton.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 375)
        Me.Controls.Add(Me.advisingButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.reportsButton)
        Me.Controls.Add(Me.studInfoButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents studInfoButton As Button
    Friend WithEvents reportsButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents advisingButton As Button
End Class
