using System;
using System.Drawing;
using System.Windows.Forms;

namespace SampleWizard;
public class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
        Application.Run(new SampleWizard());
    }
}
