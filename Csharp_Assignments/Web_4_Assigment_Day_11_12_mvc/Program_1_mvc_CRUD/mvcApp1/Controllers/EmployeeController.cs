using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcApp1.Models;
using mvcApp1.BAL;
namespace mvcApp1.Controllers
{
    public class EmployeeController : Controller
    {
        AppBAL bal = new AppBAL();
        public ActionResult Index()
        {
            List<EmpModel> dlist = bal.GetDeptList();
            return View(dlist);
        }

        [HttpGet]
        public ActionResult InsertDept()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertDept(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    EmpModel em = new EmpModel();
                    em.empno = Convert.ToInt32(collection["empno"].ToString());
                    em.empname = collection["empname"].ToString();
                    em.designation = collection["designation"].ToString();
                    em.deptname = collection["deptname"].ToString();
                    bal.InsertDepartment(em);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    TempData["err"] = ex.Message;
                    TempData["backpage"] = "InsertDept";
                    return RedirectToAction("ErrorPage");
                }

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateDept(int id)
        {
            EmpModel em = bal.GetDeptusingdno(id);
            return View(em);
        }

        [HttpPost]
        public ActionResult UpdateDept(FormCollection collection)
        {
            try
            {
                EmpModel em = new EmpModel();
                em.empno = Convert.ToInt32(collection["empno"].ToString());
                em.empname = collection["empname"].ToString();
                em.designation = collection["designation"].ToString();
                em.deptname = collection["deptname"].ToString();
                bal.UpdateDepartment(em);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "Index";
                return RedirectToAction("ErrorPage");
            }

        }

        [HttpGet]
        public ActionResult DeleteDept(int id)
        {
            try
            {
                bal.DeleteDepartment(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "Index";
                return RedirectToAction("ErrorPage");
            }
        }

        [HttpGet]
        public ActionResult DetailsDept(int id)
        {
            EmpModel em = bal.GetDeptusingdno(id);
            return View(em);
        }

        [HttpGet]
        public ActionResult ErrorPage()
        {
            TempData.Keep("err");
            TempData.Keep("InsertDept");
            return View();
        }
    }
}