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
    public partial class Form3 : Form
    {
       //creacion de distintas colas 
        Cola cola2 = new Cola();
        Cola cola3 = new Cola();
        Cola cola4 = new Cola();
        Cola cola5 = new Cola();
        public Form3()
        {
            InitializeComponent();
        }
        //boton borrado igual da
        private void Form3_Load(object sender, EventArgs e) 
        {
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //se guardan en distintos lugares las colas
        public void guardar_cola(string dato)
        {
            cola2.Insertar(dato);
            
        }
        public void guardar_cola2(string dato)
        {
            cola3.Insertar(dato);
        }
        public void guardar_cola3(string dato)
        {
            cola4.Insertar(dato);
        }
        public void guardar_cola4(string dato)
        {
            cola5.Insertar(dato);
        }
        //caja 1
        //PERSONAL GENERAL
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "NULL" && textBox3.Text == "NULL" && textBox2.Text == "NULL" && textBox1.Text == "NULL")
            {
                MessageBox.Show("No Hay Clientes");
            }
            //ABRE
            if (textBox1.Text != "NULL")
            {
                textBox1.BackColor = Color.Blue;
                MessageBox.Show(cola2.Sacar() + " -> C-1");
                textBox1.Text = cola2.Mostrar();
                textBox1.BackColor = Color.White;
            }
            else
                    if (textBox3.Text != "NULL")
            {
                textBox3.BackColor = Color.Blue;
                MessageBox.Show(cola4.Sacar() + " -> C-1");
                textBox3.Text = cola4.Mostrar();
                textBox3.BackColor = Color.White;
            }
            else
                    if (textBox2.Text != "NULL")
            {
                textBox2.BackColor = Color.Blue;
                MessageBox.Show(cola3.Sacar() + " -> C-1");
                textBox2.Text = cola3.Mostrar();
                textBox2.BackColor = Color.White;
            }
        }
        //esto es para mostrar en distintos lugares
        public void mostrar2()
        {
            
            textBox1.Text = cola2.Mostrar();
            
        }
        public void mostrar3()
        {
            textBox2.Text = cola3.Mostrar();
        }
        public void mostrar4()
        {
            textBox3.Text = cola4.Mostrar();
        }
        public void mostrar5()
        {
            textBox4.Text = cola5.Mostrar();
        }
        public void video()
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        //PERSONAL GENERAL 2
        //CAJA2
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "NULL" && textBox3.Text == "NULL" && textBox2.Text == "NULL" && textBox1.Text == "NULL")
            {
                MessageBox.Show("No Hay Clientes");
            }
            //ABRE
            if (textBox1.Text != "NULL")
            {
                textBox1.BackColor = Color.Blue;
                MessageBox.Show(cola2.Sacar() + " -> C-2");
                textBox1.Text = cola2.Mostrar();
                textBox1.BackColor = Color.White;
            } else
            if (textBox3.Text != "NULL")
            {
                textBox3.BackColor = Color.Blue;
                MessageBox.Show(cola4.Sacar() + " -> C-2");
                textBox3.Text = cola4.Mostrar();
                textBox3.BackColor = Color.White;
            }
            else
                    if (textBox2.Text != "NULL")
            {
                textBox2.BackColor = Color.Blue;
                MessageBox.Show(cola3.Sacar() + " -> C-2");
                textBox2.Text = cola3.Mostrar();
                textBox2.BackColor = Color.White;
            }
            
        }
        //MUJERES EMBARAZADAS
        //CAJA 3
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "NULL" && textBox3.Text == "NULL" && textBox2.Text == "NULL" && textBox1.Text == "NULL")
            {
                MessageBox.Show("No Hay Clientes");
            }
            //ABRE
            if (textBox2.Text != "NULL")
            {
                textBox2.BackColor = Color.Blue;
                MessageBox.Show(cola3.Sacar() + " -> C-3");
                textBox2.Text = cola3.Mostrar();
                textBox2.BackColor = Color.White;
            }
            else
                if (textBox3.Text != "NULL")
                {
                    textBox3.BackColor = Color.Blue;
                    MessageBox.Show(cola4.Sacar() + " -> C-3");
                    textBox3.Text = cola4.Mostrar();
                    textBox3.BackColor = Color.White;
            }
                else
                    if (textBox1.Text != "NULL")
                {
                    textBox1.BackColor = Color.Blue;
                    MessageBox.Show(cola2.Sacar() + " -> C-3");
                    textBox1.Text = cola2.Mostrar();
                    textBox1.BackColor = Color.White;
            }
            
        }
        //boton principal para adultos
        //CAJA 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "NULL" && textBox3.Text == "NULL" && textBox2.Text == "NULL" && textBox1.Text == "NULL")
            {
                MessageBox.Show("No Hay Clientes");
            }
            //ABRE
            if (textBox3.Text != "NULL")
                {
                    textBox3.BackColor = Color.Blue;
                    MessageBox.Show(cola4.Sacar() + " -> C-4");
                    textBox3.Text = cola4.Mostrar();
                    textBox3.BackColor = Color.White;
            }
                else
                    if ( textBox2.Text != "NULL")
                {
                textBox2.BackColor = Color.Blue;
                MessageBox.Show(cola3.Sacar() + " -> C-4");
                textBox2.Text = cola3.Mostrar();
                textBox2.BackColor = Color.White;
            }
                else
                    if (textBox1.Text != "NULL")
                {
                textBox1.BackColor = Color.Blue;
                MessageBox.Show(cola2.Sacar() + " -> C-4");
                textBox1.Text = cola2.Mostrar();
                textBox1.BackColor = Color.White;
            }
                 
        }
        //CAJA 5
        //este boton sera especial para plataformas
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "NULL" && textBox3.Text == "NULL" && textBox2.Text == "NULL" && textBox1.Text == "NULL")
            {
                MessageBox.Show("No Hay Clientes");
            }
            if (textBox4.Text != "NULL")
            {
                textBox4.BackColor = Color.Blue;
                MessageBox.Show("" + cola5.Sacar() + " -> C-5");
                textBox4.Text = cola5.Mostrar();
                textBox4.BackColor = Color.White;
            }
           
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
