﻿namespace Lab250107_LINQ
{
    partial class Form2_NewKeyworld
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(251, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "討論 NEW 關鍵字";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 243);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 14F);
            this.button1.Location = new System.Drawing.Point(23, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "ARRAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 149);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 243);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 14F);
            this.button2.Location = new System.Drawing.Point(148, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 57);
            this.button2.TabIndex = 6;
            this.button2.Text = "CLASS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(280, 149);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 243);
            this.textBox3.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 14F);
            this.button3.Location = new System.Drawing.Point(280, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 57);
            this.button3.TabIndex = 8;
            this.button3.Text = "LINQ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("新細明體", 19F);
            this.textBox4.Location = new System.Drawing.Point(431, 149);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 253);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "子類別的方法名稱跟父類別一樣的時候(12/30)";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 14F);
            this.button4.Location = new System.Drawing.Point(431, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 57);
            this.button4.TabIndex = 10;
            this.button4.Text = "繼承";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form2_NewKeyworld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2_NewKeyworld";
            this.Text = "Form2_NewKeyworld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
    }
}