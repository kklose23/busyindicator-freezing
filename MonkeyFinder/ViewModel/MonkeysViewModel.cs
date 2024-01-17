using MonkeyFinder.Services;

namespace MonkeyFinder.ViewModel;

public partial class MonkeysViewModel : BaseViewModel
{
  public MonkeysViewModel()
  {
    Items = new ObservableCollection<string>();
  }

  [ObservableProperty]
  private bool _isBusy;

  public ObservableCollection<string> Items { get; set; }

  [RelayCommand]
  async Task ReloadAsync()
  {
    IsBusy = true;
    await Task.Delay(2000);
    for (int i = 0; i < 300; i++)
    {
      Items.Add(i.ToString());
    }
    IsBusy = false;
  }
}
