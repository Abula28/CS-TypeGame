﻿namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(147, 18);
            label1.Name = "label1";
            label1.Size = new Size(340, 25);
            label1.TabIndex = 0;
            label1.Text = "სწორად შეიყვანეთ სიტყვები ^_^";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(247, 111);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 1;
            label2.Text = "ეს შეიცვლება";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(212, 303);
            button1.Name = "button1";
            button1.Size = new Size(192, 30);
            button1.TabIndex = 2;
            button1.Text = "Click";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(224, 181);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 236);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "ქულა: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(672, 450);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
    }
}