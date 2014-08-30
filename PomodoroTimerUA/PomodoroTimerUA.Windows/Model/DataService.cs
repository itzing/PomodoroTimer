using System.Collections.ObjectModel;
using System.Threading.Tasks;
using PomodoroTimerUA.Generators;

namespace PomodoroTimerUA.Model
{
	public class DataService : IDataService
	{
		public async Task<ObservableCollection<PomodoroItem>> GetData()
		{
			return PomodoroGenerator.GetPomodoros(5);
		}

		public PomodoroItem GetPomodoro(int id)
		{
			return PomodoroGenerator.GetPomodoro(id);
		}

		public void SavePomodoro(PomodoroItem pomodoro)
		{
			
		}
	}
}