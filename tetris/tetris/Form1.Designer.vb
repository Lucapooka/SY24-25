﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        avatar = New PictureBox()
        Timer1 = New Timer(components)
        PictureBox2 = New PictureBox()
        enemy = New PictureBox()
        enemy2 = New PictureBox()
        CType(avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' avatar
        ' 
        avatar.Image = CType(resources.GetObject("avatar.Image"), Image)
        avatar.Location = New Point(92, 59)
        avatar.Name = "avatar"
        avatar.Size = New Size(103, 174)
        avatar.SizeMode = PictureBoxSizeMode.StretchImage
        avatar.TabIndex = 0
        avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 105
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(351, 122)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(102, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' enemy
        ' 
        enemy.Image = CType(resources.GetObject("enemy.Image"), Image)
        enemy.Location = New Point(629, 85)
        enemy.Name = "enemy"
        enemy.Size = New Size(90, 148)
        enemy.SizeMode = PictureBoxSizeMode.StretchImage
        enemy.TabIndex = 2
        enemy.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = CType(resources.GetObject("enemy2.Image"), Image)
        enemy2.Location = New Point(761, 85)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(98, 148)
        enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        enemy2.TabIndex = 3
        enemy2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(979, 421)
        Controls.Add(enemy2)
        Controls.Add(enemy)
        Controls.Add(PictureBox2)
        Controls.Add(avatar)
        Name = "Form1"
        Text = "Form1"
        CType(avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents enemy As PictureBox
    Friend WithEvents enemy2 As PictureBox

End Class
