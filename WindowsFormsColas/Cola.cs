using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsColas
{
    
    class Cola
    {
        //atributos
        private Nodo primero;
        private Nodo ultimo;
        //metodo constructor
        public Cola()
            {
            primero = null;
            ultimo = null;

            }
        //procedimiento insertar
        public void Insertar(string nombre)
        {
            //primero creamos el nodo
            Nodo nuevo = new Nodo();
            nuevo.info = nombre;
            nuevo.sig = null;
            //luego insertamos  
            if(primero==null)
            {
                primero = nuevo ;
                ultimo = nuevo;
            }
            else
            {
                ultimo.sig = nuevo;
                ultimo = nuevo;
            }

        }
        public string Sacar()
        {
            string cliente = "";
            if (primero == null)
            {
                cliente = " Null"; 
            }
            else
            {
                cliente = primero.info;
                primero = primero.sig;
            }
            return cliente;
        }
         //el metodo mostrar
        public string Mostrar()
        {
          
            string cadena = "";
            Nodo recorrido = new Nodo();
            recorrido = primero;
            if (recorrido == null)
            {
                cadena = "NULL";
            }
            else
            {
                while (recorrido != null  )
                {
                    cadena = cadena  + recorrido.info +"  " ;
                    recorrido = recorrido.sig;
                }
            }
               
            
            
            return cadena;
        }
    }
}
