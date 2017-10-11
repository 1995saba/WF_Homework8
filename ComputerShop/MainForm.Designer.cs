namespace ComputerShop
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.addToBasketButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.totalSumLabel = new System.Windows.Forms.Label();
            this.totalSumTextBox = new System.Windows.Forms.TextBox();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(196, 32);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(218, 21);
            this.comboBox.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(164, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Введите наименование товара";
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(29, 82);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(766, 298);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // addToBasketButton
            // 
            this.addToBasketButton.Location = new System.Drawing.Point(434, 18);
            this.addToBasketButton.Name = "addToBasketButton";
            this.addToBasketButton.Size = new System.Drawing.Size(162, 46);
            this.addToBasketButton.TabIndex = 3;
            this.addToBasketButton.Text = "Добавить в корзину";
            this.addToBasketButton.UseVisualStyleBackColor = true;
            this.addToBasketButton.Click += new System.EventHandler(this.AddToBasketButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(632, 18);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(163, 46);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Редактировать список товаров";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // totalSumLabel
            // 
            this.totalSumLabel.AutoSize = true;
            this.totalSumLabel.Location = new System.Drawing.Point(57, 406);
            this.totalSumLabel.Name = "totalSumLabel";
            this.totalSumLabel.Size = new System.Drawing.Size(87, 13);
            this.totalSumLabel.TabIndex = 5;
            this.totalSumLabel.Text = "Итого к оплате:";
            // 
            // totalSumTextBox
            // 
            this.totalSumTextBox.Location = new System.Drawing.Point(150, 403);
            this.totalSumTextBox.Name = "totalSumTextBox";
            this.totalSumTextBox.ReadOnly = true;
            this.totalSumTextBox.Size = new System.Drawing.Size(204, 20);
            this.totalSumTextBox.TabIndex = 6;
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(369, 406);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(35, 13);
            this.currencyLabel.TabIndex = 7;
            this.currencyLabel.Text = "тенге";
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(632, 389);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(162, 46);
            this.countButton.TabIndex = 8;
            this.countButton.Text = "Посчитать сумму";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 443);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.totalSumTextBox);
            this.Controls.Add(this.totalSumLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addToBasketButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBox);
            this.Name = "MainForm";
            this.Text = "Учет продаж";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button addToBasketButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label totalSumLabel;
        private System.Windows.Forms.TextBox totalSumTextBox;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Button countButton;
    }
}

