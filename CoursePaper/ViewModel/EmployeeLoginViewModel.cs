using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessInterfaces;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using VM_V_Interfaces;
using System.ComponentModel;
using System.Text.RegularExpressions;
using GalaSoft.MvvmLight.Messaging;
using Model;

namespace CoursePaper.ViewModel
{
    public class EmployeeLoginViewModel : ViewModelBase
    {
        public IEmployeeAccountRepository employeeAccountRepository;
        public IRoleRepository roleRepository;

        private MainWindow mainWindow;

        private bool initialEntrance = false;
        private string login = "admin";
        public string Login
        {
            get { return login; }
            set { Set(ref login, value); }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { Set(ref password, value); }
        }

        private string infoBox;

        public string InfoBox
        {
            get { return infoBox; }
            set { Set(ref infoBox, value); }
        }
        private string greetings;

        public string Greetings
        {
            get { return greetings; }
            set { Set(ref greetings, value); }
        }

        public RelayCommand LoginToAccess { get; set; }

        public EmployeeLoginViewModel(IEmployeeAccountRepository employeeAccountRepository, IRoleRepository roleRepository)
        {
            Login = "admin";
            Password = "admin";
            this.employeeAccountRepository = employeeAccountRepository;
            this.roleRepository = roleRepository;
            Messenger.Default.Register<Messages.AnimationCompleted>(this, (msg) =>
            {
                if (mainWindow != null)
                {
                    mainWindow.Show();
                    Messenger.Default.Send<Messages.CloseViewMessage>(new Messages.CloseViewMessage());
                }
            });
            initialEntrance = !employeeAccountRepository.CheckOwnerAccount();
            if (initialEntrance)
            {
                Greetings = "Это первый вход в систему. Пожалуйста зарегистрируйтесь в системе";
                this.LoginToAccess = new RelayCommand(Registration);  
            }
            else
            {
                Greetings = "Введите, пожалуйста, Ваши регистрационные данные";
                this.LoginToAccess = new RelayCommand(LogIn);
            }
        }
        private void CreateMainWindow()
        {
            Employee employee = employeeAccountRepository.GetEmployeeByLogin(Login);

            mainWindow = new MainWindow();
            ((mainWindow.DataContext) as MainViewModel).Employee = employee;
            InfoBox = "Добро пожаловать в систему :)";
            Messenger.Default.Send<Messages.BeginAnimation>(new Messages.BeginAnimation());
        }

        private void Registration()
        {
            Role role = new Role()
            {
                RoleName = "Owner"
            };
            if (employeeAccountRepository.CreateAccount(Login, Password, null, role))
            {
                CreateMainWindow();
            }
            else
            {
                InfoBox = "Ошибка регистрации аккаунта";
                Messenger.Default.Send<Messages.BeginAnimation>(new Messages.BeginAnimation());
            }
        }
        private void LogIn()
        {
            if (employeeAccountRepository.Authentication(Login, Password))
            {
                CreateMainWindow();
            }
            else
            {
                InfoBox = "Ошибка регистрации аккаунта";
                Messenger.Default.Send<Messages.BeginAnimation>(new Messages.BeginAnimation());
            }
        }

    }
}
