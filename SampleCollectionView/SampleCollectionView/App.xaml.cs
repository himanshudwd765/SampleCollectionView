using Xamarin.Forms;
using SampleCollectionView.Services;
using SampleCollectionView.Views;

namespace SampleCollectionView
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<EmployeesMockData>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
