using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace carmanage
{
  
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
      

        public static string username;
        public static int orgid;
        public static string orgname;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
