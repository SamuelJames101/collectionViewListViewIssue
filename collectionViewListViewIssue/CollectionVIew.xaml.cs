namespace collectionViewListViewIssue;

public partial class CollectionVIew : ContentPage
{
	public CollectionVIew()
	{
		InitializeComponent();

        this.BindingContext = new MyViewModel();
    }
}
