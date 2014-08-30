using System;

namespace PomodoroTimerUA.Model
{
	public class PomodoroRecord
	{
		public PomodoroItem Pomodoro { get; set; }
		public DateTime StarTime { get; set; }
		public DateTime FinishTime { get; set; }

		public PomodoroRecord(PomodoroItem pomodoroItem, DateTime startTime)
		{
			Pomodoro = pomodoroItem;
			StarTime = startTime;
		}

		public void Finish()
		{
			FinishTime = DateTime.Now;
		}
	}
}
