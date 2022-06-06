using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Handlers
{
    public class clsLocationHandlerDAL
    {
        public clsLocation getLocationById(int id)
        {

            clsLocation location = new clsLocation();

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {


                CommandText = "SELECT id, name, description, latitud, longitude, creatorID FROM K0_MAP_LOCATIONS WHERE ID = @id",

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
                        location.id = (int)miLector["id"];
                        location.name = (string)miLector["name"];
                        location.description = (string)miLector["description"];
                        location.latitud = (decimal)miLector["latitud"];
                        location.longitude = (decimal)miLector["longitude"];
                        location.creatorId = (string)miLector["creatorID"];

                    }
                }
            }
            catch (SqlException excepcion)
            {

                throw excepcion;
            }

            return location;
        }

        public clsLocation getLastLocationByCreatorId(string id)
        {

            clsLocation location = new clsLocation();

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "SELECT TOP 1 id, name, description, latitud, longitude, creatorID FROM K0_MAP_LOCATIONS WHERE creatorId = @id ORDER BY id DESC",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;

            SqlDataReader miLector;

            try
            {

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        location.id = (int)miLector["id"];
                        location.name = (string)miLector["name"];
                        location.description = (string)miLector["description"];
                        location.latitud = (decimal)miLector["latitud"];
                        location.longitude = (decimal)miLector["longitude"];
                        location.creatorId = (string)miLector["creatorID"];

                    }
                }
            }
            catch (SqlException excepcion)
            {

                throw excepcion;
            }

            return location;
        }

        /// <summary>
        /// Método que borra una persona de la base de datos mediante su ID
        /// </summary>
        /// <param name="id">ID de la persona que queremos borrar.</param>
        /// <returns>Un int con el numero de filas afectadas.</returns>
        public int deleteLocation(int id)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "DELETE FROM K0_MAP_LOCATIONS WHERE ID = @id",

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

        public int updateLocation(clsLocation location)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "UPDATE K0_MAP_LOCATIONS SET id = @id, name = @name, description = @description, latitud = @latitud, longitude = @longitude, creatorID = @creatorId WHERE ID = @id",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = location.id;
            miComando.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = location.name;
            miComando.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value = location.description;
            miComando.Parameters.Add("@creatorID", System.Data.SqlDbType.Decimal).Value = location.latitud;
            miComando.Parameters.Add("@creatorID", System.Data.SqlDbType.Decimal).Value = location.longitude;
            miComando.Parameters.Add("@date", System.Data.SqlDbType.VarChar).Value = location.creatorId;

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
        /// Método para crear una location en la base de datos
        /// </summary>
        /// <param name="location">Persona con los atributos que queremos que se inserten en la base de datos</param>
        /// <returns>Int con las filas afectadas</returns>

        public int createLocation(clsLocation location)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "INSERT INTO K0_MAP_LOCATIONS(name, description, latitud, longitude, creatorID) VALUES (@name, @description, @latitud, @longitude, @creatorId)",

                Connection = conexion.getConnection()

            };

            miComando.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = location.name;
            miComando.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value = location.description;
            miComando.Parameters.Add("@latitud", System.Data.SqlDbType.Decimal).Value = location.latitud;
            miComando.Parameters.Add("@longitude", System.Data.SqlDbType.Decimal).Value = location.longitude;
            miComando.Parameters.Add("@creatorId", System.Data.SqlDbType.VarChar).Value = location.creatorId;


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

