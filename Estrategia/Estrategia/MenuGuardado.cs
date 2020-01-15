using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class MenuGuardado
    {
        
        public void desplegarMenu()
        {
            bool flag = false;
            do
            {
                Console.Clear(); //Limpiar la pantalla
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione una opcion...");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[A] Guardar Imagen");
                Console.WriteLine("[Esc] Salirtnn");
                Console.ForegroundColor = ConsoleColor.White;

                ConsoleKeyInfo op = Console.ReadKey(true);

                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Ud seleccionó la opción Guarda Imagen");

                        string resultado = this.solicitarGuardarImagen();

                        Console.WriteLine(resultado);
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        flag = true;

                        break;
                }
            } while (!flag);
        }



        private string solicitaNombreImagen()
        {
            Console.WriteLine("Introduce el nombre de la imagen");
            string nombre = Convert.ToString(Console.ReadLine());
            return nombre;
        }
        
        private string solicitaExtensionImagen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Selecciona tipo de archivo:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PNG");
            Console.WriteLine("JPG");
            Console.WriteLine("GIF");
            Console.ForegroundColor = ConsoleColor.White;
            string extension = Convert.ToString(Console.ReadLine());
            return extension;
        }

        private string solicitarGuardarImagen()
        {
            string nombre = this.solicitaNombreImagen();

            string extension = this.solicitaExtensionImagen();

            IGuardadoFactory fabrica = new GuardadoFactory();
            IAlmacenadorImagen guardador = fabrica.crearInstanciaGuardado(extension);
            string resultado = guardador.guardarImagen(nombre);

            return resultado;
        }
    }
}
