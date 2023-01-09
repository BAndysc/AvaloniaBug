using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml.Templates;

namespace AvaloniaApplication1;

public class DataTemplateSelector : IDataTemplate
{
    public DataTemplate BoolTemplate { get; set; }
    public DataTemplate InputTemplate { get; set; }
    
    public IControl Build(object param)
    {
        if (param is ItemViewModel vm)
        {
            return vm.IsBool ? BoolTemplate.Build(param) : InputTemplate.Build(param);
        }

        return new TextBlock(){Text = "Invalid data context"};
    }

    public bool Match(object data)
    {
        return true;
    }
}