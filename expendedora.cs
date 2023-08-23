using System;
using System.Threading; //necesaria para hacer la pausa de 2 seg

namespace ExpendedorG2_2024_1
{
    internal class expendedora
    {
        #region atributos
        //los atributos siempre la maquina le asigna un valor por dfault
        private string marca;
        private ushort cantproductos;
        private float precio;

        #endregion
        #region metodos
        private void limpiar()
        {
            Thread.Sleep(2000); // hace una pausa en la terminal de 2 segundos
            Console.Clear();

        }
        private void saludar()
        {
            Console.WriteLine("Bienvenido, elige un producto");

        }
        private string MostrarProducto()

        {
            Console.WriteLine("3A: Doritos\n3B: Churrumais");
            Console.WriteLine("Ingresa el codigo del producto");
            string codigo= Console.ReadLine(); // aqui el "codigo" esta dentro de un metodo, por lo que es una variable local, si no tuiera el mismo nombre que un atributo abria que inicializarlo dentro del metodo

            return codigo;
        }
        private void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "3A":
                    Console.WriteLine("precio:{0}", precio);
                    break;
                case "3B":
                    Console.WriteLine("precio:{0}", precio-6);
                    break;
                default:
                    Console.WriteLine("no ingresaste un codigo valido");
                    break;
            }

        }
        #endregion
        #region constructor
        public expendedora()
        {
            precio = 18;
            saludar();
            limpiar();
            marca = "AMS";
            Console.WriteLine("MARCA: {0}",marca);
            limpiar();
            string codigo=MostrarProducto();
            limpiar();
            MostrarPrecio(codigo);
        }
        public expendedora(bool mantenimiento) // puedo tener mas de un constructor con el mismo nombre pero que tenga parametros diferenetes
        {
            if (mantenimiento=true)
                Console.WriteLine("entrando a modo mantenimiento");
        }
        #endregion
    }

}
