using System;
using System.Collections.Generic;
namespace parcial_2
{

    class Program
    {

        static void Main(string[] args)
        {
            string seleccion;
            int dineroPagado=0;
            Producto Cocacola = new Producto(20, "Coca Cola", 3);
            Producto Manzana = new Producto(15, "Manzana", 5);
            Producto Refresco = new Producto(20, "Refresco", 8);
            Producto Agua = new Producto(10, "Agua", 5);
            Producto Ace = new Producto(100, "Ace", 10);
            Producto Leche = new Producto(80, "Leche", 13);
            Producto Pan = new Producto(50, "Pan", 11);
            Producto Azucar = new Producto(100, "Azucar", 7);
            Producto Jabon = new Producto(150, "Jabon", 19);
            Producto Cacao = new Producto(80, "Cacao", 7);
            Producto ProductoSeleccionado=null;
            bool continuar = true;
            Dispensador dispensador = new Dispensador();
            while (continuar)
            {
                bool seleccionProductoBien = true;
                Console.WriteLine("Seleccione su producto: " +
               "\n1:" + Cocacola.getNombre() + " Precio " + Cocacola.getPrecio() +
               "\n2:" + Manzana.getNombre() + " Precio " + Manzana.getPrecio() +
               "\n3:" + Refresco.getNombre() + " Precio " + Refresco.getPrecio()+
               "\n4:"+ Agua.getNombre()+" Precio "+Agua.getPrecio()+
               "\n5:"+Ace.getNombre()+" Precio "+Ace.getPrecio()+
               "\n6:"+Leche.getNombre()+" Precio "+Leche.getPrecio()+
               "\n7:" + Pan.getNombre() + " Precio " + Pan.getPrecio()+
               "\n8:" + Azucar.getNombre() + " Precio " + Azucar.getPrecio()+
               "\n9:" + Jabon.getNombre() + " Precio " + Jabon.getPrecio()+
               "\n10:" + Cacao.getNombre() + " Precio " + Cacao.getPrecio());

                seleccion = Console.ReadLine();
                switch (seleccion)
                {
                    case "1":
                        ProductoSeleccionado = Cocacola;
                        break;
                    case "2":
                        ProductoSeleccionado = Manzana;
                        break;
                    case "3":
                        ProductoSeleccionado = Refresco;
                        break;
                    case "4":
                        ProductoSeleccionado = Agua;
                        break;
                    case "5":
                        ProductoSeleccionado = Ace;
                        break;
                    case "6":
                        ProductoSeleccionado = Leche;
                        break;
                    case "7":
                        ProductoSeleccionado = Pan;
                        break;
                    case "8":
                        ProductoSeleccionado = Azucar;
                        break;
                    case "9":
                        ProductoSeleccionado = Jabon;
                        break;
                    case "10":
                        ProductoSeleccionado = Cacao;
                        break;
                    default:
                        seleccionProductoBien = false;
                        break;
                }
                if (seleccionProductoBien)
                {
                    Console.WriteLine("Inserte el dinero \n1:$5 \n2:$10 \n3:25 \n4:$50 \n5:$100 \n6:$200");
                    seleccion = Console.ReadLine();
                    switch (seleccion)
                    {
                        case "1":
                            dineroPagado = 5;
                            break;
                        case "2":
                            dineroPagado = 10;
                            break;
                        case "3":
                            dineroPagado = 25;
                            break;
                        case "4":
                            dineroPagado = 50;
                            break;
                        case "5":
                            dineroPagado = 100;
                            break;
                        case "6":
                            dineroPagado = 200;
                            break;
                        default:
                            Console.WriteLine("Esta opcion no esta disponible");
                            break;
                    }
                    if (dineroPagado < ProductoSeleccionado.getPrecio())
                    {
                        Console.WriteLine("No tiene suficiente dinero, tu cambio es de: " + dineroPagado);
                    }
                    else
                    {
                        int resultado = dispensador.buyProducto(ProductoSeleccionado, dineroPagado);
                        if (resultado == -1)
                        {
                            Console.WriteLine("No se puede comprar el producto, ya no tenemos ese producto");
                        }
                        else
                        {
                            Console.WriteLine("Tu cambio es de: " + resultado);

                        }
                    }
                }
                else
                {
                    Console.WriteLine("El producto seleccionado no existe");
                }
                
                Console.WriteLine("Desea continuar?\n1:Si\n2:No");
                seleccion = Console.ReadLine();
                switch (seleccion)
                {
                    case "2":
                        continuar = false;
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Coca colas restantes: " + dispensador.GetProductoRestante(Cocacola));
            Console.WriteLine("Coca colas vendidas: " + dispensador.GetProductosVendidos(Cocacola)+"\n");

            Console.WriteLine("Manzanas restantes: " + dispensador.GetProductoRestante(Manzana));
            Console.WriteLine("Manzanas vendidas: " + dispensador.GetProductosVendidos(Manzana)+"\n");

            Console.WriteLine("Refrescos restantes: " + dispensador.GetProductoRestante(Refresco));
            Console.WriteLine("Refrescos vendidas: " + dispensador.GetProductosVendidos(Refresco)+"\n");

            Console.WriteLine("Agua restantes: " + dispensador.GetProductoRestante(Agua));
            Console.WriteLine("Agua vendidas: " + dispensador.GetProductosVendidos(Agua)+"\n");

            Console.WriteLine("Ace restantes: " + dispensador.GetProductoRestante(Ace));
            Console.WriteLine("Ace vendidas: " + dispensador.GetProductosVendidos(Ace)+"\n");

            Console.WriteLine("Leche restantes: " + dispensador.GetProductoRestante(Leche));
            Console.WriteLine("Leche vendidas: " + dispensador.GetProductosVendidos(Leche)+"\n");

            Console.WriteLine("Pan restantes: " + dispensador.GetProductoRestante(Pan));
            Console.WriteLine("Pan vendidas: " + dispensador.GetProductosVendidos(Pan)+"\n");

            Console.WriteLine("Azucar restantes: " + dispensador.GetProductoRestante(Azucar));
            Console.WriteLine("Azucar vendidas: " + dispensador.GetProductosVendidos(Azucar)+"\n");

            Console.WriteLine("Jabon restantes: " + dispensador.GetProductoRestante(Jabon));
            Console.WriteLine("Jabon vendidas: " + dispensador.GetProductosVendidos(Jabon)+"\n");

            Console.WriteLine("Cacao restantes: " + dispensador.GetProductoRestante(Cacao));
            Console.WriteLine("Cacao vendidas: " + dispensador.GetProductosVendidos(Cacao)+"\n");

        }

    }
    class Producto
    {
        private int  precio,cantidad_vendida=0;
        private string nombre;
        private int existencia;


        public Producto(int precio, string nombre, int existencia)
        {
            this.precio=precio;
            this.nombre=nombre;
            this.existencia = existencia;

        }
        public void setPrecio(int precio)
        {
            this.precio = precio;

        }
        public int getPrecio()
        {
            return this.precio;

        }

        public void setcantidad_vendida()
        {
            this.cantidad_vendida++;
        }
        public int getcantidad_vendida()
        {
            return this.cantidad_vendida;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        public void setExistencia(int existencia)
        {
            this.existencia = existencia;
        }
        public int getExistencia()
        {
            return this.existencia;
        }

        public bool HasProducto()
        {
            if (this.existencia > 0)
            {
                return  true;
            }
            else
            {
                return false;
            }
        }
        public bool GetProducto()
        {
            if (HasProducto())
            {
                this.existencia--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Dispensador
    {
        public int buyProducto(Producto producto, int pago)
        {
            
            if (producto.GetProducto())
            {
                int devuelta = pago - producto.getPrecio();
                producto.setcantidad_vendida();
                return devuelta;
            }
            return -1;
            
        }
        public int GetProductoRestante(Producto producto)
        {
         return producto.getExistencia();

        }

        public int GetProductosVendidos(Producto producto)
        {
            return producto.getcantidad_vendida();
        }

    }

}
