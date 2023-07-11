using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace Geniy_Idiot_WinForms_App
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private int randomQuestionIndex;
        private int countRightAnswers = 0;
        private User user;
        public FileSystem fileSystemUser;
        private FileSystem fileSystemQuestion;
        private UserStorage userStorage;
        private int countQuestions;
        private int questionNumber = 0;
        private string userName;
        private string userSurname;
        public userDataForm newForm;
        private int seconds = 10;

        public Form1()
        {
            InitializeComponent();

        }

        public void UserData(string name, string surname)
        {
            userName = name;
            userSurname = surname;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nextButton.Hide();
            addQuestionButton.Hide();
            userAnswer2TextBox.Hide();
            userAnswer2Label.Hide();

            
            newForm = new userDataForm();
            newForm.Owner = this; 
            newForm.ShowDialog();

            questionTextLabel.Text = StartMessage();


            NewGame();
            startButton.Show();

            // ShowNextQuestion();

        }


        private void ShowNextQuestion()
        {


                nextButton.Show();
                questionNumber++;
                questionNumberLabel.Text = $"Вопрос номер {questionNumber}";
                userAnswerTextBox.Text = null;
                userAnswerTextBox.Focus();
                var random = new Random();

                randomQuestionIndex = random.Next(0, questions.Count);

                currentQuestion = questions[randomQuestionIndex];

                questionTextLabel.Text = currentQuestion.Text;

            
        }

        
        private void startButton_Click(object sender, EventArgs e)
        {
            nextButton.Show();
            seconds = 10;

            timer2.Start();
            ShowNextQuestion();
            startButton.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
                seconds = seconds - 1;

                timerLabel.Text = seconds.ToString();
           
            if (seconds == 0)
            {
                questions.Remove(currentQuestion);

                var endGame = questions.Count == 0;
                if (endGame)
                {
                    userStorage = new UserStorage();
                    string finalDiagnose = userStorage.CalculateDiagnose(countQuestions, countRightAnswers);


                    user = new User(0, userName, userSurname, countRightAnswers, finalDiagnose);

                    fileSystemUser.SaveUsersToDB(user);
                    
                    timer2.Stop();
                    timerLabel.Hide();
                    MessageBox.Show($"{user.Name} Ваш диагноз {user.Diagnose}");
                    nextButton.Hide();
                   
                    userAnswerTextBox.Text = null;
                    timer2.Stop();

                }
                else
                {
                    ShowNextQuestion();
                    seconds = 10;
                    timer2.Start();
                }
                
            }
            
            


        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            seconds = 10;
            timer2.Start();
            int userAnswer = 0;
            var checkAnswer = GetNumber(userAnswerTextBox.Text, out string message, out userAnswer);
           
                
                if (checkAnswer == true)
                {
                   
                    var rightAnswer = currentQuestion.Answer;

                    if (userAnswer == rightAnswer)
                    {
                        countRightAnswers++;
                    }

                    questions.Remove(currentQuestion);

                    var endGame = questions.Count == 0;
                    if (endGame)
                    {
                        userStorage = new UserStorage();
                        string finalDiagnose = userStorage.CalculateDiagnose(countQuestions, countRightAnswers);


                        user = new User(0, userName, userSurname, countRightAnswers, finalDiagnose);

                        fileSystemUser.SaveUsersToDB(user);

                        timer2.Stop();
                        timerLabel.Hide();
                        MessageBox.Show($"{user.Name} Ваш диагноз {user.Diagnose}");
                        nextButton.Hide();
                        userAnswerTextBox.Text = null;
                       

                }
                    else
                    {
                        ShowNextQuestion();
                    }
                } 
                else
                {
                    userAnswerTextBox.Text = null;
                    userAnswerTextBox.Focus();
                    MessageBox.Show(message);
                    
                }
            

        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newForm = new userDataForm();
            newForm.Owner = this;
            newForm.Show();
            
           
            
            
            NewGame();

            questionTextLabel.Text = StartMessage();

            userAnswerTextBox.Text = null;
            userAnswerTextBox.Focus();
            addQuestionButton.Hide();
            questionTextLabel.Show();
            nextButton.Show();
            userAnswer2TextBox.Hide();
            tableOfQuestionsDataGridView.Hide();
            numberQuestionLabel.Hide();
            questionNumberTextBox.Hide();
            questionDeleteButton.Hide();
            nextButton.Hide();
            startButton.Show();
          
        }

        private string StartMessage()
        {
            return $"Здесь появится текст вопроса когды вы нажмете START у вас будет {seconds} секунд чтобы ответить на каждый вопрос";
        }

        public void NewGame()
        {
            
            tableOfQuestionsDataGridView.Hide();
            numberQuestionLabel.Hide();
            questionNumberTextBox.Hide();
            questionDeleteButton.Hide();


            questionNumber = 0;
            fileSystemUser = new FileSystem();

            fileSystemUser.FileDBName = "users_geniyidiot_game";
            fileSystemUser.FileFolderPath = Path.GetTempPath();
            fileSystemUser.DBFilePath = fileSystemUser.FileFolderPath + fileSystemUser.FileDBName;

            fileSystemQuestion = new FileSystem();

            fileSystemQuestion.FileDBName = "questions_geniyidiot_game";
            fileSystemQuestion.FileFolderPath = Path.GetTempPath();
            fileSystemQuestion.DBFilePath = fileSystemQuestion.FileFolderPath + fileSystemQuestion.FileDBName;


            fileSystemUser.CheckFileIsCreate();
            fileSystemQuestion.CheckFileIsCreate();
            File.ReadAllText(fileSystemQuestion.DBFilePath);

            questions = fileSystemQuestion.ReadQuestionsFromDB();
            countQuestions = questions.Count;

            if (countQuestions == 0)
            {
                questions = QuestionStorage.GetQuestions();
                fileSystemQuestion.SaveQuestionsToDB(questions);
                questions = fileSystemQuestion.ReadQuestionsFromDB();
                countQuestions = questions.Count;

            }

            
        }

        private void посмотретьРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userResultsForm userResultsForm = new userResultsForm(); //где Form2 - название вашей формы
            userResultsForm.ShowDialog();

            
            tableOfQuestionsDataGridView.Hide();
            numberQuestionLabel.Hide();
            questionNumberTextBox.Hide();
            questionDeleteButton.Hide();
            userAnswer2TextBox.Hide(); 
            userAnswer2Label.Hide();

        }

        private void очиститьПредыдущиеРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileSystemUser.ClearDB();
            MessageBox.Show("Готово");
            
        }

        private void выбратьИУдалитьВопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userAnswer2TextBox.Hide();
            addQuestionButton.Hide();
            

            questions = fileSystemQuestion.ReadQuestionsFromDB();

            if (questions.Count == 0)
            {
                MessageBox.Show("Похоже в базе больше нет вопросов");
            }
            else
            {
                var tableOfQuestions = new DataTable();
                tableOfQuestions.Columns.Add("Number", typeof(int));
                tableOfQuestions.Columns.Add("Question", typeof(string));

                for (int i = 0; i < questions.Count; i++)
                {
                    tableOfQuestions.Rows.Add(i + 1, questions[i].Text);
                }

                tableOfQuestionsDataGridView.Show();
                numberQuestionLabel.Show();
                questionNumberTextBox.Show();
                questionDeleteButton.Show();


                tableOfQuestionsDataGridView.DataSource = tableOfQuestions;

               
                

            }


        }


        private void questionDeleteButton_Click(object sender, EventArgs e)
        {
            var countQuestions = questions.Count;
            var questionToDelete = GetQuestionNumber(questionNumberTextBox.Text, countQuestions);

            if (questionToDelete == 0 && countQuestions == 0)
            {
                MessageBox.Show("В базе нет вопросов");
            }
            else if (questionToDelete == -1)
            {
                MessageBox.Show($"Введите номер вопроса от 1 до {countQuestions}");
            }
            else if (questionToDelete == 0 && countQuestions > 0)
            {
                MessageBox.Show($"Введите номер вопроса от 1 до {countQuestions}");
            }
            else if (questionToDelete == -2 && countQuestions != 0)
            {
                MessageBox.Show($"Введите номер вопроса цифрами от 1 до {countQuestions}");
            }
            else if (questionToDelete == -2 && countQuestions == 0)
            {
                MessageBox.Show($"В базе нет вопросов");

            }
            else
            {
                questions.RemoveAt(questionToDelete - 1);

                fileSystemQuestion.ClearDB();
                fileSystemQuestion.SaveQuestionsToDB(questions);

                var tableOfQuestions = new DataTable();
                tableOfQuestions.Columns.Add("Number", typeof(int));
                tableOfQuestions.Columns.Add("Question", typeof(string));

                for (int i = 0; i < questions.Count; i++)
                {
                    tableOfQuestions.Rows.Add(i + 1, questions[i].Text);
                }
                tableOfQuestionsDataGridView.Show();
                numberQuestionLabel.Show();
                questionNumberTextBox.Show();

                tableOfQuestionsDataGridView.DataSource = tableOfQuestions;
            }
            
        }

        public static int GetQuestionNumber(string textBox, int countQuestions)
        {
            
            while (true) 
            {

                try
                {
                    int questionNumber = Convert.ToInt32(textBox);
                    if (questionNumber <= countQuestions && questionNumber > 0)
                    {
                        return questionNumber;
                    }
                    else if (questionNumber == 0)
                    {
                        return questionNumber;
                    }
                    else if (countQuestions == 0)
                    {
                        return questionNumber = 0;
                    }
                    else return -1;

                }

                catch (FormatException)
                {

                    return -2;

                }
            }
        }

        private void добавитьВопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            questionNumberLabel.Text = "Введите вопрос и ответ нажмите добавить";

            userAnswerTextBox.Text = null;
            userAnswerTextBox.Focus();
            addQuestionButton.Show();
            questionTextLabel.Hide();
            nextButton.Hide();
            userAnswer2TextBox.Show();
            tableOfQuestionsDataGridView.Hide();
            numberQuestionLabel.Hide();
            questionNumberTextBox.Hide();
            questionDeleteButton.Hide();    
        }

        private void сброситьСписокВопросовВИсходноеСостояниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            questions = QuestionStorage.GetQuestions();
            fileSystemQuestion.SaveQuestionsToDB(questions);
            MessageBox.Show("Готово");
        }



        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
            

        private void UserResultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               

        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            var userQuestion = userAnswerTextBox.Text;
            
            var userAnswer = 0;
            
            var checkAnswer = GetNumber(userAnswer2TextBox.Text, out string message, out userAnswer);

            if (checkAnswer == true)
            {
                
                var newQuestion = new Question(userQuestion, userAnswer);
                var currentQuestions = fileSystemQuestion.ReadQuestionsFromDB();
                currentQuestions.Add(newQuestion);
                fileSystemQuestion.SaveQuestionsToDB(currentQuestions);

                userAnswer2TextBox.Text = null;
                userAnswerTextBox.Text = null;
                MessageBox.Show(message);


            }
            else
            {
                userAnswer2TextBox.Text = null;
                userAnswer2TextBox.Focus();
                MessageBox.Show(message);

            }


            //////////////////////////////////////////////////////////////
            

        }

        public bool GetNumber(string textBox, out string message, out int userAnswer)
        {

            try
            {
                message = "Успешно";
                userAnswer = Convert.ToInt32(textBox); 
                return true;
                
            }

            catch (FormatException)
            {
                userAnswer = 0;
                message = "Введите число";
                return false;
            }

            catch (OverflowException)
            {
                userAnswer = 0;
                message = "Введите число от -2*10^-9 до 2*10^9";
                return false;
            }


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
