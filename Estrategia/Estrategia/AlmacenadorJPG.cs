using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class AlmacenadorJPG : IAlmacenadorImagen
    {
        public string guardarImagen(string nombreImagen)
        {
            return "Se ha guardado la imagen: " + nombreImagen + ".JPG";
        }
    }
}
