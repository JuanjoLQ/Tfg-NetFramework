﻿using capaEntidad;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdDepartmentUser
    {
        public void addDepartmentUser(ceDepartment_User department_user, MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Department_User (Department_idDepartment, User_idUser) VALUES " +
                    "(@Department_idDepartment, @User_idUser);", conn))
                {
                    cmd.Parameters.AddWithValue("@Department_idDepartment", department_user.Department_idDepartment);
                    cmd.Parameters.AddWithValue("@User_idUser", department_user.User_idUser);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
