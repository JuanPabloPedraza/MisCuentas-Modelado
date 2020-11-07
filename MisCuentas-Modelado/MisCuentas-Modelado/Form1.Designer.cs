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
            this.lblTituloGastoP = new System.Windows.Forms.Label();
            this.lblGastoPermitido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(12, 21);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(80, 16);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Movimiento:";
            // 
            // cBoxMovimientos
            // 
            this.cBoxMovimientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMovimientos.FormattingEnabled = true;
            this.cBoxMovimientos.Items.AddRange(new object[] {
            "Servicios",
            "Extraccion",
            "Sueldo",
            "Supermercado",
            "Transferencia",
            "Gasto Permitido"});
            this.cBoxMovimientos.Location = new System.Drawing.Point(98, 20);
            this.cBoxMovimientos.Name = "cBoxMovimientos";
            this.cBoxMovimientos.Size = new System.Drawing.Size(121, 21);
            this.cBoxMovimientos.TabIndex = 1;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(31, 52);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(56, 16);
            this.lblImporte.TabIndex = 2;
            this.lblImporte.Text = "Importe:";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(98, 49);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 3;
            // 
            // lblTituloSaldo
            // 
            this.lblTituloSaldo.AutoSize = true;
            this.lblTituloSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSaldo.Location = new System.Drawing.Point(467, 251);
            this.lblTituloSaldo.Name = "lblTituloSaldo";
            this.lblTituloSaldo.Size = new System.Drawing.Size(115, 24);
            this.lblTituloSaldo.TabIndex = 4;
            this.lblTituloSaldo.Text = "Saldo Actual";
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoActual.Location = new System.Drawing.Point(470, 306);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(112, 39);
            this.lblSaldoActual.TabIndex = 5;
            this.lblSaldoActual.Text = "30000";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 296);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(49, 84);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(133, 23);
            this.btnPago.TabIndex = 7;
            this.btnPago.Text = "Realizar Movimiento";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // lblNuevoSaldo
            // 
            this.lblNuevoSaldo.AutoSize = true;
            this.lblNuevoSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoSaldo.Location = new System.Drawing.Point(231, 21);
            this.lblNuevoSaldo.Name = "lblNuevoSaldo";
            this.lblNuevoSaldo.Size = new System.Drawing.Size(155, 16);
            this.lblNuevoSaldo.TabIndex = 8;
            this.lblNuevoSaldo.Text = "Ingrese Gasto Permitido:";
            // 
            // txtNuevoSaldo
            // 
            this.txtNuevoSaldo.Location = new System.Drawing.Point(392, 17);
            this.txtNuevoSaldo.Name = "txtNuevoSaldo";
            this.txtNuevoSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoSaldo.TabIndex = 9;
            // 
            // btnSaldoNuevo
            // 
            this.btnSaldoNuevo.Location = new System.Drawing.Point(376, 49);
            this.btnSaldoNuevo.Name = "btnSaldoNuevo";
            this.btnSaldoNuevo.Size = new System.Drawing.Size(125, 29);
            this.btnSaldoNuevo.TabIndex = 10;
            this.btnSaldoNuevo.Text = "Cargar Gasto Permitido";
            this.btnSaldoNuevo.UseVisualStyleBackColor = true;
            this.btnSaldoNuevo.Click += new System.EventHandler(this.btnSaldoNuevo_Click);
            // 
            // lblTituloGastoP
            // 
            this.lblTituloGastoP.AutoSize = true;
            this.lblTituloGastoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGastoP.Location = new System.Drawing.Point(422, 158);
            this.lblTituloGastoP.Name = "lblTituloGastoP";
            this.lblTituloGastoP.Size = new System.Drawing.Size(107, 16);
            this.lblTituloGastoP.TabIndex = 11;
            this.lblTituloGastoP.Text = "Gasto Permitido:";
            // 
            // lblGastoPermitido
            // 
            this.lblGastoPermitido.AutoSize = true;
            this.lblGastoPermitido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastoPermitido.Location = new System.Drawing.Point(551, 152);
            this.lblGastoPermitido.Name = "lblGastoPermitido";
            this.lblGastoPermitido.Size = new System.Drawing.Size(20, 24);
            this.lblGastoPermitido.TabIndex = 12;
            this.lblGastoPermitido.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Movimientos Realizados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(688, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGastoPermitido);
            this.Controls.Add(this.lblTituloGastoP);
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
        private System.Windows.Forms.Label lblTituloGastoP;
        private System.Windows.Forms.Label lblGastoPermitido;
        private System.Windows.Forms.Label label1;
    }
}

