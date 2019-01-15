using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VO2_Max
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// PROJECT MANAGER:
        /// KHOLOFELO MOCHEKE (BOSS LADY)
        ///        - Leader
        ///        - The brain
        /// 
        /// PROGRAMMERS:
        /// KATLEGO MOGOLA (CATS)
        ///               - GUI Design
        ///                     - All calculations GUI
        ///               - Calculation Code
        ///             
        /// DYNITIA KHUMALO MOFOKENG (DAN)
        ///              - Database Developer.
        ///              - Code compilation.
        ///              - System admin.
        ///              - Final GUI Design.
        ///                 -Extra forms
        ///              - Algorithm design
        ///                     - Language translator
        ///                     - Exception handling.
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
        }
    }
}
