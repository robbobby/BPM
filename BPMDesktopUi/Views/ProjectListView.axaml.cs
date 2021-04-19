using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BPMDesktopUi.Views {
    public class ProjectListView : UserControl {
        public ProjectListView() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

