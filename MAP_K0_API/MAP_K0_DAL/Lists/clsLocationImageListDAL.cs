using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Lists
{
    public class clsLocationImageListDAL
    {

        public List<clsLocationImage> getList(int idLocation)
        {
            List<clsLocationImage> list = new List<clsLocationImage>();
            clsLocationImage locationImage;

            clsMyConnection connection = new clsMyConnection();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT idLocation, idImage, image FROM K0_MAP_LOCATION_IMAGES WHERE idLocation = @idLocation",

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
                        locationImage = new clsLocationImage();

                        locationImage.idLocation = (int)reader["idLocation"];
                        locationImage.idImage = (int)reader["idImage"];
                        locationImage.image = (byte[])reader["image"];
              
                        list.Add(locationImage);

                    }
                }
            }
            catch (SqlException excepcion)
            {

                throw excepcion;
            }

            return list;
        }


        public List<clsLocationImage> getListDAL(int id)
        {
            return getList(id);
        }

    }
}
