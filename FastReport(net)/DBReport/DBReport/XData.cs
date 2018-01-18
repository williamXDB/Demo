using FastReport.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Data.Common;

namespace DBReport
{
    public class XData
    {


    }

    public class Employees: DataConnectionBase
    {
        //   public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }

        public string Notes { get; set; }

        //    public Image photo { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }

        // insert into Employees values ('DongGuan','13316655971','gogogk','William','xia','1986-01-24') 
        public Employees()
        {
            //   photo = null;
            Address = string.Empty;
            //    BirthDate = DateTime.Today;
            HomePhone = string.Empty;
            LastName = string.Empty;
            FirstName = string.Empty;
            Notes = string.Empty;
            BirthDate = DateTime.Today;

        }

        public override string QuoteIdentifier(string value, DbConnection connection)
        {
            // throw new NotImplementedException();
            return string.Empty;
        }
    }


}
