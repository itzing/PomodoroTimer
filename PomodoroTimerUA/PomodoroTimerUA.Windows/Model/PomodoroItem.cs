using System.Runtime.Serialization;
using GalaSoft.MvvmLight;
using PomodoroTimerUA.Enums;

namespace PomodoroTimerUA.Model
{
	[DataContract]
	public class PomodoroItem :  ObservableObject
	{
		[DataMemberAttribute]
		public int Id { get; set; }

		[DataMemberAttribute]
		public string Name { get; set; }

		[DataMemberAttribute]
		public PomodoroType PomodoroType { get; set; }

		[DataMemberAttribute]
		public string Description { get; set; }
	}
}
