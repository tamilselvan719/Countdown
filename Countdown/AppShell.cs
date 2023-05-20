using Countdown.Pages;

namespace Countdown;

class AppShell : Shell
{
    public AppShell(MainPage mainPage)
    {
        Items.Add(mainPage);
    }
}
