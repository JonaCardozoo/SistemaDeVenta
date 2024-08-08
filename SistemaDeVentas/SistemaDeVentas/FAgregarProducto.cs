using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    [Serializable]
    public partial class FAgregarProducto : Form
    {
        public List<PictureBox> ListPictures = new List<PictureBox>();
        public FAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccione la imagen";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = Image.FromFile(ofd.FileName);
                ListPictures.Add(pbImagen);
            }
        }

        private void FAgregarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
