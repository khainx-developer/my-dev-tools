using System.Reactive;
using System.Reactive.Linq;
using System.Web;
using ReactiveUI;

namespace MyTools.ViewModels.Components
{
    public class UrlEncodeViewModel : ViewModelBase
    {
        private string _input = "";

        public string Input
        {
            get => _input;
            set => this.RaiseAndSetIfChanged(ref _input, value);
        }

        private ObservableAsPropertyHelper<string>? _output;

        public string Output
        {
            get
            {
                if (_output != null)
                    return _output.Value;
                return string.Empty;
            }
        }

        public ReactiveCommand<Unit, Unit> EncodeButton { get; }

        public UrlEncodeViewModel()
        {
            EncodeButton = ReactiveCommand.Create(EncodeButton_Click);
        }

        private void EncodeButton_Click()
        {
            var result = HttpUtility.UrlEncode(Input);

            _output = this.WhenAnyValue(x => x.Input)
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(_ => result)
                .ToProperty(this, x => x.Output, out _output);
        }
    }
}