using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSW
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            /*
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
            */
        }

        public MainForm(string hashedusername)
        {
            InitializeComponent();
            label1.Text = hashedusername;
        }
    }
}
