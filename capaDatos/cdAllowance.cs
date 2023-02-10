﻿using MySql.Data.MySqlClient;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdAllowance
    {
        
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        public bool insertAllowance(ceAllowance allowance)
        {
            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            conn.Open();
            string query = "INSERT INTO allowance (User_idUser, Title, Observations, State, StartTime, StartHour, EndHour) VALUES " +
                "('" + allowance.User_idUser + "', '" + allowance.title + "', '" + allowance.observations + "', '" + allowance.state + "', '" + allowance.startTime + "', '" + allowance.startHour + "', '" + allowance.endHour + "');";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();

            return true;
        }

        public void addAllowance(ceAllowance allowance, MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO allowance (idAllowance, User_idUser, Title, Observations, State, StartTime, EndTime, " +
                    "StartHour, EndHour, Invoice) VALUES (@idAllowance, @User_idUser, @Title, @Observations, @State, @StartTime, @EndTime, " +
                    "@StartHour, @EndHour, @Invoice);", conn))
                {
                    cmd.Parameters.AddWithValue("@idAllowance", allowance.idAllowance);
                    cmd.Parameters.AddWithValue("@User_idUser", allowance.User_idUser);
                    cmd.Parameters.AddWithValue("@Title", allowance.title);
                    cmd.Parameters.AddWithValue("@Observations", allowance.observations);
                    cmd.Parameters.AddWithValue("@State", allowance.state);
                    cmd.Parameters.AddWithValue("@StartTime", allowance.startTime);
                    cmd.Parameters.AddWithValue("@EndTime", allowance.endTime);
                    cmd.Parameters.AddWithValue("@StartHour", allowance.startHour);
                    cmd.Parameters.AddWithValue("@EndHour", allowance.endHour);
                    cmd.Parameters.AddWithValue("@Invoice", allowance.invoice);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void updateAllowance(int idAllowance, string state)
        {
            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd;
            conn.Open();

            using (cmd = new MySqlCommand("update allowance set state = @state where idAllowance = @idAllowance;", conn))
            {
                cmd.Parameters.AddWithValue("@state", state);
                cmd.Parameters.AddWithValue("@idAllowance", idAllowance);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Dieta modificada", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }

        public void deleteAllowance(int idAllowance)
        {
            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd;
            conn.Open();

            using (cmd = new MySqlCommand("delete from allowance where idAllowance = @idAllowance;", conn))
            {
                cmd.Parameters.AddWithValue("@idAllowance", idAllowance);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Dieta eliminada", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }

    }
}