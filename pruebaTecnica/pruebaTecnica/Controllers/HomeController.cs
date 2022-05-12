using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using pruebaTecnica.Models;

namespace pruebaTecnica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult AllItems()
        {
            DBConnection.StoreProcediur data = new DBConnection.StoreProcediur();
            DataTable dt = data.GetItem();
            ViewBag.Item = dt.Rows;
            return View();
        }

        public ActionResult DefectiveItem()
        {
            DBConnection.StoreProcediur data = new DBConnection.StoreProcediur();
            DataTable dt = data.GetDefectiveItem();
            ViewBag.Item = dt.Rows;
            return View();
        }

        public ActionResult GoodItem()
        {
            DBConnection.StoreProcediur data = new DBConnection.StoreProcediur();
            DataTable dt = data.GetGoodItem();
            ViewBag.Item = dt.Rows;
            return View();
        }

        public ActionResult CreateItem()
        {
            return View();
        }

        public ActionResult StorageItem(item item)
        {
            try
            {
                DBConnection.StoreProcediur data = new DBConnection.StoreProcediur();
                data.StorageItem(item);
                return RedirectToAction("AllItems");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult ItemOutput(int Id)
        {
            try
            {
                DBConnection.StoreProcediur data = new DBConnection.StoreProcediur();
                data.ItemOutput(Id);
                return RedirectToAction("AllItems");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult ChangeStatus(int Id)
        {
            try
            {
                DBConnection.StoreProcediur data = new DBConnection.StoreProcediur();
                data.ChangeStatus(Id);
                return RedirectToAction("AllItems");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}