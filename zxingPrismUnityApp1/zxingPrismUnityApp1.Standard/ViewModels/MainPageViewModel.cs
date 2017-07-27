using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace zxingPrismUnityApp1.ViewModels {
	public class MainPageViewModel : BindableBase, INavigationAware {
		private string _title;
		public string Title {
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		private bool zxingIsActive = false;
		public bool ZXingIsActive {
			get { return zxingIsActive; }
			set { SetProperty(ref zxingIsActive, value); }
		}

		bool zxAnalyzing = false;
		public bool ZXIsAnalyzing {
			get { return zxAnalyzing; }
			set {
				if (zxAnalyzing == value) { return; }
				SetProperty(ref zxAnalyzing, value);
			}
		}
		bool zxScanning = false;
		public bool ZXIsScanning {
			get { return zxScanning; }
			set {
				if (zxScanning == value) { return; }
				SetProperty(ref zxScanning, value);
			}
		}

		INavigationService nav;
		public DelegateCommand NextCommand { get; set; }
		public DelegateCommand ActivateZXingCommand { get; set; }

		public MainPageViewModel(INavigationService navigationService) {
			nav = navigationService;
			NextCommand = new DelegateCommand(Next);
			ActivateZXingCommand = new DelegateCommand(Activate);
		}

		public void OnNavigatedFrom(NavigationParameters parameters) {

		}

		public void OnNavigatingTo(NavigationParameters parameters) {

		}
		
		private void Activate() {
			ZXingIsActive = true;
			ZXIsScanning = true;
			ZXIsAnalyzing = true;
		}

		private async void Next() {
			await nav.NavigateAsync(nameof(Views.NextPage));
		}

		public void OnNavigatedTo(NavigationParameters parameters) {
			if (parameters.ContainsKey("title"))
				Title = (string)parameters["title"] + " and Prism";
		}
	}
}
