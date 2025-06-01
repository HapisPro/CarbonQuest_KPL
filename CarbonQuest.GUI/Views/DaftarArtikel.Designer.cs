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
        btnLeaderboard = new Button();
        button1 = new Button();
        button2 = new Button();
        btnHome = new Button();
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
        // btnLeaderboard
        // 
        btnLeaderboard.BackColor = Color.FromArgb(0, 192, 0);
        btnLeaderboard.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLeaderboard.ForeColor = SystemColors.ButtonHighlight;
        btnLeaderboard.Location = new Point(12, 86);
        btnLeaderboard.Name = "btnLeaderboard";
        btnLeaderboard.Size = new Size(776, 112);
        btnLeaderboard.TabIndex = 6;
        btnLeaderboard.Text = "Judul Artikel 1";
        btnLeaderboard.TextAlign = ContentAlignment.MiddleLeft;
        btnLeaderboard.UseVisualStyleBackColor = false;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(0, 192, 0);
        button1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.ForeColor = SystemColors.ButtonHighlight;
        button1.Location = new Point(12, 213);
        button1.Name = "button1";
        button1.Size = new Size(776, 112);
        button1.TabIndex = 7;
        button1.Text = "Judul Artikel 2";
        button1.TextAlign = ContentAlignment.MiddleLeft;
        button1.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(0, 192, 0);
        button2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button2.ForeColor = SystemColors.ButtonHighlight;
        button2.Location = new Point(12, 342);
        button2.Name = "button2";
        button2.Size = new Size(776, 112);
        button2.TabIndex = 8;
        button2.Text = "Judul Artikel 3";
        button2.TextAlign = ContentAlignment.MiddleLeft;
        button2.UseVisualStyleBackColor = false;
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
        // 
        // DaftarArtikel
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 501);
        Controls.Add(btnHome);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(btnLeaderboard);
        Controls.Add(lblLogo);
        Name = "DaftarArtikel";
        Text = "DaftarArtikel";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblLogo;
    private Button btnLeaderboard;
    private Button button1;
    private Button button2;
    private Button btnHome;
}