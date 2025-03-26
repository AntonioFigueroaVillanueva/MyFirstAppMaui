using MyFirstAppMaui.Models;
using MyFirstAppMaui.PageModels;

namespace MyFirstAppMaui.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}