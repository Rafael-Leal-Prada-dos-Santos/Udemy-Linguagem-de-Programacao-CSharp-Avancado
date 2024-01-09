using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_EntendendoEAplicandoDeletages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Btn.Click += Metodo1;
            Btn.Click += Metodo2;

        }

        private void Metodo2(object sender, EventArgs e)
        {
            MessageBox.Show("Metodo 1 executado");
        }

        private void Metodo1(object sender, EventArgs e)
        {
            MessageBox.Show("Metodo 2 executado");
        }
    }
}
