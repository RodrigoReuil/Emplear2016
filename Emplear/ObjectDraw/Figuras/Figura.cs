using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace ObjectDraw.Figuras
{
    public abstract class Figura    //abstract: me hacerugo de q no se pueda hacer: figura f = new figura(); "no hay instancia"
    {
        public double X { get; set; }
        public double Y { get; set; }

        public bool Visible { get; set; }

        protected Shape FiguraVisual { get; set; }  //protected: solo lo ven los heredados

        public Shape Mostrar()
        {
            if (FiguraVisual == null)
            {
                //creamos forma
                FiguraVisual = CrearFiguraVisual();
            }

            Visible = true;

            return FiguraVisual;
        }

        //polimorfismo: virtual es el inicio y override es el enlace final
        //Virtual enlaza en tiempo de ejecucion
        /*public virtual Shape CrearFiguraVisual()
        {
            return null;
        }*/
        //el metodo abstract ya es VIRTUAL
        public abstract Shape CrearFiguraVisual();

        /*public Rectangle Ocultar()
        {
            Visible = false;
            return FiguraVisual;
        }*/
    }
}
