using Prism.Unity;
using zxingPrismUnityApp1.Views;
using Xamarin.Forms;
using zxingPrismUnityApp1.ViewModels;

namespace zxingPrismUnityApp1 {
	public partial class App : PrismApplication {
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized() {
			InitializeComponent();

			NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
		}

		protected override void RegisterTypes() {
			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<MainPage, MainPageViewModel>();
			Container.RegisterTypeForNavigation<NextPage, NextPageViewModel>();
		}
	}
}
