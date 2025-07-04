﻿using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace Academia._03data
{
    static class BasedeDatos
    {
        static public string Error { get; set; }
        static public int NumRegModif { set; get; }
        // método que conecta con la BD
        static private MySqlConnection Conectar()
        {
            string cad = "datasource=127.0.0.1; port=3306; username=root; password=; database=academia;";
            MySqlConnection conexionBD = new MySqlConnection(cad);
            return (conexionBD);
        }
        //consulta de tipo SELECT que devuelve un DataTable (tabla en memoria)
        static public DataTable Consulta(string sql)
        {
            MySqlConnection conexionBD = Conectar();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexionBD);
            try
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                NumRegModif = 0;
                Error = "Base de datos no encontrada";
                return (ds.Tables[0]);
            }
            catch (Exception e)
            {
                Error = e.Message;
                NumRegModif = -1;
                return (null);
            }
            finally { conexionBD.Close(); }
        }

        //consulta de acción INSERT, UPDATE Y DELETE se devuelve el número de registros afectados
        static public int Modificacion(string sql)
        {
            MySqlConnection conexionBD = Conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                conexionBD.Open();
                NumRegModif = comando.ExecuteNonQuery();
                Error = "Base de datos no encontrada";
                return NumRegModif;
            }
            catch (MySqlException ex)
            {
                Error = ex.Message;
                NumRegModif = -1;
                return NumRegModif;
            }
            finally { conexionBD.Close(); }
        }
    }
}