using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace CollectionWPFDemo.App;

public partial class MainWindow : Window
{
    private List<string> _list;

    public MainWindow()
    {
        _list = new List<string> { "first", "second", "last" };

        InitializeComponent();

        ListBox.ItemsSource = _list;
    }

    private void ListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var item = ListBox.SelectedItem;
        MessageBox.Show(item.ToString());
    }
}
