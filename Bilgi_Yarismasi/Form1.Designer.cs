namespace Bilgi_Yarismasi
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoruNo = new System.Windows.Forms.Label();
            this.lblTrue = new System.Windows.Forms.Label();
            this.lblFalse = new System.Windows.Forms.Label();
            this.btnSonra = new System.Windows.Forms.Button();
            this.trueGif = new System.Windows.Forms.PictureBox();
            this.falseGif = new System.Windows.Forms.PictureBox();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trueGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseGif)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(379, 179);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.Transparent;
            this.btnA.Location = new System.Drawing.Point(12, 207);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(184, 39);
            this.btnA.TabIndex = 1;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış :";
            // 
            // lblSoruNo
            // 
            this.lblSoruNo.AutoSize = true;
            this.lblSoruNo.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoruNo.Location = new System.Drawing.Point(506, 27);
            this.lblSoruNo.Name = "lblSoruNo";
            this.lblSoruNo.Size = new System.Drawing.Size(0, 28);
            this.lblSoruNo.TabIndex = 8;
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrue.Location = new System.Drawing.Point(506, 71);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(24, 28);
            this.lblTrue.TabIndex = 9;
            this.lblTrue.Text = "0";
            // 
            // lblFalse
            // 
            this.lblFalse.AutoSize = true;
            this.lblFalse.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFalse.Location = new System.Drawing.Point(506, 104);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(24, 28);
            this.lblFalse.TabIndex = 10;
            this.lblFalse.Text = "0";
            // 
            // btnSonra
            // 
            this.btnSonra.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSonra.Location = new System.Drawing.Point(418, 153);
            this.btnSonra.Name = "btnSonra";
            this.btnSonra.Size = new System.Drawing.Size(158, 38);
            this.btnSonra.TabIndex = 11;
            this.btnSonra.Text = "Başlat";
            this.btnSonra.UseVisualStyleBackColor = true;
            this.btnSonra.Click += new System.EventHandler(this.btnSonra_Click);
            // 
            // trueGif
            // 
            this.trueGif.Image = ((System.Drawing.Image)(resources.GetObject("trueGif.Image")));
            this.trueGif.Location = new System.Drawing.Point(418, 225);
            this.trueGif.Name = "trueGif";
            this.trueGif.Size = new System.Drawing.Size(72, 67);
            this.trueGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trueGif.TabIndex = 12;
            this.trueGif.TabStop = false;
            // 
            // falseGif
            // 
            this.falseGif.Image = ((System.Drawing.Image)(resources.GetObject("falseGif.Image")));
            this.falseGif.Location = new System.Drawing.Point(506, 225);
            this.falseGif.Name = "falseGif";
            this.falseGif.Size = new System.Drawing.Size(74, 67);
            this.falseGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.falseGif.TabIndex = 13;
            this.falseGif.TabStop = false;
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(207, 207);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(184, 39);
            this.btnB.TabIndex = 14;
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(12, 262);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(184, 39);
            this.btnC.TabIndex = 15;
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(207, 262);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(184, 39);
            this.btnD.TabIndex = 16;
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(592, 313);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.falseGif);
            this.Controls.Add(this.trueGif);
            this.Controls.Add(this.btnSonra);
            this.Controls.Add(this.lblFalse);
            this.Controls.Add(this.lblTrue);
            this.Controls.Add(this.lblSoruNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trueGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSoruNo;
        private Label lblTrue;
        private Label lblFalse;
        private Button btnSonra;
        private PictureBox trueGif;
        private PictureBox falseGif;
        private Button btnB;
        private Button btnC;
        private Button btnD;
    }
}