using mvcApp1.DAL;
using mvcApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace mvcApp1.BAL
{
    public class AppBAL
    {
        AppDAL dal = new AppDAL();
        
        // Methods ---------
        public List<EmpModel> GetDeptList()
        {
            SqlDataReader reader = dal.GetDepartment();
            List<EmpModel> list_1 = new List<EmpModel>();
            while (reader.Read())
            {
                EmpModel em = new EmpModel();
                em.empno = Convert.ToInt32(reader["empno"].ToString());
                em.empname = reader["empname"].ToString();
                em.designation = reader["designation"].ToString();
                em.deptname = reader["deptname"].ToString();
                list_1.Add(em);
            }
            return list_1;
        }



        public EmpModel GetDeptusingdno(int empno)
        {
            SqlDataReader reader = dal.GetDepartmentUsingDno(empno);
            EmpModel em = null;
            while (reader.Read())
            {
                em = new EmpModel();
                em.empno = Convert.ToInt32(reader["empno"].ToString());
                em.empname = reader["empname"].ToString();
                em.designation = reader["designation"].ToString();
                em.deptname = reader["deptname"].ToString();
            }
            return em;
        }

        public int InsertDepartment(EmpModel em)
        {
            int res = dal.InsertDepartment(em.empno, em.empname, em.designation, em.deptname);
            return res;

        }

        public int UpdateDepartment(EmpModel em)
        {
            int res = dal.UpdateDepartment(em.empno, em.empname, em.designation, em.deptname);
            return res;

        }

        public int DeleteDepartment(int empno)
        {
            int res = dal.DeleteDepartment(empno);
            return res;

        }


    }
}