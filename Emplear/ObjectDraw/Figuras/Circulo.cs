using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ObjectDraw.Figuras
{
    //una clase solo deriva de una clase, pero puede tener muchar interfaces
    //los constructores no se heredan
    public class Circulo : Figura, IRellenable
    {
        public float Radio { get; set; }

        /*public Rectangle Ocultar()
        {
            Visible = false;
            return _rect;
        }*/

        public override Shape CrearFiguraVisual()   //polimorfismo: override recibe de virtual
        {
            Ellipse circ = new Ellipse();

            circ.StrokeThickness = 3;      //grosor de la figura
            circ.Stroke = Brushes.Blue;   //color
            circ.Width = circ.Height = Radio * 2;

            return circ;
        }

        public void Rellenar(Brush color)
        {
            FiguraVisual.Fill = color;
        }
    }
}
