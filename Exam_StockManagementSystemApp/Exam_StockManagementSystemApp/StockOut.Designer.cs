﻿namespace Exam_StockManagementSystemApp
{
    partial class StockOut
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OutButton = new System.Windows.Forms.Button();
            this.quantityOutText = new System.Windows.Forms.TextBox();
            this.idOutText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutButton);
            this.groupBox1.Controls.Add(this.quantityOutText);
            this.groupBox1.Controls.Add(this.idOutText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Out Entry";
            // 
            // OutButton
            // 
            this.OutButton.Location = new System.Drawing.Point(52, 124);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(75, 23);
            this.OutButton.TabIndex = 4;
            this.OutButton.Text = "OUT";
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // quantityOutText
            // 
            this.quantityOutText.Location = new System.Drawing.Point(82, 75);
            this.quantityOutText.Name = "quantityOutText";
            this.quantityOutText.Size = new System.Drawing.Size(100, 20);
            this.quantityOutText.TabIndex = 3;
            // 
            // idOutText
            // 
            this.idOutText.Location = new System.Drawing.Point(82, 24);
            this.idOutText.Name = "idOutText";
            this.idOutText.Size = new System.Drawing.Size(100, 20);
            this.idOutText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Id";
            // 
            // StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockOut";
            this.Text = "StockOut";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.TextBox quantityOutText;
        private System.Windows.Forms.TextBox idOutText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}