using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.LogicalTree;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new ViewModel();
    }

    private void Toggle(object? sender, RoutedEventArgs e)
    {
        ((ViewModel)(DataContext)).Toggle();
    }

    private void StyledElement_OnDetachedFromLogicalTree(object? sender, LogicalTreeAttachmentEventArgs e)
    {
        ((ViewModel)(DataContext)).GlobalLog += "Detached Checkbox from the logical tree\n";
    }
}