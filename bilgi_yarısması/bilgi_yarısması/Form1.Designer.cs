namespace bilgi_yarısması
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
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnD = new Button();
            BtnB = new Button();
            BtnE = new Button();
            BtnC = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LblDogru = new Label();
            LblSoruNo = new Label();
            LblYanlıs = new Label();
            BtnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(-4, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(461, 216);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.Location = new Point(463, 0);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(160, 29);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(463, 105);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(160, 29);
            BtnD.TabIndex = 2;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(463, 35);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(160, 29);
            BtnB.TabIndex = 3;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            // 
            // BtnE
            // 
            BtnE.Location = new Point(463, 140);
            BtnE.Name = "BtnE";
            BtnE.Size = new Size(160, 29);
            BtnE.TabIndex = 4;
            BtnE.Text = "E";
            BtnE.UseVisualStyleBackColor = true;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(463, 70);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(160, 29);
            BtnC.TabIndex = 5;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-4, 219);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 6;
            label1.Text = "Soru No : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-5, 253);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 7;
            label2.Text = "Doğru :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-5, 287);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 8;
            label3.Text = "Yanlış :";
            // 
            // LblDogru
            // 
            LblDogru.AutoSize = true;
            LblDogru.Location = new Point(88, 253);
            LblDogru.Name = "LblDogru";
            LblDogru.Size = new Size(20, 23);
            LblDogru.TabIndex = 9;
            LblDogru.Text = "0";
            // 
            // LblSoruNo
            // 
            LblSoruNo.AutoSize = true;
            LblSoruNo.Location = new Point(88, 219);
            LblSoruNo.Name = "LblSoruNo";
            LblSoruNo.Size = new Size(20, 23);
            LblSoruNo.TabIndex = 10;
            LblSoruNo.Text = "0";
            // 
            // LblYanlıs
            // 
            LblYanlıs.AutoSize = true;
            LblYanlıs.Location = new Point(88, 287);
            LblYanlıs.Name = "LblYanlıs";
            LblYanlıs.Size = new Size(20, 23);
            LblYanlıs.TabIndex = 11;
            LblYanlıs.Text = "0";
            // 
            // BtnSonraki
            // 
            BtnSonraki.Location = new Point(463, 175);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(160, 29);
            BtnSonraki.TabIndex = 12;
            BtnSonraki.Text = "Sonraki ";
            BtnSonraki.UseVisualStyleBackColor = true;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(372, 219);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(513, 219);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(669, 389);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSonraki);
            Controls.Add(LblYanlıs);
            Controls.Add(LblSoruNo);
            Controls.Add(LblDogru);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnC);
            Controls.Add(BtnE);
            Controls.Add(BtnB);
            Controls.Add(BtnD);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnD;
        private Button BtnB;
        private Button BtnE;
        private Button BtnC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblDogru;
        private Label LblSoruNo;
        private Label LblYanlıs;
        private Button BtnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}