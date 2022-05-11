using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Handlers
{
   public class clsEventAssistanceHandlerDAL
    {

        public clsEventAssistance getEventAssistanceById(int idEvent, int idUser)
        {

            clsEventAssistance eventAssistance = new clsEventAssistance();

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "SELECT idEvent, idUser FROM K0_MAP_EVENT_ASSISTANCE WHERE idEvent = @idEvent and idUser = @idUser",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@idEvent", System.Data.SqlDbType.Int).Value = idEvent;
            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.Int).Value = idUser;

            SqlDataReader miLector;

            try
            {

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        eventAssistance.idEvent = (int)miLector["idEvent"];
                        eventAssistance.idUser = (int)miLector["idUser"];

                    }
                }
            }
            catch (SqlException excepcion)
            {

                throw excepcion;
            }

            return eventAssistance;
        }

        /// <summary>
        /// Método que borra una persona de la base de datos mediante su ID
        /// </summary>
        /// <param name="id">ID de la persona que queremos borrar.</param>
        /// <returns>Un int con el numero de filas afectadas.</returns>
        public int deleteEventAssistance(int idEvent, int idUser)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {


                CommandText = "DELETE FROM K0_MAP_EVENT_ASSISTANCE WHERE idEvent = @idEvent and idUser = @idUser",

                Connection = conexion.getConnection()

            };

            miComando.Parameters.Add("@idEvent", System.Data.SqlDbType.Int).Value = idEvent;
            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.Int).Value = idUser;

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

        public int updateEventAssistance(clsEventAssistance eventAssistance)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "UPDATE K0_MAP_EVENT_ASSISTANCE SET idEvent = @idEvent, idUser = @idUser WHERE idEvent = @idEvent AND idUser = @idUser",

                Connection = conexion.getConnection()
            };

            miComando.Parameters.Add("@idEvent", System.Data.SqlDbType.Int).Value = eventAssistance.idEvent;
            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.Int).Value = eventAssistance.idUser;
 
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
        /// Método para crear una eventAssistance en la base de datos
        /// </summary>
        /// <param name="eventAssistance">Persona con los atributos que queremos que se inserten en la base de datos</param>
        /// <returns>Int con las filas afectadas</returns>

        public int createEventAssistance(clsEventAssistance eventAssistance)
        {
            int filasAfectadas = 0;

            clsMyConnection conexion = new clsMyConnection();

            SqlCommand miComando = new SqlCommand
            {

                CommandText = "INSERT INTO K0_MAP_EVENT_ASSISTANCE(idEvent, idUser) VALUES (@idEvent, @idUser)",

                Connection = conexion.getConnection()


            };

            miComando.Parameters.Add("@idEvent", System.Data.SqlDbType.Int).Value = eventAssistance.idEvent;
            miComando.Parameters.Add("@idUser", System.Data.SqlDbType.VarChar).Value = eventAssistance.idUser;
   
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

