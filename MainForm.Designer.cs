namespace MORDOCHKA
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.btPrev = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPageSize = new System.Windows.Forms.ComboBox();
            this.lbRows = new System.Windows.Forms.Label();
            this.lbAllRows = new System.Windows.Forms.Label();
            this.tbFiltrName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(12, 12);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(1042, 557);
            this.dgvClient.TabIndex = 0;
            this.dgvClient.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvClient_RowsAdded);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(168, 604);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(75, 23);
            this.btPrev.TabIndex = 1;
            this.btPrev.Text = "Назад";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(168, 575);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Вперёд";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество строк";
            // 
            // cmbPageSize
            // 
            this.cmbPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPageSize.FormattingEnabled = true;
            this.cmbPageSize.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.cmbPageSize.Items.AddRange(new object[] {
            "10",
            "50",
            "200",
            "Все"});
            this.cmbPageSize.Location = new System.Drawing.Point(15, 605);
            this.cmbPageSize.Name = "cmbPageSize";
            this.cmbPageSize.Size = new System.Drawing.Size(121, 21);
            this.cmbPageSize.TabIndex = 5;
            this.cmbPageSize.SelectedIndexChanged += new System.EventHandler(this.cmbPageSizeSelectedIndexChanged);
            // 
            // lbRows
            // 
            this.lbRows.AutoSize = true;
            this.lbRows.Location = new System.Drawing.Point(15, 633);
            this.lbRows.Name = "lbRows";
            this.lbRows.Size = new System.Drawing.Size(13, 13);
            this.lbRows.TabIndex = 6;
            this.lbRows.Text = "0";
            // 
            // lbAllRows
            // 
            this.lbAllRows.AutoSize = true;
            this.lbAllRows.Location = new System.Drawing.Point(100, 632);
            this.lbAllRows.Name = "lbAllRows";
            this.lbAllRows.Size = new System.Drawing.Size(13, 13);
            this.lbAllRows.TabIndex = 7;
            this.lbAllRows.Text = "0";
            // 
            // tbFiltrName
            // 
            this.tbFiltrName.Location = new System.Drawing.Point(1060, 12);
            this.tbFiltrName.Name = "tbFiltrName";
            this.tbFiltrName.Size = new System.Drawing.Size(100, 20);
            this.tbFiltrName.TabIndex = 8;
            this.tbFiltrName.TextChanged += new System.EventHandler(this.tbFiltrName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 691);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFiltrName);
            this.Controls.Add(this.lbAllRows);
            this.Controls.Add(this.lbRows);
            this.Controls.Add(this.cmbPageSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.dgvClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MORDOCHKA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPageSize;
        private System.Windows.Forms.Label lbRows;
        private System.Windows.Forms.Label lbAllRows;
        private System.Windows.Forms.TextBox tbFiltrName;
        private System.Windows.Forms.Label label2;
    }
}

