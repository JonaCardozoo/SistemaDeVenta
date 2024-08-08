using System;
using System.Collections.Generic;
using System.Drawing;

namespace SistemaDeVentas
{
    [Serializable]
    internal class Empresa
    {
        public List<Productos> listaProductos = new List<Productos>();
        public List<byte[]> listaImagenes = new List<byte[]>();

        public Empresa() { }

        public void AgregarProducto(Productos unProducto, Image imagen)
        {
            listaProductos.Add(unProducto);
            listaImagenes.Add(ImageToByteArray(imagen));
        }

        public Productos BuscarProducto(long codigo)
        {
            listaProductos.Sort();
            int indice = listaProductos.BinarySearch(new Productos("", 0, codigo,"","","",new DateTime(),0));
            if (indice >= 0)
            {
                return listaProductos[indice];
            }
            return null;
        }

        public void EliminarProducto(int orden)
        {
            listaProductos.RemoveAt(orden);
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}