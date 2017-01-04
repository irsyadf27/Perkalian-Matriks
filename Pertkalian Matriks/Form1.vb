Public Class Form1
    Dim matriks_a_baris As Integer = 0
    Dim matriks_a_kolom As Integer = 0
    Dim matriks_b_baris As Integer = 0
    Dim matriks_b_kolom As Integer = 0
    Dim matriks_c_baris As Integer = 0
    Dim matriks_c_kolom As Integer = 0

    ' Matriks A
    Sub hapus_matriks_a(baris As Integer, kolom As Integer)
        If (baris <> 0) And (kolom <> 0) Then
            For brs As Integer = 1 To baris
                For klm As Integer = 1 To kolom
                    Dim text1 As TextBox = CType(Me.panel_matriks_a.Controls("matriks_a_" & brs.ToString & "_" & klm.ToString), TextBox)
                    text1.Dispose()
                Next
            Next
        End If
    End Sub

    Public Function matriks_a(baris As Integer, kolom As Integer) As System.Windows.Forms.TextBox
        Dim txt As New System.Windows.Forms.TextBox()
        Me.panel_matriks_a.Controls.Add(txt)
        txt.Name = "matriks_a_" & baris.ToString & "_" & kolom.ToString
        txt.Top = ((baris - 1) * 23) + 3
        txt.Left = ((kolom - 1) * 52) + 6
        txt.Width = 46
        txt.Height = 20
        Return txt
    End Function

    ' Matriks B
    Sub hapus_matriks_b(baris As Integer, kolom As Integer)
        If (baris <> 0) And (kolom <> 0) Then
            For brs As Integer = 1 To baris
                For klm As Integer = 1 To kolom
                    Dim text1 As TextBox = CType(Me.panel_matriks_b.Controls("matriks_b_" & brs.ToString & "_" & klm.ToString), TextBox)
                    text1.Dispose()
                Next
            Next
        End If
    End Sub

    Public Function matriks_b(baris As Integer, kolom As Integer) As System.Windows.Forms.TextBox
        Dim txt As New System.Windows.Forms.TextBox()
        Me.panel_matriks_b.Controls.Add(txt)
        txt.Name = "matriks_b_" & baris.ToString & "_" & kolom.ToString
        txt.Top = ((baris - 1) * 23) + 3
        txt.Left = ((kolom - 1) * 52) + 6
        txt.Width = 46
        txt.Height = 20
        Return txt
    End Function

    ' Matriks Hasil
    Sub hapus_matriks_hasil(baris As Integer, kolom As Integer)
        If (baris <> 0) And (kolom <> 0) Then
            For brs As Integer = 1 To baris
                For klm As Integer = 1 To kolom
                    Dim text1 As TextBox = CType(Me.panel_hasil.Controls("matriks_hasil_" & brs.ToString & "_" & klm.ToString), TextBox)
                    text1.Dispose()
                Next
            Next
        End If
    End Sub

    Public Function matriks_hasil(baris As Integer, kolom As Integer, text As String) As System.Windows.Forms.TextBox
        Dim txt As New System.Windows.Forms.TextBox()
        Me.panel_hasil.Controls.Add(txt)
        txt.Name = "matriks_hasil_" & baris.ToString & "_" & kolom.ToString
        txt.Top = ((baris - 1) * 23) + 3
        txt.Left = ((kolom - 1) * 52) + 6
        txt.Text = text
        txt.Width = 46
        txt.Height = 20
        Return txt
    End Function

    Private Sub BuatMatriks_Click(sender As Object, e As EventArgs) Handles BuatMatriks.Click
        If (Not Integer.TryParse(txt_matriks_a_baris.Text, 0)) Then
            MessageBox.Show("Baris Matriks A Tidak Valid", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (Not Integer.TryParse(txt_matriks_a_kolom.Text, 0)) Then
            MessageBox.Show("Kolom Matriks A Tidak Valid", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (Not Integer.TryParse(txt_matriks_b_baris.Text, 0)) Then
            MessageBox.Show("Baris Matriks B Tidak Valid", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (Not Integer.TryParse(txt_matriks_b_kolom.Text, 0)) Then
            MessageBox.Show("Kolom Matriks B Tidak Valid", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (txt_matriks_a_kolom.Text <> txt_matriks_b_baris.Text) Then
            MessageBox.Show("Jumlah Kolom Matriks A Tidak Sama dengan Jumlah Baris Matriks B", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Hapus Matriks Hasil
            hapus_matriks_hasil(matriks_c_baris, matriks_c_kolom)
            matriks_c_baris = 0
            matriks_c_kolom = 0

            ' Hapus Matriks A
            hapus_matriks_a(matriks_a_baris, matriks_a_kolom)
            matriks_a_baris = txt_matriks_a_baris.Text
            matriks_a_kolom = txt_matriks_a_kolom.Text

            ' Hapus Matriks B
            hapus_matriks_b(matriks_b_baris, matriks_b_kolom)
            matriks_b_baris = txt_matriks_b_baris.Text
            matriks_b_kolom = txt_matriks_b_kolom.Text

            ' Buat Matriks A
            For baris As Integer = 1 To txt_matriks_a_baris.Text
                For kolom As Integer = 1 To txt_matriks_a_kolom.Text
                    matriks_a(baris, kolom)
                Next
            Next

            ' Buat Matriks B
            For baris As Integer = 1 To txt_matriks_b_baris.Text
                For kolom As Integer = 1 To txt_matriks_b_kolom.Text
                    matriks_b(baris, kolom)
                Next
            Next
        End If
    End Sub

    Private Sub Hitung_Click(sender As Object, e As EventArgs) Handles Hitung.Click
        Dim hasil As Integer
        hapus_matriks_hasil(matriks_c_baris, matriks_c_kolom)
        matriks_c_baris = matriks_a_baris
        matriks_c_kolom = matriks_b_kolom
        For i As Integer = 1 To matriks_a_baris
            For j As Integer = 1 To matriks_b_kolom
                hasil = 0
                For k As Integer = 1 To matriks_a_kolom
                    Dim text1 As TextBox = CType(Me.panel_matriks_a.Controls("matriks_a_" & i.ToString & "_" & k.ToString), TextBox)
                    Dim text2 As TextBox = CType(Me.panel_matriks_b.Controls("matriks_b_" & k.ToString & "_" & j.ToString), TextBox)
                    If (Not Integer.TryParse(text1.Text, 0)) Then
                        MessageBox.Show("Matriks A Baris " & i.ToString & " Kolom " & k.ToString & " Bukan Angka!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        matriks_c_baris = 0
                        matriks_c_kolom = 0
                        GoTo end_of_for
                    ElseIf (Not Integer.TryParse(text2.Text, 0)) Then
                        MessageBox.Show("Matriks B Baris " & k.ToString & " Kolom " & j.ToString & " Bukan Angka!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        matriks_c_baris = 0
                        matriks_c_kolom = 0
                        GoTo end_of_for
                    Else
                        hasil = hasil + (Integer.Parse(text1.Text) * Integer.Parse(text2.Text))
                    End If

                Next
                matriks_hasil(i, j, hasil.ToString)
            Next
        Next
end_of_for:
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    End Sub
End Class