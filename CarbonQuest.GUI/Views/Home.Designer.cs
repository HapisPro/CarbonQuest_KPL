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
        pnlLeaderboard = new Panel();
        label9 = new Label();
        label8 = new Label();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        lblLeaderboard1 = new Label();
        label1 = new Label();
        pnlLeaderboard.SuspendLayout();
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
        // pnlLeaderboard
        // 
        pnlLeaderboard.Controls.Add(label9);
        pnlLeaderboard.Controls.Add(label8);
        pnlLeaderboard.Controls.Add(label7);
        pnlLeaderboard.Controls.Add(label6);
        pnlLeaderboard.Controls.Add(label5);
        pnlLeaderboard.Controls.Add(label4);
        pnlLeaderboard.Controls.Add(label3);
        pnlLeaderboard.Controls.Add(label2);
        pnlLeaderboard.Controls.Add(lblLeaderboard1);
        pnlLeaderboard.Controls.Add(label1);
        pnlLeaderboard.Location = new Point(447, 12);
        pnlLeaderboard.Name = "pnlLeaderboard";
        pnlLeaderboard.Size = new Size(341, 426);
        pnlLeaderboard.TabIndex = 9;
        pnlLeaderboard.Paint += pnlLeaderboard_Paint;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 12F);
        label9.Location = new Point(14, 387);
        label9.Name = "label9";
        label9.Size = new Size(143, 21);
        label9.TabIndex = 9;
        label9.Text = "9. Username - Skor";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 12F);
        label8.Location = new Point(14, 350);
        label8.Name = "label8";
        label8.Size = new Size(143, 21);
        label8.TabIndex = 8;
        label8.Text = "8. Username - Skor";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 12F);
        label7.Location = new Point(14, 311);
        label7.Name = "label7";
        label7.Size = new Size(143, 21);
        label7.TabIndex = 7;
        label7.Text = "7. Username - Skor";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F);
        label6.Location = new Point(14, 269);
        label6.Name = "label6";
        label6.Size = new Size(143, 21);
        label6.TabIndex = 6;
        label6.Text = "6. Username - Skor";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F);
        label5.Location = new Point(14, 229);
        label5.Name = "label5";
        label5.Size = new Size(143, 21);
        label5.TabIndex = 5;
        label5.Text = "5. Username - Skor";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F);
        label4.Location = new Point(14, 188);
        label4.Name = "label4";
        label4.Size = new Size(143, 21);
        label4.TabIndex = 4;
        label4.Text = "4. Username - Skor";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F);
        label3.Location = new Point(14, 145);
        label3.Name = "label3";
        label3.Size = new Size(143, 21);
        label3.TabIndex = 3;
        label3.Text = "3. Username - Skor";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(14, 103);
        label2.Name = "label2";
        label2.Size = new Size(143, 21);
        label2.TabIndex = 2;
        label2.Text = "2. Username - Skor";
        // 
        // lblLeaderboard1
        // 
        lblLeaderboard1.AutoSize = true;
        lblLeaderboard1.Font = new Font("Segoe UI", 12F);
        lblLeaderboard1.Location = new Point(14, 62);
        lblLeaderboard1.Name = "lblLeaderboard1";
        lblLeaderboard1.Size = new Size(143, 21);
        lblLeaderboard1.TabIndex = 1;
        lblLeaderboard1.Text = "1. Username - Skor";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
        label1.Location = new Point(14, 15);
        label1.Name = "label1";
        label1.Size = new Size(156, 28);
        label1.TabIndex = 0;
        label1.Text = "Top Kontributor";
        // 
        // Home
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(pnlLeaderboard);
        Controls.Add(btnLogout);
        Controls.Add(btnArtikel);
        Controls.Add(btnCalculator);
        Controls.Add(lblSubtitle);
        Controls.Add(lblLogo);
        Name = "Home";
        Text = "CarbonQuest";
        pnlLeaderboard.ResumeLayout(false);
        pnlLeaderboard.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblSubtitle;
    private Label lblLogo;
    private Button btnCalculator;
    private Button btnArtikel;
    private Button btnLogout;
    private Panel pnlLeaderboard;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label lblLeaderboard1;
    private Label label1;
    private Label label9;
    private Label label8;
}
