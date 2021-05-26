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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario ofrmUsuario = new frmUsuario();
            ofrmUsuario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMercaderia oMercaderia = new frmMercaderia();
            oMercaderia.Show();
        }
    }
}
