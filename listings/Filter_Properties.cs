public string FilterText
{
    get => _filtertext;
    set
    {
        _filtertext = value;
        OnPropertyChanged("AvailableWidgetFeatures");
    }
}