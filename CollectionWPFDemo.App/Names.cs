using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CollectionWPFDemo.App;

public class Names : INotifyPropertyChanged
{
    private string _first;
    public string FirstName
    {
        get => _first;
        set
        {
            if (value == _first) return;

            _first = value;
            OnPropertyChanged(nameof(FirstName));
        }
    }

    private string _last;
    public string LastName
    {
        get => _last;
        set
        {
            if (value == _last) return;

            _last = value;
            OnPropertyChanged(nameof(LastName));
        }
    }

    public string FullName { get => $"{LastName} {FirstName}"; }

    public override string ToString()
    {
        return FullName;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
