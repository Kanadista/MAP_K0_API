using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Lists
{
    public class clsUserRatingLocationListDAL
    {
        public List<clsUserRatingLocation> userRatingLocationList = new List<clsUserRatingLocation>();

        public List<clsUserRatingLocation> getList(int idLocation)
        {
            List<clsUserRatingLocation> list = new List<clsUserRatingLocation>();

            clsUserRatingLocation userRatingLocation;

            clsMyConnection connection = new clsMyConnection();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT idUser, idLocation, stars, comment FROM K0_MAP_USER_RATING_LOCATIONS WHERE idLocation = @idLocation",

                Connection = connection.getConnection()

            };


            command.Parameters.Add("@idLocation", System.Data.SqlDbType.Int).Value = idLocation;

            SqlDataReader reader;

            try
            {

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userRatingLocation = new clsUserRatingLocation();

                        userRatingLocation.idUser = (string)reader["idUser"];
                        userRatingLocation.idLocation = (int)reader["idLocation"];
                        userRatingLocation.stars = (Int16)reader["stars"];
                        userRatingLocation.comment = (string)reader["comment"];
           
                        list.Add(userRatingLocation);

                    }
                }
            }
            catch (SqlException excepcion)
            {

                throw excepcion;
            }

            return list;
        }


        public List<clsUserRatingLocation> getListDAL(int id)
        {
            return getList(id);
        } 
    }
}

