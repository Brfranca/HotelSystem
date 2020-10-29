using Common.Extentions;
using System;
using System.IO;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string x = Database.GetPath();
            AppDomain.CurrentDomain.SetData("DataDirectory", x);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormRegisterClient());
        }
    }
}
