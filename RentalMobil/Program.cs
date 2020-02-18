using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalMobil
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main_form());

           //Application.Run(new FormHomeMembers());
           // Application.Run(new FormPayment());
//            Application.Run(new FormProfilMember());
            //Application.Run(new FormDataMasterMember());
           // Application.Run(new FormHomeAdmin());
            //Application.Run(new FormSearchReadyCars());
        }
    }
}
