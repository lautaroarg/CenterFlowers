using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CenterFlowersSoftware
{
    public partial class frmCrearUsuario : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-OJTKK35\\SQLEXPRESS;Integrated Security=SSPI;Initial catalog=Center.flowers");
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string query = "Insert into Usuario (ID_Dni,contraseña,Id_Perfil_usuario,tipo_vendedor,nombre,apellido,permiso) values(@Dni,@Contraseña,@Perfil, @tipoV,@Nombre, @Apellido,@Permiso)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query,conexion);
            
            comando.Parameters.AddWithValue("@Dni", txtDNI.Text);
            comando.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
            comando.Parameters.AddWithValue("@Perfil", cboPerfil.Text);
            comando.Parameters.AddWithValue("@tipoV", cboTipoVendedor.Text);
            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
            comando.Parameters.AddWithValue("@Permiso",cboPerfil.TabIndex );
            comando.ExecuteNonQuery();
            MessageBox.Show("Insertado");

        }
    }

}
    