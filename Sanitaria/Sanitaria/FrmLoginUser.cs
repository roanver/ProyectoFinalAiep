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
    public partial class FrmLoginUser : Form
    {
        EUsuario objEU = new EUsuario(); 
        NUsuario objNUsuario = new NUsuario();
        public FrmLoginUser()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            objEU.Nombre = txtbxNombre.Text;
            objEU.Contraseña = txtbxContrtaseña.Text;
            dt= objNUsuario.nLogin(objEU);
            if (dt.Rows.Count > 0)
            {
                objEU.Nombre = dt.Rows[0][0].ToString();
                objEU.Contraseña = dt.Rows[0][1].ToString();
                MessageBox.Show("Bienvenido " + objEU.Nombre);
                
                this.Hide();

                FrmRequerimiento requ = new FrmRequerimiento();
                requ.Show(); 
            }
            else
            {
                MessageBox.Show("Usuario o contrseña incorrecta"); 
            }
            
        }

        private void txtbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {

        }
    }
}
