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
        public List<clsLocationImage> locationImageList = new List<clsLocationImage>();

        public List<clsLocationImage> getList(List<clsLocationImage> list)
        {

            clsLocationImage locationImage;

            clsMyConnection connection = new clsMyConnection();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT idLocation, idImage, image FROM K0_MAP_LOCATION_IMAGES",

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


        public void setList()
        {
            this.locationImageList = getList(locationImageList);
        }

        public List<clsLocationImage> getListDAL()
        {
            return locationImageList;
        }

        public clsLocationImageListDAL()
        {
            setList();
        }
    }
}
