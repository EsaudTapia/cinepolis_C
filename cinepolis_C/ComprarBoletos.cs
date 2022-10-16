using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinepolis_C
{
    class ComprarBoletos
    {
        private String nombre;
        private int cantidadBoletos;
        private Double resultado;
        private int cantidadCompradores;
        private int cineco;

        public int CantidadBoletos { get => cantidadBoletos; set => cantidadBoletos = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        public int CantidadCompradores { get => cantidadCompradores; set => cantidadCompradores = value; }
        public int Cineco { get => cineco; set => cineco = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public void CalcularPago()
        {
            if (this.CantidadBoletos > 5){
                Double descuento;
                descuento = 0.15 * (this.CantidadBoletos * 47);
                if (this.Cineco == 1)
                {
                    
                    Resultado = (this.CantidadBoletos * 47) - descuento -(((this.CantidadBoletos * 47) - descuento)*0.10);
                   
                }
                else
                {
                    this.Resultado = (this.CantidadBoletos * 47) - descuento;
                }
            }

            if (this.CantidadBoletos >= 3 && this.CantidadBoletos <=5)
            {
                Double descuento;
                descuento = 0.10 * (this.CantidadBoletos * 47);
                if (this.Cineco == 1)
                {

                    Resultado = (this.CantidadBoletos * 47) - descuento - (((this.CantidadBoletos * 47) - descuento) * 0.10);

                }
                else
                {
                    this.Resultado = (this.CantidadBoletos * 47) - descuento;
                }
            }


            if (this.CantidadBoletos >=1 && this.CantidadBoletos <= 2) {

                if (this.Cineco == 1)
                {

                    Resultado = ((this.CantidadBoletos * 47)) - ((this.CantidadBoletos*47)*0.10);

                }
                else
                {
                    this.Resultado = this.CantidadBoletos * 47;
                }

               

            }

                

        }


    }
}
