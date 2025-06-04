namespace CarbonQuest.GUI;

partial class Home
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblSubtitle = new Label();
        lblLogo = new Label();
        btnCalculator = new Button();
        btnArtikel = new Button();
        btnLogout = new Button();
        listViewLeaderboard = new ListView();
        label1 = new Label();
        SuspendLayout();
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 12F);
        lblSubtitle.Location = new Point(21, 60);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(125, 21);
        lblSubtitle.TabIndex = 3;
        lblSubtitle.Text = "Halo, Username!";
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblLogo
        // 
        lblLogo.AutoSize = true;
        lblLogo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblLogo.Location = new Point(12, 13);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(235, 47);
        lblLogo.TabIndex = 2;
        lblLogo.Text = "CarbonQuest";
        // 
        // btnCalculator
        // 
        btnCalculator.BackColor = Color.FromArgb(0, 192, 0);
        btnCalculator.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
        btnCalculator.ForeColor = SystemColors.ButtonHighlight;
        btnCalculator.Location = new Point(21, 115);
        btnCalculator.Name = "btnCalculator";
        btnCalculator.Size = new Size(177, 305);
        btnCalculator.TabIndex = 4;
        btnCalculator.Text = "Hitung Jejak Karbon";
        btnCalculator.UseVisualStyleBackColor = false;
        btnCalculator.Click += btnCalculator_Click;
        // 
        // btnArtikel
        // 
        btnArtikel.BackColor = Color.FromArgb(0, 192, 0);
        btnArtikel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnArtikel.ForeColor = SystemColors.ButtonHighlight;
        btnArtikel.Location = new Point(206, 115);
        btnArtikel.Name = "btnArtikel";
        btnArtikel.Size = new Size(212, 241);
        btnArtikel.TabIndex = 5;
        btnArtikel.Text = "Artikel";
        btnArtikel.UseVisualStyleBackColor = false;
        btnArtikel.Click += btnArtikel_Click;
        // 
        // btnLogout
        // 
        btnLogout.BackColor = Color.Red;
        btnLogout.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogout.ForeColor = SystemColors.ButtonHighlight;
        btnLogout.Location = new Point(206, 362);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(212, 58);
        btnLogout.TabIndex = 8;
        btnLogout.Text = "Logout";
        btnLogout.UseVisualStyleBackColor = false;
        btnLogout.Click += btnLogout_Click;
        // 
        // listViewLeaderboard
        // 
        listViewLeaderboard.Location = new Point(465, 60);
        listViewLeaderboard.Name = "listViewLeaderboard";
        listViewLeaderboard.Size = new Size(316, 369);
        listViewLeaderboard.TabIndex = 9;
        listViewLeaderboard.UseCompatibleStateImageBehavior = false;
        listViewLeaderboard.View = View.Details;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ImageAlign = ContentAlignment.TopRight;
        label1.Location = new Point(465, 31);
        label1.Name = "label1";
        label1.Size = new Size(147, 25);
        label1.TabIndex = 10;
        label1.Text = "Top Contributor";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Home
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label1);
        Controls.Add(listViewLeaderboard);
        Controls.Add(btnLogout);
        Controls.Add(btnArtikel);
        Controls.Add(btnCalculator);
        Controls.Add(lblSubtitle);
        Controls.Add(lblLogo);
        Name = "Home";
        Text = "CarbonQuest";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblSubtitle;
    private Label lblLogo;
    private Button btnCalculator;
    private Button btnArtikel;
    private Button btnLogout;
    private ListView listViewLeaderboard;
    private Label label1;
}
