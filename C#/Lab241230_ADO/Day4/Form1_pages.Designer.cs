namespace Day4
{
    partial class Form1_pages
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 15F);
            this.button4.Location = new System.Drawing.Point(641, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 52);
            this.button4.TabIndex = 30;
            this.button4.Text = "expt";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 22);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(67, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "顯示資料筆數";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 250);
            this.dataGridView1.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 15F);
            this.button3.Location = new System.Drawing.Point(532, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 52);
            this.button3.TabIndex = 26;
            this.button3.Text = "Page Dn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 15F);
            this.button2.Location = new System.Drawing.Point(415, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 52);
            this.button2.TabIndex = 25;
            this.button2.Text = "Page Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 15F);
            this.button1.Location = new System.Drawing.Point(58, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 52);
            this.button1.TabIndex = 24;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F);
            this.label2.Location = new System.Drawing.Point(234, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "目前查詢";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(471, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "查詢筆數 :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("新細明體", 16F);
            this.textBox3.Location = new System.Drawing.Point(608, 95);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 32);
            this.textBox3.TabIndex = 35;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 15F);
            this.button5.Location = new System.Drawing.Point(668, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 32);
            this.button5.TabIndex = 36;
            this.button5.Text = "Enter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F);
            this.label4.Location = new System.Drawing.Point(236, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "------------";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1_pages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1_pages";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_pages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
    }
}

