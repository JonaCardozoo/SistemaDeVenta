using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SistemaDeVentas
{
    [Serializable]
    public partial class Form1 : Form
    {
        int contador = 0;
        FAgregarProducto modal = new FAgregarProducto();
        Productos produ;
        Empresa empresa = new Empresa();
        double precioTotal = 0;
        string archivo = Application.StartupPath + "\\Serializacion.dat";
        FileStream fs;
        BinaryFormatter bf;
        DateTime fechaHora;
        FInventario fInventario = new FInventario();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cbProductos.SelectedIndex;
            if (idx != -1 && idx < empresa.listaImagenes.Count)
            {
                try
                {
                    Image imagenSeleccionada = Empresa.ByteArrayToImage(empresa.listaImagenes[idx]);
                    pbFotoProdu.Image = imagenSeleccionada;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar la imagen: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Índice seleccionado no válido.");
            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idx = cbProductos.SelectedIndex;

            if (idx != -1 && idx < empresa.listaProductos.Count) // Verificar que el índice es válido
            {
                try
                {
                    Productos seleccionProducto = empresa.listaProductos[idx];
                    produ = seleccionProducto;
                    lbPrecioTotal.Text = "";
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    long codigo = empresa.listaProductos[idx].Codigo;
                    Productos buscar = empresa.BuscarProducto(codigo);
                    if (buscar != null)
                    {
                        if (cantidad > buscar.Stock)
                        {
                            MessageBox.Show("No hay stock disponible");
                            return;
                        }
                    }
                    
                    produ = seleccionProducto;
                    lbPrecioTotal.Text = "";
                    produ.Cantidad = cantidad;
                    double precio = produ.CalcularPrecio();
                    precioTotal += precio;
                    string resumen = String.Format("Producto: {0} Precio ${1}", seleccionProducto.Nombre, precio);
                    lbPedido.Items.Add(resumen);
                    lbPrecioTotal.Text = "$" + precioTotal;

                    fInventario.dgInventario.Rows.Clear();
                    PintarDataGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto antes de agregar a la lista.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (File.Exists(archivo))
                {
                    using (fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
                    {
                        bf = new BinaryFormatter();
                        empresa.listaProductos = (List<Productos>)bf.Deserialize(fs);
                        empresa.listaImagenes = (List<byte[]>)bf.Deserialize(fs);
                    }

                    if (empresa.listaProductos == null)
                    {
                        empresa.listaProductos = new List<Productos>();
                    }

                    if (empresa.listaImagenes == null)
                    {
                        empresa.listaImagenes = new List<byte[]>();
                    }

                    cbProductos.Items.Clear();
                    foreach (Productos p in empresa.listaProductos)
                    {
                        cbProductos.Items.Add(p);
                    }
                    //PintarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                using (fs = new FileStream(archivo, FileMode.Create, FileAccess.Write))
                {
                    bf = new BinaryFormatter();
                    bf.Serialize(fs, empresa.listaProductos);
                    bf.Serialize(fs, empresa.listaImagenes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbFotoProdu_Click(object sender, EventArgs e)
        {
            FFotoProducto modal = new FFotoProducto();
            int idx = cbProductos.SelectedIndex;
            if (idx != -1 && idx < empresa.listaImagenes.Count)
            {
                try
                {
                    Image imagenSeleccionada = Empresa.ByteArrayToImage(empresa.listaImagenes[idx]);
                    modal.pbFotoGrande.Image = imagenSeleccionada;
                    modal.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar la imagen: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay foto para cargar.");
            }
        }

        private void pbFotoProdu_MouseHover(object sender, EventArgs e)
        {
            pbFotoProdu.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = cbProductos.SelectedIndex;
            FPagar fPagar = new FPagar();
            fPagar.lbPagar.Text = "$" + precioTotal.ToString();
            bool pagoValido = false;
            long codigo = empresa.listaProductos[idx].Codigo;
            Productos buscar = empresa.BuscarProducto(codigo);
            if (idx != -1)
            {
                while (!pagoValido)
                {
                    if (fPagar.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            double pagaCon = Convert.ToDouble(fPagar.txtPagaCon.Text);
                            if (pagaCon < precioTotal)
                            {
                                MessageBox.Show("Paga con menos de lo que sale el producto.");
                                continue;
                            }
                            double vueltoTotal = pagaCon - precioTotal;
                            fPagar.lbVuelto.Text = vueltoTotal.ToString();
                            lbPedido.Items.Clear();
                            lbPrecioTotal.Text = "$";
                            buscar.Stock -= Convert.ToInt32(txtCantidad.Text);
                            precioTotal = 0;
                            pagoValido = true;
                            fPagar.ShowDialog();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        pagoValido = true;
                    }


                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto antes de pagar");
            }
        }

        private void TSInventario_Click(object sender, EventArgs e)
        {
            fInventario.ShowDialog();
        }

        private void TSAgregarProducto_Click(object sender, EventArgs e)
        {
            if (modal.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    produ = new Productos(modal.txtNombreProducto.Text, Convert.ToDouble(modal.txtPrecioProducto.Text)
                    ,Convert.ToInt64(modal.txtCodigoProducto.Text), modal.txtCategoria.Text, modal.txtProveedor.Text
                    ,modal.txtEstado.Text, fechaHora.Date, Convert.ToInt32(modal.txtStock.Text));
                    empresa.AgregarProducto(produ, modal.pbImagen.Image);
                    cbProductos.Items.Add(produ);
                    FAgregadoConExito fAgregadoConExito = new FAgregadoConExito(6);
                    fAgregadoConExito.lbTexto.Text = "AGREGADO CON EXITO";
                    fAgregadoConExito.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TSModificarProducto_Click(object sender, EventArgs e)
        {
            FModificarProducto fModificarProducto = new FModificarProducto();
            int idx = cbProductos.SelectedIndex;
            if (idx != -1)
            {
                long codigo = empresa.listaProductos[idx].Codigo;
                Productos produc = empresa.BuscarProducto(codigo);

                if (produc != null)
                {
                    fModificarProducto.txtCodigoProducto.Text = produc.Codigo.ToString();
                    fModificarProducto.txtNombreProducto.Text = produc.Nombre.ToString();
                    fModificarProducto.txtPrecioProducto.Text = produc.Precio.ToString();
                    fModificarProducto.txtEstado.Text = produc.Estado.ToString();
                    fModificarProducto.txtProveedor.Text = produc.Proveedor.ToString();
                    fModificarProducto.txtStock.Text = produc.Stock.ToString();
                    fModificarProducto.txtCategoria.Text = produc.Categoria.ToString();
                }

                if (fModificarProducto.ShowDialog() == DialogResult.OK)
                {
                    produc.Codigo = Convert.ToInt64(fModificarProducto.txtCodigoProducto.Text);
                    produc.Nombre = fModificarProducto.txtNombreProducto.Text;
                    produc.Precio = Convert.ToDouble(fModificarProducto.txtPrecioProducto.Text);
                    produc.Estado = fModificarProducto.txtEstado.Text;
                    produc.Proveedor = fModificarProducto.txtProveedor.Text;
                    produc.Stock = Convert.ToInt32(fModificarProducto.txtStock.Text);
                    produc.Categoria = fModificarProducto.txtCategoria.Text;
                    fInventario.dgInventario.Rows.Clear();
                    PintarDataGrid();
                    PintarComboBox();
                    FAgregadoConExito fAgregadoConExito = new FAgregadoConExito(6);
                    fAgregadoConExito.ShowDialog();

                }
            }
            else
                MessageBox.Show("Seleccione el producto a modificar");
            
        }

        public void PintarDataGrid()
        {
            fInventario.dgInventario.Rows.Clear();
            foreach (Productos p in empresa.listaProductos)
            {
                fInventario.dgInventario.Rows.Add(new object[] { p.Codigo, p.Nombre, p.Precio, p.FechaCompra.Date, p.Categoria, p.Proveedor, p.Estado, p.Stock });
            }
        }

        public void PintarComboBox()
        {
            cbProductos.Items.Clear();
            foreach (Productos p in empresa.listaProductos)
            {
                cbProductos.Items.Add(p);
            }
        }

        private void TSEliminarProducto_Click(object sender, EventArgs e)
        {
            int idx = cbProductos.SelectedIndex;
            long codigo = empresa.listaProductos[idx].Codigo;
            Productos buscar = empresa.BuscarProducto(codigo);
            if (buscar != null)
            {
                if (idx != -1 && MessageBox.Show(String.Format("¿Seguro que desea eliminar {0} del sistema?", buscar.Nombre), "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    empresa.EliminarProducto(idx);
                    FAgregadoConExito fAgregadoConExito = new FAgregadoConExito(6);
                    fAgregadoConExito.lbTexto.Text = String.Format("EL PRODUCTO {0} \nELIMINADO CON EXITO",buscar.Nombre);
                    cbProductos.Items.Clear();
                    PintarDataGrid();
                    PintarComboBox();
                    fAgregadoConExito.ShowDialog(); 
                }
            }
            
            
        }
    }
}
