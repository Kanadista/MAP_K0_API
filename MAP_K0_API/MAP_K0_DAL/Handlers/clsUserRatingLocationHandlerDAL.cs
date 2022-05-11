using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Handlers
{
    public class clsUserRatingLocationHandlerDAL
    {
        public clsUserRatingLocation getUserRatingById(int idUser, int idLocation)
        {

            clsUserRatingLocation userRatingLocation = new clsUserRatingLocation();

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {


                CommandText = "SELECT idUser, idLocation, stars, comment FROM K0_MAP_USER_RATING_LOCATIONS WHERE idUser = @idUser AND idLocation = @idLocation",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.Int).Value = idUser;
            miComando.Parameters.Add("@idLocation", System.Data.SqlDbType.Int).Value = idLocation;

            SqlDataReader miLector;

            try
            {

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        userRatingLocation.idUser = (int)miLector["idUser"];
                        userRatingLocation.idLocation = (int)miLector["idLocation"];
                        userRatingLocation.stars = (int)miLector["stars"];
                        userRatingLocation.comment = (string)miLector["comment"];
                

                    }
                }
            }
            catch (SqlException excepcion)
            {

                throw excepcion;
            }

            return userRatingLocation;
        }


        public int deleteUserRatingLocation(int idUser, int idLocation)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "DELETE FROM K0_MAP_USER_RATING_LOCATIONS WHERE idUser = @idUser AND idLocation = @idLocation",

                Connection = conexion.getConnection()

            };


            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.Int).Value = idUser;
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

        public int updateUserRatingLocation(clsUserRatingLocation userRatingLocation)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "UPDATE K0_MAP_USERS_RATING_LOCATIONS SET idUser = @idUser, idLocation = @idLocation, stars = @stars, comment = @comment WHERE idUser = @idUser and idLocation = @idLocation",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.Int).Value = userRatingLocation.idUser;
            miComando.Parameters.Add("@idLocation", System.Data.SqlDbType.VarChar).Value = userRatingLocation.idLocation;
            miComando.Parameters.Add("@stars", System.Data.SqlDbType.VarChar).Value = userRatingLocation.stars;
            miComando.Parameters.Add("@comment", System.Data.SqlDbType.VarChar).Value = userRatingLocation.comment;

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

        public int createUserRatingLocation(clsUserRatingLocation userRatingLocation)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "INSERT INTO K0_MAP_USER_RATING_LOCATIONS(idUser, idLocation, stars, comment) VALUES (@idUser, @idLocation, @stars, @comment)",

                Connection = conexion.getConnection()

            };

            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.Int).Value = userRatingLocation.idUser;
            miComando.Parameters.Add("@idLocation", System.Data.SqlDbType.VarChar).Value = userRatingLocation.idLocation;
            miComando.Parameters.Add("@stars", System.Data.SqlDbType.VarChar).Value = userRatingLocation.stars;
            miComando.Parameters.Add("@comment", System.Data.SqlDbType.VarChar).Value = userRatingLocation.comment;

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

