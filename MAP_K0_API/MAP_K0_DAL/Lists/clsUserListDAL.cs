﻿using MAP_K0_DAL.Connection;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MAP_K0_DAL.Lists
{
   public class clsUserListDAL
    {
        public List<clsUser> userList = new List<clsUser>();

        public List<clsUser> getList(List<clsUser> list)
        {

            clsUser oUser;

            clsMyConnection connection = new clsMyConnection();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT id, nickName, firstName, lastName, address FROM K0_MAP_USERS",

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
                        oUser = new clsUser();

                        oUser.id = (string)reader["id"];
                        oUser.email = (string)reader["email"];
                        oUser.firstName = (string)reader["firstName"];
                        oUser.lastName = (string)reader["lastName"];
                        oUser.address = (string)reader["address"];
                        list.Add(oUser);

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
            this.userList = getList(userList);
        }

        public List<clsUser> getListDAL()
        {
            return userList;
        }

        public clsUserListDAL()
        {
            setList();
        }
    }
}

