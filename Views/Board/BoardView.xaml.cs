using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ChessHorse.Views
{
    public class BoardView : UserControl
    {
        public BoardView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}