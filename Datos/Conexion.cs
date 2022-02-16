// ***********************************************************************
// Assembly         : Datos
// Author           : sergi
// Created          : 02-05-2022
//
// Last Modified By : sergi
// Last Modified On : 02-07-2022
// ***********************************************************************
// <copyright file="Conexion.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************

using MySqlConnector;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Datos
{


    /// <summary>
    /// Class Conexion.
    /// </summary>
    public class Conexion
    {


        /// <summary>
        /// The conexion database externa
        /// </summary>
        private static string conexion_DB_externa = "Server=MYSQL5045.site4now.net;Database=db_a7eb45_sga;Uid=a7eb45_sga;Pwd=1234emelec";



        /// <summary>
        /// The sqlconnection
        /// </summary>
        private MySqlConnection sqlconnection = null;


        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>The connection.</value>
        public MySqlConnection Connection { get => sqlconnection; set => sqlconnection = value; }



        /// <summary>
        /// Conectars this instance.
        /// </summary>
        /// <returns>MySqlConnection.</returns>
        public MySqlConnection conectar()
        {
            try
            {
                Connection = new MySqlConnection();
                Connection.ConnectionString = conexion_DB_externa;
                Connection.Open();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());

            }
            return Connection;
        }

        /// <summary>
        /// Cerrars this instance.
        /// </summary>
        public void cerrar()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
            }
        }


    }
}
