using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Lists
{
    public class clsEventListDAL
    {
        public List<clsEvent> eventList = new List<clsEvent>();

        public List<clsEvent> getList(List<clsEvent> list){
        
            clsEvent oEvent;

            clsMyConnection connection = new clsMyConnection();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT id, name, description, address, type, creatorID, date FROM K0_MAP_EVENTS",

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
                        oEvent = new clsEvent();

                        oEvent.id = (int)reader["id"];
                        oEvent.name = (string)reader["name"];
                        oEvent.description = (string)reader["description"];
                        oEvent.address = (string)reader["address"];
                        oEvent.type = (int)reader["type"];
                        oEvent.creatorId = (string)reader["creatorID"];
                        oEvent.date = (DateTime)reader["date"];        

                        list.Add(oEvent);

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
            this.eventList = getList(eventList);
        }

        public List<clsEvent> getListDAL()
        {
            return eventList;
        }

        public clsEventListDAL()
        {
            setList();
        }
    }
}

