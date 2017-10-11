namespace ComputerShop
{
    partial class AdditionalForm
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
            this.createNewButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.enterPriceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enterDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createNewButton
            // 
            this.createNewButton.Location = new System.Drawing.Point(15, 359);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(97, 23);
            this.createNewButton.TabIndex = 0;
            this.createNewButton.Text = "Создать";
            this.createNewButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(181, 359);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(108, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 5;
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Location = new System.Drawing.Point(12, 38);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(126, 13);
            this.enterNameLabel.TabIndex = 6;
            this.enterNameLabel.Text = "Введите наименование";
            // 
            // enterPriceLabel
            // 
            this.enterPriceLabel.AutoSize = true;
            this.enterPriceLabel.Location = new System.Drawing.Point(12, 237);
            this.enterPriceLabel.Name = "enterPriceLabel";
            this.enterPriceLabel.Size = new System.Drawing.Size(75, 13);
            this.enterPriceLabel.TabIndex = 7;
            this.enterPriceLabel.Text = "Введите цену";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите характеристику";
            // 
            // enterDescriptionLabel
            // 
            this.enterDescriptionLabel.AutoSize = true;
            this.enterDescriptionLabel.Location = new System.Drawing.Point(12, 103);
            this.enterDescriptionLabel.Name = "enterDescriptionLabel";
            this.enterDescriptionLabel.Size = new System.Drawing.Size(100, 13);
            this.enterDescriptionLabel.TabIndex = 9;
            this.enterDescriptionLabel.Text = "Введите описание";
            // 
            // AdditionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 426);
            this.Controls.Add(this.enterDescriptionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enterPriceLabel);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.createNewButton);
            this.Name = "AdditionalForm";
            this.Text = "AdditionalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.Label enterPriceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label enterDescriptionLabel;
    }
}