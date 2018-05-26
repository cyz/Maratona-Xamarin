// ViewModelLocator.cs
// 
using System;
using Autofac;
using Evntr.Core.Services;

namespace Evntr.Core.ViewModels
{
	public class ViewModelLocator
	{
		IContainer _container;
		ContainerBuilder _containerBuilder;

		static readonly ViewModelLocator _instance = new ViewModelLocator();

		public static ViewModelLocator Instance
		{
			get => _instance;
		}

		public ViewModelLocator()
		{
			_containerBuilder = new ContainerBuilder();

			_containerBuilder.RegisterType<NavigationService>().As<INavigationService>();
            _containerBuilder.RegisterType<DialogService>().As<IDialogService>();
			_containerBuilder.RegisterType<ApiService>().As<IApiService>();

			_containerBuilder.RegisterType<MainViewModel>();
			_containerBuilder.RegisterType<GeneralViewModel>();
			_containerBuilder.RegisterType<AboutViewModel>();
            _containerBuilder.RegisterType<ScheduleViewModel>();
			_containerBuilder.RegisterType<TalkDetailsViewModel>();

		}

		public T Resolve<T>() => _container.Resolve<T>();
        public object Resolve(Type type) => _container.Resolve(type);

		public void Register<TInterface, TImplementation>() where TImplementation : TInterface => _containerBuilder.RegisterType<TImplementation>().As<TInterface>();
		public void Register<T>() where T : class => _containerBuilder.RegisterType<T>();

		public void Build()
		{
			if (_container == null)
				_container = _containerBuilder.Build();
		}
	}
}
