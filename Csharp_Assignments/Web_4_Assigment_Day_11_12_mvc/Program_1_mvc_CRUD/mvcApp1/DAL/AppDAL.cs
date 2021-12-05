using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace mvcApp1.DAL
{
    public class AppDAL
    {
        public SqlDataReader GetDepartment()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=mvcDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("showEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception in show Emp " + ex.Message);
                throw;

            }
            return reader;
        }

        public SqlDataReader GetDepartmentUsingDno(int empno)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=mvcDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getEmpusingEmpNo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("empno", empno);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return reader;
        }

        public int InsertDepartment(int empno, string empname, string designation, string deptname)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=mvcDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empno", empno);
                cmd.Parameters.AddWithValue("empname", empname);
                cmd.Parameters.AddWithValue("designation", designation);
                cmd.Parameters.AddWithValue("deptname", deptname);

                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception  in insert emp" + ex.Message);
                throw;
            }
            return no;
        }

        public int UpdateDepartment(int empno, string empname, string designation, string deptname)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=mvcDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("updateEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empno", empno);
                cmd.Parameters.AddWithValue("empname", empname);
                cmd.Parameters.AddWithValue("designation", designation);
                cmd.Parameters.AddWithValue("deptname", deptname);

                no = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception in update emp " + ex.Message);
                throw;
            }
            return no;
        }

        public int DeleteDepartment(int empno)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=mvcDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("deleteEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empno", empno);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception in delete emp " + ex.Message);
                throw;
            }
            return no;
        }

    }
}