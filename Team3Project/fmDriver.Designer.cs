﻿namespace Team3Project
{
    partial class fmDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDriver));
            this.btnViewDel = new System.Windows.Forms.Button();
            this.btnLogDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewDel
            // 
            this.btnViewDel.Location = new System.Drawing.Point(32, 43);
            this.btnViewDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewDel.Name = "btnViewDel";
            this.btnViewDel.Size = new System.Drawing.Size(93, 48);
            this.btnViewDel.TabIndex = 0;
            this.btnViewDel.Text = "Today\'s Deliveries";
            this.btnViewDel.UseVisualStyleBackColor = true;
            this.btnViewDel.Click += new System.EventHandler(this.btnViewDel_Click);
            // 
            // btnLogDel
            // 
            this.btnLogDel.Location = new System.Drawing.Point(32, 113);
            this.btnLogDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogDel.Name = "btnLogDel";
            this.btnLogDel.Size = new System.Drawing.Size(93, 48);
            this.btnLogDel.TabIndex = 1;
            this.btnLogDel.Text = "Log Deliveries";
            this.btnLogDel.UseVisualStyleBackColor = true;
            this.btnLogDel.Click += new System.EventHandler(this.btnLogDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnViewDel);
            this.groupBox1.Controls.Add(this.btnLogDel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Print out today\'s deliveries.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Log deliveries made today.";
            // 
            // fmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 220);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fmDriver";
            this.Text = "Driver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmDriver_FormClosing);
            this.Load += new System.EventHandler(this.fmDriver_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewDel;
        private System.Windows.Forms.Button btnLogDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}