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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockDbContext db = new StockDbContext();
            string toCheck = StockUtility.SHA256Hash(textBox1.Text);
            var userQuery = db.Users.Where(u => u.Username == toCheck);
            
            try
            {
                User user = userQuery.First<User>();
                /*
                foreach (var u in userQuery)
                {
                    theloginpw = u.HashedPassword;
                }
                */
                if (user.HashedPassword == StockUtility.SHA256Hash(textBox2.Text))
                {
                    MainForm mf = new MainForm(user.Username);
                    mf.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

            /*MessageBox.Show(user.ToString());
            foreach (var u in user)
            {
                MessageBox.Show(u.Username + " - " + u.Id.ToString() + " - " + u.HashedPassword.ToString() + " - " + u.Type.ToString());
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }
    }
}
