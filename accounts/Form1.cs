using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace accounts
{
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }        
        public Person thePerson
        {
            get { return Bank.GetPerson(userLogin.Text); }
        }       

        private void loginClear_Click_1(object sender, EventArgs e)
        {
            userLogin.Text = "";
            passwordLogin.Text = "";
        }

        private void login_Click_1(object sender, EventArgs e)
        {
            bool flag = true;
            try
            {
                Bank.GetPerson(userLogin.Text).Login(passwordLogin.Text);
            }
            catch (AccountException et)
            {
                flag = false;
                MessageBox.Show(et.Message);
                userLogin.Text = "";
                passwordLogin.Text = "";
            }
            if (flag)
            {
                if (Bank.GetPerson(userLogin.Text).IsAuthenticated)
                {
                    frm = new Form2();
                    frm.thePerson = thePerson;
                    frm.Show();
                }
            }
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            Bank.GetPerson(userLogin.Text).Logout();
            frm.Close();            
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
            userLogin.Text = "";
            passwordLogin.Text = "";
        }
    }
}
