using System.Diagnostics.CodeAnalysis;
using Windows.UI.Xaml;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using PomodoroTimerUA.Common;
using PomodoroTimerUA.Design;
using PomodoroTimerUA.Model;

namespace PomodoroTimerUA.ViewModel
{
	/// <summary>
	/// This class contains static references to all the view models in the
	/// application and provides an entry point for the bindings.
	/// </summary>
	public class ViewModelLocator
	{
		[SuppressMessage("Microsoft.Performance",
			"CA1822:MarkMembersAsStatic",
			Justification = "This non-static member is needed for data binding purposes.")]
		public MainViewModel Main
		{
			get
			{
				return ServiceLocator.Current.GetInstance<MainViewModel>();
			}
		}

		public PomodoroItemDetailsViewModel Details
		{
			get { return ServiceLocator.Current.GetInstance<PomodoroItemDetailsViewModel>(); }
	}

		static ViewModelLocator()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

			if (ViewModelBase.IsInDesignModeStatic)
			{
				SimpleIoc.Default.Register<IDataService, DesignDataService>();
			}
			else
			{
				SimpleIoc.Default.Register<IDataService, DataService>();
			}

			SimpleIoc.Default.Register<IDialogService, DialogService>();
			SimpleIoc.Default.Register<INavigationService, NavigationService>();
			SimpleIoc.Default.Register<MainViewModel>();
			SimpleIoc.Default.Register<PomodoroItemDetailsViewModel>();
		}

		public static ViewModelLocator Instance
		{
			get { return Application.Current.Resources["Locator"] as ViewModelLocator; }
		}
		
		public static void Cleanup()
		{
			// TODO Clear the ViewModels
		}
	}
}