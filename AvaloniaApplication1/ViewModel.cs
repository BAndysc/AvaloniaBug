using System.Collections.ObjectModel;

namespace AvaloniaApplication1;

public class ViewModel : BaseViewModel
{
    public ObservableCollection<ItemViewModel> Items { get; set; } = new ObservableCollection<ItemViewModel>();

    private ItemViewModel item;

    public ViewModel()
    {
        item = new ItemViewModel(this);
        Items.Add(item);
        
    }
    
    public void Toggle()
    {
        item.IsBool = !item.IsBool;

        Items.RemoveAt(0);
        Items.Add(item);
    }

    private string globalLog = "";
    public string GlobalLog
    {
        get => globalLog;
        set => SetField(ref globalLog, value);
    }
}