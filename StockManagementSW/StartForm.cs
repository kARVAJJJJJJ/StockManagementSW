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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            button2.Hide();
            groupBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            if (lf.DialogResult == DialogResult.OK)
            {
                //MessageBox.Show("nice");
                button1.Hide();
                button2.Show();
                groupBox1.Enabled = true;
            }
            else
            {
                MessageBox.Show("fail");
            }
        }
    }
}
