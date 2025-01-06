namespace Day5
{
    partial class Form1
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
            this.EXPT = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Ans = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CurrencyName = new System.Windows.Forms.TextBox();
            this.CurrencyAlternateKey = new System.Windows.Forms.TextBox();
            this.CurrencyKey = new System.Windows.Forms.TextBox();
            this.UPself = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EXPT
            // 
            this.EXPT.Font = new System.Drawing.Font("新細明體", 14F);
            this.EXPT.Location = new System.Drawing.Point(371, 29);
            this.EXPT.Name = "EXPT";
            this.EXPT.Size = new System.Drawing.Size(97, 50);
            this.EXPT.TabIndex = 13;
            this.EXPT.Text = "EXPT.";
            this.EXPT.UseVisualStyleBackColor = true;
            this.EXPT.Click += new System.EventHandler(this.EXPT_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("新細明體", 14F);
            this.UPDATE.Location = new System.Drawing.Point(139, 29);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(97, 50);
            this.UPDATE.TabIndex = 12;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // Read
            // 
            this.Read.Font = new System.Drawing.Font("新細明體", 14F);
            this.Read.Location = new System.Drawing.Point(22, 29);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(97, 50);
            this.Read.TabIndex = 11;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Ans
            // 
            this.Ans.Font = new System.Drawing.Font("新細明體", 10F);
            this.Ans.Location = new System.Drawing.Point(417, 164);
            this.Ans.Multiline = true;
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(269, 274);
            this.Ans.TabIndex = 20;
            this.Ans.TextChanged += new System.EventHandler(this.Ans_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 274);
            this.dataGridView1.TabIndex = 19;
            // 
            // CurrencyName
            // 
            this.CurrencyName.Font = new System.Drawing.Font("新細明體", 14F);
            this.CurrencyName.Location = new System.Drawing.Point(261, 102);
            this.CurrencyName.Multiline = true;
            this.CurrencyName.Name = "CurrencyName";
            this.CurrencyName.Size = new System.Drawing.Size(425, 39);
            this.CurrencyName.TabIndex = 18;
            // 
            // CurrencyAlternateKey
            // 
            this.CurrencyAlternateKey.Font = new System.Drawing.Font("新細明體", 14F);
            this.CurrencyAlternateKey.Location = new System.Drawing.Point(139, 102);
            this.CurrencyAlternateKey.Multiline = true;
            this.CurrencyAlternateKey.Name = "CurrencyAlternateKey";
            this.CurrencyAlternateKey.Size = new System.Drawing.Size(100, 39);
            this.CurrencyAlternateKey.TabIndex = 17;
            // 
            // CurrencyKey
            // 
            this.CurrencyKey.Font = new System.Drawing.Font("新細明體", 14F);
            this.CurrencyKey.Location = new System.Drawing.Point(22, 102);
            this.CurrencyKey.Multiline = true;
            this.CurrencyKey.Name = "CurrencyKey";
            this.CurrencyKey.Size = new System.Drawing.Size(100, 39);
            this.CurrencyKey.TabIndex = 16;
            // 
            // UPself
            // 
            this.UPself.Font = new System.Drawing.Font("新細明體", 14F);
            this.UPself.Location = new System.Drawing.Point(261, 29);
            this.UPself.Name = "UPself";
            this.UPself.Size = new System.Drawing.Size(97, 50);
            this.UPself.TabIndex = 21;
            this.UPself.Text = "Upself";
            this.UPself.UseVisualStyleBackColor = true;
            this.UPself.Click += new System.EventHandler(this.UPself_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UPself);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CurrencyName);
            this.Controls.Add(this.CurrencyAlternateKey);
            this.Controls.Add(this.CurrencyKey);
            this.Controls.Add(this.EXPT);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.Read);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EXPT;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.TextBox Ans;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CurrencyName;
        private System.Windows.Forms.TextBox CurrencyAlternateKey;
        private System.Windows.Forms.TextBox CurrencyKey;
        private System.Windows.Forms.Button UPself;
    }
}

