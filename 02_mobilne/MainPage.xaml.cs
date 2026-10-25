using System.Collections.ObjectModel;

namespace NotatkiMobilne
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> notatki;

        public MainPage()
        {
            InitializeComponent();

            notatki = new ObservableCollection<string>
            {
                "Kupić prezent na urodziny",
                "Oddać książkę do biblioteki",
                "Zadzwonić do dentysty"
            };

            NotatkiListView.ItemsSource = notatki;
        }

        private void OnDodajClicked(object sender, EventArgs e)
        {
            string tekst = NowaNotatkaEntry.Text;

            if (!string.IsNullOrWhiteSpace(tekst))
            {
                notatki.Add(tekst);
                NowaNotatkaEntry.Text = string.Empty;
            }
        }
    }
}
