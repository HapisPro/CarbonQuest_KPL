namespace CarbonQuest.GUI.Views;

partial class Login
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
        lblSubtitle = new Label();
        formUsername = new TextBox();
        label1 = new Label();
        label2 = new Label();
        formPassword = new TextBox();
        btnLogin = new Button();
        lblNavSingup = new Label();
        lblError = new Label();
        cbxShowPw = new CheckBox();
        SuspendLayout();
        // 
        // lblLogo
        // 
        lblLogo.AutoSize = true;
        lblLogo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblLogo.Location = new Point(282, 70);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(235, 47);
        lblLogo.TabIndex = 0;
        lblLogo.Text = "CarbonQuest";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 12F);
        lblSubtitle.Location = new Point(289, 117);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(220, 21);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Selamat datang! Silakan Login";
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // formUsername
        // 
        formUsername.Location = new Point(324, 203);
        formUsername.Name = "formUsername";
        formUsername.Size = new Size(226, 23);
        formUsername.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(244, 205);
        label1.Name = "label1";
        label1.Size = new Size(78, 20);
        label1.TabIndex = 3;
        label1.Text = "Username";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(244, 243);
        label2.Name = "label2";
        label2.Size = new Size(73, 20);
        label2.TabIndex = 5;
        label2.Text = "Password";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // formPassword
        // 
        formPassword.Location = new Point(324, 241);
        formPassword.Name = "formPassword";
        formPassword.Size = new Size(226, 23);
        formPassword.TabIndex = 4;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(0, 192, 0);
        btnLogin.Font = new Font("Segoe UI", 11F);
        btnLogin.ForeColor = SystemColors.ButtonHighlight;
        btnLogin.Location = new Point(244, 298);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(306, 31);
        btnLogin.TabIndex = 6;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // lblNavSingup
        // 
        lblNavSingup.AutoSize = true;
        lblNavSingup.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
        lblNavSingup.Location = new Point(335, 332);
        lblNavSingup.Name = "lblNavSingup";
        lblNavSingup.Size = new Size(119, 17);
        lblNavSingup.TabIndex = 7;
        lblNavSingup.Text = "Belum punya akun?";
        lblNavSingup.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblError
        // 
        lblError.AutoSize = true;
        lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblError.ForeColor = Color.Red;
        lblError.Location = new Point(244, 182);
        lblError.Name = "lblError";
        lblError.Size = new Size(157, 17);
        lblError.TabIndex = 8;
        lblError.Text = "error message goes here";
        lblError.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cbxShowPw
        // 
        cbxShowPw.AutoSize = true;
        cbxShowPw.Location = new Point(324, 269);
        cbxShowPw.Name = "cbxShowPw";
        cbxShowPw.Size = new Size(108, 19);
        cbxShowPw.TabIndex = 9;
        cbxShowPw.Text = "Show Password";
        cbxShowPw.UseVisualStyleBackColor = true;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(cbxShowPw);
        Controls.Add(lblError);
        Controls.Add(lblNavSingup);
        Controls.Add(btnLogin);
        Controls.Add(label2);
        Controls.Add(formPassword);
        Controls.Add(label1);
        Controls.Add(formUsername);
        Controls.Add(lblSubtitle);
        Controls.Add(lblLogo);
        Name = "Login";
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblLogo;
    private Label lblSubtitle;
    private TextBox formUsername;
    private Label label1;
    private Label label2;
    private TextBox formPassword;
    private Button btnLogin;
    private Label lblNavSingup;
    private Label lblError;
    private CheckBox cbxShowPw;
}