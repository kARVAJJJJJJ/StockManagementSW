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
            //comboBox1.DataSource = Enum.GetValues(typeof(UserType));
            label4.Text = "Please register your user";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    User justRegistered = new User(textBox3.Text, StockUtility.SHA256Hash(textBox1.Text), StockUtility.SHA256Hash(textBox2.Text), checkBox1.Checked, checkBox2.Checked);
                    StockDbContext db = new StockDbContext();
                    db.Users.Add(justRegistered);
                    db.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " valamint minden mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("A jelszónak legalább 1 karakter hosszúnak kell lennie", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*
public static string SHA256Hash(string mit)
{
string addOn = "Ptxc:Ja~6Fj\"f!s)dfC]AmRT"; // a \ utáni " a karaktersor része(24) :)
SHA256CryptoServiceProvider csp = new SHA256CryptoServiceProvider();
byte[] titkositott = csp.ComputeHash(Encoding.UTF8.GetBytes(mit + addOn));
return BitConverter.ToString(titkositott).Replace("-", "");
}
*/
    }
}
