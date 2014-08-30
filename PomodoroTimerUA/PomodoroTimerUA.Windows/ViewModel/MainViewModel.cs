using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PomodoroTimerUA.Common;
using PomodoroTimerUA.Model;

namespace PomodoroTimerUA.ViewModel
{
	/// <summary>
	/// This class contains properties that the main View can data bind to.
	/// <para>
	/// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
	/// </para>
	/// <para>
	/// You can also use Blend to data bind with the tool's support.
	/// </para>
	/// <para>
	/// See http://www.galasoft.ch/mvvm
	/// </para>
	/// </summary>
	public class MainViewModel : ViewModelBase
	{
		private ObservableCollection<PomodoroItem> pomodoros;
		private readonly INavigationService navigationService;
		private readonly IDataService dataService;


		/// <summary>
		/// Initializes a new instance of the MainViewModel class.
		/// </summary>
		public MainViewModel(INavigationService navigationService, IDataService dataService)
		{
			this.navigationService = navigationService;
			this.dataService = dataService;
			Initialize();
		}

		public ObservableCollection<PomodoroItem> Pomodoros
		{
			get { return pomodoros; }
			set { Set(() => Pomodoros, ref pomodoros, value); }
		}

		private RelayCommand<PomodoroItem> showPomodoroDetailsCommand;

		public RelayCommand<PomodoroItem> ShowPomodoroDetailsCommand
		{
			get
			{
				return showPomodoroDetailsCommand
				       ?? (showPomodoroDetailsCommand = new RelayCommand<PomodoroItem>(
					       pomodoro => navigationService.Navigate(typeof (ItemPage), pomodoro)));
			}
		}

		public void Load(MainViewState state)
		{
			if (state != null)
			{
				Pomodoros = state.Pomodoros;
			}
		}

		private async Task Initialize()
		{
			try
			{
				var data = await dataService.GetData();

				Pomodoros = data;
			}
			catch (Exception)
			{
				// Report error here
			}
		}

	}
}