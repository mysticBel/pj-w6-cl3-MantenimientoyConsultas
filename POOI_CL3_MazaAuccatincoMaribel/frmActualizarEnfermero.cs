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
    public partial class frmActualizarEnfermero : Form
    {
        DAOEnfermero objDAO = new DAOEnfermero();
        public frmActualizarEnfermero()
        {
            InitializeComponent();
            cboEspecialidad.DataSource = objDAO.llenarCboEspecialidad();
            cboEspecialidad.DisplayMember = "nom_esp";
            cboEspecialidad.ValueMember = "ide_esp";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                DataRow dr = objDAO.buscarEnfermero(codigo).Rows[0];

                txtNombres.Text = dr[1].ToString();
                txtApellidos.Text = dr[2].ToString();
                txtTelefono.Text = dr[3].ToString();           
                cboEspecialidad.Text = dr[4].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Enfermero NO existe..!!!");
            }
        }

        private void dgEnfermeros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int codigo = int.Parse(dgEnfermeros.CurrentRow.Cells[0].Value.ToString());

            DataRow dr = objDAO.buscarEnfermero(codigo).Rows[0];
            txtCodigo.Text = dr[0].ToString();
            txtNombres.Text = dr[1].ToString();
            txtApellidos.Text = dr[2].ToString();
            txtTelefono.Text = dr[3].ToString();     
            cboEspecialidad.Text = dr[4].ToString();
        }

        private void frmActualizarEnfermero_Load(object sender, EventArgs e)
        {
            dgEnfermeros.DataSource = objDAO.listadoEnfermeros();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Enfermero objV = new Enfermero()
            {
                ide_enf = int.Parse(txtCodigo.Text),
                nom_enf = txtNombres.Text,
                ape_enf = txtApellidos.Text,
                tel_enf = txtTelefono.Text,
                ide_esp = int.Parse(cboEspecialidad.SelectedValue.ToString())
            };
            try
            {
                int n = objDAO.actualizarEnfermero(objV);
                if (n == 1)
                    MessageBox.Show(n + " Se ha ACTUALIZADO un registro");
                dgEnfermeros.DataSource = objDAO.listadoEnfermeros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
