using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geniy_Idiot_WinForms_App
{
    public partial class userDataForm : Form
    {
        
       

        public userDataForm()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {

            string name = userNameTextBox.Text;
            string surname = userSurnameTextBox.Text;
            
            Form1 frm = (Form1)this.Owner;
            frm.UserData(name, surname);

            

            this.Close();   
        }
    }
}
