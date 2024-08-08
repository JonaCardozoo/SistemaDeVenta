using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    public partial class FAgregadoConExito : Form
    {
        public FAgregadoConExito()
        {
            InitializeComponent();

        }

        public FAgregadoConExito(int segundos)
        {
            InitializeComponent();

            timer1.Interval = segundos * 1000;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}
