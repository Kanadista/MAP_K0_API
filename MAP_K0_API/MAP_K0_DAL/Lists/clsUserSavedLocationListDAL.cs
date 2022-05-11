using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Lists
{
   public class clsUserSavedLocationListDAL
    {
        public List<clsUserSavedLocations> userSavedLocationList = new List<clsUserSavedLocations>();

        public List<clsUserSavedLocations> getList(List<clsUserSavedLocations> list)
        {

            clsUserSavedLocations userSavedLocation;

            clsMyConnection connection = new clsMyConnection();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT idUser, idLocation FROM K0_MAP_USERS_SAVED_LOCATIONS",

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
                        userSavedLocation = new clsUserSavedLocations();

                        userSavedLocation.idUser = (int)reader["idUser"];
                        userSavedLocation.idLocation = (int)reader["idLocation"];

                        list.Add(userSavedLocation);

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
            this.userSavedLocationList = getList(userSavedLocationList);
        }

        public List<clsUserSavedLocations> getListDAL()
        {
            return userSavedLocationList;
        }

        public clsUserSavedLocationListDAL()
        {
            setList();
        }

    }
}
