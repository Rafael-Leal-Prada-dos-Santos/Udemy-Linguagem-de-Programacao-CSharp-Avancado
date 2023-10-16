using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_DelegateMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //BtnClick.Click += delegate (object sender, EventArgs e)
            //{
            //    MessageBox.Show("Olá, fui clicado!");
            //};

            BtnClick.Click += delegate
            {
                MessageBox.Show("Olá, fui clicado!");
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
