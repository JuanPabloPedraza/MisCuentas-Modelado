namespace MisCuentas_Modelado
{
    partial class Form1
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.cBoxMovimientos = new System.Windows.Forms.ComboBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblTituloSaldo = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPago = new System.Windows.Forms.Button();
            this.lblNuevoSaldo = new System.Windows.Forms.Label();
            this.txtNuevoSaldo = new System.Windows.Forms.TextBox();
            this.btnSaldoNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 30);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(64, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Movimiento:";
            // 
            // cBoxMovimientos
            // 
            this.cBoxMovimientos.FormattingEnabled = true;
            this.cBoxMovimientos.Items.AddRange(new object[] {
            "Agua",
            "Cobro",
            "Comida",
            "Compra",
            "Extraccion",
            "Gas",
            "Luz",
            "Pago",
            "Sueldo",
            "Supermercado",
            "Transferencia"});
            this.cBoxMovimientos.Location = new System.Drawing.Point(82, 30);
            this.cBoxMovimientos.Name = "cBoxMovimientos";
            this.cBoxMovimientos.Size = new System.Drawing.Size(121, 21);
            this.cBoxMovimientos.TabIndex = 1;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(31, 75);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(45, 13);
            this.lblImporte.TabIndex = 2;
            this.lblImporte.Text = "Importe:";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(82, 69);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 3;
            // 
            // lblTituloSaldo
            // 
            this.lblTituloSaldo.AutoSize = true;
            this.lblTituloSaldo.Location = new System.Drawing.Point(576, 30);
            this.lblTituloSaldo.Name = "lblTituloSaldo";
            this.lblTituloSaldo.Size = new System.Drawing.Size(67, 13);
            this.lblTituloSaldo.TabIndex = 4;
            this.lblTituloSaldo.Text = "Saldo Actual";
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoActual.Location = new System.Drawing.Point(594, 54);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(36, 39);
            this.lblSaldoActual.TabIndex = 5;
            this.lblSaldoActual.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 274);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(82, 102);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(75, 23);
            this.btnPago.TabIndex = 7;
            this.btnPago.Text = "Pagar";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // lblNuevoSaldo
            // 
            this.lblNuevoSaldo.AutoSize = true;
            this.lblNuevoSaldo.Location = new System.Drawing.Point(235, 54);
            this.lblNuevoSaldo.Name = "lblNuevoSaldo";
            this.lblNuevoSaldo.Size = new System.Drawing.Size(122, 13);
            this.lblNuevoSaldo.TabIndex = 8;
            this.lblNuevoSaldo.Text = "Ingrese Gasto Permitido:";
            // 
            // txtNuevoSaldo
            // 
            this.txtNuevoSaldo.Location = new System.Drawing.Point(362, 51);
            this.txtNuevoSaldo.Name = "txtNuevoSaldo";
            this.txtNuevoSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoSaldo.TabIndex = 9;
            // 
            // btnSaldoNuevo
            // 
            this.btnSaldoNuevo.Location = new System.Drawing.Point(350, 77);
            this.btnSaldoNuevo.Name = "btnSaldoNuevo";
            this.btnSaldoNuevo.Size = new System.Drawing.Size(125, 29);
            this.btnSaldoNuevo.TabIndex = 10;
            this.btnSaldoNuevo.Text = "Cargar Gasto Permitido";
            this.btnSaldoNuevo.UseVisualStyleBackColor = true;
            this.btnSaldoNuevo.Click += new System.EventHandler(this.btnSaldoNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaldoNuevo);
            this.Controls.Add(this.txtNuevoSaldo);
            this.Controls.Add(this.lblNuevoSaldo);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSaldoActual);
            this.Controls.Add(this.lblTituloSaldo);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.cBoxMovimientos);
            this.Controls.Add(this.lblTipo);
            this.Name = "Form1";
            this.Text = "Mis Cuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cBoxMovimientos;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblTituloSaldo;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label lblNuevoSaldo;
        private System.Windows.Forms.TextBox txtNuevoSaldo;
        private System.Windows.Forms.Button btnSaldoNuevo;
    }
}

