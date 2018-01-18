using FastReport.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using FastReport.Utils;

namespace DBReport
{
    class GlobalApplication
    {
        [STAThreadAttribute]
        public static void Main()
        {
            // AppDomain.CurrentDomain.AssemblyResolve +=OnResolveAssembly;            
            RegisteredObjects.AddConnection(typeof(SQLiteDataConnection));
           // Debug.WriteLine("dbthread init now....");
            App.Main();
        }

        public  static Assembly OnResolveAssembly(object sender, ResolveEventArgs args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = new AssemblyName(args.Name);

            string path = assemblyName.Name + ".dll";
            if (assemblyName.CultureInfo.Equals(CultureInfo.InvariantCulture) == false)
            {
                path = String.Format(@"{0}\{1}", assemblyName.CultureInfo, path);
            }

            using (Stream stream = executingAssembly.GetManifestResourceStream(path))
            {
                if (stream == null)
                    return null;

                byte[] assemblyRawBytes = new byte[stream.Length];
                stream.Read(assemblyRawBytes, 0, assemblyRawBytes.Length);
                return Assembly.Load(assemblyRawBytes);

            }
        }
      

    }
}
