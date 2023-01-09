using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AvaloniaApplication1;

public abstract class BaseViewModel : INotifyPropertyChanged
{
    private event PropertyChangedEventHandler? propertyChanged;
    public event PropertyChangedEventHandler? PropertyChanged
    {
        add => propertyChanged += value;
        remove => propertyChanged -= value;
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}