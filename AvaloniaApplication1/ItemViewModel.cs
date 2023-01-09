using System;

namespace AvaloniaApplication1;

public class ItemViewModel : BaseViewModel
{
    private readonly ViewModel viewModel;
    private long val;

    public ItemViewModel(ViewModel viewModel)
    {
        this.viewModel = viewModel;
    }

    public long Value
    {
        get => val;
        set
        {
            viewModel.GlobalLog += "Set val to " + value + " from " + val + "\n";
            SetField(ref val, value);
        }
    }

    public bool IsBool { get; set; } = true;
}