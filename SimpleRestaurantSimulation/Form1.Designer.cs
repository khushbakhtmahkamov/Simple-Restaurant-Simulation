namespace SimpleRestaurantSimulation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.receiveRequestCustomer = new System.Windows.Forms.Button();
            this.typeDrink = new System.Windows.Forms.ComboBox();
            this.quantityEgg = new System.Windows.Forms.TextBox();
            this.quantityChicken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextQualityResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.sendCustomerRequestsCook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerName);
            this.groupBox1.Controls.Add(this.receiveRequestCustomer);
            this.groupBox1.Controls.Add(this.typeDrink);
            this.groupBox1.Controls.Add(this.quantityEgg);
            this.groupBox1.Controls.Add(this.quantityChicken);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(37, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(447, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(292, 117);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(121, 26);
            this.customerName.TabIndex = 6;
            // 
            // receiveRequestCustomer
            // 
            this.receiveRequestCustomer.Location = new System.Drawing.Point(47, 115);
            this.receiveRequestCustomer.Name = "receiveRequestCustomer";
            this.receiveRequestCustomer.Size = new System.Drawing.Size(217, 30);
            this.receiveRequestCustomer.TabIndex = 5;
            this.receiveRequestCustomer.Text = "Receive this request from:";
            this.receiveRequestCustomer.UseVisualStyleBackColor = true;
            this.receiveRequestCustomer.Click += new System.EventHandler(this.receiveRequestCustomer_Click);
            // 
            // typeDrink
            // 
            this.typeDrink.FormattingEnabled = true;
            this.typeDrink.Location = new System.Drawing.Point(292, 53);
            this.typeDrink.Name = "typeDrink";
            this.typeDrink.Size = new System.Drawing.Size(121, 28);
            this.typeDrink.TabIndex = 4;
            // 
            // quantityEgg
            // 
            this.quantityEgg.Location = new System.Drawing.Point(180, 74);
            this.quantityEgg.Name = "quantityEgg";
            this.quantityEgg.Size = new System.Drawing.Size(62, 26);
            this.quantityEgg.TabIndex = 3;
            // 
            // quantityChicken
            // 
            this.quantityChicken.Location = new System.Drawing.Point(180, 34);
            this.quantityChicken.Name = "quantityChicken";
            this.quantityChicken.Size = new System.Drawing.Size(62, 26);
            this.quantityChicken.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "How many egg?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "How many chicken?";
            // 
            // TextQualityResult
            // 
            this.TextQualityResult.AutoSize = true;
            this.TextQualityResult.Location = new System.Drawing.Point(32, 228);
            this.TextQualityResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextQualityResult.Name = "TextQualityResult";
            this.TextQualityResult.Size = new System.Drawing.Size(0, 20);
            this.TextQualityResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Results";
            // 
            // textResult
            // 
            this.textResult.AcceptsReturn = true;
            this.textResult.Location = new System.Drawing.Point(36, 343);
            this.textResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(446, 109);
            this.textResult.TabIndex = 8;
            // 
            // sendCustomerRequestsCook
            // 
            this.sendCustomerRequestsCook.Location = new System.Drawing.Point(84, 184);
            this.sendCustomerRequestsCook.Name = "sendCustomerRequestsCook";
            this.sendCustomerRequestsCook.Size = new System.Drawing.Size(318, 30);
            this.sendCustomerRequestsCook.TabIndex = 6;
            this.sendCustomerRequestsCook.Text = "Send all Customer requests to the Cook";
            this.sendCustomerRequestsCook.UseVisualStyleBackColor = true;
            this.sendCustomerRequestsCook.Click += new System.EventHandler(this.sendCustomerRequestsCook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 469);
            this.Controls.Add(this.sendCustomerRequestsCook);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextQualityResult);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "My Restaurant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TextQualityResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button receiveRequestCustomer;
        private System.Windows.Forms.ComboBox typeDrink;
        private System.Windows.Forms.TextBox quantityEgg;
        private System.Windows.Forms.TextBox quantityChicken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendCustomerRequestsCook;
        private System.Windows.Forms.TextBox customerName;
    }
}

