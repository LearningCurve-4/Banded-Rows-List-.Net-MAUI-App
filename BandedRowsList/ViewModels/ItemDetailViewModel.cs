namespace BandedRowsList.ViewModels;

public class ItemDetailViewModel : BaseViewModel
{
	static BandedRowsListModel? itemDetail = null;
	public BandedRowsListModel? ItemDetail
	{
		get => itemDetail;
		set
		{
			if (itemDetail == value) { return; }
			itemDetail = value;
			OnPropertyChanged();
		}
	}
}
