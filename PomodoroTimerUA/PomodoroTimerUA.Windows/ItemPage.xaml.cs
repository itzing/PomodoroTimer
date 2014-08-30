// The Universal Hub Application project template is documented at http://go.microsoft.com/fwlink/?LinkID=391955

using PomodoroTimerUA.ViewModel;

namespace PomodoroTimerUA
{
	/// <summary>
	/// A page that displays details for a single item within a group.
	/// </summary>
	public sealed partial class ItemPage
	{
		public ItemPage()
		{
			InitializeComponent();
		}

		public PomodoroItemDetailsViewModel ViewModel
		{
			get { return (PomodoroItemDetailsViewModel)DataContext; }
		}

		protected override void LoadState(object state)
		{
			var pomodoroId = state as int?;

			if (pomodoroId != null)
			{
				ViewModel.Load(pomodoroId);
			}
		}

		protected override object SaveState()
		{
			return ViewModel.Pomodoro.Id;
		}
	}
}