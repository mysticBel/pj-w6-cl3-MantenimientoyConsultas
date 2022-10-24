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
    public partial class frmListarEspecialidades : Form
    {
        public frmListarEspecialidades()
        {
            InitializeComponent();
        }

        private void frmListarEspecialidades_Load(object sender, EventArgs e)
        {
            DAOEnfermero objDAO = new DAOEnfermero();
            dgEspecialidades.DataSource = objDAO.listadoEspecialidades();
            dgEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
