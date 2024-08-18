namespace Imagine;

partial class Form1
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
        pictureBox1 = new PictureBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        lblDPI = new Label();
        lblHeight = new Label();
        lblWidth = new Label();
        btnUpload = new Button();
        lblWidthMM = new Label();
        lblHeightMM = new Label();
        label6 = new Label();
        label7 = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(12, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(651, 810);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(669, 12);
        label1.Name = "label1";
        label1.Size = new Size(64, 15);
        label1.TabIndex = 1;
        label1.Text = "Image DPI:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(669, 48);
        label2.Name = "label2";
        label2.Size = new Size(104, 15);
        label2.TabIndex = 2;
        label2.Text = "Image height (px):";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(669, 75);
        label3.Name = "label3";
        label3.Size = new Size(100, 15);
        label3.TabIndex = 3;
        label3.Text = "Image width (px):";
        // 
        // lblDPI
        // 
        lblDPI.AutoSize = true;
        lblDPI.Location = new Point(779, 12);
        lblDPI.Name = "lblDPI";
        lblDPI.Size = new Size(13, 15);
        lblDPI.TabIndex = 4;
        lblDPI.Text = "0";
        // 
        // lblHeight
        // 
        lblHeight.AutoSize = true;
        lblHeight.Location = new Point(779, 48);
        lblHeight.Name = "lblHeight";
        lblHeight.Size = new Size(13, 15);
        lblHeight.TabIndex = 5;
        lblHeight.Text = "0";
        // 
        // lblWidth
        // 
        lblWidth.AutoSize = true;
        lblWidth.Location = new Point(779, 75);
        lblWidth.Name = "lblWidth";
        lblWidth.Size = new Size(13, 15);
        lblWidth.TabIndex = 6;
        lblWidth.Text = "0";
        // 
        // btnUpload
        // 
        btnUpload.Location = new Point(669, 177);
        btnUpload.Name = "btnUpload";
        btnUpload.Size = new Size(139, 23);
        btnUpload.TabIndex = 7;
        btnUpload.Text = "Upload Image";
        btnUpload.UseVisualStyleBackColor = true;
        btnUpload.Click += btnUpload_Click;
        // 
        // lblWidthMM
        // 
        lblWidthMM.AutoSize = true;
        lblWidthMM.Location = new Point(779, 141);
        lblWidthMM.Name = "lblWidthMM";
        lblWidthMM.Size = new Size(13, 15);
        lblWidthMM.TabIndex = 11;
        lblWidthMM.Text = "0";
        // 
        // lblHeightMM
        // 
        lblHeightMM.AutoSize = true;
        lblHeightMM.Location = new Point(779, 114);
        lblHeightMM.Name = "lblHeightMM";
        lblHeightMM.Size = new Size(13, 15);
        lblHeightMM.TabIndex = 10;
        lblHeightMM.Text = "0";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(669, 141);
        label6.Name = "label6";
        label6.Size = new Size(109, 15);
        label6.TabIndex = 9;
        label6.Text = "Image width (mm):";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(669, 114);
        label7.Name = "label7";
        label7.Size = new Size(113, 15);
        label7.TabIndex = 8;
        label7.Text = "Image height (mm):";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(877, 837);
        Controls.Add(lblWidthMM);
        Controls.Add(lblHeightMM);
        Controls.Add(label6);
        Controls.Add(label7);
        Controls.Add(btnUpload);
        Controls.Add(lblWidth);
        Controls.Add(lblHeight);
        Controls.Add(lblDPI);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label lblDPI;
    private Label lblHeight;
    private Label lblWidth;
    private Button btnUpload;
    private Label lblWidthMM;
    private Label lblHeightMM;
    private Label label6;
    private Label label7;
}
