using System.Collections.ObjectModel;
using System.Threading.Tasks;
using PomodoroTimerUA.Generators;
using PomodoroTimerUA.Model;

namespace PomodoroTimerUA.Design
{
	public class DesignDataService : IDataService
	{
		public Task<ObservableCollection<PomodoroItem>> GetData()
		{
			var result = PomodoroGenerator.GetPomodoros(5);

			return Task.FromResult(result);
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