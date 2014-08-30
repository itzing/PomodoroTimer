// The Universal Hub Application project template is documented at http://go.microsoft.com/fwlink/?LinkID=391955

using PomodoroTimerUA.ViewModel;

namespace PomodoroTimerUA
{
	/// <summary>
	/// A page that displays a grouped collection of items.
	/// </summary>
	public sealed partial class HubPage
	{
		public MainViewModel Main
		{
			get { return (MainViewModel) DataContext; }
		}

		public HubPage()
		{
			InitializeComponent();
		}
	}
}
