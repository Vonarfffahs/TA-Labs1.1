using System.Collections.Generic;
using System.Windows.Forms;

namespace lab2
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGraph());
        }
    }
}