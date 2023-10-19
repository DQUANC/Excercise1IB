using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dquan_1IB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ejercicio 1

        private void button1_Click(object sender, EventArgs e)
        {

            int num = Convert.ToInt32(textBox1.Text);


            StringBuilder tree = new StringBuilder();

            for (int i = 0; i < num; i++)
            {
                // Agregar espacios en blanco.
                for (int j = num - i; j > 0; j--)
                {
                    tree.Append(" ");
                }

                // Agregar asteriscos.
                for (int k = 0; k < i * 2 + 1; k++)
                {
                    tree.Append("*");
                }

                // Agregar una nueva línea.
                tree.AppendLine();
            }

            label2.Text = tree.ToString();

        }

        // Ejercicio 2
       
        private void button2_Click(object sender, EventArgs e)
        {

            int num = Convert.ToInt32(textBox2.Text);

            switch (num)
            {
                case 0:
                    label3.Text = label3.Text + "No hay establecido un valor definido\r\npara el tipo de bomba";
                break;
                case 1:
                    label3.Text = label3.Text + "La bomba es una bomba de agua";
                break;
                case 2:
                    label3.Text = label3.Text + "La bomba es una bomba de gasolina";
                break;
                case 3:
                    label3.Text = label3.Text + "La bomba es una bomba de hormigón";
                break;
                case 4:
                    label3.Text =   label3.Text + "La bomba es una bomba de pasta alimenticia";
                break;
                default:
                    label3.Text = label3.Text + "No existe un valor\r\nválido para tipo de bomba";
                break;

            }

        }

        // hasta aqui finaliza la tarea original



        // Ejercicio 3
            // Area de un triangulo
        private void button3_Click(object sender, EventArgs e)
        {
            int bas = Convert.ToInt32(textBox3.Text);
            int hei = Convert.ToInt32(textBox4.Text);
            int area;

            area = (bas * hei)/2 ;

            label5.Text = label5.Text + area;

        }

            // Perimetro de un cuadrado
        private void button4_Click(object sender, EventArgs e)
        {
            int lado = Convert.ToInt32(textBox5.Text);
            int per = lado * 4;

            label11.Text = label11.Text + per;

        }

            // Area de un cuadrado
        private void button5_Click(object sender, EventArgs e)
        {
            int lado = Convert.ToInt32(textBox5.Text);
            int area = lado * lado;

            label11.Text = label11.Text + area;
        }
    }
}
