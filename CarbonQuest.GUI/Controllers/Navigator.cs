using System;
using System.Windows.Forms;
using CarbonQuest.GUI.Views;

namespace CarbonQuest.GUI.Controllers
{
    public enum AppRoute
    {
        Login,
        Signup,
        Home,
        Kalkulator,
        DaftarArtikel,
        ArtikelDetail
    }

    public class Navigator
    {
        private static Navigator? _instance;
        private Form? _currentForm;
        private CarbonQuestContext? _appContext;

        private Navigator() { }

        public static Navigator Instance => _instance ??= new Navigator();

        public void SetAppContext(CarbonQuestContext context)
        {
            _appContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Navigate(AppRoute route, object? parameter = null)
        {
            if (_appContext == null)
                throw new InvalidOperationException("AppContext belum di-set");

            Form form = route switch
            {
                AppRoute.Login => new Login(),
                AppRoute.Signup => new Signup(),
                AppRoute.Home => new Home(),
                AppRoute.Kalkulator => new Kalkulator(),
                AppRoute.DaftarArtikel => new DaftarArtikel(),
                AppRoute.ArtikelDetail when parameter is Tuple<string, string> p 
                    => new ArtikelDetail(p.Item1, p.Item2),
                _ => throw new NotImplementedException($"Route {route} belum diimplementasi"),
            };

            _appContext.SetCurrentForm(form);
        }
    }
}
