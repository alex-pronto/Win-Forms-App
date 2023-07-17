using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_Game_WindowsFormsApp
{


    public partial class MainForm : Form
    {

        private Label[,] labelsMap;
        private int mapSize;
        private static Random random = new Random();
        private int score;
        private User newUser;
        public StartForm startForm;
        private int countGeneratedAndCreatedNumbers = 0;
        private bool game = true;
        private int  countDoubles = 0;
        private const int labelSize = 70;
        private const int padding = 6;
        private const int startX = 10;
        private const int startY = 70;
        private List<User> allUsers;
        



        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startForm = new StartForm();
            startForm.ShowDialog();
            newUser = new User("неизвестно", 0, 0);
            newUser.Name = startForm.userNameTextBox.Text;
            newUser.MapSize = int.Parse(startForm.mapSizeComboBox.Text);
            mapSize = int.Parse(startForm.mapSizeComboBox.Text);
            InitMap();
            GenerateNumber();
            ShowScore();
                

        }

        

        private void ShowScore()

        {
            if (score == 0)
            {
                
                
                allUsers = FileSystem.ReadAllUsersFromDB();
            }
            
            
            scoreLabel.Text = score.ToString();

            if (allUsers.Count > 0)
            {
                bestResultLabel.Text = allUsers[0].UserResult.ToString();
            }
            

            if (int.Parse(scoreLabel.Text) > int.Parse(bestResultLabel.Text))
            {
                bestResultLabel.Text = scoreLabel.Text;
            }
           
        }

        private void GenerateNumber()
        {
            
            while (true)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    
                    int randomNumber = 3;
                    while(randomNumber == 3)
                    {
                         randomNumber = random.Next(2, 5);
                    }


                    labelsMap[indexRow, indexColumn].Text = randomNumber.ToString();
                   
                    if (randomNumber == 4)
                    { 
                        labelsMap[indexRow, indexColumn].BackColor = Color.FromArgb(234, 224, 221);
                    }

                    countGeneratedAndCreatedNumbers++;
                    break;
                }
            }
            

        }

        private void InitMap()
        {
            this.ClientSize = new System.Drawing.Size(10 + (labelSize + padding) *mapSize, 70 + (labelSize + padding) * mapSize);
            labelsMap = new Label[mapSize, mapSize];
            
            for (int i = 0; i < mapSize; i++)
            {
                for(int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }


        
        private bool PlayGame()
        {
            if (countGeneratedAndCreatedNumbers == mapSize*mapSize)
            {
                
                MessageBox.Show($"Игра Закончена Ваш результат {score} очков");
                newUser.UserResult = score;
               
                FileSystem.SaveUserToDB(newUser);


                return false;
            }
            else
            {
                GenerateNumber();
                ShowScore();
                countDoubles = 0;
                return true;
                
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            
            label.BackColor = GetColor(0);
            label.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(labelSize, labelSize);
            //label.Text = number.ToString();
            int x = startX + indexColumn*(labelSize + padding);
            int y = startY + indexRow * (labelSize + padding);
            label.Location = new Point(x, y);
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {


            if (game == true && (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down))
            {
                if (e.KeyCode == Keys.Right)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        for (int j = mapSize - 1; j >= 0; j--)
                        {
                            if (labelsMap[i, j].Text != string.Empty)
                            {

                                if ((j - 1) >= 0 && labelsMap[i, j - 1].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j - 1].Text);
                                    score += number * 2;

                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    
                                    if (labelsMap[i, j].Text == "2048")
                                    {
                                        MessageBox.Show("Вы победили!!!");
                                    }
                                    
                                    
                                    
                                    labelsMap[i, j - 1].Text = string.Empty;

                                    labelsMap[i, j].BackColor = GetColor(int.Parse(labelsMap[i, j].Text));
                                    labelsMap[i, j - 1].BackColor = GetColor(0);


                                    countGeneratedAndCreatedNumbers--;
                                    break;
                                }


                            }
                        }
                    }

                    for (int i = 0; i < mapSize; i++)
                    {
                        for (int j = mapSize - 1; j >= 0; j--)
                        {
                            if (labelsMap[i, j].Text == string.Empty)
                            {
                                for (int k = j - 1; k >= 0; k--)
                                {
                                    if (labelsMap[i, k].Text != string.Empty)
                                    {

                                        labelsMap[i, j].Text = labelsMap[i, k].Text;
                                        labelsMap[i, j].BackColor = labelsMap[i, k].BackColor;
                                        labelsMap[i, k].Text = string.Empty;
                                        labelsMap[i, k].BackColor = GetColor(0);

                                        break;
                                    }

                                }
                            }
                        }
                    }

                    for (int i = 0; i < mapSize; i++)
                    {
                        for (int j = mapSize - 1; j >= 0; j--)
                        {
                            if (labelsMap[i, j].Text != string.Empty)
                            {

                                if ((j - 1) >= 0 && labelsMap[i, j - 1].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j - 1].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    
                                    
                                    if (labelsMap[i, j].Text == "2048")
                                    {
                                        MessageBox.Show("Вы победили!!!");
                                    }

                                    labelsMap[i, j - 1].Text = string.Empty;

                                    labelsMap[i, j].BackColor = GetColor(int.Parse(labelsMap[i, j].Text));
                                    labelsMap[i, j - 1].BackColor = GetColor(0);

                                    countGeneratedAndCreatedNumbers--;
                                    break;
                                }


                            }
                        }
                    }

                }
                if (e.KeyCode == Keys.Left)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        for (int j = 0; j < mapSize; j++)
                        {
                            if (labelsMap[i, j].Text != string.Empty)
                            {

                                if ((j + 1) < mapSize && labelsMap[i, j + 1].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j + 1].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();

                                    if (labelsMap[i, j].Text == "2048")
                                    {
                                        MessageBox.Show("Вы победили!!!");
                                    }

                                    labelsMap[i, j].BackColor = GetColor(int.Parse(labelsMap[i, j].Text));
                                    labelsMap[i, j + 1].Text = string.Empty;
                                    labelsMap[i, j + 1].BackColor = GetColor(0);
                                    countGeneratedAndCreatedNumbers--;
                                    break;
                                }


                            }
                        }
                    }

                    for (int i = 0; i < mapSize; i++)
                    {
                        for (int j = 0; j < mapSize; j++)
                        {
                            if (labelsMap[i, j].Text == string.Empty)
                            {
                                for (int k = j + 1; k < mapSize; k++)
                                {
                                    if (labelsMap[i, k].Text != string.Empty)
                                    {

                                        labelsMap[i, j].Text = labelsMap[i, k].Text;
                                        labelsMap[i, j].BackColor = labelsMap[i, k].BackColor;
                                        labelsMap[i, k].Text = string.Empty;
                                        labelsMap[i, k].BackColor = GetColor(0);
                                        break;
                                    }

                                }
                            }
                        }
                    }

                    for (int i = 0; i < mapSize; i++)
                    {
                        for (int j = 0; j < mapSize; j++)
                        {
                            if (labelsMap[i, j].Text != string.Empty)
                            {

                                if ((j + 1) < mapSize && labelsMap[i, j + 1].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j + 1].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();

                                    if (labelsMap[i, j].Text == "2048")
                                    {
                                        MessageBox.Show("Вы победили!!!");
                                    }

                                    labelsMap[i, j].BackColor = GetColor(int.Parse(labelsMap[i, j].Text));
                                    labelsMap[i, j + 1].Text = string.Empty;
                                    labelsMap[i, j + 1].BackColor = GetColor(0);
                                    countGeneratedAndCreatedNumbers--;
                                    break;
                                }


                            }
                        }
                    }

                }
                if (e.KeyCode == Keys.Up)
                {
                    for (int j = 0; j < mapSize; j++)
                    {


                        for (int i = 0; i < mapSize; i++)
                        {
                            if (labelsMap[i, j].Text != string.Empty)
                            {
                                for (int k = i + 1; k < mapSize; k++)
                                {

                                    if (((i + 1) < mapSize) && (labelsMap[i, j].Text == labelsMap[i + 1, j].Text))
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        labelsMap[i, j].Text = (number * 2).ToString();

                                        if (labelsMap[i, j].Text == "2048")
                                        {
                                            MessageBox.Show("Вы победили!!!");
                                        }

                                        labelsMap[i, j].BackColor = GetColor(int.Parse(labelsMap[i, j].Text));
                                        labelsMap[i + 1, j].Text = string.Empty;
                                        labelsMap[i + 1, j].BackColor = GetColor(0);

                                        countGeneratedAndCreatedNumbers--;
                                        break;
                                    }

                                }
                            }
                        }
                    }

                    for (int j = 0; j < mapSize; j++)
                    {
                        for (int i = 0; i < mapSize; i++)
                        {
                            if (labelsMap[i, j].Text == string.Empty)
                            {
                                for (int k = i + 1; k < mapSize; k++)
                                {
                                    if (labelsMap[k, j].Text != string.Empty)
                                    {

                                        labelsMap[i, j].Text = labelsMap[k, j].Text;
                                        labelsMap[i, j].BackColor = labelsMap[k, j].BackColor;
                                        labelsMap[k, j].Text = string.Empty;
                                        labelsMap[k, j].BackColor = GetColor(0);
                                        break;
                                    }

                                }
                            }
                        }
                    }

                    for (int j = 0; j < mapSize; j++)
                    {
                        for (int i = 0; i < mapSize; i++)
                        {
                            if (labelsMap[i, j].Text != string.Empty)
                            {
                                for (int k = i + 1; k < mapSize; k++)
                                {

                                    if (((i + 1) < mapSize) && (labelsMap[i, j].Text == labelsMap[i + 1, j].Text) && countDoubles == 0)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        labelsMap[i, j].Text = (number * 2).ToString();

                                        if (labelsMap[i, j].Text == "2048")
                                        {
                                            MessageBox.Show("Вы победили!!!");
                                        }

                                        labelsMap[i, j].BackColor = GetColor(int.Parse(labelsMap[i, j].Text));
                                        labelsMap[i + 1, j].Text = string.Empty;
                                        labelsMap[i + 1, j].BackColor = GetColor(0);

                                        countGeneratedAndCreatedNumbers--;
                                        break;
                                    }

                                }
                            }
                        }
                    }

                }
                if (e.KeyCode == Keys.Down)
                {

                    for (int j = 0; j < mapSize; j++)
                    {


                        for (int i = mapSize - 1; i >= 0; i--)
                        {

                            if (labelsMap[i, j].Text != string.Empty)
                            {

                                if (((i - 1) >= 0) && (labelsMap[i, j].Text == labelsMap[i - 1, j].Text))
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();

                                    if (labelsMap[i, j].Text == "2048")
                                    {
                                        MessageBox.Show("Вы победили!!!");
                                    }

                                    labelsMap[i, j].BackColor = GetColor(int.Parse(labelsMap[i, j].Text));
                                    labelsMap[i - 1, j].Text = string.Empty;
                                    labelsMap[i - 1, j].BackColor = GetColor(0);
                                    countGeneratedAndCreatedNumbers--;
                                    //countDoubles = 1;  
                                    break;
                                }

                            }
                        }
                    }

                    for (int j = 0; j < mapSize; j++)
                    {
                        for (int i = mapSize - 1; i >= 0; i--)
                        {
                            if (labelsMap[i, j].Text == string.Empty)
                            {
                                for (int k = i - 1; k >= 0; k--)
                                {
                                    if (labelsMap[k, j].Text != string.Empty)
                                    {

                                        labelsMap[i, j].Text = labelsMap[k, j].Text;
                                        labelsMap[i, j].BackColor = labelsMap[k, j].BackColor;
                                        labelsMap[k, j].Text = string.Empty;
                                        labelsMap[k, j].BackColor = GetColor(0);
                                        break;
                                    }

                                }

                            }
                        }
                    }

                    for (int j = 0; j < mapSize; j++)
                    {
                        for (int i = mapSize - 1; i >= 0; i--)
                        {
                            if (labelsMap[i, j].Text != string.Empty)
                            {

                                if (((i - 1) >= 0) && (labelsMap[i, j].Text == labelsMap[i - 1, j].Text))
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();

                                    if (labelsMap[i, j].Text == "2048")
                                    {
                                        MessageBox.Show("Вы победили!!!");
                                    }

                                    labelsMap[i, j].BackColor = GetColor(int.Parse(labelsMap[i, j].Text));
                                    labelsMap[i - 1, j].Text = string.Empty;
                                    labelsMap[i - 1, j].BackColor = GetColor(0);
                                    countGeneratedAndCreatedNumbers--;
                                    break;
                                }



                            }
                        }
                    }
                }



                game = PlayGame();
            }
            else return;


        }

        
       

        private Color GetColor(int number)
        {

        
            if (number == 0)
            {
                return Color.FromArgb(202, 192, 181);
            }

            if (number == 2)
            {
                return  Color.FromArgb(238, 228, 218);
            }
            if (number == 4)
            {
                return Color.FromArgb(234, 224, 221);
            }
            if (number == 8)
            {
                return Color.FromArgb(232, 180, 121);
            }
            if (number == 16)
            {
                return Color.FromArgb(231, 153, 107);
            }
            if (number == 32)
            {
                return Color.FromArgb(230, 129, 103);
            }
            if (number == 64)
            {
                return Color.FromArgb(225, 104, 69);
            }
            if (number == 128)
            {
                return Color.FromArgb(231, 209, 125);
            }
            if (number == 256)
            {
                return Color.FromArgb(231, 205, 112);
            }
            if (number == 512)
            {
                return Color.FromArgb(231, 205, 112);
            }
            if (number == 1024)
            {
                return Color.FromArgb(230, 198, 87);
            }
            if (number == 2048)
            {
                return Color.FromArgb(229, 196, 79);
            }

            return Color.White;
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void показатьРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowResults();
        }

        private void ShowResults()
        {
            
            List<User>allUsers = FileSystem.ReadAllUsersFromDB();
            var tableResults = new DataTable();
            tableResults.Columns.Add("Имя", typeof(string));
            tableResults.Columns.Add("Размер игрового поля", typeof(int));
            tableResults.Columns.Add("Результат", typeof(int));

            foreach (var user in allUsers)

                tableResults.Rows.Add(user.Name, user.MapSize, user.UserResult);

            var userResultsForm = new UserResultsForm();
            userResultsForm.UserResultsDataGridView.DataSource = tableResults;

            userResultsForm.ShowDialog();
            
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPopup = new formPopup();
            formPopup.Owner = this;
            formPopup.ShowDialog(this);

            

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
