namespace Day4
{
    partial class Form3_updates
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SQL_Name = new System.Windows.Forms.TextBox();
            this.SQL_Key = new System.Windows.Forms.TextBox();
            this.SQL_select_from = new System.Windows.Forms.TextBox();
            this.Expt = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Ans = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateSelf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 274);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SQL_Name
            // 
            this.SQL_Name.Font = new System.Drawing.Font("新細明體", 14F);
            this.SQL_Name.Location = new System.Drawing.Point(270, 88);
            this.SQL_Name.Multiline = true;
            this.SQL_Name.Name = "SQL_Name";
            this.SQL_Name.Size = new System.Drawing.Size(425, 39);
            this.SQL_Name.TabIndex = 13;
            this.SQL_Name.TextChanged += new System.EventHandler(this.SQL_Name_TextChanged);
            // 
            // SQL_Key
            // 
            this.SQL_Key.Font = new System.Drawing.Font("新細明體", 14F);
            this.SQL_Key.Location = new System.Drawing.Point(148, 88);
            this.SQL_Key.Multiline = true;
            this.SQL_Key.Name = "SQL_Key";
            this.SQL_Key.Size = new System.Drawing.Size(100, 39);
            this.SQL_Key.TabIndex = 12;
            this.SQL_Key.TextChanged += new System.EventHandler(this.SQL_Key_TextChanged);
            // 
            // SQL_select_from
            // 
            this.SQL_select_from.Font = new System.Drawing.Font("新細明體", 14F);
            this.SQL_select_from.Location = new System.Drawing.Point(31, 88);
            this.SQL_select_from.Multiline = true;
            this.SQL_select_from.Name = "SQL_select_from";
            this.SQL_select_from.Size = new System.Drawing.Size(100, 39);
            this.SQL_select_from.TabIndex = 11;
            this.SQL_select_from.TextChanged += new System.EventHandler(this.SQL_select_from_TextChanged);
            // 
            // Expt
            // 
            this.Expt.Font = new System.Drawing.Font("新細明體", 14F);
            this.Expt.Location = new System.Drawing.Point(270, 32);
            this.Expt.Name = "Expt";
            this.Expt.Size = new System.Drawing.Size(97, 50);
            this.Expt.TabIndex = 10;
            this.Expt.Text = "EXPT.";
            this.Expt.UseVisualStyleBackColor = true;
            this.Expt.Click += new System.EventHandler(this.PgDn_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("新細明體", 14F);
            this.UPDATE.Location = new System.Drawing.Point(151, 32);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(97, 50);
            this.UPDATE.TabIndex = 9;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // Read
            // 
            this.Read.Font = new System.Drawing.Font("新細明體", 14F);
            this.Read.Location = new System.Drawing.Point(34, 32);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(97, 50);
            this.Read.TabIndex = 8;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Ans
            // 
            this.Ans.Font = new System.Drawing.Font("新細明體", 10F);
            this.Ans.Location = new System.Drawing.Point(426, 150);
            this.Ans.Multiline = true;
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(269, 274);
            this.Ans.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 14F);
            this.button1.Location = new System.Drawing.Point(373, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Changed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateSelf
            // 
            this.UpdateSelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateSelf.Font = new System.Drawing.Font("新細明體", 14F);
            this.UpdateSelf.Location = new System.Drawing.Point(476, 32);
            this.UpdateSelf.Name = "UpdateSelf";
            this.UpdateSelf.Size = new System.Drawing.Size(97, 50);
            this.UpdateSelf.TabIndex = 17;
            this.UpdateSelf.Text = "UpdateSelf";
            this.UpdateSelf.UseVisualStyleBackColor = true;
            this.UpdateSelf.Click += new System.EventHandler(this.UpdateSelf_Click);
            // 
            // Form3_updates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 442);
            this.Controls.Add(this.UpdateSelf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SQL_Name);
            this.Controls.Add(this.SQL_Key);
            this.Controls.Add(this.SQL_select_from);
            this.Controls.Add(this.Expt);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.Read);
            this.Name = "Form3_updates";
            this.Text = "Form3_updates";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_updates_FormClosing);
            this.Load += new System.EventHandler(this.Form3_updates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SQL_Name;
        private System.Windows.Forms.TextBox SQL_Key;
        private System.Windows.Forms.TextBox SQL_select_from;
        private System.Windows.Forms.Button Expt;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.TextBox Ans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateSelf;
    }
}