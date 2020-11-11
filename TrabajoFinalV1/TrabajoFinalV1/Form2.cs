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
    public partial class SegundaVentana : Form
    {
        DataTable Tabla = new DataTable() ;
        private int Saldo;
        public SegundaVentana(int Saldo)
  
        {
            this.Saldo = Saldo;
            InitializeComponent();
        }



        private void SegundaVentana_Load(object sender, EventArgs e)
        {

               
            Tabla.TableName = "Lista";
            Tabla.Columns.Add("Deuda", typeof(string));
            Tabla.Columns.Add("Abono", typeof(string));
            Tabla.Columns.Add("Vuelto", typeof(string));
            DGV.DataSource = Tabla;

            Tabla.Rows.Add();
            Tabla.Rows[0]["Deuda"] = "Su saldo $" + Saldo;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32 (txtPago.Text) > Saldo)
            {
                btn_Descuento.Enabled = false;
                btnPagar.Enabled = false;
                lblNohaysaldo.Visible = false;

                Tabla.Rows[0]["Abono"] = "Abona con" + txtPago.Text;
                Tabla.WriteXml(@"TicketFinal");
                           
            }
            else if (System.Convert.ToInt32(txtPago.Text) < Saldo)
            {
                lblNohaysaldo.Text = "Saldo insuficiente , intente de nuevo por favor";
            }
            else if (Saldo == System.Convert.ToInt32 (txtPago.Text))
            {
               
                Tabla.Rows[0]["Abono"] = "Abona con" + txtPago.Text;
                Tabla.WriteXml(@"TicketFinal");

                btn_Descuento.Enabled = false;
                btnPagar.Enabled = false;
            }
             int vueltoFila = System.Convert.ToInt32(txtPago.Text) - Saldo;
            if (vueltoFila > 0)
            {
                Tabla.Rows[0]["Vuelto"] = "$" +  System.Convert.ToString (vueltoFila);
            }
            else if (vueltoFila == 0)
            {
                Tabla.Rows[0]["Vuelto"] = "Ha Abonado justo";
            }
        }

        private void btn_Descuento_Click(object sender, EventArgs e)
        {
            BE Descuento = new BE();
            Descuento.ValorDescuento = Saldo;
            lblNuevoSaldo.Text =  " Su descuento es de $ "  + System.Convert.ToString(Descuento.Cupon());
           // lblmostrarnuevosaldo.Text = "Su saldo a pagar ahora es de " + (Saldo - Descuento.Cupon());
            Saldo = Saldo - (Descuento.Cupon());
            Tabla.Rows[0]["Deuda"] = "Su saldo $" + Saldo;

            btn_Descuento.Enabled = false;


           
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            if (txtPago.Text != "")
            {
                btnPagar.Enabled = true;
            }
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion Control = new Validacion();
            Control.SoloNumeros(e);
        }
    }
    // Falta agregar un control donde me aparezca bloqueada la barra de pagar si esta vacio el textbox

    
}
