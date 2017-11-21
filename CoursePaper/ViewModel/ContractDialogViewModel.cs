using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
namespace CoursePaper.ViewModel
{
    public class ContractDialogViewModel : ViewModelBase
    {
        private Page frameSkin = new Dialogs.RequisiteContractPage();

        public Page FrameSkin
        {
            get { return frameSkin = new Dialogs.RequisiteContractPage(); }
            set { Set(ref frameSkin, value); }
        }

    }
}
