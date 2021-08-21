using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using MyTools.ViewModels;
using MyTools.Views;

namespace MyTools
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                MainWindowViewModel vm = new();
                desktop.MainWindow = new MainWindow
                {
                    DataContext = vm
                };
                vm.CloseAction = desktop.MainWindow.Close;

                if (desktop.MainWindow.DataContext != null)
                {
                    var splMain = desktop.MainWindow.FindControl<DockPanel>("SplMain");
                    ((MainWindowViewModel) desktop.MainWindow.DataContext).SplMain = splMain;
                }
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}