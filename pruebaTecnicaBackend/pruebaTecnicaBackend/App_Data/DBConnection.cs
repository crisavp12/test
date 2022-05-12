using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using pruebaTecnicaBackend.Models;
/// <summary>
/// Summary description for ConnectionDataBase
/// </summary>
/// 
public class DBConnection
{
    public class StoreProcediur
    {
        public static List<Item> GetItem(int type)
        {
            List<Item> itemList = new List<Item>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString))
            try
                {
                    //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                    //SqlDataAdapter da = new SqlDataAdapter("SP_GetItem", connection);
                    //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    SqlCommand cmd = new SqlCommand();
                    if (type == 1)
                    {
                        cmd = new SqlCommand("SP_GetDefectiveItem", connection);
                    }
                    else if (type == 2)
                    {
                        cmd = new SqlCommand("SP_GetGoodItem", connection);
                    }
                    else
                    {
                        cmd = new SqlCommand("SP_GetItem", connection);
                    }
                    
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            itemList.Add(new Item()
                            {
                                Id = Convert.ToInt32(dr["it_id"]),
                                Name = dr["it_name"].ToString(),
                                State = Convert.ToInt32(dr["it_state"])
                            });
                        }

                    }

                return itemList ;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool StorageItem(Item item)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_StorageItem", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pName", SqlDbType.VarChar).Value = item.Name;
                cmd.Parameters.AddWithValue("@pState", SqlDbType.Int).Value = item.State;

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool ItemOutput(int Id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_deleteItem", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId", SqlDbType.Int).Value = Id;

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool ChangeStatus(int Id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_changeStatus", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId", SqlDbType.Int).Value = Id;

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }
}