namespace CarbonQuest.GUI.Views;

partial class DaftarArtikel
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
        lblLogo = new Label();
        btnHome = new Button();
        flowLayoutPanelArticle = new FlowLayoutPanel();
        btnTambah = new Button();
        SuspendLayout();
        // 
        // lblLogo
        // 
        lblLogo.AutoSize = true;
        lblLogo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblLogo.ImageAlign = ContentAlignment.MiddleLeft;
        lblLogo.Location = new Point(12, 26);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(235, 47);
        lblLogo.TabIndex = 5;
        lblLogo.Text = "CarbonQuest";
        // 
        // btnHome
        // 
        btnHome.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
        btnHome.Location = new Point(697, 42);
        btnHome.Name = "btnHome";
        btnHome.Size = new Size(91, 38);
        btnHome.TabIndex = 9;
        btnHome.Text = "Home";
        btnHome.UseVisualStyleBackColor = true;
        btnHome.Click += btnHome_Click;
        // 
        // flowLayoutPanelArticle
        // 
        flowLayoutPanelArticle.AutoScroll = true;
        flowLayoutPanelArticle.Location = new Point(12, 89);
        flowLayoutPanelArticle.Name = "flowLayoutPanelArticle";
        flowLayoutPanelArticle.Size = new Size(776, 400);
        flowLayoutPanelArticle.TabIndex = 10;
        // 
        // btnTambah
        // 
        btnTambah.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
        btnTambah.Location = new Point(592, 42);
        btnTambah.Name = "btnTambah";
        btnTambah.Size = new Size(99, 38);
        btnTambah.TabIndex = 11;
        btnTambah.Text = "Tambah";
        btnTambah.UseVisualStyleBackColor = true;
        btnTambah.Click += btnTambah_Click;
        // 
        // DaftarArtikel
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 501);
        Controls.Add(btnTambah);
        Controls.Add(flowLayoutPanelArticle);
        Controls.Add(btnHome);
        Controls.Add(lblLogo);
        Name = "DaftarArtikel";
        Text = "DaftarArtikel";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblLogo;
    private Button btnHome;
    private FlowLayoutPanel flowLayoutPanelArticle;
    private Button btnTambah;
}