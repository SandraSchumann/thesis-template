 public ICollectionView AvailableWidgetFeatures
{
    get
    {
        if (_availableWidgetFeatures == null ||
            _filtertext != null)
        {
            var viewSource = new CollectionViewSource();
            if (string.IsNullOrEmpty(FilterText))
            {
                viewSource.GroupDescriptions
                    .Add(new PropertyGroupDescription("Category"));
            }

            viewSource.SortDescriptions
                .Add(new SortDescription
                    ("Category", ListSortDirection.Ascending));
            viewSource.SortDescriptions
                .Add(new SortDescription
                    ("Name", ListSortDirection.Ascending));
            viewSource.Source = WidgetFeatures;

            // FilterSource is local Delegate
            viewSource
                .Filter += new FilterEventHandler(FilterSource);
            viewSource.View.Refresh();
            _availableWidgetFeatures = viewSource.View;
        }
        return _availableWidgetFeatures;
    }
}