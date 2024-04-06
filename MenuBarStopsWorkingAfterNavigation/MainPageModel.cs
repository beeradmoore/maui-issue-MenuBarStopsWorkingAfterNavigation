using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MenuBarStopsWorkingAfterNavigation;

public partial class MainPageModel : ObservableObject
{
	WeakReference<MainPage> _weakPage;
	
	public MainPageModel(MainPage page)
	{
		_weakPage = new WeakReference<MainPage>(page);
	}

	[RelayCommand]
	async Task MenuItemAsync()
	{
		if (_weakPage.TryGetTarget(out MainPage? mainPage))
		{
			await mainPage.DisplayAlert("Alert", "Menu item clicked", "Okay");
		}
	}

	[RelayCommand]
	async Task GoToOtherPageAsync()
	{
		if (_weakPage.TryGetTarget(out MainPage? mainPage))
		{
			await mainPage.Navigation.PushAsync(new OtherPage());
		}
	}
}