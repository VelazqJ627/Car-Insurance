using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Odbc;

namespace CarInsurance.Models
{
    public class DbConnection
    {

        private List<Report> aListOfReport = new List<Report>();


        //Start of GetOrders Method

        public List<Report> GetReport()
        {
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            //basic sql
            string aSQL = "SELECT RId, Id, UserPlate, RDate, RAddress, RCity, RZip, RDesc, RName, RPlate, RInsurance, RPolNum, RMin, RMax, RShop, Image FROM Report;";
            //@"provider etc = depends on your driver ;Data SOurce=connection to the database string 
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=MSI;Initial Catalog=Report;Integrated Security=SSPI;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;

            //run sql and run it into aReader variable which turns it into a spreadsheet
            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aRId = (int)aReader["RId"];
                string aUserId = (string)aReader["Id"];
                string aUserPlate = (string)aReader["UserPlate"];
                string aRDate = (string)aReader["RDate"];
                string aRAddress = (string)aReader["RAddress"];
                string aRCity = (string)aReader["RCity"];
                int aRZip = (int)aReader["RZip"];
                string aRDesc = (string)aReader["RDesc"];
                string aRName = (string)aReader["RName"];
                string aRPlate = (string)aReader["RPlate"];
                string aRInsurance = (string)aReader["RInsurance"];
                string aRPolNum = (string)aReader["RPolNum"];
                int aRMin = (int)aReader["RMin"];
                int aRMax = (int)aReader["RMax"];
                string aRShop = (string)aReader["RShop"];
                string aImage = (string)aReader["Image"];
                

                Report aReport = new Report();

                aReport.RId = aRId;
                aReport.UserId = aUserId;
                aReport.UserPlate = aUserPlate;
                aReport.RDate = aRDate;
                aReport.RAddress = aRAddress;
                aReport.RCity = aRCity;
                aReport.RZip = aRZip;
                aReport.RDesc = aRDesc;
                aReport.RName = aRName;
                aReport.RPlate = aRPlate;
                aReport.RInsurance = aRInsurance;
                aReport.RPolNum = aRPolNum;
                aReport.RMin = aRMin;
                aReport.RMax = aRMax;
                aReport.RShop = aRShop;
                aReport.Image = aImage;
                

                aListOfReport.Add(aReport);
            }
            aConnection.Close();

            return aListOfReport;
        }

        public bool InsertReport(string UserId, string UserPlate, string RDate, string RAddress, string RCity, int RZip, string RDesc, string RName, string RPlate, string RInsurance, string RPolNum, int RMin, int RMax, string RShop, string Image )

        {

            bool aFlag = false;
            string aSQL = "INSERT INTO Report (Id, UserPlate, RDate, RAddress, RCity, RZip, RDesc, RName, RPlate, RInsurance, RPolNum, RMin, RMax, RShop, Image )";
            aSQL = aSQL + "VALUES('" + UserId + "','" + UserPlate + "', '" + RDate + "','" + RAddress + "','" + RCity + "', '" + RZip + "','" + RDesc + "','" + RName + "','" + RPlate + "', '" + RInsurance + "','" + RPolNum + "','" + RMin + "', '" + RMax + "','" + RShop + "','" + Image + "') ";

            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            //CHANGE ME
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=MSI;Initial Catalog=Report;Integrated Security=SSPI;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }
    }
}