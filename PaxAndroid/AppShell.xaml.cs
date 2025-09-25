using PaxAndroid.Pages;

namespace PaxAndroid
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddTips), typeof(Pages.AddTips));

        }
    }
}
