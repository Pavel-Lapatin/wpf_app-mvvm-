/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:CoursePaper.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using AccessInterfaces;
using Repository;
using VM_V_Interfaces;

namespace CoursePaper.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                
            }
            else
            {
                SimpleIoc.Default.Register<IClientRepository, Repository.ClientRepository>();
                SimpleIoc.Default.Register<IEmployeeRepository, Repository.EmployeeRepository>();
                SimpleIoc.Default.Register<IRoleRepository, Repository.RoleRepository>();
                SimpleIoc.Default.Register<IEmployeeAccountRepository, Repository.EmployeeAccountRepository>();
                SimpleIoc.Default.Register<IGroupRepository, GroupRepository>();
            }

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<ContractViewModel>();
            SimpleIoc.Default.Register<ClientViewModel>();
            SimpleIoc.Default.Register<ClientDialogViewModel>();
            SimpleIoc.Default.Register<ContractDialogViewModel>();
            SimpleIoc.Default.Register<EmployeeLoginViewModel>();

            //SimpleIoc.Default.Register<EmployeeRepository>();
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public ContractViewModel ContractVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ContractViewModel>();
            }
        }
        
        public ClientViewModel ClientVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ClientViewModel>();
            }
        }
        
        public ClientDialogViewModel ClientDlgVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ClientDialogViewModel>();
            }
        }
        public ContractDialogViewModel ContractDlgVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ContractDialogViewModel>();
            }
        }
        public EmployeeLoginViewModel EmployeeLoginVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EmployeeLoginViewModel>();
            }
        }
       //public EmployeeRepository EmployeeRrep
       // {
       //     get
       //     {
       //         return ServiceLocator.Current.GetInstance<EmployeeRepository>();
       //     }
       // }
        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}