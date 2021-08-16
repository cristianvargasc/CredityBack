using Models.Figura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ObtenerArea
    {
        public Circulo Circulo(Circulo circulo)
        {
            if (circulo.Radio == 0)
            {
                circulo.Area = "El radio ingresado no es un número valido";
            }
            else
            {
                circulo.Area = Convert.ToString(circulo.Pi * (circulo.Radio * circulo.Radio));
            }
            
            return circulo;
        }

        public Rectangulo Rectangulo(Rectangulo rectangulo)
        {
            if (rectangulo.Largo == 0 || rectangulo.Ancho == 0)
            {
                rectangulo.Area = "Los datos ingresados no son validos";
            }
            else
            {
                rectangulo.Area = Convert.ToString(rectangulo.Largo * rectangulo.Ancho);
            }
            
            return rectangulo;
        }
    }
}
