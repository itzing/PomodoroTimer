using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace PomodoroTimerUA.Model
{
	public interface IDataService
	{
		Task<ObservableCollection<PomodoroItem>> GetData();
		PomodoroItem GetPomodoro(int id);
		void SavePomodoro(PomodoroItem pomodoro);
	}
}