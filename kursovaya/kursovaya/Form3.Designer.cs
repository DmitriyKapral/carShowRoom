namespace kursovaya
{
    partial class Form3
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
            this.nameClient = new System.Windows.Forms.TextBox();
            this.surnameClient = new System.Windows.Forms.TextBox();
            this.middlenameClient = new System.Windows.Forms.TextBox();
            this.passportDateClient = new System.Windows.Forms.TextBox();
            this.numberPhoneClient = new System.Windows.Forms.TextBox();
            this.addClients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameClient
            // 
            this.nameClient.Location = new System.Drawing.Point(12, 70);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(100, 20);
            this.nameClient.TabIndex = 0;
            // 
            // surnameClient
            // 
            this.surnameClient.Location = new System.Drawing.Point(153, 70);
            this.surnameClient.Name = "surnameClient";
            this.surnameClient.Size = new System.Drawing.Size(100, 20);
            this.surnameClient.TabIndex = 1;
            // 
            // middlenameClient
            // 
            this.middlenameClient.Location = new System.Drawing.Point(303, 70);
            this.middlenameClient.Name = "middlenameClient";
            this.middlenameClient.Size = new System.Drawing.Size(100, 20);
            this.middlenameClient.TabIndex = 2;
            // 
            // passportDateClient
            // 
            this.passportDateClient.Location = new System.Drawing.Point(244, 133);
            this.passportDateClient.Name = "passportDateClient";
            this.passportDateClient.Size = new System.Drawing.Size(100, 20);
            this.passportDateClient.TabIndex = 3;
            this.passportDateClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passportDateClient_KeyPress);
            // 
            // numberPhoneClient
            // 
            this.numberPhoneClient.Location = new System.Drawing.Point(70, 133);
            this.numberPhoneClient.Name = "numberPhoneClient";
            this.numberPhoneClient.Size = new System.Drawing.Size(100, 20);
            this.numberPhoneClient.TabIndex = 4;
            this.numberPhoneClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPhoneClient_KeyPress);
            // 
            // addClients
            // 
            this.addClients.Location = new System.Drawing.Point(165, 205);
            this.addClients.Name = "addClients";
            this.addClients.Size = new System.Drawing.Size(75, 23);
            this.addClients.TabIndex = 5;
            this.addClients.Text = "Добавить";
            this.addClients.UseVisualStyleBackColor = true;
            this.addClients.Click += new System.EventHandler(this.addClients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Паспортные данные";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 240);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addClients);
            this.Controls.Add(this.numberPhoneClient);
            this.Controls.Add(this.passportDateClient);
            this.Controls.Add(this.middlenameClient);
            this.Controls.Add(this.surnameClient);
            this.Controls.Add(this.nameClient);
            this.Name = "Form3";
            this.Text = "Добавление клиентов";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameClient;
        private System.Windows.Forms.TextBox surnameClient;
        private System.Windows.Forms.TextBox middlenameClient;
        private System.Windows.Forms.TextBox passportDateClient;
        private System.Windows.Forms.TextBox numberPhoneClient;
        private System.Windows.Forms.Button addClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}