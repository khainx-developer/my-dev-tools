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
        private Controls Children { get; } = new();

        public void Base64ActionHandler()
        {
            Children.Clear();

            Base64ViewModel vm = new();
            var base64Component = new Base64Component
            {
                DataContext = vm
            };
            SplMain?.Children.Add(base64Component);
        }

        public void ExitCommandHandler()
        {
            CloseAction?.Invoke();
        }
    }
}