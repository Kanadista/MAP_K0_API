using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Handlers
{
   public class clsEventHandlerDAL
    {

        public clsEvent getEventById(int id)
        {

            clsEvent oEvent = new clsEvent();

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {


                CommandText = "SELECT id, name, description, address, type, creatorID, date FROM K0_MAP_EVENTS WHERE ID = @id",

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
                        oEvent.id = (int)miLector["id"];
                        oEvent.name = (string)miLector["name"];
                        oEvent.description = (string)miLector["description"];
                        oEvent.address = (string)miLector["address"];
                        oEvent.type = (int)miLector["type"];
                        oEvent.creatorId = (string)miLector["creatorID"];
                        oEvent.date = (DateTime)miLector["date"];

                    }
                }
            }
            catch (SqlException excepcion)
            {

                throw excepcion;
            }

            return oEvent;
        }

        /// <summary>
        /// Método que borra una persona de la base de datos mediante su ID
        /// </summary>
        /// <param name="id">ID de la persona que queremos borrar.</param>
        /// <returns>Un int con el numero de filas afectadas.</returns>
        public int deleteEvent(int id)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "DELETE FROM K0_MAP_EVENT WHERE ID = @id",

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

        public int updateEvent(clsEvent oEvent)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "UPDATE K0_MAP_EVENTS SET id = @id, name = @name, description = @description, creatorID = @creatorID, date = @date WHERE ID = @id",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = oEvent.id;
            miComando.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = oEvent.name;
            miComando.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value = oEvent.description;
            miComando.Parameters.Add("@creatorID", System.Data.SqlDbType.VarChar).Value = oEvent.creatorId;
            miComando.Parameters.Add("@date", System.Data.SqlDbType.DateTime).Value = oEvent.date;
           
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
        /// Método para crear una oEvent en la base de datos
        /// </summary>
        /// <param name="oEvent">Persona con los atributos que queremos que se inserten en la base de datos</param>
        /// <returns>Int con las filas afectadas</returns>

        public int createEvent(clsEvent oEvent)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "INSERT INTO K0_MAP_EVENTS(name, description, address, type, creatorID, date) VALUES (@id, @name, @description, @address, @type, @creatorId, @date)",

                Connection = conexion.getConnection()


            };

            miComando.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = oEvent.name;
            miComando.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value = oEvent.description;
            miComando.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = oEvent.address;
            miComando.Parameters.Add("@type", System.Data.SqlDbType.Int).Value = oEvent.type;
            miComando.Parameters.Add("@creatorID", System.Data.SqlDbType.VarChar).Value = oEvent.creatorId;
            miComando.Parameters.Add("@date", System.Data.SqlDbType.DateTime).Value = oEvent.date;

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

