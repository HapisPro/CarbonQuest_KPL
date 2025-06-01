namespace CarbonQuest.GUI.Views;

partial class Kalkulator
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
        lblPertanyaan1 = new Label();
        rdoJawabanA = new RadioButton();
        rdoJawabanB = new RadioButton();
        rdoJawabanC = new RadioButton();
        label1 = new Label();
        radioButton3 = new RadioButton();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        btnSimpan = new Button();
        SuspendLayout();
        // 
        // lblLogo
        // 
        lblLogo.AutoSize = true;
        lblLogo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblLogo.ImageAlign = ContentAlignment.MiddleLeft;
        lblLogo.Location = new Point(9, 9);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(235, 47);
        lblLogo.TabIndex = 3;
        lblLogo.Text = "CarbonQuest";
        // 
        // lblPertanyaan1
        // 
        lblPertanyaan1.AutoSize = true;
        lblPertanyaan1.Font = new Font("Segoe UI", 11F);
        lblPertanyaan1.Location = new Point(12, 103);
        lblPertanyaan1.Name = "lblPertanyaan1";
        lblPertanyaan1.Size = new Size(187, 20);
        lblPertanyaan1.TabIndex = 4;
        lblPertanyaan1.Text = "1. Pertanyaan Nomor Satu?";
        // 
        // rdoJawabanA
        // 
        rdoJawabanA.AutoSize = true;
        rdoJawabanA.Font = new Font("Segoe UI", 10F);
        rdoJawabanA.Location = new Point(36, 135);
        rdoJawabanA.Name = "rdoJawabanA";
        rdoJawabanA.Size = new Size(95, 23);
        rdoJawabanA.TabIndex = 5;
        rdoJawabanA.TabStop = true;
        rdoJawabanA.Text = "A. Jawaban";
        rdoJawabanA.UseVisualStyleBackColor = true;
        // 
        // rdoJawabanB
        // 
        rdoJawabanB.AutoSize = true;
        rdoJawabanB.Font = new Font("Segoe UI", 10F);
        rdoJawabanB.Location = new Point(36, 164);
        rdoJawabanB.Name = "rdoJawabanB";
        rdoJawabanB.Size = new Size(94, 23);
        rdoJawabanB.TabIndex = 6;
        rdoJawabanB.TabStop = true;
        rdoJawabanB.Text = "B. Jawaban";
        rdoJawabanB.UseVisualStyleBackColor = true;
        // 
        // rdoJawabanC
        // 
        rdoJawabanC.AutoSize = true;
        rdoJawabanC.Font = new Font("Segoe UI", 10F);
        rdoJawabanC.Location = new Point(36, 193);
        rdoJawabanC.Name = "rdoJawabanC";
        rdoJawabanC.Size = new Size(95, 23);
        rdoJawabanC.TabIndex = 7;
        rdoJawabanC.TabStop = true;
        rdoJawabanC.Text = "C. Jawaban";
        rdoJawabanC.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11F);
        label1.Location = new Point(13, 249);
        label1.Name = "label1";
        label1.Size = new Size(185, 20);
        label1.TabIndex = 8;
        label1.Text = "2. Pertanyaan Nomor Dua?";
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Font = new Font("Segoe UI", 10F);
        radioButton3.Location = new Point(37, 281);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(95, 23);
        radioButton3.TabIndex = 9;
        radioButton3.TabStop = true;
        radioButton3.Text = "A. Jawaban";
        radioButton3.UseVisualStyleBackColor = true;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Font = new Font("Segoe UI", 10F);
        radioButton1.Location = new Point(37, 339);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(95, 23);
        radioButton1.TabIndex = 11;
        radioButton1.TabStop = true;
        radioButton1.Text = "C. Jawaban";
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Font = new Font("Segoe UI", 10F);
        radioButton2.Location = new Point(37, 310);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(94, 23);
        radioButton2.TabIndex = 10;
        radioButton2.TabStop = true;
        radioButton2.Text = "B. Jawaban";
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // btnSimpan
        // 
        btnSimpan.Font = new Font("Segoe UI", 10F);
        btnSimpan.Location = new Point(37, 399);
        btnSimpan.Name = "btnSimpan";
        btnSimpan.Size = new Size(112, 28);
        btnSimpan.TabIndex = 12;
        btnSimpan.Text = "Simpan";
        btnSimpan.UseVisualStyleBackColor = true;
        // 
        // Kalkulator
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnSimpan);
        Controls.Add(radioButton1);
        Controls.Add(radioButton2);
        Controls.Add(radioButton3);
        Controls.Add(label1);
        Controls.Add(rdoJawabanC);
        Controls.Add(rdoJawabanB);
        Controls.Add(rdoJawabanA);
        Controls.Add(lblPertanyaan1);
        Controls.Add(lblLogo);
        Name = "Kalkulator";
        Text = "Kalkulator";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblLogo;
    private Label lblPertanyaan1;
    private RadioButton rdoJawabanA;
    private RadioButton rdoJawabanB;
    private RadioButton rdoJawabanC;
    private Label label1;
    private RadioButton radioButton3;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private Button btnSimpan;
}