using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _03_Eventos.Lib;
using _03_Eventos.Lib.Mensageiro;

namespace _03_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnVideoEncode.Click += EventodeClick;
        }


        /* Evento é utilizado para proteger uma ação que é feita no componente
         * Você que controla quem escreve nele.
         * Os eventos não podem ser redefinidos! você só pode definir
         * o que ele irá acionar ao ocorrer.
         * Os metodos que vão ser vinculados a um evento ele tem que ter um padrão
         */
        public void EventodeClick(object sender, EventArgs e) 
        {
            Video video = new Video() { Nome = "video.mp4" };

            VideoEncode vid = new VideoEncode();
            vid.Encoded += new Email().EnviarMensagem;
            vid.Encoded += new SMS().EnviarMensagem;

            vid.Encode(video);
        }
    }
}
