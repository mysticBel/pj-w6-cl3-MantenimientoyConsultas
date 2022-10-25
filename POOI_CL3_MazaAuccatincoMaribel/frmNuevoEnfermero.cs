using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOI_CL3_MazaAuccatincoMaribel
{
    public partial class frmNuevoEnfermero : Form
    {
        DAOEnfermero objDAO = new DAOEnfermero();
        public frmNuevoEnfermero()
        {
            InitializeComponent();
            cboEspecialidad.DataSource = objDAO.llenarCboEspecialidad();
            cboEspecialidad.DisplayMember = "nom_esp";
            cboEspecialidad.ValueMember = "ide_esp";
        }

        private void frmNuevoEnfermero_Load(object sender, EventArgs e)
        {
            int n = objDAO.generaCodigo();
            lblCodigo.Text = n.ToString("0000");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Enfermero objE = new Enfermero()
            {
                nom_enf = txtNombres.Text,
                ape_enf = txtApellidos.Text,
                tel_enf = txtTelefono.Text,
                ide_esp = int.Parse(cboEspecialidad.SelectedValue.ToString())
            };
            try
            {
                int n = objDAO.nuevoEnfermero(objE);
                if (n == 1)

                    MessageBox.Show
                    (n + " Registro de enfermero exitoso !! ");
            }
            catch (Exception ex)
            {

                MessageBox.Show
                (ex.Message);
            }
        }

    }
}
