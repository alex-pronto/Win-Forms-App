using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_Game_WindowsFormsApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //string name = userNameTextBox.Text;
            //int mapSize = int.Parse(mapSizeComboBox.Text);

            //MainForm frm = (MainForm)this.Owner;

           // frm.GetUserData(name, mapSize);
            this.Close();

        }
    }
}
