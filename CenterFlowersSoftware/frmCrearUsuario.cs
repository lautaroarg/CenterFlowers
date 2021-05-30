using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterFlowersSoftware
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var Us = new UsuarioMetodo();
            dt = Us.consultar();
            if (dt.Rows.Count != 0)
            {
                dgvUsuario.DataSource = dt;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();
            var al = new UsuarioMetodo();
        }
    }

}
    