using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using DirectoryOfDoctors.Classes.PhotoDB;

namespace DirectoryOfDoctors
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
