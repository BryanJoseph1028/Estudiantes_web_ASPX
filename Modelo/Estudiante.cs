using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.UI.WebControls;


namespace Modelo
{
    public class Estudiante{
        ConexionBD conectar;
        private DataTable drop_sangre(){
            DataTable tabla = new DataTable();
           
            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = String.Format("	SELECT id_tipo_sangre as id,sangre from tipo_sangre; ");
            MySqlDataAdapter query = new MySqlDataAdapter(consulta, conectar.conectar);
            query.Fill(tabla);
            return tabla;
        }
        private DataTable grid_estudiante() {
            DataTable tabla = new DataTable();

            conectar = new ConexionBD();
            conectar.AbrirConexion();
            string consulta = String.Format("select e.id_tipo_sangre as id,e.carne,e.nombre,e.apellidos,e.direccion,e.correo_electronico,t.sangre,e.fecha_nacimiento from estudiantes as e inner join tipo_sangre as t on e.id_tipo_sangre = t.id_tipo_sangre; ");
            MySqlDataAdapter query = new MySqlDataAdapter(consulta, conectar.conectar);
            query.Fill(tabla);
            conectar.CerrarConexion();
            return tabla;
        }
        public void drop_sangre(DropDownList drop){
            drop.ClearSelection();
            drop.Items.Clear();
            drop.AppendDataBoundItems = true;
            drop.Items.Add("<<--Elija su tipo de sangre-->>");
            drop.Items[0].Value = "0";
            drop.DataSource = drop_sangre();
            drop.DataTextField = "sangre";
            drop.DataTextField = "id";
            drop.DataBind();

        }
        public void grid_estudiante(GridView grid){
            grid.DataSource = grid_estudiante();
            grid.DataBind();

        }
        public int crear(string carne,string nombres,string apellidos, string direccion, string correo_electronico, int id_tipo_sangre, string fecha_nacimiento){
            int no = 0;
            conectar.AbrirConexion();
            string consulta = string.Format("INSERT INTO estudiantes(carne,nombre,apellidos,direccion,correo_electronico,id_tipo_sangre,fecha_nacimiento) VALUES('{0}','{1}','{2}','{3}','{4}',{5},'{6}');",carne,nombres,apellidos,direccion,correo_electronico,id_tipo_sangre,fecha_nacimiento);
            MySqlCommand query = new MySqlCommand(consulta,conectar.conectar);
            query.Connection = conectar.conectar;
            no = query.ExecuteNonQuery();
            conectar.CerrarConexion();
            return 0;
        }
        public int actualizar(int id, string carne, string nombres, string apellidos, string direccion, string correo_electronico, int id_tipo_sangre, string fecha_nacimiento)
        {
            int no = 0;
            conectar.AbrirConexion();
            string consulta = string.Format("UPDATE estudiantes SET carne='{0}',nombre='{1}',apellidos='{2}',direccion='{3}',correo_electronico='{4}',id_tipo_sangre={5},fecha_nacimiento='{6}' WHERE id = ={7};", carne, nombres, apellidos, direccion, correo_electronico, id_tipo_sangre, fecha_nacimiento,id);
            MySqlCommand query = new MySqlCommand(consulta, conectar.conectar);
            query.Connection = conectar.conectar;
            no = query.ExecuteNonQuery();
            conectar.CerrarConexion();
            return 0;
        }
        public int borrar(int id){
            int no = 0;
            conectar.AbrirConexion();
            string consulta = string.Format("DELETE FROM estudiantes WHERE id_estudiante ={0};",id);
            MySqlCommand query = new MySqlCommand(consulta, conectar.conectar);
            query.Connection = conectar.conectar;
            no = query.ExecuteNonQuery();
            conectar.CerrarConexion();
            return 0;
        }
    }

}
