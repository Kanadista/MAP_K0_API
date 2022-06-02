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

        public List<clsUserRatingLocation> getList(List<clsUserRatingLocation> list)
        {

            clsUserRatingLocation userRatingLocation;

            clsMyConnection connection = new clsMyConnection();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT idUser, idLocation, stars, comment FROM K0_MAP_USER_RATING_LOCATIONS",

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


        public void setList()
        {
            this.userRatingLocationList = getList(userRatingLocationList);
        }

        public List<clsUserRatingLocation> getListDAL()
        {
            return userRatingLocationList;
        }

        public clsUserRatingLocationListDAL()
        {
            setList();
        }
    }
}

