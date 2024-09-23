using DevExpress.Xpf.Core;
using System.Configuration;
using System.Data;
using System.Windows;

namespace FileSeparator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ApplicationThemeHelper.ApplicationThemeName = LightweightTheme.Office2019Black.Name;
        }
    }
}