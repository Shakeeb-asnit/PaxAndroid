namespace PaxAndroid
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Wait 3 seconds before navigating
            await Task.Delay(4000);

            // Navigate to the next page (replace NextPage with your page)
           await Navigation.PushModalAsync(new Pages.AddItems());
        }
    }

}
