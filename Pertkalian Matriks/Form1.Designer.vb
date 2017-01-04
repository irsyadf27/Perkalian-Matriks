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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_matriks_a_kolom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_matriks_a_baris = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_matriks_b_kolom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txt_matriks_b_baris = New System.Windows.Forms.TextBox()
        Me.BuatMatriks = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.panel_matriks_b = New System.Windows.Forms.Panel()
        Me.panel_matriks_a = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.panel_hasil = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Hitung = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_matriks_a_kolom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_matriks_a_baris)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 72)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Matriks A"
        '
        'txt_matriks_a_kolom
        '
        Me.txt_matriks_a_kolom.Location = New System.Drawing.Point(114, 31)
        Me.txt_matriks_a_kolom.Name = "txt_matriks_a_kolom"
        Me.txt_matriks_a_kolom.Size = New System.Drawing.Size(36, 20)
        Me.txt_matriks_a_kolom.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "x"
        '
        'txt_matriks_a_baris
        '
        Me.txt_matriks_a_baris.Location = New System.Drawing.Point(54, 31)
        Me.txt_matriks_a_baris.Name = "txt_matriks_a_baris"
        Me.txt_matriks_a_baris.Size = New System.Drawing.Size(36, 20)
        Me.txt_matriks_a_baris.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_matriks_b_kolom)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.txt_matriks_b_baris)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(233, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 72)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Matriks B"
        '
        'txt_matriks_b_kolom
        '
        Me.txt_matriks_b_kolom.Location = New System.Drawing.Point(130, 31)
        Me.txt_matriks_b_kolom.Name = "txt_matriks_b_kolom"
        Me.txt_matriks_b_kolom.Size = New System.Drawing.Size(36, 20)
        Me.txt_matriks_b_kolom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "x"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(-59, 92)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(36, 20)
        Me.TextBox5.TabIndex = 1
        '
        'txt_matriks_b_baris
        '
        Me.txt_matriks_b_baris.Location = New System.Drawing.Point(70, 31)
        Me.txt_matriks_b_baris.Name = "txt_matriks_b_baris"
        Me.txt_matriks_b_baris.Size = New System.Drawing.Size(36, 20)
        Me.txt_matriks_b_baris.TabIndex = 0
        '
        'BuatMatriks
        '
        Me.BuatMatriks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuatMatriks.Location = New System.Drawing.Point(3, 3)
        Me.BuatMatriks.Name = "BuatMatriks"
        Me.BuatMatriks.Size = New System.Drawing.Size(106, 66)
        Me.BuatMatriks.TabIndex = 5
        Me.BuatMatriks.Text = "Buat Matriks"
        Me.BuatMatriks.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.panel_matriks_b)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(233, 81)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(224, 300)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Matriks B"
        '
        'panel_matriks_b
        '
        Me.panel_matriks_b.AutoScroll = True
        Me.panel_matriks_b.AutoScrollMinSize = New System.Drawing.Size(120, 0)
        Me.panel_matriks_b.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_matriks_b.Location = New System.Drawing.Point(3, 16)
        Me.panel_matriks_b.Name = "panel_matriks_b"
        Me.panel_matriks_b.Size = New System.Drawing.Size(218, 281)
        Me.panel_matriks_b.TabIndex = 0
        '
        'panel_matriks_a
        '
        Me.panel_matriks_a.AutoScroll = True
        Me.panel_matriks_a.AutoScrollMinSize = New System.Drawing.Size(120, 0)
        Me.panel_matriks_a.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_matriks_a.Location = New System.Drawing.Point(3, 16)
        Me.panel_matriks_a.Name = "panel_matriks_a"
        Me.panel_matriks_a.Size = New System.Drawing.Size(218, 281)
        Me.panel_matriks_a.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.panel_matriks_a)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 300)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Matriks A"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel1.Text = "Mohammad Irsyad Fauzan"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 389)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(693, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox5, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40816!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.59184!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(691, 384)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.panel_hasil)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(463, 81)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(225, 300)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Hasil"
        '
        'panel_hasil
        '
        Me.panel_hasil.AutoScroll = True
        Me.panel_hasil.AutoScrollMinSize = New System.Drawing.Size(120, 0)
        Me.panel_hasil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_hasil.Location = New System.Drawing.Point(3, 16)
        Me.panel_hasil.Name = "panel_hasil"
        Me.panel_hasil.Size = New System.Drawing.Size(219, 281)
        Me.panel_hasil.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Hitung, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BuatMatriks, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(463, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(225, 72)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'Hitung
        '
        Me.Hitung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hitung.Location = New System.Drawing.Point(115, 3)
        Me.Hitung.Name = "Hitung"
        Me.Hitung.Size = New System.Drawing.Size(107, 66)
        Me.Hitung.TabIndex = 10
        Me.Hitung.Text = "Hitung"
        Me.Hitung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 411)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.Text = "Perkalian Dua Buah Matriks"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_matriks_a_kolom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_matriks_a_baris As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_matriks_b_kolom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txt_matriks_b_baris As TextBox
    Friend WithEvents BuatMatriks As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents panel_matriks_b As Panel
    Friend WithEvents panel_matriks_a As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents panel_hasil As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Hitung As Button
End Class
