using System;
using System.Windows.Forms;
using CarbonQuest.GUI.Controllers;

namespace CarbonQuest.GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new CarbonQuestContext());
        }
    }
}
