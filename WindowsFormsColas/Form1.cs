using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsColas
{
    
    public partial class Form1 : Form
    {
        //variables globales
        int a,b,c,d;
        //distintas colas para personas distintas
        Cola cola1 = new Cola();
        Cola cola2 = new Cola();
        Cola cola3 = new Cola();
        Cola cola4 = new Cola();
        Form3 abrir = new Form3();
      

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            a = a + 1;
            if (a < 10)
            {
                abrir.guardar_cola(" P00" + textBox1.Text + a);

            }
            else
            {

                abrir.guardar_cola(" P0" + textBox1.Text + a);
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {

            //esto abre el otro lado del windowsform1
            // abrir.textBox1.Text = cola1.Mostrar();
            //esto abre cada uno de los texbox donde se mostrara las colas
            
            abrir.mostrar2();
            abrir.mostrar3();
            abrir.mostrar4();
            abrir.mostrar5();
            abrir.video();
            abrir.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            b = b + 1;
            if (b <10)
            {
                abrir.guardar_cola2(" E00" + textBox2.Text + b);   
            }
            else
            {   
                abrir.guardar_cola2(" E0" + textBox2.Text + b);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            c = c + 1;
            if (c < 10)
            {
                abrir.guardar_cola3(" A00" + textBox3.Text + c);

            }
            else
            {

                abrir.guardar_cola3(" A0" + textBox3.Text + c);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            d = d + 1;
            if (d < 10)
            {
                abrir.guardar_cola4(" T00" + textBox4.Text + d);

            }
            else
            {

                abrir.guardar_cola4(" T0" + textBox4.Text + d);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
