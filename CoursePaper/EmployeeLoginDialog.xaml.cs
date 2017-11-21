using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CoursePaper.Dialogs
{
    /// <summary>
    /// Interaction logic for EmployeeLoginDialog.xaml
    /// </summary>
    public partial class EmployeeLoginDialog : Window
    {
        public EmployeeLoginDialog()
        {
            InitializeComponent();
            Messenger.Default.Register<Messages.BeginAnimation>(this, (msg) =>
            {
                login_btn.IsEnabled = false;
                BeginStoryboard(this.FindResource("LoginAnimation") as Storyboard);
            });
            Messenger.Default.Register<Messages.CloseViewMessage>(this, (msg) =>
            {
                this.Close();
            });
        }

        private void DoubleAnimation_Completed(object sender, EventArgs e)
        {
            login_btn.IsEnabled = true;
            Messenger.Default.Send<Messages.AnimationCompleted>(new Messages.AnimationCompleted()); 
        }
    }
}
