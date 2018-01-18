using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBReport
{
    public class STRSQL
    {

        public static string TABLE_EMPLOYYE =
                   " CREATE TABLE  if not exists [Employees] (" +
                   "[Address] TEXT  NULL," +
                   "[HomePhone] TEXT  NULL, " +
                   "[Notes] TEXT  NULL, " +
                   "[LastName] TEXT  NULL, " +
                   "[FirstName] TEXT  NULL, " +
                    "[BirthDate] TIME  NULL)";

    }
}
