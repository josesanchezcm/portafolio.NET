using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Clases
{
    public class Conexion
    {
        MySqlConnection conection; 

        //constructir inicia la conexion a la base de datos.
        public Conexion()
        {
            try
            {
                conection = new MySqlConnection();
                conection.ConnectionString = "Server=127.0.0.1;DataBase=zapateria;Uid=root;Pwd= ;";
            }catch(MySqlException){
            }
            
        }
        //funcion para eliminar,insertar y editar registros
        public int ejecutar_sql(string sql)
        {
            int i = 0;
            try
            {
                conection.Open();
                MySqlCommand query = conection.CreateCommand();
                query.CommandText = sql;
                i = query.ExecuteNonQuery();
            }
            catch (Exception)
            {
                i = -1;
            }
           
            return i;
        }
        //funcion para buscar registros
        public MySqlCommand busquedaRegistro(string sql)
        {
            try
            {
                conection.Open();
            }
            catch (MySqlException)
            {
            }

            MySqlCommand cm = new MySqlCommand(sql, conection);
            return cm;
        }
        //metodo para cerrar conexion
        public void cerrar_conexion()
        {
            conection.Close();
        }
    }
}
