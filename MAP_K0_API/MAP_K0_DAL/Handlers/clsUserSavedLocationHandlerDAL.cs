using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Handlers
{
    public class clsUserSavedLocationHandlerDAL
    {

        public clsUserSavedLocations getUserSavedLocationById(string idUser)
        {

            clsUserSavedLocations userSavedLocation = new clsUserSavedLocations();

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {


                CommandText = "SELECT idUser, idLocation FROM K0_MAP_USER_SAVED_LOCATIONS WHERE idUser = @idUser",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.VarChar).Value = idUser;

            SqlDataReader miLector;

            try
            {

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        userSavedLocation.idUser = (string)miLector["idUser"];
                        userSavedLocation.idLocation = (int)miLector["idLocation"];
                    }
                }
            }
            catch (SqlException excepcion)
            {

                throw excepcion;
            }

            return userSavedLocation;
        }


        public int deleteUserSavedLocation(string idUser, int idLocation)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "DELETE FROM K0_MAP_USER_SAVED_LOCATIONS WHERE idUser = @idUser AND idLocation = @idLocation",

                Connection = conexion.getConnection()

            };


            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.VarChar).Value = idUser;
            miComando.Parameters.Add("@idLocation", System.Data.SqlDbType.Int).Value = idLocation;

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

        public int updateUserSavedLocation(clsUserSavedLocations userSavedLocation)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "UPDATE K0_MAP_USERS_SAVED_LOCATIONS SET idUser = @idUser, idLocation = @idLocation WHERE idUser = @idUser and idLocation = @idLocation",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.VarChar).Value = userSavedLocation.idUser;
            miComando.Parameters.Add("@idLocation", System.Data.SqlDbType.VarChar).Value = userSavedLocation.idLocation;

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

        public int createUserSavedLocation(clsUserSavedLocations userSavedLocation)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "INSERT INTO K0_MAP_USER_SAVED_LOCATIONS(idUser, idLocation) VALUES (@idUser, @idLocation)",

                Connection = conexion.getConnection()

            };

            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.VarChar).Value = userSavedLocation.idUser;
            miComando.Parameters.Add("@idLocation", System.Data.SqlDbType.VarChar).Value = userSavedLocation.idLocation;

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

