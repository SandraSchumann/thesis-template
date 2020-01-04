// Constructor for Filter
public string FilterText
{
    get => _filtertext;
    set
    {
        _filtertext = value;
        AvailableWidgetFeatures.Refresh();
        OnPropertyChanged("AvailableWidgetFeatures");
    }
}