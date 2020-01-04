// Filter for WidgetFeatureProperties
private void FilterSource(object sender, FilterEventArgs e)
{
    if (string.IsNullOrEmpty(FilterText))
    {
        e.Accepted = true;
        return;
    }

    var widgetFeature = e.Item as FeatureViewModel;

    if 
    (widgetFeature != null &&
     widgetFeature.Name.ToUpper().Contains(_filtertext.ToUpper()))
    {
        e.Accepted = true;
    }
    else
    {
        e.Accepted = false;
    }
}