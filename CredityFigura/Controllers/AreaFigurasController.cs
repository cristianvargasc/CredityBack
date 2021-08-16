using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Figura;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CredityFigura.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaFigurasController : Controller
    {
        [HttpGet]
        [Route("Circulo/{Radio}")]
        public Circulo AreaCirculo()
        {
            Circulo circulo = new Circulo();

            string RadioObtenido = RouteData.Values["Radio"].ToString().Replace(".",",");

            try
            {
                circulo.Radio = Convert.ToDouble(RadioObtenido);
            }
            catch (Exception)
            {
                try
                {
                    circulo.Radio = Convert.ToInt32(RadioObtenido);
                }
                catch (Exception)
                {
                    circulo.Radio = 0;
                }
            }
            finally
            {
                ObtenerArea obtenerArea = new ObtenerArea();

                circulo = obtenerArea.Circulo(circulo);
            }
            return circulo;
        }

        [HttpGet]
        [Route("Rectangulo/{largo}/{ancho}")]
        public Rectangulo AreaRectangulo()
        {
            Rectangulo rectangulo = new Rectangulo();

            string largo = RouteData.Values["largo"].ToString().Replace(".", ",");
            string ancho = RouteData.Values["ancho"].ToString().Replace(".", ",");

            try
            {
                rectangulo.Largo = Convert.ToDouble(largo);
                rectangulo.Ancho = Convert.ToDouble(ancho);
            }
            catch (Exception)
            {
                try
                {
                    rectangulo.Largo = Convert.ToInt32(largo);
                    rectangulo.Ancho = Convert.ToInt32(ancho);
                }
                catch (Exception)
                {
                    rectangulo.Largo = 0;
                    rectangulo.Ancho = 0;
                }
            }
            finally
            {
                ObtenerArea obtenerArea = new ObtenerArea();

                rectangulo = obtenerArea.Rectangulo(rectangulo);
            }
            return rectangulo;
        }
    }
}
