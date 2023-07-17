using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _2048_Game_WindowsFormsApp
{
    public partial class formPopup : Form
    {
        public formPopup()
        {
            InitializeComponent();
        }

        private void formPopup_Load(object sender, EventArgs e)
        {
            Form formPopup = (Form)this.Owner;
            
            rulesLabel.MaximumSize = new Size(750, 500);
        }
    }
}
