<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.title = New System.Windows.Forms.Label()
        Me.author = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.samaDengan = New System.Windows.Forms.Button()
        Me.kurang = New System.Windows.Forms.Button()
        Me.tambah = New System.Windows.Forms.Button()
        Me.bagi = New System.Windows.Forms.Button()
        Me.kali = New System.Windows.Forms.Button()
        Me.titik = New System.Windows.Forms.Button()
        Me.nolNol = New System.Windows.Forms.Button()
        Me.nol = New System.Windows.Forms.Button()
        Me.sembilan = New System.Windows.Forms.Button()
        Me.delapan = New System.Windows.Forms.Button()
        Me.tujuh = New System.Windows.Forms.Button()
        Me.enam = New System.Windows.Forms.Button()
        Me.lima = New System.Windows.Forms.Button()
        Me.empat = New System.Windows.Forms.Button()
        Me.tiga = New System.Windows.Forms.Button()
        Me.dua = New System.Windows.Forms.Button()
        Me.satu = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Yu Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.White
        Me.title.Location = New System.Drawing.Point(139, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(295, 42)
        Me.title.TabIndex = 0
        Me.title.Text = "Simple Calculator"
        Me.title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'author
        '
        Me.author.AutoSize = True
        Me.author.BackColor = System.Drawing.Color.Transparent
        Me.author.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author.ForeColor = System.Drawing.Color.White
        Me.author.Location = New System.Drawing.Point(253, 51)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(83, 18)
        Me.author.TabIndex = 1
        Me.author.Text = "by AlfianiFk"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.Controls.Add(Me.Button19)
        Me.Panel1.Controls.Add(Me.clear)
        Me.Panel1.Controls.Add(Me.samaDengan)
        Me.Panel1.Controls.Add(Me.kurang)
        Me.Panel1.Controls.Add(Me.tambah)
        Me.Panel1.Controls.Add(Me.bagi)
        Me.Panel1.Controls.Add(Me.kali)
        Me.Panel1.Controls.Add(Me.titik)
        Me.Panel1.Controls.Add(Me.nolNol)
        Me.Panel1.Controls.Add(Me.nol)
        Me.Panel1.Controls.Add(Me.sembilan)
        Me.Panel1.Controls.Add(Me.delapan)
        Me.Panel1.Controls.Add(Me.tujuh)
        Me.Panel1.Controls.Add(Me.enam)
        Me.Panel1.Controls.Add(Me.lima)
        Me.Panel1.Controls.Add(Me.empat)
        Me.Panel1.Controls.Add(Me.tiga)
        Me.Panel1.Controls.Add(Me.dua)
        Me.Panel1.Controls.Add(Me.satu)
        Me.Panel1.Controls.Add(Me.txtInput)
        Me.Panel1.Location = New System.Drawing.Point(35, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 476)
        Me.Panel1.TabIndex = 2
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button19.ForeColor = System.Drawing.Color.White
        Me.Button19.Location = New System.Drawing.Point(371, 419)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(91, 39)
        Me.Button19.TabIndex = 19
        Me.Button19.Text = "Close"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(49, 359)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(209, 43)
        Me.clear.TabIndex = 18
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'samaDengan
        '
        Me.samaDengan.Location = New System.Drawing.Point(275, 359)
        Me.samaDengan.Name = "samaDengan"
        Me.samaDengan.Size = New System.Drawing.Size(150, 44)
        Me.samaDengan.TabIndex = 17
        Me.samaDengan.Text = "="
        Me.samaDengan.UseVisualStyleBackColor = True
        '
        'kurang
        '
        Me.kurang.Location = New System.Drawing.Point(274, 297)
        Me.kurang.Name = "kurang"
        Me.kurang.Size = New System.Drawing.Size(151, 56)
        Me.kurang.TabIndex = 16
        Me.kurang.Text = "-"
        Me.kurang.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(275, 232)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(151, 56)
        Me.tambah.TabIndex = 15
        Me.tambah.Text = "+"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'bagi
        '
        Me.bagi.Location = New System.Drawing.Point(274, 170)
        Me.bagi.Name = "bagi"
        Me.bagi.Size = New System.Drawing.Size(151, 56)
        Me.bagi.TabIndex = 14
        Me.bagi.Text = ":"
        Me.bagi.UseVisualStyleBackColor = True
        '
        'kali
        '
        Me.kali.Location = New System.Drawing.Point(274, 107)
        Me.kali.Name = "kali"
        Me.kali.Size = New System.Drawing.Size(151, 56)
        Me.kali.TabIndex = 13
        Me.kali.Text = "x"
        Me.kali.UseVisualStyleBackColor = True
        '
        'titik
        '
        Me.titik.Location = New System.Drawing.Point(193, 296)
        Me.titik.Name = "titik"
        Me.titik.Size = New System.Drawing.Size(66, 57)
        Me.titik.TabIndex = 12
        Me.titik.Text = "."
        Me.titik.UseVisualStyleBackColor = True
        '
        'nolNol
        '
        Me.nolNol.Location = New System.Drawing.Point(121, 296)
        Me.nolNol.Name = "nolNol"
        Me.nolNol.Size = New System.Drawing.Size(66, 57)
        Me.nolNol.TabIndex = 11
        Me.nolNol.Text = "00"
        Me.nolNol.UseVisualStyleBackColor = True
        '
        'nol
        '
        Me.nol.Location = New System.Drawing.Point(49, 296)
        Me.nol.Name = "nol"
        Me.nol.Size = New System.Drawing.Size(66, 57)
        Me.nol.TabIndex = 10
        Me.nol.Text = "0"
        Me.nol.UseVisualStyleBackColor = True
        '
        'sembilan
        '
        Me.sembilan.Location = New System.Drawing.Point(193, 233)
        Me.sembilan.Name = "sembilan"
        Me.sembilan.Size = New System.Drawing.Size(66, 57)
        Me.sembilan.TabIndex = 9
        Me.sembilan.Text = "9"
        Me.sembilan.UseVisualStyleBackColor = True
        '
        'delapan
        '
        Me.delapan.Location = New System.Drawing.Point(121, 233)
        Me.delapan.Name = "delapan"
        Me.delapan.Size = New System.Drawing.Size(66, 57)
        Me.delapan.TabIndex = 8
        Me.delapan.Text = "8"
        Me.delapan.UseVisualStyleBackColor = True
        '
        'tujuh
        '
        Me.tujuh.Location = New System.Drawing.Point(49, 233)
        Me.tujuh.Name = "tujuh"
        Me.tujuh.Size = New System.Drawing.Size(66, 57)
        Me.tujuh.TabIndex = 7
        Me.tujuh.Text = "7"
        Me.tujuh.UseVisualStyleBackColor = True
        '
        'enam
        '
        Me.enam.Location = New System.Drawing.Point(193, 170)
        Me.enam.Name = "enam"
        Me.enam.Size = New System.Drawing.Size(66, 57)
        Me.enam.TabIndex = 6
        Me.enam.Text = "6"
        Me.enam.UseVisualStyleBackColor = True
        '
        'lima
        '
        Me.lima.Location = New System.Drawing.Point(121, 170)
        Me.lima.Name = "lima"
        Me.lima.Size = New System.Drawing.Size(66, 57)
        Me.lima.TabIndex = 5
        Me.lima.Text = "5"
        Me.lima.UseVisualStyleBackColor = True
        '
        'empat
        '
        Me.empat.Location = New System.Drawing.Point(49, 170)
        Me.empat.Name = "empat"
        Me.empat.Size = New System.Drawing.Size(66, 57)
        Me.empat.TabIndex = 4
        Me.empat.Text = "4"
        Me.empat.UseVisualStyleBackColor = True
        '
        'tiga
        '
        Me.tiga.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tiga.Location = New System.Drawing.Point(193, 107)
        Me.tiga.Name = "tiga"
        Me.tiga.Size = New System.Drawing.Size(66, 57)
        Me.tiga.TabIndex = 3
        Me.tiga.Text = "3"
        Me.tiga.UseVisualStyleBackColor = False
        '
        'dua
        '
        Me.dua.BackColor = System.Drawing.SystemColors.ControlLight
        Me.dua.Location = New System.Drawing.Point(121, 107)
        Me.dua.Name = "dua"
        Me.dua.Size = New System.Drawing.Size(66, 57)
        Me.dua.TabIndex = 2
        Me.dua.Text = "2"
        Me.dua.UseVisualStyleBackColor = False
        '
        'satu
        '
        Me.satu.BackColor = System.Drawing.SystemColors.ControlLight
        Me.satu.Location = New System.Drawing.Point(49, 107)
        Me.satu.Name = "satu"
        Me.satu.Size = New System.Drawing.Size(66, 57)
        Me.satu.TabIndex = 1
        Me.satu.Text = "1"
        Me.satu.UseVisualStyleBackColor = False
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(49, 15)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(376, 69)
        Me.txtInput.TabIndex = 0
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(558, 589)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.title)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents author As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents kurang As System.Windows.Forms.Button
    Friend WithEvents tambah As System.Windows.Forms.Button
    Friend WithEvents bagi As System.Windows.Forms.Button
    Friend WithEvents kali As System.Windows.Forms.Button
    Friend WithEvents titik As System.Windows.Forms.Button
    Friend WithEvents nolNol As System.Windows.Forms.Button
    Friend WithEvents nol As System.Windows.Forms.Button
    Friend WithEvents sembilan As System.Windows.Forms.Button
    Friend WithEvents delapan As System.Windows.Forms.Button
    Friend WithEvents tujuh As System.Windows.Forms.Button
    Friend WithEvents enam As System.Windows.Forms.Button
    Friend WithEvents lima As System.Windows.Forms.Button
    Friend WithEvents empat As System.Windows.Forms.Button
    Friend WithEvents tiga As System.Windows.Forms.Button
    Friend WithEvents dua As System.Windows.Forms.Button
    Friend WithEvents satu As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents samaDengan As System.Windows.Forms.Button

End Class
