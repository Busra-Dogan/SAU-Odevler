﻿
namespace NDPProject
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.narenciyeButton = new System.Windows.Forms.Button();
            this.katiMeyveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vitaminALabel = new System.Windows.Forms.Label();
            this.vitaminCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(28, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 41);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(28, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // narenciyeButton
            // 
            this.narenciyeButton.Location = new System.Drawing.Point(71, 344);
            this.narenciyeButton.Name = "narenciyeButton";
            this.narenciyeButton.Size = new System.Drawing.Size(94, 29);
            this.narenciyeButton.TabIndex = 3;
            this.narenciyeButton.Text = "Narenciye";
            this.narenciyeButton.UseVisualStyleBackColor = true;
            this.narenciyeButton.Click += new System.EventHandler(this.narenciyeButton_Click);
            // 
            // katiMeyveButton
            // 
            this.katiMeyveButton.Location = new System.Drawing.Point(222, 344);
            this.katiMeyveButton.Name = "katiMeyveButton";
            this.katiMeyveButton.Size = new System.Drawing.Size(94, 29);
            this.katiMeyveButton.TabIndex = 4;
            this.katiMeyveButton.Text = "Katı Meyve";
            this.katiMeyveButton.UseVisualStyleBackColor = true;
            this.katiMeyveButton.Click += new System.EventHandler(this.katiMeyveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toplam Vitamin A Değeri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toplam Vitamin C Değeri";
            // 
            // vitaminALabel
            // 
            this.vitaminALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vitaminALabel.Location = new System.Drawing.Point(394, 121);
            this.vitaminALabel.Name = "vitaminALabel";
            this.vitaminALabel.Size = new System.Drawing.Size(176, 79);
            this.vitaminALabel.TabIndex = 7;
            this.vitaminALabel.Text = "0";
            // 
            // vitaminCLabel
            // 
            this.vitaminCLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vitaminCLabel.Location = new System.Drawing.Point(394, 248);
            this.vitaminCLabel.Name = "vitaminCLabel";
            this.vitaminCLabel.Size = new System.Drawing.Size(176, 79);
            this.vitaminCLabel.TabIndex = 8;
            this.vitaminCLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vitaminCLabel);
            this.Controls.Add(this.vitaminALabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.katiMeyveButton);
            this.Controls.Add(this.narenciyeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button narenciyeButton;
        private System.Windows.Forms.Button katiMeyveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vitaminALabel;
        private System.Windows.Forms.Label vitaminCLabel;
    }
}

