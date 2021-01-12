using AzerbaijanStore.Models;
using AzerbaijanStore.MyForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzerbaijanStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_RegisterInLogin_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm(this);
            register.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string workid = txb_WorkId.Text;
            string password = txb_Password.Text;
            Database database = new Database();
            bool result1=database.IfUserExist(workid, password);
            if (result1)
            {
                FruitForm fruitForm = new FruitForm(this);
                fruitForm.Show();
            }
            else
            {
                MessageBox.Show("failed");
            }
        }
    }
}
