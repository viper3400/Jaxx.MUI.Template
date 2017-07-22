/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:DoManagerMui"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using System;
using Autofac;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
namespace Jaxx.MUI.Template.ViewModel
{

    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        private IContainer viewContainer;

        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
         
            var builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<View1ViewModel>();
            builder.RegisterType<View2ViewModel>();
            viewContainer = builder.Build();
        }

  
        public MainViewModel Main
        {
            get
            {
                using (var scope = viewContainer.BeginLifetimeScope())
                {
                    return scope.Resolve<MainViewModel>();
                }
            }
        }

        public View1ViewModel View1
        {
            get
            {
                using (var scope = viewContainer.BeginLifetimeScope())
                {
                    return scope.Resolve<View1ViewModel>();
                }
            }
        }

        public View2ViewModel View2
        {
            get
            {
                using (var scope = viewContainer.BeginLifetimeScope())
                {
                    return scope.Resolve<View2ViewModel>();
                }
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }

}
