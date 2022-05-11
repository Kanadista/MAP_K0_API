using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Lists
{
   public class clsLocationListDAL
    {
            public List<clsLocation> locationList = new List<clsLocation>();

            public List<clsLocation> getList(List<clsLocation> list)
            {

                clsLocation oLocation;

                clsMyConnection connection = new clsMyConnection();

                SqlCommand command = new SqlCommand
                {
                    CommandText = "SELECT id, name, description, latitud, longitude, creatorID FROM K0_MAP_LOCATIONS",

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
                            oLocation = new clsLocation();

                            oLocation.id = (int)reader["id"];
                            oLocation.name = (string)reader["name"];
                            oLocation.description = (string)reader["description"];
                            oLocation.latitud = (decimal)reader["latitud"];
                            oLocation.longitude = (decimal)reader["longitude"];
                            oLocation.creatorId = (int)reader["creatorID"];
                       
                            list.Add(oLocation);

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
                this.locationList = getList(locationList);
            }

            public List<clsLocation> getListDAL()
            {
                return locationList;
            }

            public clsLocationListDAL()
            {
                setList();
            }
        }
    }

