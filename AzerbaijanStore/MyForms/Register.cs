using AzerbaijanStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzerbaijanStore.MyForms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.registerControl1.btn_RegisterInRegister.Click += Btn_RegisterInRegister_Click;
        }

        private void Btn_RegisterInRegister_Click(object sender, EventArgs e)
        {
           
            if(!string.IsNullOrEmpty(registerControl1.txb_RegisterConfirmPassword.Text)&&
               !string.IsNullOrEmpty(registerControl1.txb_RegisterName.Text) &&
               !string.IsNullOrEmpty(registerControl1.txb_RegisterSurname.Text) &&
               !string.IsNullOrEmpty(registerControl1.txb_RegisterWorkID.Text)&&
               registerControl1.txb_RegisterPassword.Text==registerControl1.txb_RegisterConfirmPassword.Text)
            {
                User user = new User()
                {
                    Name = registerControl1.txb_RegisterName.Text,
                    Password = registerControl1.txb_RegisterPassword.Text,
                    Surname = registerControl1.txb_RegisterSurname.Text,
                    WorkID = registerControl1.txb_RegisterWorkID.Text
                };
                Database database = new Database();
                database.AddUser(user);
                if (database!=null)
                {
                    MessageBox.Show("Succesfully Registered!");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void registerControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
