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
            this.chicken = new System.Windows.Forms.RadioButton();
            this.egg = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitNewRequest = new System.Windows.Forms.Button();
            this.copyThePreviousRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prepareFood = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.egg);
            this.groupBox1.Controls.Add(this.chicken);
            this.groupBox1.Location = new System.Drawing.Point(37, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(258, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // chicken
            // 
            this.chicken.AutoSize = true;
            this.chicken.Location = new System.Drawing.Point(33, 29);
            this.chicken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chicken.Name = "chicken";
            this.chicken.Size = new System.Drawing.Size(84, 24);
            this.chicken.TabIndex = 1;
            this.chicken.TabStop = true;
            this.chicken.Text = "Chicken";
            this.chicken.UseVisualStyleBackColor = true;
            // 
            // egg
            // 
            this.egg.AutoSize = true;
            this.egg.Location = new System.Drawing.Point(161, 29);
            this.egg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.egg.Name = "egg";
            this.egg.Size = new System.Drawing.Size(56, 24);
            this.egg.TabIndex = 2;
            this.egg.TabStop = true;
            this.egg.Text = "Egg";
            this.egg.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 26);
            this.textBox1.TabIndex = 2;
            // 
            // submitNewRequest
            // 
            this.submitNewRequest.Location = new System.Drawing.Point(256, 111);
            this.submitNewRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitNewRequest.Name = "submitNewRequest";
            this.submitNewRequest.Size = new System.Drawing.Size(228, 35);
            this.submitNewRequest.TabIndex = 3;
            this.submitNewRequest.Text = "Submit new request";
            this.submitNewRequest.UseVisualStyleBackColor = true;
            // 
            // copyThePreviousRequest
            // 
            this.copyThePreviousRequest.Location = new System.Drawing.Point(37, 169);
            this.copyThePreviousRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.copyThePreviousRequest.Name = "copyThePreviousRequest";
            this.copyThePreviousRequest.Size = new System.Drawing.Size(392, 35);
            this.copyThePreviousRequest.TabIndex = 4;
            this.copyThePreviousRequest.Text = "Copy the previous request";
            this.copyThePreviousRequest.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Egg Quality:  65";
            // 
            // prepareFood
            // 
            this.prepareFood.Location = new System.Drawing.Point(37, 280);
            this.prepareFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prepareFood.Name = "prepareFood";
            this.prepareFood.Size = new System.Drawing.Size(392, 35);
            this.prepareFood.TabIndex = 6;
            this.prepareFood.Text = "Prepare Food";
            this.prepareFood.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Results";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 373);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(446, 221);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 614);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prepareFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.copyThePreviousRequest);
            this.Controls.Add(this.submitNewRequest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "My Restaurant";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton egg;
        private System.Windows.Forms.RadioButton chicken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitNewRequest;
        private System.Windows.Forms.Button copyThePreviousRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prepareFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

