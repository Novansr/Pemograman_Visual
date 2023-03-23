<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbWanita = New System.Windows.Forms.RadioButton()
        Me.rbPria = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbJomblo = New System.Windows.Forms.RadioButton()
        Me.rbMenikah = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtGajiPokok = New System.Windows.Forms.TextBox()
        Me.txtTunjangan = New System.Windows.Forms.TextBox()
        Me.txtIzin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTanpa = New System.Windows.Forms.TextBox()
        Me.btHitung = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtPengurangan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gaji Pokok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tunjangan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbWanita)
        Me.GroupBox1.Controls.Add(Me.rbPria)
        Me.GroupBox1.Location = New System.Drawing.Point(264, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 44)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'rbWanita
        '
        Me.rbWanita.AutoSize = True
        Me.rbWanita.Location = New System.Drawing.Point(131, 13)
        Me.rbWanita.Name = "rbWanita"
        Me.rbWanita.Size = New System.Drawing.Size(70, 20)
        Me.rbWanita.TabIndex = 1
        Me.rbWanita.TabStop = True
        Me.rbWanita.Text = "Wanita"
        Me.rbWanita.UseVisualStyleBackColor = True
        '
        'rbPria
        '
        Me.rbPria.AutoSize = True
        Me.rbPria.Location = New System.Drawing.Point(6, 13)
        Me.rbPria.Name = "rbPria"
        Me.rbPria.Size = New System.Drawing.Size(52, 20)
        Me.rbPria.TabIndex = 0
        Me.rbPria.TabStop = True
        Me.rbPria.Text = "Pria"
        Me.rbPria.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbJomblo)
        Me.GroupBox2.Controls.Add(Me.rbMenikah)
        Me.GroupBox2.Location = New System.Drawing.Point(264, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 53)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'rbJomblo
        '
        Me.rbJomblo.AutoSize = True
        Me.rbJomblo.Location = New System.Drawing.Point(131, 21)
        Me.rbJomblo.Name = "rbJomblo"
        Me.rbJomblo.Size = New System.Drawing.Size(73, 20)
        Me.rbJomblo.TabIndex = 1
        Me.rbJomblo.TabStop = True
        Me.rbJomblo.Text = "Jomblo"
        Me.rbJomblo.UseVisualStyleBackColor = True
        '
        'rbMenikah
        '
        Me.rbMenikah.AutoSize = True
        Me.rbMenikah.Location = New System.Drawing.Point(6, 21)
        Me.rbMenikah.Name = "rbMenikah"
        Me.rbMenikah.Size = New System.Drawing.Size(79, 20)
        Me.rbMenikah.TabIndex = 0
        Me.rbMenikah.TabStop = True
        Me.rbMenikah.Text = "Menikah"
        Me.rbMenikah.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(188, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(414, 38)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Perhitungan Gaji Karyawan"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(270, 71)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(350, 22)
        Me.txtNama.TabIndex = 8
        '
        'txtGajiPokok
        '
        Me.txtGajiPokok.Location = New System.Drawing.Point(270, 259)
        Me.txtGajiPokok.Name = "txtGajiPokok"
        Me.txtGajiPokok.Size = New System.Drawing.Size(350, 22)
        Me.txtGajiPokok.TabIndex = 9
        '
        'txtTunjangan
        '
        Me.txtTunjangan.Location = New System.Drawing.Point(270, 310)
        Me.txtTunjangan.Name = "txtTunjangan"
        Me.txtTunjangan.Size = New System.Drawing.Size(350, 22)
        Me.txtTunjangan.TabIndex = 10
        '
        'txtIzin
        '
        Me.txtIzin.Location = New System.Drawing.Point(270, 366)
        Me.txtIzin.Name = "txtIzin"
        Me.txtIzin.Size = New System.Drawing.Size(350, 22)
        Me.txtIzin.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(140, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Izin / Sakit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(143, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tanpa Ket"
        '
        'txtTanpa
        '
        Me.txtTanpa.Location = New System.Drawing.Point(270, 419)
        Me.txtTanpa.Name = "txtTanpa"
        Me.txtTanpa.Size = New System.Drawing.Size(350, 22)
        Me.txtTanpa.TabIndex = 14
        '
        'btHitung
        '
        Me.btHitung.Location = New System.Drawing.Point(701, 205)
        Me.btHitung.Name = "btHitung"
        Me.btHitung.Size = New System.Drawing.Size(118, 58)
        Me.btHitung.TabIndex = 15
        Me.btHitung.Text = "Hitung"
        Me.btHitung.UseVisualStyleBackColor = True
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(701, 283)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(118, 49)
        Me.btClear.TabIndex = 16
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(143, 464)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Gaji Bersih"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(270, 464)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 22)
        Me.TextBox1.TabIndex = 18
        '
        'txtPengurangan
        '
        Me.txtPengurangan.Location = New System.Drawing.Point(667, 416)
        Me.txtPengurangan.Name = "txtPengurangan"
        Me.txtPengurangan.Size = New System.Drawing.Size(152, 22)
        Me.txtPengurangan.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(141, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Bulan"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.ComboBox1.Location = New System.Drawing.Point(270, 223)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(350, 24)
        Me.ComboBox1.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(683, 397)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Pengurangan Gaji"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(978, 556)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPengurangan)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btHitung)
        Me.Controls.Add(Me.txtTanpa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIzin)
        Me.Controls.Add(Me.txtTunjangan)
        Me.Controls.Add(Me.txtGajiPokok)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbWanita As RadioButton
    Friend WithEvents rbPria As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbJomblo As RadioButton
    Friend WithEvents rbMenikah As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtGajiPokok As TextBox
    Friend WithEvents txtTunjangan As TextBox
    Friend WithEvents txtIzin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTanpa As TextBox
    Friend WithEvents btHitung As Button
    Friend WithEvents btClear As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtPengurangan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label11 As Label
End Class
