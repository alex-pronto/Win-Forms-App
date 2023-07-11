using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geniy_Idiot_WinForms_App
{
    public partial class userResultsForm : Form
    {
        public FileSystem fileSystemUser;
        public userResultsForm()
        {
            InitializeComponent();
        }

        private void userResultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userResultsForm_Load(object sender, EventArgs e)
        {
            var table = new DataTable();


            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Surname", typeof(string));
            table.Columns.Add("Right Answers", typeof(int));
            table.Columns.Add("Diagnose", typeof(string));

            fileSystemUser = new FileSystem();
            fileSystemUser.FileDBName = "users_geniyidiot_game";
            fileSystemUser.FileFolderPath = Path.GetTempPath();
            fileSystemUser.DBFilePath = fileSystemUser.FileFolderPath + fileSystemUser.FileDBName;
            var allUsers = fileSystemUser.ReadAllUsersFromDB();


            foreach (var user in allUsers)

                table.Rows.Add(user.Id, user.Name, user.Surname, user.CountRightAnswers, user.Diagnose);

            userResultsDataGridView.DataSource = table;
        }
    }
}
