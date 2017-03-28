using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimMeetLibrary
{
   public struct Adress
    {
        private string street;
        private string city;
        private string province;
        private string zip;

        

        #region Constructor
        public Adress(string street, string city, string province, string zip)
        {
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;

        }
        #endregion

        #region ToString Method
        public override string ToString()
        {
            return string.Format("\n\t {0} \n\t {1} \n\t {2} \n\t {3} ", Street, City, Province, Zip);
        }
        #endregion

        #region Properties
        public string Street
        {
            get
            {
                return street;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
        }

        public string Province
        {
            get
            {
                return province;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }
        }
        #endregion
    }
}

