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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Clear();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtIngresar_Click(object sender, EventArgs e)
        {
            {
                var dt = new DataTable();
                var usu = new LoginMetodo();
                var usuario = txtUsuario.Text;
                var password = txtPassword.Text;
                dt = usu.ConsultaLogin(usuario, password);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Ingreso correcto");
                    var frm = new frmMenu();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto");
                }
            }

        }

        private void lkOlvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarPass ofrmRecuperarPass = new frmRecuperarPass();
            ofrmRecuperarPass.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCrearUsuario oCrearUsuario = new frmCrearUsuario();
            oCrearUsuario.Show();
        }
    }
}
