using System;
using System.Windows.Forms;

namespace FNToolKit
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            SavedData.CheckDir();
            SavedData.SaveConfigFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
