namespace TrabajoFinalV1
{
    partial class SegundaVentana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltexto = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btn_Descuento = new System.Windows.Forms.Button();
            this.lblNuevoSaldo = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.lblNohaysaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltexto.Location = new System.Drawing.Point(9, 19);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(208, 17);
            this.lbltexto.TabIndex = 1;
            this.lbltexto.Text = "¿Con cuanto abona su comida?";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(12, 59);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(110, 20);
            this.txtPago.TabIndex = 2;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(12, 98);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btn_Descuento
            // 
            this.btn_Descuento.Location = new System.Drawing.Point(290, 7);
            this.btn_Descuento.Name = "btn_Descuento";
            this.btn_Descuento.Size = new System.Drawing.Size(101, 41);
            this.btn_Descuento.TabIndex = 5;
            this.btn_Descuento.Text = "Si tiene un cupon presione aqui";
            this.btn_Descuento.UseVisualStyleBackColor = true;
            this.btn_Descuento.Click += new System.EventHandler(this.btn_Descuento_Click);
            // 
            // lblNuevoSaldo
            // 
            this.lblNuevoSaldo.AutoSize = true;
            this.lblNuevoSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoSaldo.Location = new System.Drawing.Point(146, 101);
            this.lblNuevoSaldo.Name = "lblNuevoSaldo";
            this.lblNuevoSaldo.Size = new System.Drawing.Size(0, 15);
            this.lblNuevoSaldo.TabIndex = 6;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 134);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(347, 93);
            this.DGV.TabIndex = 8;
            // 
            // lblNohaysaldo
            // 
            this.lblNohaysaldo.AutoSize = true;
            this.lblNohaysaldo.Location = new System.Drawing.Point(146, 66);
            this.lblNohaysaldo.Name = "lblNohaysaldo";
            this.lblNohaysaldo.Size = new System.Drawing.Size(0, 13);
            this.lblNohaysaldo.TabIndex = 9;
            // 
            // SegundaVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 432);
            this.Controls.Add(this.lblNohaysaldo);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.lblNuevoSaldo);
            this.Controls.Add(this.btn_Descuento);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.lbltexto);
            this.Name = "SegundaVentana";
            this.Text = "Segunda Ventana";
            this.Load += new System.EventHandler(this.SegundaVentana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btn_Descuento;
        private System.Windows.Forms.Label lblNuevoSaldo;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label lblNohaysaldo;
    }
}