namespace UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    
    using Dentas_Pro.UI;
    using Dentas_Pro.UI.Mail;
    using Dentas_Pro.UI.Base;

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
            Application.Run(new Login_Form());
            //Application.Run(new Dentas_Pro.UI.User.User_Title_Register_Form());
            //Application.Run(new Send_An_E_Mail());
            //Application.Run(new MainMDIForm());
        }
    }
}
