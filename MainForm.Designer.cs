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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFiltrGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFiltrPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFiltrMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSortLName = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btAddClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(12, 57);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(1042, 512);
            this.dgvClient.TabIndex = 0;
            this.dgvClient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellDoubleClick);
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
            this.tbFiltrName.Location = new System.Drawing.Point(3, 52);
            this.tbFiltrName.Name = "tbFiltrName";
            this.tbFiltrName.Size = new System.Drawing.Size(149, 20);
            this.tbFiltrName.TabIndex = 8;
            this.tbFiltrName.TextChanged += new System.EventHandler(this.tbFiltrName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbFiltrGender);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbFiltrPhone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbFiltrMail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbFiltrName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1060, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 261);
            this.panel1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Пол";
            // 
            // cmbFiltrGender
            // 
            this.cmbFiltrGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrGender.FormattingEnabled = true;
            this.cmbFiltrGender.Items.AddRange(new object[] {
            "ВСЕ",
            "м",
            "ж"});
            this.cmbFiltrGender.Location = new System.Drawing.Point(3, 237);
            this.cmbFiltrGender.Name = "cmbFiltrGender";
            this.cmbFiltrGender.Size = new System.Drawing.Size(149, 21);
            this.cmbFiltrGender.TabIndex = 12;
            this.cmbFiltrGender.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrGender_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Фильтр";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Телефон";
            // 
            // tbFiltrPhone
            // 
            this.tbFiltrPhone.Location = new System.Drawing.Point(3, 151);
            this.tbFiltrPhone.Name = "tbFiltrPhone";
            this.tbFiltrPhone.Size = new System.Drawing.Size(149, 20);
            this.tbFiltrPhone.TabIndex = 15;
            this.tbFiltrPhone.TextChanged += new System.EventHandler(this.tbFiltrPhone_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Почта";
            // 
            // tbFiltrMail
            // 
            this.tbFiltrMail.Location = new System.Drawing.Point(3, 100);
            this.tbFiltrMail.Name = "tbFiltrMail";
            this.tbFiltrMail.Size = new System.Drawing.Size(149, 20);
            this.tbFiltrMail.TabIndex = 13;
            this.tbFiltrMail.TextChanged += new System.EventHandler(this.tbFiltrMail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Поиск";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ФИО";
            // 
            // btSortLName
            // 
            this.btSortLName.Location = new System.Drawing.Point(106, 3);
            this.btSortLName.Name = "btSortLName";
            this.btSortLName.Size = new System.Drawing.Size(75, 40);
            this.btSortLName.TabIndex = 12;
            this.btSortLName.Text = "Фамилия";
            this.btSortLName.UseVisualStyleBackColor = true;
            this.btSortLName.Click += new System.EventHandler(this.btSortLName_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btSortLName);
            this.panel2.Location = new System.Drawing.Point(18, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 46);
            this.panel2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "Кол-во \r\nпосещений";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Дата\r\nпосещения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сортировка";
            // 
            // btAddClient
            // 
            this.btAddClient.Location = new System.Drawing.Point(979, 575);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(75, 51);
            this.btAddClient.TabIndex = 14;
            this.btAddClient.Text = "Добавить клиента";
            this.btAddClient.UseVisualStyleBackColor = true;
            this.btAddClient.Click += new System.EventHandler(this.btAddClient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 691);
            this.Controls.Add(this.btAddClient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAllRows);
            this.Controls.Add(this.lbRows);
            this.Controls.Add(this.cmbPageSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.dgvClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MORDOCHKA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFiltrGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFiltrPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFiltrMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSortLName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btAddClient;
    }
}

