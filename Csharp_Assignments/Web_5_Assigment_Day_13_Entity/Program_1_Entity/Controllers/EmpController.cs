using Program_2_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Program_2_EntityFramework.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        mvcDBEntities2 me = new mvcDBEntities2();
        public ActionResult Index()
        {
            return View(me.mvcEmpTables);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(mvcEmpTable m)
        {

            //mvcEmpTable e = new mvcEmpTable();
            //e.empno = Convert.ToInt32(collection["empno"].ToString());
            //e.ename = collection["ename"].ToString();
            //e.designation = collection["designation"].ToString();
            //e.deptno = Convert.ToInt32(collection["deptno"].ToString());
            //e.mgrid = Convert.ToInt32(collection["mgrid"].ToString());
            //e.salary = Convert.ToDecimal(collection["salary"].ToString());
            me.mvcEmpTables.Add(m);
            me.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(me.mvcEmpTables.Find(id));

        }


        [HttpPost]
        public ActionResult Edit(mvcEmpTable e1, FormCollection collection)
        {
            mvcEmpTable me1 = me.mvcEmpTables.Find(e1.empno);
            me1.empno = Convert.ToInt32(collection["empno"].ToString());
            me1.empname = collection["empname"].ToString();
            me1.designation = collection["designation"].ToString();
            me1.deptname = collection["deptname"].ToString();
            me.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(me.mvcEmpTables.Find(id));

        }

        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {

            mvcEmpTable med = me.mvcEmpTables.Find(Convert.ToInt32(collection["hdnempno"].ToString()));
   
            me.mvcEmpTables.Remove(med);
            me.SaveChanges();

    

            return RedirectToAction("Index");



        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            mvcEmpTable me3 = me.mvcEmpTables.Find(id);
            return View(me3);
        }
    }
}