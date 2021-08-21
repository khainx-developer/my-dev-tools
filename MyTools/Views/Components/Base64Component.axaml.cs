using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MyTools.Views.Components
{
    public partial class Base64Component : UserControl
    {
        public Base64Component()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}