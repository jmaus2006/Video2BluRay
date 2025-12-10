namespace VideoConverter
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
            button1 = new Button();
            label1 = new Label();
            comboBoxFrameRate = new ComboBox();
            comboBoxBitrate = new ComboBox();
            comboBoxCodec = new ComboBox();
            comboBoxInterpolation = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            label7 = new Label();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            labelProgress = new Label();
            txtFileName = new TextBox();
            label6 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(24, 24);
            button1.Name = "button1";
            button1.Size = new Size(256, 53);
            button1.TabIndex = 0;
            button1.Text = "Select Video";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 80);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // comboBoxFrameRate
            // 
            comboBoxFrameRate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFrameRate.FormattingEnabled = true;
            comboBoxFrameRate.Items.AddRange(new object[] { "23.976", "24", "25", "29.97", "50", "59.94" });
            comboBoxFrameRate.Location = new Point(195, 115);
            comboBoxFrameRate.Name = "comboBoxFrameRate";
            comboBoxFrameRate.Size = new Size(223, 33);
            comboBoxFrameRate.TabIndex = 2;
            // 
            // comboBoxBitrate
            // 
            comboBoxBitrate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBitrate.FormattingEnabled = true;
            comboBoxBitrate.Items.AddRange(new object[] { "15M", "18M", "20M", "21M", "22M", "23M", "24M", "25M", "26M", "27M", "28M", "29M", "30M", "35M" });
            comboBoxBitrate.Location = new Point(195, 165);
            comboBoxBitrate.Name = "comboBoxBitrate";
            comboBoxBitrate.Size = new Size(223, 33);
            comboBoxBitrate.TabIndex = 3;
            // 
            // comboBoxCodec
            // 
            comboBoxCodec.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCodec.Items.AddRange(new object[] { "libx264", "mpeg2video", "vc1" });
            comboBoxCodec.Location = new Point(195, 215);
            comboBoxCodec.Name = "comboBoxCodec";
            comboBoxCodec.Size = new Size(223, 33);
            comboBoxCodec.TabIndex = 4;
            // 
            // comboBoxInterpolation
            // 
            comboBoxInterpolation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxInterpolation.FormattingEnabled = true;
            comboBoxInterpolation.Items.AddRange(new object[] { "minterpolate", "tblend", "None" });
            comboBoxInterpolation.Location = new Point(195, 265);
            comboBoxInterpolation.Name = "comboBoxInterpolation";
            comboBoxInterpolation.Size = new Size(223, 33);
            comboBoxInterpolation.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 115);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 6;
            label2.Text = "Frames per second";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 165);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 7;
            label3.Text = "Bitrate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 215);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 8;
            label4.Text = "Codec";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 265);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 9;
            label5.Text = "Interpolation";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(403, 397);
            button2.Name = "button2";
            button2.Size = new Size(178, 80);
            button2.TabIndex = 10;
            button2.Text = "Convert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 458);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 13;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(24, 397);
            button3.Name = "button3";
            button3.Size = new Size(253, 58);
            button3.TabIndex = 12;
            button3.Text = "Select Output Directory";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(24, 531);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(557, 23);
            progressBar1.TabIndex = 14;
            // 
            // labelProgress
            // 
            labelProgress.Location = new Point(588, 531);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(50, 23);
            labelProgress.TabIndex = 15;
            labelProgress.Text = "0%";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(27, 327);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(391, 31);
            txtFileName.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(424, 333);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 17;
            label6.Text = "New File Name";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(339, 24);
            button4.Name = "button4";
            button4.Size = new Size(256, 53);
            button4.TabIndex = 18;
            button4.Text = "Concatenate Videos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 591);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(txtFileName);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxInterpolation);
            Controls.Add(comboBoxCodec);
            Controls.Add(comboBoxBitrate);
            Controls.Add(comboBoxFrameRate);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(labelProgress);
            Name = "Form1";
            Text = "Video Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox comboBoxFrameRate;
        private ComboBox comboBoxBitrate;
        private ComboBox comboBoxCodec;
        private ComboBox comboBoxInterpolation;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Label label7;
        private Button button3;
        private ProgressBar progressBar1;
        private Label labelProgress;
        private TextBox txtFileName;
        private Label label6;
        private Button button4;
    }
}
