using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using PomodoroTimerUA.Model;

namespace PomodoroTimerUA.ViewModel
{
	[DataContract]
	public class MainViewState
	{
		[DataMemberAttribute]
		public ObservableCollection<PomodoroItem> Pomodoros { get; set; }
	}
}
