using Avalonia.Controls;
using Avalonia.LogicalTree;

namespace AvaloniaApplication1;

public class CleanDataContextOnLogicalTreeRemovalPanel : Panel
{
    protected override void OnDetachedFromLogicalTree(LogicalTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromLogicalTree(e);
        DataContext = null;
    }
}