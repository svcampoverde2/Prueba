// ***********************************************************************
// Assembly         : LogicaDeNegocios
// Author           : sergi
// Created          : 02-05-2022
//
// Last Modified By : sergi
// Last Modified On : 02-07-2022
// ***********************************************************************
// <copyright file="ConectorDeProcedimientos.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    /// <summary>
    /// Class ConectorDeProcedimientos.
    /// </summary>
    class ConectorDeProcedimientos
    {
        /// <summary>
        /// Conectars the procedimiento.
        /// </summary>
        /// <param name="Procedimientos">The procedimientos.</param>
        /// <param name="mySqlConnection">My SQL connection.</param>
        /// <returns>MySqlCommand.</returns>
        public MySqlCommand ConectarProcedimiento(string Procedimientos, MySqlConnection mySqlConnection)
        {
            MySqlCommand mySqlCommand;
            mySqlCommand = new MySqlCommand(Procedimientos, mySqlConnection);
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return mySqlCommand;
        }
    }
}
