using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CenterFlowersSoftware
{
        class LoginMetodo : connection
        {
            #region metodos
            public DataTable ConsultaLogin(string usu, string pass)
            {
                string sqlStr = "Select usuario,contraseña from Login where usuario='" + usu + "' and contraseña ='" + pass + "'";
                var da = new SqlDataAdapter(sqlStr, conectar());
                var ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                return dt;

            }

        }
        #endregion

    }

