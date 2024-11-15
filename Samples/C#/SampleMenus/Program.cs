using System;
using System.Drawing;
using System.Windows.Forms;

namespace SampleMenus;
public class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
        Application.SetDefaultFont(new Font(new FontFamily("Segoe UI"), 9f));
        Application.Run(new MDIContainer());
    }
}
