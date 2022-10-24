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
    public partial class frmListarEnfermeros : Form
    {
        public frmListarEnfermeros()
        {
            InitializeComponent();
        }

        private void frmListarEnfermeros_Load(object sender, EventArgs e)
        {
            DAOEnfermero objDAO = new DAOEnfermero();
            dgEnfermeros.DataSource = objDAO.listadoEnfermeros();
            dgEnfermeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
