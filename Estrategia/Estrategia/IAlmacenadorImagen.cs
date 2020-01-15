using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    //Nombre de la imagen, menu para el tipo,  se ha guardado la imagen nombre. extension
    public interface IAlmacenadorImagen
    {
        string guardarImagen(string nombreImagen);
    }
}
