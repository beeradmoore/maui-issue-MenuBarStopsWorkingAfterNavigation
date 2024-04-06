using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MenuBarStopsWorkingAfterNavigation;

public partial class OtherPageModel : ObservableObject
{	
	WeakReference<OtherPage> _weakPage;
	
	public OtherPageModel(OtherPage page)
	{
		_weakPage = new WeakReference<OtherPage>(page);
	}
	
	[RelayCommand]
	async Task GoBackAsync()
	{
		if (_weakPage.TryGetTarget(out OtherPage? otherPage))
		{
			await otherPage.Navigation.PopAsync();
		}
	}
}