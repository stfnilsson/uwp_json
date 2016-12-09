using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using App1.Data;


namespace App1
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var data = await LoadAsync();
            if (data == null)
            {
                return;
            }

            dataTextBlock.Text = data;
        }

        private async Task<string> LoadAsync()
        {
            var data = await DataLoader.LoadJsonAsync().ConfigureAwait(false);
            return data;
        }
    }
}
