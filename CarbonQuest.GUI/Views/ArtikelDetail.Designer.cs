namespace CarbonQuest.GUI.Views;

partial class ArtikelDetail
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnKembali = new Button();
        btnEdit = new Button();
        btnHapus = new Button();
        tbxArtikel = new RichTextBox();
        tbxJudul = new TextBox();
        SuspendLayout();
        // 
        // btnKembali
        // 
        btnKembali.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
        btnKembali.Location = new Point(12, 12);
        btnKembali.Name = "btnKembali";
        btnKembali.Size = new Size(91, 38);
        btnKembali.TabIndex = 10;
        btnKembali.Text = "Kembali";
        btnKembali.UseVisualStyleBackColor = true;
        btnKembali.Click += btnKembali_Click;
        // 
        // btnEdit
        // 
        btnEdit.BackColor = SystemColors.Highlight;
        btnEdit.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
        btnEdit.ForeColor = SystemColors.ButtonHighlight;
        btnEdit.Location = new Point(697, 12);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(91, 38);
        btnEdit.TabIndex = 13;
        btnEdit.Text = "Edit";
        btnEdit.UseVisualStyleBackColor = false;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnHapus
        // 
        btnHapus.BackColor = Color.Red;
        btnHapus.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
        btnHapus.ForeColor = SystemColors.ButtonHighlight;
        btnHapus.Location = new Point(600, 12);
        btnHapus.Name = "btnHapus";
        btnHapus.Size = new Size(91, 38);
        btnHapus.TabIndex = 14;
        btnHapus.Text = "Hapus";
        btnHapus.UseVisualStyleBackColor = false;
        btnHapus.Click += btnHapus_Click;
        // 
        // tbxArtikel
        // 
        tbxArtikel.Location = new Point(12, 130);
        tbxArtikel.Name = "tbxArtikel";
        tbxArtikel.ScrollBars = RichTextBoxScrollBars.None;
        tbxArtikel.Size = new Size(776, 308);
        tbxArtikel.TabIndex = 15;
        tbxArtikel.Text = "Isi artikel";
        // 
        // tbxJudul
        // 
        tbxJudul.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
        tbxJudul.Location = new Point(12, 87);
        tbxJudul.Name = "tbxJudul";
        tbxJudul.Size = new Size(776, 34);
        tbxJudul.TabIndex = 16;
        tbxJudul.Text = "Judul Artikel";
        // 
        // ArtikelDetail
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tbxJudul);
        Controls.Add(tbxArtikel);
        Controls.Add(btnHapus);
        Controls.Add(btnEdit);
        Controls.Add(btnKembali);
        Name = "ArtikelDetail";
        Text = "ArtikelDetail";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnKembali;
    private Button btnEdit;
    private Button btnHapus;
    private RichTextBox tbxArtikel;
    private TextBox tbxJudul;
}