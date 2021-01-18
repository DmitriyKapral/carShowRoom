namespace kursovaya
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.percentToNameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addPercent = new System.Windows.Forms.Button();
            this.percentLabel = new System.Windows.Forms.Label();
            this.averageSalaryBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.avarageLabel = new System.Windows.Forms.Label();
            this.averageSalaryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Клиенты",
            "Должность сотрудников"});
            this.comboBox1.Location = new System.Drawing.Point(15, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(8, 330);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(603, 330);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 7;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // percentToNameBox
            // 
            this.percentToNameBox.Location = new System.Drawing.Point(578, 58);
            this.percentToNameBox.Name = "percentToNameBox";
            this.percentToNameBox.Size = new System.Drawing.Size(100, 20);
            this.percentToNameBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "123";
            // 
            // addPercent
            // 
            this.addPercent.Location = new System.Drawing.Point(578, 109);
            this.addPercent.Name = "addPercent";
            this.addPercent.Size = new System.Drawing.Size(75, 23);
            this.addPercent.TabIndex = 20;
            this.addPercent.Text = "Вычислить";
            this.addPercent.UseVisualStyleBackColor = true;
            this.addPercent.Click += new System.EventHandler(this.addPercent_Click);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(575, 93);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(40, 13);
            this.percentLabel.TabIndex = 21;
            this.percentLabel.Text = "Ответ:";
            // 
            // averageSalaryBox
            // 
            this.averageSalaryBox.Location = new System.Drawing.Point(578, 222);
            this.averageSalaryBox.Name = "averageSalaryBox";
            this.averageSalaryBox.Size = new System.Drawing.Size(100, 20);
            this.averageSalaryBox.TabIndex = 22;
            this.averageSalaryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.averageSalaryBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "label9";
            // 
            // avarageLabel
            // 
            this.avarageLabel.AutoSize = true;
            this.avarageLabel.Location = new System.Drawing.Point(575, 262);
            this.avarageLabel.Name = "avarageLabel";
            this.avarageLabel.Size = new System.Drawing.Size(40, 13);
            this.avarageLabel.TabIndex = 24;
            this.avarageLabel.Text = "Ответ:";
            // 
            // averageSalaryButton
            // 
            this.averageSalaryButton.Location = new System.Drawing.Point(578, 278);
            this.averageSalaryButton.Name = "averageSalaryButton";
            this.averageSalaryButton.Size = new System.Drawing.Size(75, 23);
            this.averageSalaryButton.TabIndex = 25;
            this.averageSalaryButton.Text = "Вычислить";
            this.averageSalaryButton.UseVisualStyleBackColor = true;
            this.averageSalaryButton.Click += new System.EventHandler(this.averageSalaryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 369);
            this.Controls.Add(this.averageSalaryButton);
            this.Controls.Add(this.avarageLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.averageSalaryBox);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.addPercent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.percentToNameBox);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.TextBox percentToNameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addPercent;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.TextBox averageSalaryBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label avarageLabel;
        private System.Windows.Forms.Button averageSalaryButton;
    }
}

