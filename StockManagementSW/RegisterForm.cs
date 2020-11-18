using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace StockManagementSW
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(UserType));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    User registered = new User(0, SHA256Hash(textBox1.Text), SHA256Hash(textBox2.Text), (UserType)comboBox1.SelectedIndex);
                    StockDbContext db = new StockDbContext();
                    db.Users.Add(registered);
                    db.SaveChanges();
                    this.Close();
                    
                    //MessageBox.Show(registered.Username);
                }
                else
                {
                    MessageBox.Show("Minden mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        internal static string SHA256Hash(string mit)
        {
            string addOn = "Ptxc:Ja~6Fj\"f!s)dfC]AmRT"; // a \ utáni " a karaktersor része(24) :)
            SHA256CryptoServiceProvider csp = new SHA256CryptoServiceProvider();
            byte[] titkositott = csp.ComputeHash(Encoding.UTF8.GetBytes(mit + addOn));
            return BitConverter.ToString(titkositott).Replace("-", "");
        }
    }
}
