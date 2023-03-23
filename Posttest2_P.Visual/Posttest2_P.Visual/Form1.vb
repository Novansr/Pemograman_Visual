Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub btHitung_Click(sender As Object, e As EventArgs) Handles btHitung.Click
        Dim Keterangan As String

        If txtIzin.Text <> 0 Then
            Keterangan = "pengurangan"
        Else txtIzin.Text = 0
            Keterangan = "Bersih"
        End If
        txtPengurangan.Text = 200000 * (txtIzin.Text + +txtTanpa.Text)
        TextBox1.Text = txtGajiPokok.Text + +txtTunjangan.Text - txtPengurangan.Text
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        txtNama.Text = ""
        txtGajiPokok.Text = ""
        txtTunjangan.Text = ""
        txtIzin.Text = ""
        txtTanpa.Text = ""
        TextBox1.Text = ""
        txtPengurangan.Text = ""
        ComboBox1.SelectedIndex = -1
    End Sub
End Class
