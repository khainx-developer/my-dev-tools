using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MyTools.Views.Components
{
    public partial class UrlEncodeComponent : UserControl
    {
        public UrlEncodeComponent()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}