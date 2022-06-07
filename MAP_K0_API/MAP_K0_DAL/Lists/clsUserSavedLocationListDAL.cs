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

        public List<clsUserSavedLocations> getList(String idUser)
        {

            clsUserSavedLocations userSavedLocation;
            List<clsUserSavedLocations> list = new List<clsUserSavedLocations>();
            clsMyConnection connection = new clsMyConnection();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT idUser, idLocation FROM K0_MAP_USER_SAVED_LOCATIONS WHERE idUser = @idUser",

                Connection = connection.getConnection()

            };

            command.Parameters.Add("@idUser", System.Data.SqlDbType.VarChar).Value = idUser;
            SqlDataReader reader;

            try
            {

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userSavedLocation = new clsUserSavedLocations();

                        userSavedLocation.idUser = (string)reader["idUser"];
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


        public List<clsUserSavedLocations> getListDAL(String idUser)
        {
            return userSavedLocationList;
        }

    }
}
