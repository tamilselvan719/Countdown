using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Countdown.ViewModels;

partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    int _clickCount = 0;

    [RelayCommand]
    public void IncrementClickMeButton() => ClickCount += 1;
}
