using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using System.Data;
using Microsoft.AspNet.Identity;
using System.IO;


namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        
        DbConnection aConnection = new DbConnection();

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult InsertReport(string UserId, string UserPlate, string RDate, string RAddress, string RCity, int RZip, string RDesc, string RName, string RPlate, string RInsurance, string RPolNum, int RMin, int RMax, string RShop, string Image, HttpPostedFileBase file)
        {

            
            if (file != null)
            {
                string path = Path.Combine(Server.MapPath("~/Content/Images"), Path.GetFileName(file.FileName));
                file.SaveAs(path);
            }
            


            var aUserId = User.Identity.GetUserId();
            var aImage = Path.GetFileName(file.FileName);
            
            ViewBag.UserId = aUserId;
            ViewBag.UserPlate = UserPlate;
            ViewBag.RDate = RDate.ToString();
            ViewBag.RAddress = RAddress;
            ViewBag.RCity = RCity;
            ViewBag.RZip = RZip;
            ViewBag.RDesc = RDesc;
            ViewBag.RName = RName;
            ViewBag.RPlate = RPlate;
            ViewBag.RInsurance = RInsurance;
            ViewBag.RPolNum = RPolNum;
            ViewBag.RMin = RMin;
            ViewBag.RMax = RMax;
            ViewBag.RShop = RShop;
            ViewBag.Image = aImage;
            


            DbConnection aConnection = new DbConnection();

            aConnection.InsertReport(aUserId,UserPlate, RDate, RAddress, RCity, RZip, RDesc, RName, RPlate, RInsurance, RPolNum, RMin, RMax, RShop, aImage);
            string aSQL = "INSERT INTO Report (Id, UserPlate, RDate, RAddress, RCity, RZip, RDesc, RName, RPlate, RInsurance, RPolNum, RMin, RMax, RShop, Image )";
            aSQL = aSQL + "VALUES('" + UserId + "','" + UserPlate + "', '" + RDate + "','" + RAddress + "','" + RCity + "', '" + RZip + "','" + RDesc + "','" + RName + "','" + RPlate + "', '" + RInsurance + "','" + RPolNum + "','" + RMin + "', '" + RMax + "','" + RShop + "','" + Image + "') ";
            ViewBag.SQL = aSQL;
            return View();
        }



        [Authorize]
        public ActionResult InsertReportForm()
        {
            return View();
        }
        [Authorize]
        public ActionResult GetReport()
        {
            List<Report> aListOfReport = new List<Report>();
            aListOfReport = aConnection.GetReport();

            ViewBag.ListOfReport = aListOfReport;
            return View();
        }
        [Authorize]
        public ActionResult ReportDetail(string UserId)
        {
            List<Report> aListOfReport = new List<Report>();
            aListOfReport = aConnection.GetReport();

            var reportDetail = from c in aListOfReport
                                  where c.UserId == UserId
                                  select c;
            UserId = User.Identity.GetUserId();
            ViewBag.ListOfReport = reportDetail;
            ViewBag.UserId = UserId;
            return View();
        }


    }
}