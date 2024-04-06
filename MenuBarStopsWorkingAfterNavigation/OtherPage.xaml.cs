using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBarStopsWorkingAfterNavigation;

public partial class OtherPage : ContentPage
{
	public OtherPage()
	{
		InitializeComponent();
		BindingContext = new OtherPageModel(this);
	}
}