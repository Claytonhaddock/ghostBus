namespace GhostBus
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
            this.components = new System.ComponentModel.Container();
            this.bus1 = new System.Windows.Forms.Panel();
            this.bus1time = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bus2 = new System.Windows.Forms.Panel();
            this.bus2time = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bus3 = new System.Windows.Forms.Panel();
            this.bus3time = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bus4 = new System.Windows.Forms.Panel();
            this.bus4time = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bus5 = new System.Windows.Forms.Panel();
            this.bus5time = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bus6 = new System.Windows.Forms.Panel();
            this.bus6time = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.round = new System.Windows.Forms.Timer(this.components);
            this.bus1.SuspendLayout();
            this.bus2.SuspendLayout();
            this.bus3.SuspendLayout();
            this.bus4.SuspendLayout();
            this.bus5.SuspendLayout();
            this.bus6.SuspendLayout();
            this.SuspendLayout();
            // 
            // bus1
            // 
            this.bus1.BackColor = System.Drawing.Color.Green;
            this.bus1.Controls.Add(this.bus1time);
            this.bus1.Controls.Add(this.label7);
            this.bus1.Controls.Add(this.label1);
            this.bus1.Location = new System.Drawing.Point(279, 28);
            this.bus1.Name = "bus1";
            this.bus1.Size = new System.Drawing.Size(244, 48);
            this.bus1.TabIndex = 0;
            // 
            // bus1time
            // 
            this.bus1time.AutoSize = true;
            this.bus1time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bus1time.ForeColor = System.Drawing.SystemColors.Control;
            this.bus1time.Location = new System.Drawing.Point(130, 12);
            this.bus1time.Name = "bus1time";
            this.bus1time.Size = new System.Drawing.Size(20, 24);
            this.bus1time.TabIndex = 2;
            this.bus1time.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(165, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "146";
            // 
            // bus2
            // 
            this.bus2.BackColor = System.Drawing.Color.Green;
            this.bus2.Controls.Add(this.bus2time);
            this.bus2.Controls.Add(this.label9);
            this.bus2.Controls.Add(this.label2);
            this.bus2.Location = new System.Drawing.Point(279, 82);
            this.bus2.Name = "bus2";
            this.bus2.Size = new System.Drawing.Size(244, 48);
            this.bus2.TabIndex = 1;
            // 
            // bus2time
            // 
            this.bus2time.AutoSize = true;
            this.bus2time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bus2time.ForeColor = System.Drawing.SystemColors.Control;
            this.bus2time.Location = new System.Drawing.Point(130, 10);
            this.bus2time.Name = "bus2time";
            this.bus2time.Size = new System.Drawing.Size(20, 24);
            this.bus2time.TabIndex = 2;
            this.bus2time.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(165, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Minutes";
            this.label9.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "146";
            // 
            // bus3
            // 
            this.bus3.BackColor = System.Drawing.Color.Green;
            this.bus3.Controls.Add(this.bus3time);
            this.bus3.Controls.Add(this.label10);
            this.bus3.Controls.Add(this.label3);
            this.bus3.Location = new System.Drawing.Point(279, 136);
            this.bus3.Name = "bus3";
            this.bus3.Size = new System.Drawing.Size(244, 48);
            this.bus3.TabIndex = 1;
            // 
            // bus3time
            // 
            this.bus3time.AutoSize = true;
            this.bus3time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bus3time.ForeColor = System.Drawing.SystemColors.Control;
            this.bus3time.Location = new System.Drawing.Point(130, 11);
            this.bus3time.Name = "bus3time";
            this.bus3time.Size = new System.Drawing.Size(20, 24);
            this.bus3time.TabIndex = 2;
            this.bus3time.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(165, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "146";
            // 
            // bus4
            // 
            this.bus4.BackColor = System.Drawing.Color.Green;
            this.bus4.Controls.Add(this.bus4time);
            this.bus4.Controls.Add(this.label11);
            this.bus4.Controls.Add(this.label4);
            this.bus4.Location = new System.Drawing.Point(279, 190);
            this.bus4.Name = "bus4";
            this.bus4.Size = new System.Drawing.Size(244, 48);
            this.bus4.TabIndex = 1;
            // 
            // bus4time
            // 
            this.bus4time.AutoSize = true;
            this.bus4time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bus4time.ForeColor = System.Drawing.SystemColors.Control;
            this.bus4time.Location = new System.Drawing.Point(130, 10);
            this.bus4time.Name = "bus4time";
            this.bus4time.Size = new System.Drawing.Size(20, 24);
            this.bus4time.TabIndex = 2;
            this.bus4time.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(165, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(11, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "146";
            // 
            // bus5
            // 
            this.bus5.BackColor = System.Drawing.Color.Green;
            this.bus5.Controls.Add(this.bus5time);
            this.bus5.Controls.Add(this.label12);
            this.bus5.Controls.Add(this.label5);
            this.bus5.Location = new System.Drawing.Point(279, 244);
            this.bus5.Name = "bus5";
            this.bus5.Size = new System.Drawing.Size(244, 48);
            this.bus5.TabIndex = 2;
            // 
            // bus5time
            // 
            this.bus5time.AutoSize = true;
            this.bus5time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bus5time.ForeColor = System.Drawing.SystemColors.Control;
            this.bus5time.Location = new System.Drawing.Point(133, 11);
            this.bus5time.Name = "bus5time";
            this.bus5time.Size = new System.Drawing.Size(20, 24);
            this.bus5time.TabIndex = 2;
            this.bus5time.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(165, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(9, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "146";
            // 
            // bus6
            // 
            this.bus6.BackColor = System.Drawing.Color.Green;
            this.bus6.Controls.Add(this.bus6time);
            this.bus6.Controls.Add(this.label13);
            this.bus6.Controls.Add(this.label6);
            this.bus6.Location = new System.Drawing.Point(279, 298);
            this.bus6.Name = "bus6";
            this.bus6.Size = new System.Drawing.Size(244, 48);
            this.bus6.TabIndex = 1;
            // 
            // bus6time
            // 
            this.bus6time.AutoSize = true;
            this.bus6time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bus6time.ForeColor = System.Drawing.SystemColors.Control;
            this.bus6time.Location = new System.Drawing.Point(133, 10);
            this.bus6time.Name = "bus6time";
            this.bus6time.Size = new System.Drawing.Size(20, 24);
            this.bus6time.TabIndex = 2;
            this.bus6time.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(165, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "Minutes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "146";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LevelLabel.Location = new System.Drawing.Point(63, 162);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(127, 39);
            this.LevelLabel.TabIndex = 3;
            this.LevelLabel.Text = "Level 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(32, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 48);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ghost Bus";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.bus6);
            this.Controls.Add(this.bus5);
            this.Controls.Add(this.bus4);
            this.Controls.Add(this.bus3);
            this.Controls.Add(this.bus2);
            this.Controls.Add(this.bus1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bus1.ResumeLayout(false);
            this.bus1.PerformLayout();
            this.bus2.ResumeLayout(false);
            this.bus2.PerformLayout();
            this.bus3.ResumeLayout(false);
            this.bus3.PerformLayout();
            this.bus4.ResumeLayout(false);
            this.bus4.PerformLayout();
            this.bus5.ResumeLayout(false);
            this.bus5.PerformLayout();
            this.bus6.ResumeLayout(false);
            this.bus6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bus1;
        private System.Windows.Forms.Panel bus2;
        private System.Windows.Forms.Panel bus3;
        private System.Windows.Forms.Panel bus4;
        private System.Windows.Forms.Panel bus5;
        private System.Windows.Forms.Panel bus6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label bus1time;
        private System.Windows.Forms.Label bus2time;
        private System.Windows.Forms.Label bus3time;
        private System.Windows.Forms.Label bus4time;
        private System.Windows.Forms.Label bus5time;
        private System.Windows.Forms.Label bus6time;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer round;
    }
}

