﻿using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace capaDatos
{
    public class cdRole
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        // Comprobar si funka
        public bool CheckRole(String role)
        {
            Debug.WriteLine("Capa datos logUser");
            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            conn.Open();
            string query = "SELECT COUNT(*) FROM role where nameRole='" + role + "';";
            MySqlCommand command = new MySqlCommand(query, conn);

            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Comprobar si funka
        public bool CrearRole(String role)
        {

            if (CheckRole(role) == false)
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "INSERT INTO role (nameRole) VALUES " +
                    "('" + role + "');";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registro de user creado");
                return true;
            }
            else
            {
                MessageBox.Show("Email ya existente.");
                return false;
            }

        }

        public void addRole(ceRole role, MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("insert into role (idRole, nameRole, privileges) " +
                "values(@idRole, @nameRole, @privileges);", conn))
                {
                    cmd.Parameters.AddWithValue("@idRole", role.idRole);
                    cmd.Parameters.AddWithValue("@nameRole", role.nameRole);
                    cmd.Parameters.AddWithValue("@privileges", role.privileges);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
