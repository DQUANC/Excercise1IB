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
        /* Descripcion       
         Cree un programa que dibuje un árbol dado un número del 1 al 5
            1. Ejemplo: si se ingresa el número 4 debe dibujar
            *
            **
            ***
            ****
         */

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
        /* Descripcion   
         Estás desarrollando una aplicación donde trabajas con tipos de motor (suponemos que se trata
        del tipo de motor de una bomba para mover fluidos). Define una variable tipoMotor e ingresa un
        valor a través de una caja de texto. Los valores posibles son 1, 2, 3, 4. A través de un condicional
        switch haz lo siguiente:
       
        a) Si el tipo de motor es 0, mostrar un mensaje indicando “No hay establecido un valor definido
        para el tipo de bomba”.
       
        b) Si el tipo de motor es 1, mostrar un mensaje indicando “La bomba es una bomba de agua”.
        
        c) Si el tipo de motor es 2, mostrar un mensaje indicando “La bomba es una bomba de gasolina”.
       
        d) Si el tipo de motor es 3, mostrar un mensaje indicando “La bomba es una bomba de
        hormigón”.
       
        e) Si el tipo de motor es 4,mostrar un mensaje indicando “La bomba es una bomba de pasta
        alimenticia”.
       
        f) Si no se cumple ninguno de los valores anteriores mostrar el mensaje “No existe un valor
        válido para tipo de bomba”
        */
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

    }
}
