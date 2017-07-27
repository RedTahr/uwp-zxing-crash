using Xamarin.Forms;

namespace zxingPrismUnityApp1.Views {
	public partial class MainPage : ContentPage {
		public MainPage() {
			InitializeComponent();
			var options = new ZXing.Mobile.MobileBarcodeScanningOptions {
				PossibleFormats = { ZXing.BarcodeFormat.QR_CODE }
			};
			zxing.Options = options;
		}

		private void zxing_OnScanResult(ZXing.Result result) {
			System.Diagnostics.Debug.WriteLine($"result: {result.Text}");
		}
	}
}