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
            AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockDbContext db = new StockDbContext();
            string toCheck = StockUtility.SHA256Hash(textBox1.Text);
            var userQuery = db.Users.Where(u => u.HashedUsername == toCheck);
            
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    User user = userQuery.First<User>();

                    foreach (var u in userQuery)
                    {
                        string theloginpw = u.HashedPassword;
                    }

                    if (user.HashedPassword == StockUtility.SHA256Hash(textBox2.Text))
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("A felhasználónév vagy jelszó nem megfelelő!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    MessageBox.Show("Nincs kivel belépni!");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DialogResult = DialogResult.None;
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
