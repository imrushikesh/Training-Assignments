using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data;
using System.Data.Entity;
using System.Web.Http;

/*
 * 
 * Author  : Rushikesh Patil.
 * version :
 * Description :
 * Requirments :
*/
namespace WebApi2.Controllers
{
    public class DemoController : ApiController
    {

        mvcDBEntities obj = new mvcDBEntities();
        public List<mvcEmpTable> get()
        {
          
            List<mvcEmpTable> det = new List<mvcEmpTable>();
            foreach (mvcEmpTable d in obj.mvcEmpTables)
            {
                det.Add(d);
            }
            return det;
        
        }


        public mvcEmpTable get(int id)
        {
            return obj.mvcEmpTables.Find(id);

        }


        [HttpPost]
        public List<mvcEmpTable> Create(mvcEmpTable m)
        {

            obj.mvcEmpTables.Add(m);
            obj.SaveChanges();

            List<mvcEmpTable> det = new List<mvcEmpTable>();
            foreach (mvcEmpTable d in obj.mvcEmpTables)
            {
                det.Add(d);
            }
            return det;
           
        }


    


        [HttpPut]
        public List<mvcEmpTable> EditData(int id, mvcEmpTable m)
        {
 
            
            mvcEmpTable me1 = obj.mvcEmpTables.Find(id);
            me1.empno = m.empno;
            me1.empname = m.empname;
            me1.designation = m.designation;
            me1.deptname = m.deptname;
            obj.SaveChanges();

            List<mvcEmpTable> det = new List<mvcEmpTable>();
            foreach (mvcEmpTable d in obj.mvcEmpTables)
            {
                det.Add(d);
            }
            return det;
        }
        [HttpDelete]
        public List<mvcEmpTable> DeleteData(int id)
        {

            mvcEmpTable m = obj.mvcEmpTables.Find(id);

            obj.mvcEmpTables.Remove(m);
            obj.SaveChanges();


            List<mvcEmpTable> det = new List<mvcEmpTable>();
            foreach (mvcEmpTable d in obj.mvcEmpTables)
            {
                det.Add(d);
            }
            return det;



        }

    }
}
