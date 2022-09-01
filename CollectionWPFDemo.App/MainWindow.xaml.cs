using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace CollectionWPFDemo.App;

public partial class MainWindow : Window, INotifyPropertyChanged
{
    public ObservableCollection<Names> List { get; set; }

    private Names _names;
    public Names Item
    {
        get => _names;
        set
        {
            if (value == _names) return;
            _names = value;
            OnPropertyChanged(nameof(Item));
        }
    }

    public MainWindow()
    {
        List = new ObservableCollection<Names>
        {
            new Names() {FirstName = "A", LastName = "AA"},
            new Names() {FirstName = "B", LastName = "BB"},
            new Names() {FirstName = "C", LastName = "CC"},
            new Names() {FirstName = "D", LastName = "DD"},
        };

        InitializeComponent();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
