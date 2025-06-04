using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonQuest.GUI.Controllers
{
    public class AppState
    {
        private static AppState _instance;
        public static AppState Instance => _instance ??= new AppState();

        private AppState() { }

        public string LoggedInUsername { get; set; }
    }
}
