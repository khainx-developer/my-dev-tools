using System;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;

namespace MyTools.ViewModels.Components
{
    public class Base64ViewModel : ViewModelBase
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
        public ReactiveCommand<Unit, Unit> DecodeButton { get; }

        public Base64ViewModel()
        {
            EncodeButton = ReactiveCommand.Create(EncodeButton_Click);

            DecodeButton = ReactiveCommand.Create(DecodeButton_Click);
        }

        private void EncodeButton_Click()
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(Input);

            _output = this.WhenAnyValue(x => x.Input)
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(_ => Convert.ToBase64String(plainTextBytes))
                .ToProperty(this, x => x.Output, out _output);
        }

        private void DecodeButton_Click()
        {
            var base64EncodedBytes = Convert.FromBase64String(Input);

            _output = this.WhenAnyValue(x => x.Input)
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(_ => Convert.ToBase64String(base64EncodedBytes))
                .ToProperty(this, x => x.Output, out _output);
        }
    }
}