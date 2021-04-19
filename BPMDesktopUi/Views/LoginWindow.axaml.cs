using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BPMDesktopUi.Views {
    public class LoginWindow : Window {
        public LoginWindow() {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

