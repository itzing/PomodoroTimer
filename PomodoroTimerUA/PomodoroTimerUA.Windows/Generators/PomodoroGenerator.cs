using System.Collections.ObjectModel;
using PomodoroTimerUA.Enums;
using PomodoroTimerUA.Model;

namespace PomodoroTimerUA.Generators
{
	public class PomodoroGenerator
	{
		public static ObservableCollection<PomodoroItem> GetPomodoros(int number)
		{
			var items = new ObservableCollection<PomodoroItem>();

			for (int i = 0; i < number; i++)
			{
				items.Add(GetPomodoro(i));
			}

			return items;
		}

		public static PomodoroItem GetPomodoro(int number)
		{
			return new PomodoroItem
			{
				Description = string.Format("Description {0}", number),
				Id = number,
				Name = string.Format("Pomodoro Name {0}", number),
				PomodoroType = PomodoroType.Pomodoro
			};
		}
	}
}
