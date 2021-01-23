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
        /*
        public MainForm()
        {
            InitializeComponent();
        }
        */
                
        public MainForm()
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            lf.BringToFront();
            lf.Activate();
            if (lf.DialogResult == DialogResult.OK)
            {
                InitializeComponent();
                //label1.Text = user.ToString();
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
