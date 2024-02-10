namespace BandedRowsList
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
			InitializeRouting();
		}

		public void InitializeRouting()
		{
			Routing.RegisterRoute(nameof(BandedRowsListPage), typeof(BandedRowsListPage));
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
		}
	}
}
