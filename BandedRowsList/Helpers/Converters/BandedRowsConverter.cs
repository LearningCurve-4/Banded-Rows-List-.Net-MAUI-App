﻿namespace BandedRowsList.Helpers.Converters;

public class BandedRowsConverter : IValueConverter
{
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		if (value == null && parameter == null) { return Colors.Transparent; }

		Application.Current!.Resources.TryGetValue("PageFillColor", out object bg);
		Application.Current!.Resources.TryGetValue("AlternateRowColor", out object alt);

		int index = ((CollectionView)parameter!).ItemsSource.Cast<object?>().ToList().IndexOf(value);
		return index % 2 == 0 ? (Color)bg : (Color)alt;
	}

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		return Colors.Transparent;
	}
}
