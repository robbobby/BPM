using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BPMDesktopUi.Services;
using BPMDesktopUi.ViewModels;
using BPMDesktopUi.Views;

namespace BPMDesktopUi {
    public class App : Application {
        public override void Initialize() {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted() {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
                MockProjectDb projectDb = new MockProjectDb(); 
                desktop.MainWindow = new MainWindow {
                    DataContext = new MainWindowViewModel(projectDb),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
        public void ToggleMenuBarSize() {
        }
    }
}
