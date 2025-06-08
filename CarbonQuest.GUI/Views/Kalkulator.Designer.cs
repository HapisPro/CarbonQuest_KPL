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
        btnSimpan = new Button();
        flowLayoutPanelQuestion = new FlowLayoutPanel();
        btnBatal = new Button();
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
        // btnSimpan
        // 
        btnSimpan.BackColor = SystemColors.ActiveCaption;
        btnSimpan.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSimpan.Location = new Point(36, 360);
        btnSimpan.Name = "btnSimpan";
        btnSimpan.Size = new Size(362, 39);
        btnSimpan.TabIndex = 12;
        btnSimpan.Text = "Simpan";
        btnSimpan.UseVisualStyleBackColor = false;
        btnSimpan.Click += btnSimpan_Click;
        // 
        // flowLayoutPanelQuestion
        // 
        flowLayoutPanelQuestion.AutoScroll = true;
        flowLayoutPanelQuestion.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanelQuestion.Location = new Point(12, 73);
        flowLayoutPanelQuestion.Name = "flowLayoutPanelQuestion";
        flowLayoutPanelQuestion.Size = new Size(776, 281);
        flowLayoutPanelQuestion.TabIndex = 13;
        flowLayoutPanelQuestion.WrapContents = false;
        // 
        // btnBatal
        // 
        btnBatal.BackColor = Color.IndianRed;
        btnBatal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBatal.ForeColor = SystemColors.ButtonHighlight;
        btnBatal.Location = new Point(404, 360);
        btnBatal.Name = "btnBatal";
        btnBatal.Size = new Size(362, 39);
        btnBatal.TabIndex = 14;
        btnBatal.Text = "Batal";
        btnBatal.UseVisualStyleBackColor = false;
        btnBatal.Click += btnBatal_Click;
        // 
        // Kalkulator
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 416);
        Controls.Add(btnBatal);
        Controls.Add(flowLayoutPanelQuestion);
        Controls.Add(btnSimpan);
        Controls.Add(lblLogo);
        Name = "Kalkulator";
        Text = "Kalkulator";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblLogo;
    private Button btnSimpan;
    private FlowLayoutPanel flowLayoutPanelQuestion;
    private Button btnBatal;
}