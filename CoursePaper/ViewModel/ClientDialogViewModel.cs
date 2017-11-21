using AccessInterfaces;
using CoursePaper.Messages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using VM_V_Interfaces;

namespace CoursePaper.ViewModel
{
    public class ClientDialogViewModel : ViewModelBase
    {
        private Client client = new Client();
        public Client Client
        {
            get { return client; }
            set { Set(ref client, value); }
        }
        private ObservableCollection<Group> groups;

        public ObservableCollection<Group> Groups
        {
            get { return groups; }
            set { Set(ref groups, value); }
        }

        IGroupRepository groupRepository;
        
        private RelayCommand ok;

        public RelayCommand OK
        {
            get { return ok; }
            set { Set(ref ok, value); }
        }


        public ClientDialogViewModel(IGroupRepository groupRepository)
        {
            this.groupRepository = groupRepository;
            Groups = new ObservableCollection<Group>(groupRepository.GetAll());
            Messenger.Default.Register<SendClient>(this, (msg) =>
            {
                
                if (msg.Client != null)
                {
                    Client = msg.Client;
                }
                else Client = null;
            });

            OK = new RelayCommand(OKCmd);
        }
        void OKCmd()
        {
            Client.ValidationOn = true;
            Client.RaisePropertyChanged();
            if (Client.HasErrors)
            {
                Client.ValidationOn = false;
            }
            else
            {
                Messenger.Default.Send<SendClient>(new SendClient(Client));
                Messenger.Default.Send<CloseClientDialog>(new CloseClientDialog());
            }
        }
    }
}
