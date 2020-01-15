using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface  IGuardadoFactory
    {
        IAlmacenadorImagen crearInstanciaGuardado(string extension);
    }
}
