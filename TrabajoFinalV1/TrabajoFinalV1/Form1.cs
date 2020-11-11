using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalV1
{

    public partial class Form1 : Form
    {
        DataTable Tabla2 = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        public int Saldo = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            Boton2doFormulario.Enabled = false;
            Tabla2.TableName = "Productos";
            Tabla2.Columns.Add("Comida", typeof(string));
            Tabla2.Columns.Add("Precio", typeof(string));
        }

       

        private void Ajuste ()
        {
            if (Saldo == 0)
            {
                BtnMostrarLista.Enabled = true;
                Boton2doFormulario.Enabled = false;
                
            }
            else if (Saldo > 0)
            {
                BtnMostrarLista.Enabled = false;

                Boton2doFormulario.Enabled = true;
            }
          
        }


        private void BtnMostrarLista_Click(object sender, EventArgs e)
        {
            
            

            dataGridView2.DataSource = Tabla2;

            if (checkBox1.Checked== true)
            {
                 Tabla2.Rows.Add();
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Comida"] = "Hamburguesa Simple C/ Papas";
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Precio"] = "$200";
                Saldo = Saldo + 200;
            }
            if (checkBox2.Checked == true)
            {
                Tabla2.Rows.Add();
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Comida"] = "Hamburguesa Doble C / Papas  ";
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Precio"] = "$250";
                Saldo = Saldo + 250;
            }
            if (checkBox3.Checked == true)
            {
                Tabla2.Rows.Add();
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Comida"] = "Hamburguesa Triple C / Papas";
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Precio"] = "$ 300";
                Saldo = Saldo + 300;
            }
            if (checkBox4.Checked == true)
            {
                Tabla2.Rows.Add();
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Comida"] = "Hamburguesa Doble Cheddar y Bacon";
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Precio"] = "$ 350";
                Saldo = Saldo + 350;
            }
            if (checkBox5.Checked == true)
            {
                Tabla2.Rows.Add();
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Comida"] = "Pizza de muzzarella";
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Precio"] = "$ 230";
                Saldo = Saldo + 230;
            }
            if (checkBox6.Checked == true)
            {
                Tabla2.Rows.Add();
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Comida"] = "Pizza de Fugazzeta";
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Precio"] = "$ 250";
                Saldo = Saldo + 250;
            }
            if (checkBox7.Checked == true)
            {
                Tabla2.Rows.Add();
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Comida"] = "Pizza de champiñones ";
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Precio"] = "$ 290";
                Saldo = Saldo + 290;
            }
            if (checkBox8.Checked == true)
            {
                Tabla2.Rows.Add();
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Comida"] = "Pizza de rucula";
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Precio"] = "$ 310";
                Saldo = Saldo + 310;
            }
            if (checkBox9.Checked == true)
            {
                Tabla2.Rows.Add();
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Comida"] = "Botella Agua mineral";
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Precio"] = "$60";
                Saldo = Saldo + 60;
            }
            if (checkBox10.Checked == true)
            {
                Tabla2.Rows.Add();
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Comida"] = "Botella de Coca Cola";
                Tabla2.Rows[Tabla2.Rows.Count - 1]["Precio"] = "$70";
                Saldo = Saldo + 70;
            }

            Ajuste();

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form VentanaCobro = new SegundaVentana(Saldo);
            VentanaCobro.ShowDialog();

            
            Tabla2.WriteXml(@"Productos.xml");


        }

    }

}
