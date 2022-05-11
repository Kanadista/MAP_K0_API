using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Handlers
{
    public class clsLocationImageHandlerDAL
    {

        /// <summary>
        /// Método que borra una persona de la base de datos mediante su ID
        /// </summary>
        /// <param name="id">ID de la persona que queremos borrar.</param>
        /// <returns>Un int con el numero de filas afectadas.</returns>
        public int deleteLocationImage(int idLocation, int idImage)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "DELETE FROM K0_MAP_EVENT_ASSISTANCE WHERE idLocation = @idLocation and idImage = @idImage",

                Connection = conexion.getConnection()

            };

            miComando.Parameters.Add("@idLocation", System.Data.SqlDbType.Int).Value = idLocation;
            miComando.Parameters.Add("@idImage", System.Data.SqlDbType.Int).Value = idImage;

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

        public int updateLocationImage(clsLocationImage locationImage)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "UPDATE K0_MAP_EVENT_ASSISTANCE SET idLocation = @idLocation, idImage = @idImage, image = @image WHERE idEvent = @idEvent AND idUser = @idUser",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@idLocation", System.Data.SqlDbType.Int).Value = locationImage.idLocation;
            miComando.Parameters.Add("@idImage", System.Data.SqlDbType.Int).Value = locationImage.idImage;
            miComando.Parameters.Add("@image", System.Data.SqlDbType.VarBinary).Value = locationImage.image;

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

        public int createLocationImage(clsLocationImage locationImage)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "INSERT INTO K0_MAP_EVENT_ASSISTANCE(idLocation, idImage, image) VALUES (@idLocation, @idImage, @image)",

                Connection = conexion.getConnection()

            };

            miComando.Parameters.Add("@idLocation", System.Data.SqlDbType.Int).Value = locationImage.idLocation;
            miComando.Parameters.Add("@idImage", System.Data.SqlDbType.Int).Value = locationImage.idImage;
            miComando.Parameters.Add("@image", System.Data.SqlDbType.VarChar).Value = locationImage.image;

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
