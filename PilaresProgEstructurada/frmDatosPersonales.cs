﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaresProgEstructurada
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //estructuras secuenciales
            string saludo = "";//cadena de caracteres
            saludo = this.txtNombres.Text + " " + this.txtApellidos.Text;
            MessageBox.Show("Hola: "  + saludo);

            //estructuras repetitivas
            string aux = "";
            for (int i=1; i<=10; i++)
            {
                //aux = aux + saludo + System.Environment.NewLine;
                aux += saludo + System.Environment.NewLine;
            }

            //estructuras selectivas
            int a = 100;
            int b = 20;
            if (a > b)
                aux = aux + "a mayor b";
            else
                aux = aux + "b mayor que a";

            this.txtResultado.Text = aux;
            this.getsaludos(saludo);//llamada a la funcion
            this.lbNombres.Text = this.lbNombres.Text + " -->" + this.getCalculos(a, b).ToString();
        }

    //procedimientos = funciones
    //las funciones devuelven valores
    //el procedimiento es una funcion que no devuelve valor
    void getsaludos(string nombres)
        {
            this.lbNombres.Text = "Uso de funcion que no devuelve valor (" + nombres + ")";
        }

    //funcion que devuelve el valor

    double getCalculos(int a, int b)
        {
            double resul = 0;
            resul = (a * 10) / (b * 2.5);
            return resul;
        }
        //tipos de datos en C#
        //operadores logicos
        //operadores relacionales
        //operadores aritmeticos
        //estructuras repetitivas

        //pasar parametros por valor
        //cuando se pasa una copia de la variable

        void ejemploPasoValor(int x)
        {
            x = x + 100;
            MessageBox.Show("El nuevo valor de x: " + x.ToString());
        }

        void ejemploPasoReferencia(ref int a)
        {//la funcion recibe la variable original (direccion de memoria)
            //cualquier cambio en esta variable se refleja en la original
            a = a + 100;
            MessageBox.Show("El nuevo valor de x: " + a.ToString());
        }

        private void btnPasoValor_Click(object sender, EventArgs e)
        {
            int x = 5; int y = 200;
            //ejemploPasoValor(x);
            ejemploPasoReferencia(ref x);
            this.ejemploParametrosOpcionales(x,y);
            this.txtValor.Text = x.ToString();
        }
        //paso de parametros opcionales
        void ejemploParametrosOpcionales(int x, int y=10)
        {
            x = x + y;
            MessageBox.Show("Parametro opcional" + y.ToString());
            MessageBox.Show("El nuevo valor de x:" + x.ToString()); 
        }
    }
}
