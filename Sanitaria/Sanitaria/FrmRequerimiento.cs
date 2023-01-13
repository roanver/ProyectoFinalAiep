using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRequerimiento : Form
    {
        
        NRequerimiento reque = new NRequerimiento();

        public FrmRequerimiento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnListaRequerimientos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListaRequerimientos lista = new FrmListaRequerimientos();
            lista.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ERequerimiento EReque = new ERequerimiento();
            {
                EReque.Id_usuario = 1;
                EReque.Responsable = comboBoxasignadoa.SelectedItem.ToString();
                EReque.Tipo = cmbxTipoRequeri.SelectedItem.ToString();
                EReque.Descripcion = txtbxDescripcion.Text;
                EReque.Estado = "Pendiente";
                EReque.Prioridad = comboBoxprioridad.SelectedItem.ToString(); 
               
            }
            if (EReque != null)
            {
                var response = reque.Insertar(EReque);

                if(response > 0)
                {
                    if(EReque.Prioridad== "Alta")
                    {
                        MessageBox.Show("El requerimiento fue ingresado, el plazo para resolver es de 3 días"); 
                    }
                    else if(EReque.Prioridad== "Media")
                    {
                        MessageBox.Show("El requerimiento fue ingresado, el plazo para resolver es de 4 días");
                    }
                    else if(EReque.Prioridad == "Baja")
                    {
                        MessageBox.Show("El requerimiento fue ingresado, el plazo para resolver es de 5 días");
                    }
                }
            }

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            comboBoxasignadoa.Text = "";
            txtbxDescripcion.Clear();
            cmbxTipoRequeri.Text = "";
            comboBoxprioridad.Text = ""; 
        }

        private void cmbxTipoRequeri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

