namespace Hotel
{
    partial class Hotel
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
        public void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrezerv = new System.Windows.Forms.RadioButton();
            this.btnfree = new System.Windows.Forms.RadioButton();
            this.btnzanyat = new System.Windows.Forms.RadioButton();
            this.btnvip = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxstatus = new System.Windows.Forms.TextBox();
            this.textBoxfio = new System.Windows.Forms.TextBox();
            this.textBoxviezd = new System.Windows.Forms.TextBox();
            this.textBoxvezd = new System.Windows.Forms.TextBox();
            this.btnkart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnpoisk = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Статус";
            // 
            // btnrezerv
            // 
            this.btnrezerv.AutoSize = true;
            this.btnrezerv.Location = new System.Drawing.Point(18, 97);
            this.btnrezerv.Name = "btnrezerv";
            this.btnrezerv.Size = new System.Drawing.Size(116, 17);
            this.btnrezerv.TabIndex = 2;
            this.btnrezerv.TabStop = true;
            this.btnrezerv.Text = "Зарезервировано";
            this.btnrezerv.UseVisualStyleBackColor = true;
            this.btnrezerv.CheckedChanged += new System.EventHandler(this.btnrezerv_CheckedChanged);
            // 
            // btnfree
            // 
            this.btnfree.AutoSize = true;
            this.btnfree.Location = new System.Drawing.Point(18, 134);
            this.btnfree.Name = "btnfree";
            this.btnfree.Size = new System.Drawing.Size(82, 17);
            this.btnfree.TabIndex = 3;
            this.btnfree.TabStop = true;
            this.btnfree.Text = "Свободные";
            this.btnfree.UseVisualStyleBackColor = true;
            this.btnfree.CheckedChanged += new System.EventHandler(this.btnfree_CheckedChanged);
            // 
            // btnzanyat
            // 
            this.btnzanyat.AutoSize = true;
            this.btnzanyat.Location = new System.Drawing.Point(18, 171);
            this.btnzanyat.Name = "btnzanyat";
            this.btnzanyat.Size = new System.Drawing.Size(63, 17);
            this.btnzanyat.TabIndex = 4;
            this.btnzanyat.TabStop = true;
            this.btnzanyat.Text = "Заняты";
            this.btnzanyat.UseVisualStyleBackColor = true;
            this.btnzanyat.CheckedChanged += new System.EventHandler(this.btnzanyat_CheckedChanged);
            // 
            // btnvip
            // 
            this.btnvip.AutoSize = true;
            this.btnvip.Location = new System.Drawing.Point(16, 206);
            this.btnvip.Name = "btnvip";
            this.btnvip.Size = new System.Drawing.Size(103, 17);
            this.btnvip.TabIndex = 5;
            this.btnvip.TabStop = true;
            this.btnvip.Text = "Выписываются";
            this.btnvip.UseVisualStyleBackColor = true;
            this.btnvip.CheckedChanged += new System.EventHandler(this.btnvip_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(161, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 423);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(217, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список гостей";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(566, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 423);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(589, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер №";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 256);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(631, 97);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(122, 89);
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(653, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(662, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(636, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата выезда";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(636, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата заезда";
            // 
            // textBoxstatus
            // 
            this.textBoxstatus.Location = new System.Drawing.Point(631, 226);
            this.textBoxstatus.Name = "textBoxstatus";
            this.textBoxstatus.Size = new System.Drawing.Size(134, 20);
            this.textBoxstatus.TabIndex = 16;
            // 
            // textBoxfio
            // 
            this.textBoxfio.Location = new System.Drawing.Point(631, 272);
            this.textBoxfio.Name = "textBoxfio";
            this.textBoxfio.Size = new System.Drawing.Size(134, 20);
            this.textBoxfio.TabIndex = 17;
            // 
            // textBoxviezd
            // 
            this.textBoxviezd.Location = new System.Drawing.Point(631, 364);
            this.textBoxviezd.Name = "textBoxviezd";
            this.textBoxviezd.Size = new System.Drawing.Size(134, 20);
            this.textBoxviezd.TabIndex = 18;
            // 
            // textBoxvezd
            // 
            this.textBoxvezd.Location = new System.Drawing.Point(631, 318);
            this.textBoxvezd.Name = "textBoxvezd";
            this.textBoxvezd.Size = new System.Drawing.Size(134, 20);
            this.textBoxvezd.TabIndex = 19;
            // 
            // btnkart
            // 
            this.btnkart.Location = new System.Drawing.Point(678, 403);
            this.btnkart.Name = "btnkart";
            this.btnkart.Size = new System.Drawing.Size(110, 35);
            this.btnkart.TabIndex = 20;
            this.btnkart.Text = "Просмотр карточки";
            this.btnkart.UseVisualStyleBackColor = true;
            this.btnkart.Click += new System.EventHandler(this.btnkart_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(444, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Введите номер";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(566, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 22;
            // 
            // btnpoisk
            // 
            this.btnpoisk.Location = new System.Drawing.Point(730, 1);
            this.btnpoisk.Name = "btnpoisk";
            this.btnpoisk.Size = new System.Drawing.Size(58, 22);
            this.btnpoisk.TabIndex = 23;
            this.btnpoisk.Text = "Найти";
            this.btnpoisk.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(6, 426);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 24;
            this.btnexit.Text = "Выход";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnpoisk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnkart);
            this.Controls.Add(this.textBoxvezd);
            this.Controls.Add(this.textBoxviezd);
            this.Controls.Add(this.textBoxfio);
            this.Controls.Add(this.textBoxstatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnvip);
            this.Controls.Add(this.btnzanyat);
            this.Controls.Add(this.btnfree);
            this.Controls.Add(this.btnrezerv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Hotel";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton btnrezerv;
        public System.Windows.Forms.RadioButton btnfree;
        public System.Windows.Forms.RadioButton btnzanyat;
        public System.Windows.Forms.RadioButton btnvip;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxstatus;
        public System.Windows.Forms.TextBox textBoxfio;
        public System.Windows.Forms.TextBox textBoxviezd;
        public System.Windows.Forms.TextBox textBoxvezd;
        public System.Windows.Forms.Button btnkart;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnpoisk;
        public System.Windows.Forms.Button btnexit;
    }
}

