using CommunityToolkit.Mvvm.Input;
using MyFirstAppMaui.Models;

namespace MyFirstAppMaui.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}