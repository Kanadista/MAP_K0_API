using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Lists
{
    public class clsEventAssistanceListDAL
    {
        public List<clsEventAssistance> eventAssistanceList = new List<clsEventAssistance>();

        public List<clsEventAssistance> getList(List<clsEventAssistance> list)
        {
            clsEventAssistance eventAssistance;

            clsMyConnection connection = new clsMyConnection();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT idEvent, idUser FROM K0_MAP_EVENT_ASSISTANCE",

                Connection = connection.getConnection()

            };

            SqlDataReader reader;

            try
            {

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        eventAssistance = new clsEventAssistance();

                        eventAssistance.idEvent = (int)reader["idEvent"];
                        eventAssistance.idUser = (string)reader["idUser"];
               
                        list.Add(eventAssistance);

                    }
                }
            }
            catch (SqlException excepcion)
            {

                throw excepcion;
            }

            return list;
        }


        public void setList()
        {
            this.eventAssistanceList = getList(eventAssistanceList);
        }

        public List<clsEventAssistance> getListDAL()
        {
            return eventAssistanceList;
        }

        public clsEventAssistanceListDAL()
        {
            setList();
        }
    }

}

