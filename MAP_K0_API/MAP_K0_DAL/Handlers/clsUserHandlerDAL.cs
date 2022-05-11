using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Handlers
{
   public class clsUserHandlerDAL
    {

        public clsUser getUserById(int id)
        {

            clsUser oUser = new clsUser();

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {


                CommandText = "SELECT id, nickName, firstName, lastName, address, profilePic, level, levelxp FROM K0_MAP_USERS WHERE ID = @id",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

            SqlDataReader miLector;

            try
            {

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oUser.id = (int)miLector["id"];
                        oUser.nickName = (string)miLector["name"];
                        oUser.firstName = (string)miLector["firstName"];
                        oUser.lastName = (string)miLector["lastName"];
                        oUser.address = (string)miLector["addres"];
                        oUser.profilePic = (byte[])miLector["profilePic"];
                        oUser.level = (int)miLector["level"];
                        oUser.levelxp = (int)miLector["levelxp"];

                    }
                }
            }
            catch (SqlException excepcion)
            {

                throw excepcion;
            }

            return oUser;
        }


        public int deleteUser(int id)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "DELETE FROM K0_MAP_EVENT_USERS WHERE id = @id",

                Connection = conexion.getConnection()

            };

            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

            try
            {
                filasAfectadas = miComando.ExecuteNonQuery();

            }

            catch (SqlException excepcion)
            {

                throw excepcion;

            }

            return filasAfectadas;
        }

        /// <summary>
        /// Método que actualiza los datos de una persona en la base de datos.
        /// </summary>
        /// <param name="persona">Objeto persona con los atributos que queremos modificar en la base de datos</param>
        /// <returns>Int con las filas afectadas</returns>

        public int updateUser(clsUser oUser)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "UPDATE K0_MAP_USERS SET id = @id, nickName = @nickName, firstName = @firstName, lastName = @lastName, address = @address, profilePic = @profilePic, level = @level, levelxp = @levelxp WHERE id = @id",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = oUser.id;
            miComando.Parameters.Add("@nickName", System.Data.SqlDbType.VarChar).Value = oUser.nickName;
            miComando.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar).Value = oUser.firstName;
            miComando.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar).Value = oUser.lastName;
            miComando.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = oUser.address;
            miComando.Parameters.Add("@profilePic", System.Data.SqlDbType.VarBinary).Value = oUser.profilePic;
            miComando.Parameters.Add("@level", System.Data.SqlDbType.Int).Value = oUser.level;
            miComando.Parameters.Add("@levelxp", System.Data.SqlDbType.Int).Value = oUser.levelxp;

            try
            {
                filasAfectadas = miComando.ExecuteNonQuery();

            }

            catch (SqlException excepcion)
            {

                throw excepcion;

            }

            return filasAfectadas;
        }

        /// <summary>
        /// Método para crear una locationImage en la base de datos
        /// </summary>
        /// <param name="locationImage">Persona con los atributos que queremos que se inserten en la base de datos</param>
        /// <returns>Int con las filas afectadas</returns>

        public int createUser(clsUser oUser)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "INSERT INTO K0_MAP_USER(id, nickName, firstName, lastName, address, profilePic, level, levelxp) VALUES (@id, @nickName, @firstName, @lastName, @address, @profilePic, @level, @levelxp)",

                Connection = conexion.getConnection()

            };

            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = oUser.id;
            miComando.Parameters.Add("@nickName", System.Data.SqlDbType.VarChar).Value = oUser.nickName;
            miComando.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar).Value = oUser.firstName;
            miComando.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar).Value = oUser.lastName;
            miComando.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = oUser.address;
            miComando.Parameters.Add("@profilePic", System.Data.SqlDbType.VarBinary).Value = oUser.profilePic;
            miComando.Parameters.Add("@level", System.Data.SqlDbType.Int).Value = oUser.level;
            miComando.Parameters.Add("@levelxp", System.Data.SqlDbType.Int).Value = oUser.levelxp;


            try
            {
                filasAfectadas = miComando.ExecuteNonQuery();

            }

            catch (SqlException excepcion)
            {

                throw excepcion;

            }

            return filasAfectadas;
        }
    }
}
