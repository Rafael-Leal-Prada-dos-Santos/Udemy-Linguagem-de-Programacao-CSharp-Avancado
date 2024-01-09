using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
namespace _01_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SINCRONO - FICA AGUARDANDO A CHEGADA DA INFORMAÇÃO E DEPOIS EXECUTA O RESTANTE DOCODIGO
        //ASSINCRONO - O CODIGO CONTINUA SENDO EXECUTANDO NORMALMENTE QUANDO A INFORMAÇÃO CHEGAR VAI EXECUTAR EM ALGUMA PARTE

        //TASK - TRANSFORMA O FLUXO EM ASSÍNCRONO
        //INTERFACE GRAFICA AINDA PODE SER UTILIZADA MAS O CODIGO É EXECUTADO EM PARALELO

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            string endereco = txtSite.Text;

            WebClient webClient = new WebClient();
            //string html = webClient.DownloadString(endereco);

            string html = await webClient.DownloadStringTaskAsync(new Uri(endereco));

            txtResultado.Text = html;
        }
    }
}
