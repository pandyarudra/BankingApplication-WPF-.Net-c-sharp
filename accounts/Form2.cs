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
    public partial class Form2 : Form
    {
        Person p;
        Account a;
        CheckingAccount ca;
        SavingAccount sa;
        VisaAccount va;
        string type = "";
        string accountNum = "";
        public Form2()
        {
            InitializeComponent();
            stTime.Text = DateTime.Now.ToShortTimeString();
        }
       public Person thePerson
        {
            set { p = value; stName.Text = p.Name + " is logged-in！"; }
        }
        private void accountsDisplay_Click_1(object sender, EventArgs e)
        {
            allAccountsLst.DataSource = Bank.returnAccounts(p);
        }

        private void accountSelect_Click_1(object sender, EventArgs e)
        {
            if (allAccountsLst.SelectedValue != null)
            {
                accountNum = allAccountsLst.SelectedValue.ToString();
                stAcc.Text = accountNum;               
                a = Bank.GetAccount(accountNum);
                type = accountNum.Substring(0, 2);
                switch (type)
                {
                    case "CK":
                        ca = (CheckingAccount)a;
                        transDP.Text = "Deposit";
                        transWD.Text = "Withdraw";
                        break;
                    case "SV":
                        sa = (SavingAccount)a;
                        transDP.Text = "Deposit";
                        transWD.Text = "Withdraw";
                        break;
                    case "VS":
                        va = (VisaAccount)a;
                        transDP.Text = "Pay";
                        transWD.Text = "Purchase";
                        break;
                }
            }
        }

        private void detailDisplay_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "CK":
                    detailDisplayFunction(ca);
                    break;
                case "SV":
                    detailDisplayFunction(sa);
                    break;
                case "VS":
                    detailDisplayFunction(va);
                    break;
            }
        }
        public void detailDisplayFunction(Account a)
        {
            string value = a.ToString();
            char delimiter = '%';
            string[] substrings = value.Split(delimiter);
            accountDetail.DataSource = substrings;
        }
        private void monthlyReport_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "CK":
                    ca.PrepareMonthlyReport();
                    detailDisplayFunction(ca);
                    break;
                case "SV":
                    sa.PrepareMonthlyReport();
                    detailDisplayFunction(sa);
                    break;
                case "VS":
                    va.PrepareMonthlyReport();
                    detailDisplayFunction(va);
                    break;
            }
        }
        private void accountAddClear_Click(object sender, EventArgs e)
        {
            rBtnCK.Checked = false;
            rBtnSA.Checked = false;
            rBtnVS.Checked = false;
            iniBalance.Text = "";
            iniHolder.Text = "";
        }

        private void accountAddConfirm_Click_1(object sender, EventArgs e)
        {
            bool flag = true;
            try { Bank.GetPerson(iniHolder.Text); }
            catch (AccountException et)
            {
                MessageBox.Show(et.Message);
                flag = false;
            }
            if (flag)
            {
                if (rBtnCK.Checked == false && rBtnSA.Checked == false && rBtnVS.Checked == false)
                {
                    MessageBox.Show("Account type must be selected!");
                }
                else
                {
                    if (IsNumeric(iniBalance.Text))
                        MessageBox.Show("Balance must be a number!");
                    else
                    {
                        if (double.Parse(iniBalance.Text) < 0)
                        {
                            MessageBox.Show("Initial balance must be number and greater than 0!");
                        }
                        else
                        {
                            if (rBtnCK.Checked)
                            {
                                CheckingAccount caAdd = new CheckingAccount(double.Parse(iniBalance.Text));
                                Bank.addAccount(caAdd);
                                caAdd.AddUser(Bank.GetPerson(iniHolder.Text));
                                MessageBox.Show("Your checking account has been created!");
                            }
                            else if (rBtnSA.Checked)
                            {
                                SavingAccount saAdd = new SavingAccount(double.Parse(iniBalance.Text));
                                Bank.addAccount(saAdd);
                                saAdd.AddUser(Bank.GetPerson(iniHolder.Text));
                                MessageBox.Show("Your saving account has been created!");
                            }
                            else if (rBtnVS.Checked)
                            {
                                VisaAccount vaAdd = new VisaAccount(double.Parse(iniBalance.Text));
                                Bank.addAccount(vaAdd);
                                vaAdd.AddUser(Bank.GetPerson(iniHolder.Text));
                                MessageBox.Show("Your visa account has been created!");
                            }
                        }
                    }

                }
            }
        }
        public bool IsNumeric(string TextBoxValue)
        {
            try
            {
                double i = double.Parse(TextBoxValue);
                return false;
            }
            catch
            {
                return true;
            }
        }
        //double.TryParse(string, double x)
        private void button4_Click_1(object sender, EventArgs e)
        {
            if ((nameBox.Text == "") || (sinBox.Text == ""))
                MessageBox.Show("Name and SIN cannot be empty!");
            else
            {
                if (IsNumeric(sinBox.Text))
                    MessageBox.Show("SIN must be a number!");
                else
                {
                    Person g = new Person(nameBox.Text, sinBox.Text);
                    Bank.addUser(g);
                    nameBox.Text = "";
                    sinBox.Text = "";
                    MessageBox.Show("User has been added!");
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            nameBox.Text = "";
            sinBox.Text = "";
        }
        private void transConfirm_Click_1(object sender, EventArgs e)
        {
            if (type != "")
            {
                if (transDP.Checked)
                {
                    switch (type)
                    {
                        case "CK":
                            ca.Deposit(double.Parse(transAmount.Text), p);
                            break;
                        case "SV":
                            sa.Deposit(double.Parse(transAmount.Text), p);
                            break;
                        case "VS":
                            va.DoPayment(double.Parse(transAmount.Text), p);
                            break;
                    }
                }
                else
                {
                    switch (type)
                    {
                        case "CK":
                            try { ca.Withdraw(double.Parse(transAmount.Text), p); }
                            catch (AccountException et)
                            {
                                MessageBox.Show(et.Message);
                            }
                            break;
                        case "SV":
                            try { sa.Withdraw(double.Parse(transAmount.Text), p); }
                            catch (AccountException et)
                            {
                                MessageBox.Show(et.Message);
                            }
                            break;
                        case "VS":
                            try { va.DoPurchase(double.Parse(transAmount.Text), p); }
                            catch (AccountException et)
                            {
                                MessageBox.Show(et.Message);
                            }
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No account has been selected!");
            }
        }
    }
}

