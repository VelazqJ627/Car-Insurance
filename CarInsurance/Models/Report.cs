using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class Report
    {
        //private variable

        private int rId = 0;
        private string userId = "n/a";
        private string userPlate = "n/a";
        private string rDate = "n/a";
        private string rAddress = "n/a";
        private string rCity = "n/a";
        private int rZip = 0;
        private string rDesc = "n/a";
        private string rName = "n/a";
        private string rPlate = "n/a";
        private string rInsurance = "n/a";
        private string rPolNum = "n/a";
        private int rMin = 0;
        private int rMax = 0;
        private string rShop = "n/a";
        private string image = "n/a";

        //gets and sets

        public int RId
        {
            get { return this.rId; }
            set { this.rId = value; }
        }

        public string UserId { get { return this.userId; } set { this.userId = value; } }
        public string UserPlate { get { return this.userPlate; } set { this.userPlate = value; } }
        public string RDate { get { return this.rDate; } set { this.rDate = value; } }
        public string RAddress { get { return this.rAddress; } set { this.rAddress = value; } }
        public string RCity { get { return this.rCity; } set { this.rCity = value; } }
        public int RZip { get { return this.rZip; } set { this.rZip = value; } }
        public string RDesc { get { return this.rDesc; } set { this.rDesc = value; } }
        public string RName { get { return this.rName; } set { this.rName = value; } }
        public string RPlate { get { return this.rPlate; } set { this.rPlate = value; } }
        public string RInsurance { get { return this.rInsurance; } set { this.rInsurance = value; } }
        public string RPolNum { get { return this.rPolNum; } set { this.rPolNum = value; } }
        public int RMin { get { return this.rMin; } set { this.rMin = value; } }
        public int RMax { get { return this.rMax; } set { this.rMax = value; } }
        public string RShop { get { return this.rShop; } set { this.rShop = value; } }
        public string Image { get { return this.image; } set { this.image = value; } }

        //tostring

        public override string ToString()
        {
            string aMessage = "n/a";
            aMessage = aMessage + "RId: " + RId + "/n";
            aMessage = aMessage + "UserId: " + UserId + "/n";
            aMessage = aMessage + " UserPlate: " + UserPlate + "/n";
            aMessage = aMessage + " RDate: " + RDate + "/n";
            aMessage = aMessage + " RAddress: " + RAddress + "/n";
            aMessage = aMessage + " RCity: " + RCity + "/n";
            aMessage = aMessage + " RZip: " + RZip + "/n";
            aMessage = aMessage + " RDesc: " + RDesc+"/n";
            aMessage = aMessage + " RName: " + RName + "/n";
            aMessage = aMessage + " RPlate: " + RPlate + "/n";
            aMessage = aMessage + " RInsurance: " + RInsurance + "/n";
            aMessage = aMessage + " RPollNum: " + RPolNum + "/n";
            aMessage = aMessage + " RMin: " + RMin + "/n";
            aMessage = aMessage + " RMax: " + RMax + "/n";
            aMessage = aMessage + " RShop: " + RShop + "/n";
            aMessage = aMessage + "Image : " + Image + "/n";
            return aMessage;
        }

        //constructor

        public Report() { }
        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress, string aRCity, int aRZip, string aRDesc, string aRName, string aRPlate, string aRInsurance, string aRPolNum, int aRMin, int aRMax, string aRShop, string aImage)
        {
            this.RId = aRId;
            this.UserId = aUserId;
            this.UserPlate = aUserPlate;
            this.RDate = aRDate;
            this.RAddress = aRAddress;
            this.RCity = aRCity;
            this.RZip = aRZip;
            this.RDesc = aRDesc;
            this.RName = aRName;
            this.RPlate = aRPlate;
            this.RInsurance = aRInsurance;
            this.RPolNum = aRPolNum;
            this.RMin = aRMin;
            this.RMax = aRMax;
            this.RShop = aRShop;
            this.Image = aImage;
        }

        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress, string aRCity, int aRZip, string aRDesc, string aRName, string aRPlate, string aRInsurance, string aRPolNum, int aRMin, int aRMax, string aRShop)
            : this(aRId, aUserId, aUserPlate, aRDate, aRAddress, aRCity, aRZip, aRDesc, aRName, aRPlate, aRInsurance, aRPolNum, aRMin, aRMax, aRShop, "n/a")
        { }

        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress, string aRCity, int aRZip, string aRDesc, string aRName, string aRPlate, string aRInsurance, string aRPolNum, int aRMin, int aRMax)
            : this( aRId,  aUserId,  aUserPlate,  aRDate,  aRAddress,  aRCity,  aRZip,  aRDesc,  aRName,  aRPlate,  aRInsurance,  aRPolNum, aRMin, aRMax, "n/a",  "n/a")
        { }
        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress, string aRCity, int aRZip, string aRDesc, string aRName, string aRPlate, string aRInsurance, string aRPolNum, int aRMin)
            : this(aRId, aUserId, aUserPlate, aRDate, aRAddress, aRCity, aRZip, aRDesc, aRName, aRPlate, aRInsurance, aRPolNum, aRMin, 0, "n/a",  "n/a")
        { }

        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress, string aRCity, int aRZip, string aRDesc, string aRName, string aRPlate, string aRInsurance, string aRPolNum)
            : this(aRId, aUserId, aUserPlate, aRDate, aRAddress, aRCity, aRZip, aRDesc, aRName, aRPlate, aRInsurance, aRPolNum, 0, 0, "n/a",  "n/a")
        { }

        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress, string aRCity, int aRZip, string aRDesc, string aRName, string aRPlate, string aRInsurance )
            : this(aRId, aUserId, aUserPlate, aRDate, aRAddress, aRCity, aRZip, aRDesc, aRName, aRPlate, aRInsurance, "n/a", 0, 0, "n/a",  "n/a")
        { }

        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress, string aRCity, int aRZip, string aRDesc, string aRName, string aRPlate)
            : this(aRId, aUserId, aUserPlate, aRDate, aRAddress, aRCity, aRZip, aRDesc, aRName, aRPlate, "n/a", "n/a", 0, 0, "n/a",  "n/a")
        { }

        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress, string aRCity, int aRZip, string aRDesc, string aRName)
            : this(aRId, aUserId, aUserPlate, aRDate, aRAddress, aRCity, aRZip, aRDesc, aRName, "n/a", "n/a", "n/a", 0, 0, "n/a",  "n/a")
        { }

        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress, string aRCity, int aRZip, string aRDesc)
            : this(aRId, aUserId, aUserPlate, aRDate, aRAddress, aRCity, aRZip, aRDesc, "n/a", "n/a", "n/a", "n/a", 0, 0, "n/a",  "n/a")
        { }

        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress, string aRCity, int aRZip)
            : this(aRId, aUserId, aUserPlate, aRDate, aRAddress, aRCity, aRZip, "n/a", "n/a", "n/a", "n/a", "n/a", 0, 0, "n/a",  "n/a")
        { }

        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress, string aRCity)
            : this(aRId, aUserId, aUserPlate, aRDate, aRAddress, aRCity, 0, "n/a", "n/a", "n/a", "n/a", "n/a", 0, 0, "n/a",  "n/a")
        { }

        public Report(int aRId, string aUserId, string aUserPlate, string aRDate, string aRAddress)
            : this(aRId, aUserId, aUserPlate, aRDate, aRAddress, "n/a", 0, "n/a", "n/a", "n/a", "n/a", "n/a", 0, 0, "n/a",  "n/a")
        { }

        public Report(int aRId, string aUserId, string aUserPlate, string aRDate)
            : this(aRId, aUserId, aUserPlate, aRDate, "n/a", "n/a", 0, "n/a", "n/a", "n/a", "n/a", "n/a", 0, 0, "n/a",  "n/a")
        { }

        public Report(int aRId, string aUserId, string aUserPlate)
            : this(aRId, aUserId, aUserPlate, "n/a", "n/a", "n/a", 0, "n/a", "n/a", "n/a", "n/a", "n/a", 0, 0, "n/a",  "n/a")
        { }

        public Report(int aRId, string aUserId)
            : this(aRId, aUserId, "n/a", "n/a", "n/a", "n/a", 0, "n/a", "n/a", "n/a", "n/a", "n/a", 0, 0, "n/a",  "n/a")
        { }

        public Report(int aRId)
            : this(aRId, "n/a", "n/a", "n/a", "n/a", "n/a", 0, "n/a", "n/a", "n/a", "n/a", "n/a", 0, 0, "n/a",  "n/a")
        { }



    }
}