using System.Windows.Forms;
using System;

namespace Geniy_Idiot_WinForms_App
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
            this.components = new System.ComponentModel.Container();
            this.nextButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПредыдущиеРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьИУдалитьВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьСписокВопросовВИсходноеСостояниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableOfQuestionsDataGridView = new System.Windows.Forms.DataGridView();
            this.questionNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberQuestionLabel = new System.Windows.Forms.Label();
            this.questionDeleteButton = new System.Windows.Forms.Button();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.userAnswer2TextBox = new System.Windows.Forms.TextBox();
            this.userAnswer2Label = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOfQuestionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(68, 302);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(180, 147);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.questionNumberLabel.Location = new System.Drawing.Point(77, 83);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(154, 25);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Вопрос номер";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(74, 148);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(157, 25);
            this.questionTextLabel.TabIndex = 2;
            this.questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(82, 221);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(196, 31);
            this.userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1495, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.посмотретьРезультатыToolStripMenuItem,
            this.очиститьПредыдущиеРезультатыToolStripMenuItem,
            this.выбратьИУдалитьВопросыToolStripMenuItem,
            this.добавитьВопросыToolStripMenuItem,
            this.сброситьСписокВопросовВИсходноеСостояниеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 36);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(699, 44);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // посмотретьРезультатыToolStripMenuItem
            // 
            this.посмотретьРезультатыToolStripMenuItem.Name = "посмотретьРезультатыToolStripMenuItem";
            this.посмотретьРезультатыToolStripMenuItem.Size = new System.Drawing.Size(699, 44);
            this.посмотретьРезультатыToolStripMenuItem.Text = "Посмотреть результаты ";
            this.посмотретьРезультатыToolStripMenuItem.Click += new System.EventHandler(this.посмотретьРезультатыToolStripMenuItem_Click);
            // 
            // очиститьПредыдущиеРезультатыToolStripMenuItem
            // 
            this.очиститьПредыдущиеРезультатыToolStripMenuItem.Name = "очиститьПредыдущиеРезультатыToolStripMenuItem";
            this.очиститьПредыдущиеРезультатыToolStripMenuItem.Size = new System.Drawing.Size(699, 44);
            this.очиститьПредыдущиеРезультатыToolStripMenuItem.Text = "Очистить предыдущие результаты";
            this.очиститьПредыдущиеРезультатыToolStripMenuItem.Click += new System.EventHandler(this.очиститьПредыдущиеРезультатыToolStripMenuItem_Click);
            // 
            // выбратьИУдалитьВопросыToolStripMenuItem
            // 
            this.выбратьИУдалитьВопросыToolStripMenuItem.Name = "выбратьИУдалитьВопросыToolStripMenuItem";
            this.выбратьИУдалитьВопросыToolStripMenuItem.Size = new System.Drawing.Size(699, 44);
            this.выбратьИУдалитьВопросыToolStripMenuItem.Text = "Выбрать и удалить вопросы";
            this.выбратьИУдалитьВопросыToolStripMenuItem.Click += new System.EventHandler(this.выбратьИУдалитьВопросыToolStripMenuItem_Click);
            // 
            // добавитьВопросыToolStripMenuItem
            // 
            this.добавитьВопросыToolStripMenuItem.Name = "добавитьВопросыToolStripMenuItem";
            this.добавитьВопросыToolStripMenuItem.Size = new System.Drawing.Size(699, 44);
            this.добавитьВопросыToolStripMenuItem.Text = "Добавить вопросы";
            this.добавитьВопросыToolStripMenuItem.Click += new System.EventHandler(this.добавитьВопросыToolStripMenuItem_Click);
            // 
            // сброситьСписокВопросовВИсходноеСостояниеToolStripMenuItem
            // 
            this.сброситьСписокВопросовВИсходноеСостояниеToolStripMenuItem.Name = "сброситьСписокВопросовВИсходноеСостояниеToolStripMenuItem";
            this.сброситьСписокВопросовВИсходноеСостояниеToolStripMenuItem.Size = new System.Drawing.Size(699, 44);
            this.сброситьСписокВопросовВИсходноеСостояниеToolStripMenuItem.Text = "Сбросить список вопросов в исходное состояние";
            this.сброситьСписокВопросовВИсходноеСостояниеToolStripMenuItem.Click += new System.EventHandler(this.сброситьСписокВопросовВИсходноеСостояниеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(699, 44);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tableOfQuestionsDataGridView
            // 
            this.tableOfQuestionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOfQuestionsDataGridView.Location = new System.Drawing.Point(41, 93);
            this.tableOfQuestionsDataGridView.Name = "tableOfQuestionsDataGridView";
            this.tableOfQuestionsDataGridView.RowHeadersWidth = 82;
            this.tableOfQuestionsDataGridView.RowTemplate.Height = 33;
            this.tableOfQuestionsDataGridView.Size = new System.Drawing.Size(1180, 411);
            this.tableOfQuestionsDataGridView.TabIndex = 7;
            // 
            // questionNumberTextBox
            // 
            this.questionNumberTextBox.Location = new System.Drawing.Point(82, 555);
            this.questionNumberTextBox.Name = "questionNumberTextBox";
            this.questionNumberTextBox.Size = new System.Drawing.Size(100, 31);
            this.questionNumberTextBox.TabIndex = 8;
            // 
            // numberQuestionLabel
            // 
            this.numberQuestionLabel.AutoSize = true;
            this.numberQuestionLabel.Location = new System.Drawing.Point(77, 507);
            this.numberQuestionLabel.Name = "numberQuestionLabel";
            this.numberQuestionLabel.Size = new System.Drawing.Size(501, 25);
            this.numberQuestionLabel.TabIndex = 9;
            this.numberQuestionLabel.Text = "Введите номер вопроса который хотите удалить";
            // 
            // questionDeleteButton
            // 
            this.questionDeleteButton.Location = new System.Drawing.Point(217, 548);
            this.questionDeleteButton.Name = "questionDeleteButton";
            this.questionDeleteButton.Size = new System.Drawing.Size(105, 45);
            this.questionDeleteButton.TabIndex = 10;
            this.questionDeleteButton.Text = "Удалить вопрос";
            this.questionDeleteButton.UseVisualStyleBackColor = true;
            this.questionDeleteButton.Click += new System.EventHandler(this.questionDeleteButton_Click);
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(432, 548);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(135, 38);
            this.addQuestionButton.TabIndex = 11;
            this.addQuestionButton.Text = "Добавить";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // userAnswer2TextBox
            // 
            this.userAnswer2TextBox.Location = new System.Drawing.Point(562, 221);
            this.userAnswer2TextBox.Name = "userAnswer2TextBox";
            this.userAnswer2TextBox.Size = new System.Drawing.Size(100, 31);
            this.userAnswer2TextBox.TabIndex = 12;
            // 
            // userAnswer2Label
            // 
            this.userAnswer2Label.AutoSize = true;
            this.userAnswer2Label.Location = new System.Drawing.Point(557, 83);
            this.userAnswer2Label.Name = "userAnswer2Label";
            this.userAnswer2Label.Size = new System.Drawing.Size(71, 25);
            this.userAnswer2Label.TabIndex = 13;
            this.userAnswer2Label.Text = "Ответ";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.ForeColor = System.Drawing.Color.Red;
            this.timerLabel.Location = new System.Drawing.Point(808, 548);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(89, 63);
            this.timerLabel.TabIndex = 14;
            this.timerLabel.Text = "10";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(932, 486);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(392, 204);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 723);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.userAnswer2Label);
            this.Controls.Add(this.userAnswer2TextBox);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.questionDeleteButton);
            this.Controls.Add(this.numberQuestionLabel);
            this.Controls.Add(this.questionNumberTextBox);
            this.Controls.Add(this.tableOfQuestionsDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.nextButton);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Гений Идиот Игра";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOfQuestionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem новаяИграToolStripMenuItem;
        private ToolStripMenuItem посмотретьРезультатыToolStripMenuItem;
        private ToolStripMenuItem очиститьПредыдущиеРезультатыToolStripMenuItem;
        private ToolStripMenuItem выбратьИУдалитьВопросыToolStripMenuItem;
        private ToolStripMenuItem добавитьВопросыToolStripMenuItem;
        private ToolStripMenuItem сброситьСписокВопросовВИсходноеСостояниеToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private DataGridView tableOfQuestionsDataGridView;
        private TextBox questionNumberTextBox;
        private Label numberQuestionLabel;
        private Button questionDeleteButton;
        private Button addQuestionButton;
        private TextBox userAnswer2TextBox;
        private Label userAnswer2Label;
        private Label timerLabel;
        private Button startButton;
        private Timer timer2;
    }
}

