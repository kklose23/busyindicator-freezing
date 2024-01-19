using CommonHelpers.Collections;
using MonkeyFinder.Services;

namespace MonkeyFinder.ViewModel;

public partial class MonkeysViewModel : BaseViewModel
{
  public MonkeysViewModel()
  {
    Items = new ObservableRangeCollection<string>();
  }

  [ObservableProperty]
  private bool _isBusy;

  public ObservableRangeCollection<string> Items { get; set; }

  [RelayCommand]
  async Task ReloadAsync()
  {
    IsBusy = true;

    await Task.Delay(2000);

    var newItems = await GetDataAsync(300);

    Items.AddRange(newItems);

    IsBusy = false;
  }

  Task<IEnumerable<string>> GetDataAsync(int count)
  {
      var data = Enumerable.Range(0, count).Select(i => $"{i}");

      return Task.FromResult(data);
  }
}
