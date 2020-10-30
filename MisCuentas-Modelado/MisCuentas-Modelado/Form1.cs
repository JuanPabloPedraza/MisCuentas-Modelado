using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                MessageBox.Show("Debe Ingresar Un Gasto Permitido");
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
            if (saldoDisponible(Convert.ToInt32(txtImporte.Text)))
            {
                int nGrabados = -1;
                TxtBox_a_Obj();
                nGrabados = objNegMovimiento.abmMovimiento("Alta", objEntMovimiento);
                MessageBox.Show("Movimiento Cargado");
                LlenarDGV();
            }           
        }

        private void btnSaldoNuevo_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtNuevoSaldo.Text) >= 0)
            {
                lblSaldoActual.Text = Convert.ToString(txtNuevoSaldo.Text);
            }
        }
    }
}
