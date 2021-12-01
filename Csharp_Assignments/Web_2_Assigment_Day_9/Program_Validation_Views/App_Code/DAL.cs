using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Sql Connection File rp_MSsqlDB.
/// </summary>
public class DAL
{
    SqlConnection con = null;
    public DAL()
    {
        con = new SqlConnection();
        con.ConnectionString = "Server=.;Database=AspFormDB;Trusted_Connection=true";

        con.Open();

       
    }

    public bool Login(string username, string password)
    {

        try
        {
            SqlCommand cmd = new SqlCommand("loginProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("username", username);
            SqlParameter p2 = new SqlParameter("password", password);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (SqlException s)
        {
            Console.WriteLine(s.Message);
            return false;
        }
    }

    public bool insertData(string username, string password, string firstname , string lastname , string address , string state ,
string mobile , string birthdate , string remark)
    {

        try
        {
            SqlCommand cmd = new SqlCommand("insertData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            /*    SqlParameter p1 = new SqlParameter("username", username);
                SqlParameter p2 = new SqlParameter("password", password);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);*/


            cmd.Parameters.AddWithValue("username",username);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("firstname", firstname);
            cmd.Parameters.AddWithValue("lastname", lastname);
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("state", state);
            cmd.Parameters.AddWithValue("mobile", mobile);
            cmd.Parameters.AddWithValue("birthdate", birthdate);
            cmd.Parameters.AddWithValue("remark", remark);
            cmd.ExecuteNonQuery();
            return true;
          /*  if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }
        catch (SqlException s)
        {
            Console.WriteLine(s.Message);
            return false;
        }
    }


/*    ~DAL()
    {
        con.Close();
    }*/
}