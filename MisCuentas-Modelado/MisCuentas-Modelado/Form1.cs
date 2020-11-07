using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace MisCuentas_Modelado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "Tipo Movimiento";
            dataGridView1.Columns[1].HeaderText = "Importe";
            
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 100;

            

        }

        public Movimientos objEntMovimiento = new Movimientos();

        public CapaNegocioMovimientos objNegMovimiento = new CapaNegocioMovimientos();

        

        private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
        {


            float importe = Convert.ToInt32(txtImporte.Text);
            string tipoMovimiento = cBoxMovimientos.Text;

            objEntMovimiento = new Movimientos(importe, tipoMovimiento);
        }
        private void LlenarDGV()
        {
            dataGridView1.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegMovimiento.listadoMovimientos("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    
                    dataGridView1.Rows.Add(dr[1].ToString(), dr[2].ToString());
                    //dr[0].ToString(), 
                }
            }
            else
                MessageBox.Show("No hay Movimientos cargados en el sistema");
        }

        private Boolean saldoDisponible(float importe)
        {
            Boolean resultado = false;

            float saldoDisponibleA = Convert.ToInt32(lblSaldoActual.Text);
            if (importe > saldoDisponibleA && saldoDisponibleA != 0)
            {
                MessageBox.Show("El gasto es mayor al gasto permitido, no puede registrar el movimiento");
            }
            else if (saldoDisponibleA == 0)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            else
            {
                saldoDisponibleA -= importe;
                lblSaldoActual.Text = Convert.ToString(saldoDisponibleA);
                resultado = true;
            }

            return resultado;
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            int gastoPermitido = Convert.ToInt32(lblGastoPermitido.Text);

            if (cBoxMovimientos.Text == "Sueldo")
            {
                int saldoAux = Convert.ToInt32(lblSaldoActual.Text);
                int saldoMov = Convert.ToInt32(txtImporte.Text);
                lblSaldoActual.Text = Convert.ToString(saldoAux + saldoMov);

                int nGrabados = -1;
                TxtBox_a_Obj();
                nGrabados = objNegMovimiento.abmMovimiento("Alta", objEntMovimiento);
                MessageBox.Show("Movimiento Cargado");
                LlenarDGV();
            }
            else if (cBoxMovimientos.Text == "Gasto Permitido" && lblGastoPermitido.Text == "0")
            {
                MessageBox.Show("Ingrese un Gasto Permitido");
            }
            else if (cBoxMovimientos.Text == "Gasto Permitido" && lblGastoPermitido.Text != "0")
            {
                int importeAux = Convert.ToInt32(txtImporte.Text);
                int gastoAux = gastoPermitido;

                if (importeAux > gastoAux)
                {
                    MessageBox.Show("Su gasto es mayor al permitido");
                }
                else
                {
                    lblGastoPermitido.Text = Convert.ToString(gastoAux - importeAux);

                    int nGrabados = -1;
                    TxtBox_a_Obj();
                    nGrabados = objNegMovimiento.abmMovimiento("Alta", objEntMovimiento);
                    MessageBox.Show("Movimiento Cargado");
                    LlenarDGV();
                }
            }
            else
            {
                if (saldoDisponible(Convert.ToInt32(txtImporte.Text)))
                {
                    int nGrabados = -1;
                    TxtBox_a_Obj();
                    nGrabados = objNegMovimiento.abmMovimiento("Alta", objEntMovimiento);
                    MessageBox.Show("Movimiento Cargado");
                    LlenarDGV();
                }
            }      
        }


        private void btnSaldoNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtNuevoSaldo.Text) <= Convert.ToInt32(lblSaldoActual.Text) && lblGastoPermitido.Text == "0")
                {
                    int gastoAux = Convert.ToInt32(txtNuevoSaldo.Text);
                    int saldoAux = Convert.ToInt32(lblSaldoActual.Text);


                    lblGastoPermitido.Text = txtNuevoSaldo.Text;
                    lblSaldoActual.Text = Convert.ToString(saldoAux - gastoAux);
                }
                else if (Convert.ToInt32(txtNuevoSaldo.Text) <= Convert.ToInt32(lblSaldoActual.Text) && lblGastoPermitido.Text != "0")
                {
                    int gastoAux = Convert.ToInt32(txtNuevoSaldo.Text);
                    int saldoAux = Convert.ToInt32(lblSaldoActual.Text);
                    int gastoAux2 = Convert.ToInt32(lblGastoPermitido.Text);

                    lblSaldoActual.Text = Convert.ToString(saldoAux + gastoAux2);
                    lblGastoPermitido.Text = Convert.ToString(gastoAux);

                    saldoAux = Convert.ToInt32(lblSaldoActual.Text);

                    lblSaldoActual.Text = Convert.ToString(saldoAux - gastoAux);
                    


                }
                else if (Convert.ToString(lblSaldoActual.Text) == "0")
                {
                    MessageBox.Show("No posee saldo en su cuenta");
                }
                else
                {
                    MessageBox.Show("El Gasto Permitido no puede ser mayor al saldo disponible");
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error al intentar generar Gasto Permitido", error);
            }

        }
    }
}
