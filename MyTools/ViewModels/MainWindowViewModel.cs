using System;
using Avalonia.Controls;
using MyTools.ViewModels.Components;
using MyTools.Views.Components;

namespace MyTools.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public DockPanel? SplMain { get; set; }
        public Action? CloseAction { get; set; }

        public void Base64ActionHandler()
        {
            SplMain?.Children.Clear();

            Base64ViewModel vm = new();
            var base64Component = new Base64Component
            {
                DataContext = vm
            };
            SplMain?.Children.Add(base64Component);
        }

        public void UrlEncodeActionHandler()
        {
            SplMain?.Children.Clear();

            UrlEncodeViewModel vm = new();
            var urlEncodeComponent = new UrlEncodeComponent()
            {
                DataContext = vm
            };
            SplMain?.Children.Add(urlEncodeComponent);
        }

        public void ExitCommandHandler()
        {
            CloseAction?.Invoke();
        }
    }
}