// OneFileExplorer
// A FileExplorer model for use with OneFilesystem
// https://github.com/picrap/OneFileExplorer

namespace OneFileExplorerTest
{
    using System.Windows;
    using Caliburn.Micro;
    using FileExplorer.WPF.ViewModels;
    using FileExplorer.WPF.Views;
    using OneFileExplorer;

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
            var view = new OneFileExplorerWindow();
            var viewModel = new ExplorerViewModel(null, new EventAggregator());
            view.DataContext = viewModel;
            view.ShowDialog();
        }
    }
}
