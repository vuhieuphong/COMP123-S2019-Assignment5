using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_S2019_Assignment5.Models;

namespace COMP123_S2019_Assignment5
{
    static class Program
    {
        public static Dictionary<FormNames, Form> Forms;
        public static Product product;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormNames, Form>();
            Forms.Add(FormNames.SPLASH_SCREEN, new SplashScreen());
            Forms.Add(FormNames.START_FORM, new StartForm());
            Forms.Add(FormNames.SELECT_FORM, new SelectForm());
            Forms.Add(FormNames.PRODUCT_INFO_FORM,new ProductInfoForm());
            Forms.Add(FormNames.ORDER_FORM, new OrderForm());
            Forms.Add(FormNames.ABOUT_FORM, new AboutForm());
            product = new Product();
           
            Application.Run(Forms[FormNames.SPLASH_SCREEN]);
        }
    }
}
