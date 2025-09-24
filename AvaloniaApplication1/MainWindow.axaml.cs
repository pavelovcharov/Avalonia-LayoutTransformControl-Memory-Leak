using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        LayoutTransformControl.LayoutTransformProperty.Changed.AddClassHandler<LayoutTransformControl>((x,e) =>
        {
            _ = x;
            _ = e;
        });
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Content.Children.Add(new ProgressBar() { Orientation = Orientation.Vertical});
    }

    private void Button_OnClick1(object? sender, RoutedEventArgs e)
    {
        Content.Children.Clear();
    }
}