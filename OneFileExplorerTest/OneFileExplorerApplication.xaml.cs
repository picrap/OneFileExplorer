// OneFileExplorer
// A FileExplorer model for use with OneFilesystem
// https://github.com/picrap/OneFileExplorer

namespace OneFileExplorerTest
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class OneFileExplorerApplication
    {
        public OneFileExplorerApplication()
        {
            Startup += OnStartup;
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
        }
    }
}
