namespace XMLWeather
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.currentTempOut = new System.Windows.Forms.Label();
            this.windDescOut = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.max2Output = new System.Windows.Forms.Label();
            this.min2Output = new System.Windows.Forms.Label();
            this.day1Clouds = new System.Windows.Forms.Label();
            this.day2Clouds = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.Location = new System.Drawing.Point(61, 88);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(35, 13);
            this.cityOutput.TabIndex = 0;
            this.cityOutput.Text = "label1";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.Location = new System.Drawing.Point(61, 31);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(58, 13);
            this.maxOutput.TabIndex = 1;
            this.maxOutput.Text = "maxOutput";
            // 
            // currentTempOut
            // 
            this.currentTempOut.AutoSize = true;
            this.currentTempOut.Location = new System.Drawing.Point(61, 62);
            this.currentTempOut.Name = "currentTempOut";
            this.currentTempOut.Size = new System.Drawing.Size(35, 13);
            this.currentTempOut.TabIndex = 2;
            this.currentTempOut.Text = "label1";
            // 
            // windDescOut
            // 
            this.windDescOut.AutoSize = true;
            this.windDescOut.Location = new System.Drawing.Point(61, 113);
            this.windDescOut.Name = "windDescOut";
            this.windDescOut.Size = new System.Drawing.Size(35, 13);
            this.windDescOut.TabIndex = 3;
            this.windDescOut.Text = "label1";
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.Location = new System.Drawing.Point(61, 139);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(35, 13);
            this.minOutput.TabIndex = 4;
            this.minOutput.Text = "label1";
            // 
            // max2Output
            // 
            this.max2Output.AutoSize = true;
            this.max2Output.Location = new System.Drawing.Point(61, 184);
            this.max2Output.Name = "max2Output";
            this.max2Output.Size = new System.Drawing.Size(35, 13);
            this.max2Output.TabIndex = 5;
            this.max2Output.Text = "label1";
            // 
            // min2Output
            // 
            this.min2Output.AutoSize = true;
            this.min2Output.Location = new System.Drawing.Point(61, 161);
            this.min2Output.Name = "min2Output";
            this.min2Output.Size = new System.Drawing.Size(35, 13);
            this.min2Output.TabIndex = 6;
            this.min2Output.Text = "label2";
            // 
            // day1Clouds
            // 
            this.day1Clouds.AutoSize = true;
            this.day1Clouds.Location = new System.Drawing.Point(174, 139);
            this.day1Clouds.Name = "day1Clouds";
            this.day1Clouds.Size = new System.Drawing.Size(35, 13);
            this.day1Clouds.TabIndex = 7;
            this.day1Clouds.Text = "label1";
            // 
            // day2Clouds
            // 
            this.day2Clouds.AutoSize = true;
            this.day2Clouds.Location = new System.Drawing.Point(174, 173);
            this.day2Clouds.Name = "day2Clouds";
            this.day2Clouds.Size = new System.Drawing.Size(35, 13);
            this.day2Clouds.TabIndex = 8;
            this.day2Clouds.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(461, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.day2Clouds);
            this.Controls.Add(this.day1Clouds);
            this.Controls.Add(this.min2Output);
            this.Controls.Add(this.max2Output);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.windDescOut);
            this.Controls.Add(this.currentTempOut);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.cityOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label currentTempOut;
        private System.Windows.Forms.Label windDescOut;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label max2Output;
        private System.Windows.Forms.Label min2Output;
        private System.Windows.Forms.Label day1Clouds;
        private System.Windows.Forms.Label day2Clouds;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

