namespace CarbonQuest.GUI.Views;

partial class Signup
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
        lblError = new Label();
        lblNavSingup = new Label();
        btnSignup = new Button();
        label2 = new Label();
        formPassword = new TextBox();
        label1 = new Label();
        formUsername = new TextBox();
        lblSubtitle = new Label();
        lblLogo = new Label();
        SuspendLayout();
        // 
        // lblError
        // 
        lblError.AutoSize = true;
        lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblError.Location = new Point(236, 196);
        lblError.Name = "lblError";
        lblError.Size = new Size(157, 17);
        lblError.TabIndex = 17;
        lblError.Text = "error message goes here";
        lblError.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblNavSingup
        // 
        lblNavSingup.AutoSize = true;
        lblNavSingup.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
        lblNavSingup.Location = new Point(327, 333);
        lblNavSingup.Name = "lblNavSingup";
        lblNavSingup.Size = new Size(120, 17);
        lblNavSingup.TabIndex = 16;
        lblNavSingup.Text = "Sudah punya akun?";
        lblNavSingup.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnSignup
        // 
        btnSignup.BackColor = Color.FromArgb(0, 192, 0);
        btnSignup.Font = new Font("Segoe UI", 11F);
        btnSignup.ForeColor = SystemColors.ButtonHighlight;
        btnSignup.Location = new Point(236, 299);
        btnSignup.Name = "btnSignup";
        btnSignup.Size = new Size(306, 31);
        btnSignup.TabIndex = 15;
        btnSignup.Text = "Signup";
        btnSignup.UseVisualStyleBackColor = false;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(236, 257);
        label2.Name = "label2";
        label2.Size = new Size(73, 20);
        label2.TabIndex = 14;
        label2.Text = "Password";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // formPassword
        // 
        formPassword.Location = new Point(316, 255);
        formPassword.Name = "formPassword";
        formPassword.Size = new Size(226, 23);
        formPassword.TabIndex = 13;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(236, 219);
        label1.Name = "label1";
        label1.Size = new Size(78, 20);
        label1.TabIndex = 12;
        label1.Text = "Username";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // formUsername
        // 
        formUsername.Location = new Point(316, 217);
        formUsername.Name = "formUsername";
        formUsername.Size = new Size(226, 23);
        formUsername.TabIndex = 11;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 12F);
        lblSubtitle.Location = new Point(281, 131);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(230, 21);
        lblSubtitle.TabIndex = 10;
        lblSubtitle.Text = "Selamat datang! Silakan Signup";
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblLogo
        // 
        lblLogo.AutoSize = true;
        lblLogo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblLogo.Location = new Point(274, 84);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(235, 47);
        lblLogo.TabIndex = 9;
        lblLogo.Text = "CarbonQuest";
        // 
        // Signup
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblError);
        Controls.Add(lblNavSingup);
        Controls.Add(btnSignup);
        Controls.Add(label2);
        Controls.Add(formPassword);
        Controls.Add(label1);
        Controls.Add(formUsername);
        Controls.Add(lblSubtitle);
        Controls.Add(lblLogo);
        Name = "Signup";
        Text = "Signup";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblError;
    private Label lblNavSingup;
    private Button btnSignup;
    private Label label2;
    private TextBox formPassword;
    private Label label1;
    private TextBox formUsername;
    private Label lblSubtitle;
    private Label lblLogo;
}