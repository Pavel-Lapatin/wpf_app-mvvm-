using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CoursePaper.ViewModel
{
    public class ContractViewModel : ViewModelBase
    {
        private string test1;

        public string Test1
        {
            get { return test1; }
            set { Set(ref test1, value); }
        }

        
        public RelayCommand<TabControl> ChooseContractByItType { get; set; }
        public RelayCommand AddContract { get; set; }
        public RelayCommand ShowContractsWatingSpareParts { get; set; }

        public ContractViewModel()
        {
            Test1 = "Initial";
            this.ChooseContractByItType = new RelayCommand<TabControl>(args =>
            {
                TabItem item = args.SelectedItem as TabItem;
                if (item == null) new ArgumentNullException();
                switch (item.Header)
                {
                    case "Все Заказы":
                        Test1 = "Все Заказы";
                        break;
                    case "В ремонте":
                        Test1 = "В ремонте";
                        break;
                    case "Готовые":
                        Test1 = "Готовые";
                        break;
                    case "Ожидают запчастей":
                        Test1 = "Ожидают запчастей";
                        break;
                    case "На согласовании":
                        Test1 = "На согласовании";
                        break;
                    case "По гарантии":
                        Test1 = "На согласовании";
                        break;
                    default:
                        new NotImplementedException();
                        break;
                }
            });

            this.AddContract = new RelayCommand(() =>
            {
                Dialogs.ContractDialog contractDlg = new Dialogs.ContractDialog();
                contractDlg.ShowDialog();
            });
        }
    }
}
