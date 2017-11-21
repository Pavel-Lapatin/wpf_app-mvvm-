using GalaSoft.MvvmLight;
using AccessInterfaces;
using GalaSoft.MvvmLight.Command;
using System.Windows.Controls;
using Model;

namespace CoursePaper.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private UserControl currentPage;
        public UserControl CurrentPage
        {
            get { return currentPage; }
            set { Set(ref currentPage, value); }
        }

        private string pageName;
        public string PageName
        {
            get { return pageName; }
            set { Set(ref pageName, value); }
        }

        public Employee Employee { get; set; }


        public RelayCommand OpenClientPage { get; set; }
        public RelayCommand OpenContractPage { get; set; }
        public RelayCommand OpenSparePartPage { get; set; }
        public RelayCommand OpenSMSPage { get; set; }
        public RelayCommand OpenEmailPage { get; set; }
        public RelayCommand OpenIncomingInvoices { get; set; }
        public RelayCommand OpenCreditInvoice { get; set; }
        public RelayCommand OpenActsOfDisplacment { get; set; }
        public RelayCommand OpenActsOfCancaletion { get; set; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {

            CurrentPage = new Skins.ClientPage();

            this.OpenClientPage = new RelayCommand(() =>
            {
                CurrentPage = new Skins.ClientPage();
            });
            this.OpenContractPage = new RelayCommand(() =>
            {
                CurrentPage = new Skins.ContractPage();
            });

            ////public override void Cleanup()
            ////{
            ////    // Clean up if needed

            ////    base.Cleanup();
            ////}
        }
    }
}