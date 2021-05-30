using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace CenterFlowersSoftware
{
    class UsuarioMetodo : connection
    {

        public DataTable consultar()
        {
            string sqlStr = "select Nombre, Apellido, Id_perfil_usuario,Tipo_vendedor ,Usuario.ID_dni, Contraseña,Calle,Altura,Piso,Fijo,Celular,laboral,personal from Usuario,Telefonos,Domicilios,Emails where Telefonos.ID_dni = Usuario.ID_dni and Domicilios.Id_dni = Usuario.ID_dni and Emails.Id_dni_usuario = Usuario.ID_dni";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
         
    }
}
