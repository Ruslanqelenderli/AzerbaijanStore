using AzerbaijanStore.DAL;
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
    public partial class FruitForm : Form
    {
        private Form _LoginForm;
        public FruitForm(Form form)
        {
            _LoginForm = form;
            InitializeComponent();

            List<Fruit> fruits = new List<Fruit>()
            {
                new Fruit{Id=1,Name="Apple",Type="Katya"},
                new Fruit{Id=2,Name="Pear",Type="Rogneda"},
                new Fruit{Id=3,Name="Pomegranate",Type="Goycay"}
                
            };
            int x = 28;
            int a = 1;
            foreach (Fruit fruit in fruits)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = fruit.Name;
                groupBox.Size = new Size(200, 112);
                groupBox.Location = new Point(x, 42);
                PictureBox picture = new PictureBox();
                if (a == 1) { 
                picture.Image = Image.FromFile(@"C:\Users\User\source\repos\AzerbaijanStore\AzerbaijanStore\Images\alma.jpg");
                  }
                if (a == 2)
                {
                    picture.Image = Image.FromFile(@"C:\Users\User\source\repos\AzerbaijanStore\AzerbaijanStore\Images\Armud.jpg");
                }
                if (a == 3)
                {
                    picture.Image = Image.FromFile(@"C:\Users\User\source\repos\AzerbaijanStore\AzerbaijanStore\Images\nar.jpg");
                }

                picture.Size= new Size(200, 200);
                
                
                picture.Location = new Point(x, 148);
                x += 275;
                a++;
               
                this.Controls.Add(groupBox);
                this.Controls.Add(picture);
            };
      }

        public string Local { get; }
        public string Foreign { get; }
        public object MyForms { get; }

        private void FruitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
