using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PomodoroTimerUA.Model;

namespace PomodoroTimerUA.ViewModel
{
	public class PomodoroItemDetailsViewModel : ViewModelBase
	{
		private readonly IDataService dataService;
		private PomodoroItem pomodoro;

		public PomodoroItemDetailsViewModel(IDataService dataService)
		{
			this.dataService = dataService;
		}

		public PomodoroItem Pomodoro
		{
			get { return pomodoro; }
			set { Set(() => Pomodoro, ref pomodoro, value); }
		}

		private RelayCommand<PomodoroItem> savePomodoroCommand;

		public RelayCommand<PomodoroItem> SavePomodoroCommand
		{
			get
			{
				return savePomodoroCommand
					   ?? (savePomodoroCommand = new RelayCommand<PomodoroItem>(
						   item => dataService.SavePomodoro(item)));
			}
		}

		public void Load(int? id)
		{
			if (id != null)
			{
				Pomodoro = dataService.GetPomodoro((int)id);
			}
		}
	}
}
