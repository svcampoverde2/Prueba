// ***********************************************************************
// Assembly         : Presentacion
// Author           : sergi
// Created          : 02-05-2022
//
// Last Modified By : sergi
// Last Modified On : 02-07-2022
// ***********************************************************************
// <copyright file="Program.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;

namespace Presentacion
{
    /// <summary>
    /// Class Program.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegistroVendedor());
        }
    }
}
