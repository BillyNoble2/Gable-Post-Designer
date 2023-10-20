namespace Gable_Post_Designer
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
            this.postHeight_textBox1 = new System.Windows.Forms.TextBox();
            this.postHeight_label = new System.Windows.Forms.Label();
            this.postCentres_label = new System.Windows.Forms.Label();
            this.postCentres_textBox = new System.Windows.Forms.TextBox();
            this.windPressure_label = new System.Windows.Forms.Label();
            this.windPressure_textBox = new System.Windows.Forms.TextBox();
            this.windSuction_label = new System.Windows.Forms.Label();
            this.windSuction_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // postHeight_textBox1
            // 
            this.postHeight_textBox1.Location = new System.Drawing.Point(107, 59);
            this.postHeight_textBox1.Name = "postHeight_textBox1";
            this.postHeight_textBox1.Size = new System.Drawing.Size(100, 20);
            this.postHeight_textBox1.TabIndex = 0;
            // 
            // postHeight_label
            // 
            this.postHeight_label.AutoSize = true;
            this.postHeight_label.Location = new System.Drawing.Point(24, 62);
            this.postHeight_label.Name = "postHeight_label";
            this.postHeight_label.Size = new System.Drawing.Size(62, 13);
            this.postHeight_label.TabIndex = 1;
            this.postHeight_label.Text = "Post Height";
            // 
            // postCentres_label
            // 
            this.postCentres_label.AutoSize = true;
            this.postCentres_label.Location = new System.Drawing.Point(24, 88);
            this.postCentres_label.Name = "postCentres_label";
            this.postCentres_label.Size = new System.Drawing.Size(67, 13);
            this.postCentres_label.TabIndex = 3;
            this.postCentres_label.Text = "Post Centres";
            // 
            // postCentres_textBox
            // 
            this.postCentres_textBox.Location = new System.Drawing.Point(107, 85);
            this.postCentres_textBox.Name = "postCentres_textBox";
            this.postCentres_textBox.Size = new System.Drawing.Size(100, 20);
            this.postCentres_textBox.TabIndex = 2;
            // 
            // windPressure_label
            // 
            this.windPressure_label.AutoSize = true;
            this.windPressure_label.Location = new System.Drawing.Point(24, 114);
            this.windPressure_label.Name = "windPressure_label";
            this.windPressure_label.Size = new System.Drawing.Size(76, 13);
            this.windPressure_label.TabIndex = 5;
            this.windPressure_label.Text = "Wind Pressure";
            // 
            // windPressure_textBox
            // 
            this.windPressure_textBox.Location = new System.Drawing.Point(107, 111);
            this.windPressure_textBox.Name = "windPressure_textBox";
            this.windPressure_textBox.Size = new System.Drawing.Size(100, 20);
            this.windPressure_textBox.TabIndex = 4;
            // 
            // windSuction_label
            // 
            this.windSuction_label.AutoSize = true;
            this.windSuction_label.Location = new System.Drawing.Point(24, 140);
            this.windSuction_label.Name = "windSuction_label";
            this.windSuction_label.Size = new System.Drawing.Size(71, 13);
            this.windSuction_label.TabIndex = 7;
            this.windSuction_label.Text = "Wind Suction";
            // 
            // windSuction_textBox
            // 
            this.windSuction_textBox.Location = new System.Drawing.Point(107, 137);
            this.windSuction_textBox.Name = "windSuction_textBox";
            this.windSuction_textBox.Size = new System.Drawing.Size(100, 20);
            this.windSuction_textBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.windSuction_label);
            this.Controls.Add(this.windSuction_textBox);
            this.Controls.Add(this.windPressure_label);
            this.Controls.Add(this.windPressure_textBox);
            this.Controls.Add(this.postCentres_label);
            this.Controls.Add(this.postCentres_textBox);
            this.Controls.Add(this.postHeight_label);
            this.Controls.Add(this.postHeight_textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox postHeight_textBox1;
        private System.Windows.Forms.Label postHeight_label;
        private System.Windows.Forms.Label postCentres_label;
        private System.Windows.Forms.TextBox postCentres_textBox;
        private System.Windows.Forms.Label windPressure_label;
        private System.Windows.Forms.TextBox windPressure_textBox;
        private System.Windows.Forms.Label windSuction_label;
        private System.Windows.Forms.TextBox windSuction_textBox;
    }
}

