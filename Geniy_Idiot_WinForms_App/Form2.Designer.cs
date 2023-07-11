namespace Geniy_Idiot_WinForms_App
{
    partial class userDataForm
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userSurnameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userSurnameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(264, 284);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(220, 109);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(59, 73);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(53, 25);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Имя";
            // 
            // userSurnameLabel
            // 
            this.userSurnameLabel.AutoSize = true;
            this.userSurnameLabel.Location = new System.Drawing.Point(485, 72);
            this.userSurnameLabel.Name = "userSurnameLabel";
            this.userSurnameLabel.Size = new System.Drawing.Size(104, 25);
            this.userSurnameLabel.TabIndex = 2;
            this.userSurnameLabel.Text = "Фамилия";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(64, 132);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(229, 31);
            this.userNameTextBox.TabIndex = 3;
            // 
            // userSurnameTextBox
            // 
            this.userSurnameTextBox.Location = new System.Drawing.Point(490, 132);
            this.userSurnameTextBox.Name = "userSurnameTextBox";
            this.userSurnameTextBox.Size = new System.Drawing.Size(217, 31);
            this.userSurnameTextBox.TabIndex = 4;
            // 
            // userDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userSurnameTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userSurnameLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.addUserButton);
            this.Name = "userDataForm";
            this.Text = "Добавление Данных Пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userSurnameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userSurnameTextBox;
    }
}