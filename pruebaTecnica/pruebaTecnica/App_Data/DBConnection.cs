using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using pruebaTecnica.Models;
/// <summary>
/// Summary description for ConnectionDataBase
/// </summary>
/// 
public class DBConnection
{
    public class StoreProcediur
    {
        public DataTable GetItem()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                SqlDataAdapter da = new SqlDataAdapter("SP_GetItem", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetDefectiveItem()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                SqlDataAdapter da = new SqlDataAdapter("SP_GetDefectiveItem", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetGoodItem()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                SqlDataAdapter da = new SqlDataAdapter("SP_GetGoodItem", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable StorageItem(item model)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                SqlDataAdapter da = new SqlDataAdapter("SP_StorageItem", con);
                da.SelectCommand.Parameters.Add("@pName", SqlDbType.VarChar).Value = model.Name;
                da.SelectCommand.Parameters.Add("@pState", SqlDbType.VarChar).Value = model.State;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ItemOutput(int Id)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                SqlDataAdapter da = new SqlDataAdapter("SP_deleteItem", con);
                da.SelectCommand.Parameters.Add("@pId", SqlDbType.VarChar).Value = Id;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ChangeStatus(int Id)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                SqlDataAdapter da = new SqlDataAdapter("SP_changeStatus", con);
                da.SelectCommand.Parameters.Add("@pId", SqlDbType.VarChar).Value = Id;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}