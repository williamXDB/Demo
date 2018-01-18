using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBReport
{
    public class IOSQL
    {

        private static IOSQL _ioSQL = null;

        public SQLiteConnection m_dbConnection;
        private string strDBName = string.Empty;
        private string DBPwsd = string.Empty;    //"IOWilliamxia2016";
        public IOSQL(string dbName, string strPwd = null)
        {
            strDBName = dbName;
            DBPwsd = strPwd;
            m_dbConnection = null;
            createDataBase();
            connectToDataBase();

        }

        public static IOSQL getInstance(string strDB, string strPwd = null)
        {
            if (_ioSQL == null)
            {
                _ioSQL = new IOSQL(strDB, strPwd);
            }
            return _ioSQL;
        }

        // private string uDataBase = "Employee.db3"; //default is in the app file directory    
        public bool FileInUse(string strpath)
        {
            bool res = false;
            try
            {
                using (FileStream fs = new FileStream(strpath, FileMode.OpenOrCreate))
                {
                    res = !fs.CanWrite;
                }
                return false;
            }
            catch (IOException ex)
            {
                Debug.WriteLine("{0}", ex.ToString());
                return true;

            }

        }
        private void createDataBase()
        {
            if (File.Exists(strDBName))
            {
                Debug.WriteLine("database is exist ");
                if (FileInUse(strDBName))
                {
                    //MessageBox.Show("File is in used or has opened,you must close the file firstly!");
                    Debug.WriteLine("File is in used or has opened,you must close the file firstly!");
                    Environment.Exit(-1);
                }
            }
            else
            {
                //  Debug.WriteLine("database is not exist....");
                SQLiteConnection.CreateFile(strDBName);
            }

        }
     
        public bool iSDataBaseOpen()
        {            
            return (m_dbConnection != null && m_dbConnection.State.HasFlag(System.Data.ConnectionState.Open));
        }

        private void connectToDataBase()
        {
            try
            {
                string strDBC = string.Format("Data Source={0};Version=3;Password={1}", strDBName, DBPwsd);
                m_dbConnection = new SQLiteConnection(strDBC);
                m_dbConnection.Open();
                //  m_dbConnection.SetPassword
                m_dbConnection.ChangePassword(DBPwsd);
                //  m_dbConnection   

                if (iSDataBaseOpen())
                {
                    Debug.WriteLine("has connected to database and open ....");

                }
                else
                {

                    Debug.WriteLine("database is colosed.......");
                }

            }

            catch (Exception ec)
            {
                //   MessageBox.Show("Open dtabase error");
                Debug.WriteLine("connect to database error...............{0}", ec.ToString());
            }

        }
        public int executeSQL(string sqlTb)
        {
            SQLiteCommand comand = new SQLiteCommand(sqlTb, m_dbConnection);
            return comand.ExecuteNonQuery();//insert or create table ,it is the non return type  
            //executeNonQuery--0: failuer 1:sucess 
        }
        public int numOfCount(string strTable)
        {
            // int res = 0;
            string strSelect = string.Format("select count(*) as numberofItems from {0}", strTable);


            SQLiteCommand comand = new SQLiteCommand(strSelect, m_dbConnection);
            var count = comand.ExecuteScalar();
            if (count == null)
                return 0;
            else
                return (Int16.Parse(count.ToString()));
        }



    }
}
