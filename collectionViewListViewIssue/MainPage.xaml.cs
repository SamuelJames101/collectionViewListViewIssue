namespace collectionViewListViewIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		this.BindingContext = new MyViewModel();
	}
}


