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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCharac = new System.Windows.Forms.TextBox();
            this.textBoxDescrirtion = new System.Windows.Forms.TextBox();
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
            this.createNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
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
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(150, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(139, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(150, 234);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(139, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // textBoxCharac
            // 
            this.textBoxCharac.Location = new System.Drawing.Point(150, 167);
            this.textBoxCharac.Name = "textBoxCharac";
            this.textBoxCharac.Size = new System.Drawing.Size(139, 20);
            this.textBoxCharac.TabIndex = 4;
            // 
            // textBoxDescrirtion
            // 
            this.textBoxDescrirtion.Location = new System.Drawing.Point(150, 100);
            this.textBoxDescrirtion.Name = "textBoxDescrirtion";
            this.textBoxDescrirtion.Size = new System.Drawing.Size(139, 20);
            this.textBoxDescrirtion.TabIndex = 5;
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
            this.Controls.Add(this.textBoxDescrirtion);
            this.Controls.Add(this.textBoxCharac);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
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
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCharac;
        private System.Windows.Forms.TextBox textBoxDescrirtion;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.Label enterPriceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label enterDescriptionLabel;
    }
}