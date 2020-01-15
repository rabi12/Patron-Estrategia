using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class GuardadoFactory : IGuardadoFactory
    {
        public IAlmacenadorImagen crearInstanciaGuardado(string extension)
        {
            switch (extension)
            {
                case "PNG": return new AlmacenadorPNG();
                case "JPG": return new AlmacenadorJPG();
                default: return new AlmacenadorGIF();
            }

        }
    }
}
