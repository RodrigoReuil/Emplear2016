using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ObjectDraw.Figuras
{
    //interfase, es el "comportamiento" q se aplica a determinadas clases o tipos de una gerarquia
    interface IRellenable
    {
        //solo metoso y propiedades (q son metodos)
        void Rellenar(Brush color); //decimos q cualquier clase q implemente esta interface, tiene q tener este metodo
    }
}
