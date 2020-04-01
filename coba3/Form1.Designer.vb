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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bil1 = New System.Windows.Forms.TextBox()
        Me.bil2 = New System.Windows.Forms.TextBox()
        Me.hsil = New System.Windows.Forms.TextBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnkurang = New System.Windows.Forms.Button()
        Me.btnkali = New System.Windows.Forms.Button()
        Me.btnbagi = New System.Windows.Forms.Button()
        Me.btnhps = New System.Windows.Forms.Button()
        Me.btnext = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bilangan 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bilangin 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'bil1
        '
        Me.bil1.Location = New System.Drawing.Point(106, 30)
        Me.bil1.Name = "bil1"
        Me.bil1.Size = New System.Drawing.Size(149, 20)
        Me.bil1.TabIndex = 3
        Me.bil1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bil2
        '
        Me.bil2.Location = New System.Drawing.Point(106, 75)
        Me.bil2.Name = "bil2"
        Me.bil2.Size = New System.Drawing.Size(149, 20)
        Me.bil2.TabIndex = 4
        Me.bil2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hsil
        '
        Me.hsil.Location = New System.Drawing.Point(106, 122)
        Me.hsil.Name = "hsil"
        Me.hsil.Size = New System.Drawing.Size(149, 20)
        Me.hsil.TabIndex = 5
        Me.hsil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(23, 208)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(58, 29)
        Me.btntambah.TabIndex = 6
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnkurang
        '
        Me.btnkurang.Location = New System.Drawing.Point(87, 208)
        Me.btnkurang.Name = "btnkurang"
        Me.btnkurang.Size = New System.Drawing.Size(58, 29)
        Me.btnkurang.TabIndex = 7
        Me.btnkurang.Text = "Kurang"
        Me.btnkurang.UseVisualStyleBackColor = True
        '
        'btnkali
        '
        Me.btnkali.Location = New System.Drawing.Point(151, 208)
        Me.btnkali.Name = "btnkali"
        Me.btnkali.Size = New System.Drawing.Size(58, 29)
        Me.btnkali.TabIndex = 8
        Me.btnkali.Text = "Kali"
        Me.btnkali.UseVisualStyleBackColor = True
        '
        'btnbagi
        '
        Me.btnbagi.Location = New System.Drawing.Point(215, 208)
        Me.btnbagi.Name = "btnbagi"
        Me.btnbagi.Size = New System.Drawing.Size(58, 29)
        Me.btnbagi.TabIndex = 9
        Me.btnbagi.Text = "Bagi"
        Me.btnbagi.UseVisualStyleBackColor = True
        '
        'btnhps
        '
        Me.btnhps.Location = New System.Drawing.Point(55, 243)
        Me.btnhps.Name = "btnhps"
        Me.btnhps.Size = New System.Drawing.Size(58, 29)
        Me.btnhps.TabIndex = 10
        Me.btnhps.Text = "Delete"
        Me.btnhps.UseVisualStyleBackColor = True
        '
        'btnext
        '
        Me.btnext.Location = New System.Drawing.Point(179, 243)
        Me.btnext.Name = "btnext"
        Me.btnext.Size = New System.Drawing.Size(58, 29)
        Me.btnext.TabIndex = 11
        Me.btnext.Text = "Exit"
        Me.btnext.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Label4"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(84, 178)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(186, 24)
        Me.ProgressBar1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 305)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnext)
        Me.Controls.Add(Me.btnhps)
        Me.Controls.Add(Me.btnbagi)
        Me.Controls.Add(Me.btnkali)
        Me.Controls.Add(Me.btnkurang)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.hsil)
        Me.Controls.Add(Me.bil2)
        Me.Controls.Add(Me.bil1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bil1 As TextBox
    Friend WithEvents bil2 As TextBox
    Friend WithEvents hsil As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnkurang As Button
    Friend WithEvents btnkali As Button
    Friend WithEvents btnbagi As Button
    Friend WithEvents btnhps As Button
    Friend WithEvents btnext As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
