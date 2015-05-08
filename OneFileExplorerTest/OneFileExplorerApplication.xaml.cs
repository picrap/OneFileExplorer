// OneFileExplorer
// A FileExplorer model for use with OneFilesystem
// https://github.com/picrap/OneFileExplorer

namespace OneFileExplorerTest
{
    using System.IO;
    using System.Windows;
    using Caliburn.Micro;
    using FileExplorer.IO;
    using FileExplorer.Models;
    using FileExplorer.WPF.Models;
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

        private async void OnStartup(object sender, StartupEventArgs e)
        {
            var windowManager = new WindowManager();
            var view = new OneFileExplorerWindow();
            var eventAggregator = new EventAggregator();
            var viewModel = new ExplorerViewModel(windowManager, eventAggregator);
            viewModel.RootProfiles = new IProfile[] { new FileSystemInfoExProfile(eventAggregator, windowManager), };
            var root = await viewModel.RootProfiles[0].ParseAsync(DirectoryInfoEx.DesktopDirectory.FullName);
            viewModel.RootModels = new IEntryModel[] { root };
            view.DataContext = viewModel;
            //view.ShowDialog();
            windowManager.ShowPopup(viewModel);
            //windowManager.ShowWindow(viewModel);
        }
    }
}
