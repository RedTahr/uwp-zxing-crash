using Xamarin.Forms;

namespace zxingPrismUnityApp1.Views {
	public partial class MainPage : ContentPage {
		public MainPage() {
			InitializeComponent();
		}

		private void zxing_OnScanResult(ZXing.Result result) {
			System.Diagnostics.Debug.WriteLine($"result: {result.Text}");
		}
	}
}