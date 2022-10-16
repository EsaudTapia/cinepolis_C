using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinepolis_C
{

    public partial class Form1 : Form
    {

        ComprarBoletos ConsultarCompra = new ComprarBoletos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor;
            bool esNumero = true;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                label6.Text = "Por favor llene todos los campos ";
                textBox4.Text = "";

            } else if  (!(int.TryParse(textBox2.Text, out valor)) || !(int.TryParse(textBox3.Text, out valor)) ) {

                label6.Text = "ingrese numeros en los campos de los  boletos y compradores ";
                textBox4.Text = "";

            }
            else {





            label6.Text = "";


            String nombre = Convert.ToString(textBox1.Text);
            int cantCompradores = Convert.ToInt32(textBox2.Text);
            int cantBoletos = Convert.ToInt32(textBox3.Text);

            int cineco = 0;

            if (radioButton1.Checked)
            {
                cineco = 1;

            }


            if (radioButton2.Checked)
            {
                cineco = 0;

            }




            ConsultarCompra.Nombre = nombre;
            ConsultarCompra.CantidadCompradores = cantCompradores;
            ConsultarCompra.CantidadBoletos = cantBoletos;
            ConsultarCompra.Cineco = cineco;

                if (cantBoletos < cantCompradores)
                {
                    label8.Text = "¡cantidad de boletos debe ser mayor!";
                    textBox4.Text = "";
                } else{

                    //para la cantidad de compradores
                    if ((cantCompradores * 7) - cantBoletos >= 0)
                    {
                        ConsultarCompra.CalcularPago();

                        textBox4.Text = Convert.ToString(ConsultarCompra.Resultado);
                        label5.Text = nombre + " debe pagar";
                        label8.Text = "";

                    }
                    else
                    {
                        label8.Text = "¡solo se permite 7 boletos por comprador!";
                        textBox4.Text = "";

                    }


                }

                }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label8.Text = "";
            label5.Text = "Debe pagar";
            label6.Text = "";
            radioButton2.Checked = true; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
