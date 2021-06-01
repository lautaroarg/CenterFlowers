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
            UsuarioMetodo oUsuarioMetodo = new UsuarioMetodo();
            oUsuarioMetodo.conectar();
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();
            var Us = new UsuarioMetodo();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string query = "Insert into Usuario (ID_Dni,contraseña,Id_Perfil_usuario,tipo_vendedor,nombre,apellido,permiso) values(@Dni,@Contraseña,@Perfil, @tipoV,@Nombre, @Apellido,@Permiso)" +
                           "Insert into Domicilios (Calle,Altura,Piso,Domicilio.ID_dni) values(@Calle,@Altura,@Piso,@DomicilioID) " +
                           "Insert into Emails(Personal,laboral,Id_dni_usuario) values (@Personal,@Laboral,@EmailDNI)" +
                           "Insert into Telefonos (Fijo,Celular,ID_dni)values (@Fijo,@Celular,@TelefonoDNI)";
            //Localidad,Provincia,Pais,(No los puse por que si es un Empleado que usa el sistema, es mas que obvio que vive en Cordoba.)ID_domicilio_usuario(Hay que hacerle una numeracion Automatica, dependiendo el numero de registro.)
            //Debemos hacer una metodo que valide si ese DNI,MAILS,TELEFONOS Ya existen en la base, y decirle al usuario que ponga OTROS datos, por que si no la base se rompe.
            conexion.Open();
            SqlCommand comando = new SqlCommand(query,conexion);
            
            comando.Parameters.AddWithValue("@Dni", txtDNI.Text);
            comando.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
            comando.Parameters.AddWithValue("@Perfil", cboPerfil.Text);
            comando.Parameters.AddWithValue("@tipoV", cboTipoVendedor.Text);
            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
            comando.Parameters.AddWithValue("@Permiso",cboPerfil.TabIndex );
            comando.Parameters.AddWithValue("@Calle", txtCalle.Text);
            comando.Parameters.AddWithValue("@Altura",txtAltura.Text);
            comando.Parameters.AddWithValue("@Piso", txtPiso.Text);
            comando.Parameters.AddWithValue("@DomicilioID", txtDNI.Text);
            comando.Parameters.AddWithValue("@Personal", txtPersonal.Text);
            comando.Parameters.AddWithValue("@Laboral", txtLaboral.Text);
            comando.Parameters.AddWithValue("@EmailDNI", txtDNI.Text);
            comando.Parameters.AddWithValue("@Fijo", txtFijo.Text);
            comando.Parameters.AddWithValue("@Celular", txtCelular.Text);
            comando.Parameters.AddWithValue("@TelefonoDNI", txtDNI.Text);
            //Podriamos cambiar el nombre de las columnas Domicilio.ID_dni,Id_dni_usuario,ID_dni en (Domicilios,Emails,Telefonos) para que sea mas entendible.
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro exitoso");

        }

        private void btnActualizar_Click(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {

            


        }
    }

}
    