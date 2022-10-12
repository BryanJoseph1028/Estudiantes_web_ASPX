using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ConexionBD{
        private string cadena = "server=localhost;database=db_estudiante;user=usr_estudiante;password=Estudiante@4560 ";
        public MySqlConnection conectar = new MySqlConnection();
        
        public void AbrirConexion(){
            try{
                //conectar = new MySqlConnection();
                conectar.ConnectionString = cadena;
                conectar.Open();
                System.Diagnostics.Debug.WriteLine("Conexion Exitosa");
               

            }
            catch (Exception ex){
                //System.Diagnostics.Debug.WriteLine(ex.Message);
                Console.WriteLine(ex.Message);
            }

        }
        public void CerrarConexion(){
            try{
                if (conectar.State == ConnectionState.Open){
                    conectar.Close();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
