namespace BallGamesWindowsFormsApp
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
            this.components = new System.ComponentModel.Container();
            this.ballButton = new System.Windows.Forms.Button();
            this.randomBallButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ballButton
            // 
            this.ballButton.Location = new System.Drawing.Point(878, 43);
            this.ballButton.Name = "ballButton";
            this.ballButton.Size = new System.Drawing.Size(197, 53);
            this.ballButton.TabIndex = 0;
            this.ballButton.Text = "Двигать Шарик";
            this.ballButton.UseVisualStyleBackColor = true;
            this.ballButton.Click += new System.EventHandler(this.ballButton_Click);
            // 
            // randomBallButton
            // 
            this.randomBallButton.Location = new System.Drawing.Point(515, 52);
            this.randomBallButton.Name = "randomBallButton";
            this.randomBallButton.Size = new System.Drawing.Size(324, 44);
            this.randomBallButton.TabIndex = 1;
            this.randomBallButton.Text = "Рисовать Случайный Шарик";
            this.randomBallButton.UseVisualStyleBackColor = true;
            this.randomBallButton.Click += new System.EventHandler(this.randomBallButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(878, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Двигать Шарик";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.randomBallButton);
            this.Controls.Add(this.ballButton);
            this.Name = "MainForm";
            this.Text = "Шарики";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ballButton;
        private System.Windows.Forms.Button randomBallButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer;
    }
}

