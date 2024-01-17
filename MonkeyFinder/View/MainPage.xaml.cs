using Telerik.Maui.Controls;
using Telerik.Maui.Controls.RichTextEditor;

namespace MonkeyFinder.View;

public partial class MainPage : ContentPage
{
  public MainPage(MonkeysViewModel viewModel)
  {
    InitializeComponent();
    BindingContext = viewModel;
  }
}

