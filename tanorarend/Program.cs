using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tanorarend
{
    internal static class Program
    {
        public static Orarend orarend = null;
        public static Login login = null;
        static void Main()
        {
            Server.csatlakozas();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login = new Login();
            orarend = new Orarend();
            Application.Run(login);
        }
    }
}
