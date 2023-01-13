using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmListaRequerimientos : Form
    {

        NListaRequerimiento listar = new NListaRequerimiento();
        ERequerimiento reque = new ERequerimiento(); 


        public FrmListaRequerimientos()
        {
            InitializeComponent();
        }

       

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
          
                reque.Tipo = cmbxTipoReque.SelectedItem.ToString();
                reque.Estado = comboBoxEstado.SelectedItem.ToString();
                reque.Prioridad = comboBoxPrioridad.SelectedItem.ToString();
                dt = listar.listar(reque);
                dataGridView2.DataSource = dt;
           
            if (cmbxTipoReque.SelectedItem.ToString() == "Todos" && comboBoxPrioridad.SelectedItem.ToString() == "Todos")
            {
                DataTable listaa = new DataTable();

                listaa = listar.dt();
                dataGridView2.DataSource = listaa;
            }

        }

        private void FrmListaRequerimientos_Load(object sender, EventArgs e)
        {
            DataTable listaa = new DataTable();


            listaa = listar.dt(); 
            
            dataGridView2.DataSource = listaa;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable estados = new DataTable();

            int id_req = Convert.ToInt32(dataGridView2.CurrentRow.Cells["id_requerimiento"].Value.ToString().TrimEnd());
            string estado = dataGridView2.CurrentRow.Cells["estado"].Value.ToString().TrimEnd();

            switch (estado)
            {
                case "Pendiente":
                    reque.Id_requerimiento = id_req;
                    reque.Estado = "Resuelto";
                    listar.CambioEstado(reque);
                    MessageBox.Show("Cambio a 'Resuelto' se ha realizado exitosamente =) ");
                    estados = listar.dt();
                    dataGridView2.DataSource = estados; 
                    break;
                case "Resuelto":
                    reque.Id_requerimiento = id_req;
                    reque.Estado = "Pendiente";
                    listar.CambioEstado(reque);
                    dataGridView2.DataSource = estados;
                    MessageBox.Show("Cambio a 'Pendiente' se ha realizado exitosamente ;) ");
                    break;

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRequerimiento requer = new FrmRequerimiento();
            requer.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dte = new DataTable();

            reque.Id_requerimiento = Convert.ToInt32(dataGridView2.CurrentRow.Cells["id_requerimiento"].Value.ToString().TrimEnd());

            listar.eliminar(reque);
            MessageBox.Show("Requerimiento eliminado exitosamente! uwu");
            dte = listar.dt();
            dataGridView2.DataSource = dte;
        }
      




    }
}
