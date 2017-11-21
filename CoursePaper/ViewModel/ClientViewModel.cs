using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using AccessInterfaces;
using Model;
using VM_V_Interfaces;
using CoursePaper.Messages;
using System.Windows.Controls;

namespace CoursePaper.ViewModel
{
    

    public class ClientViewModel : ViewModelBase
    {
        private IClientRepository clientRepository;
        private IGroupRepository groupRepository;
        private Client client;


        private ObservableCollection<Client> clientList;
        public ObservableCollection<Client> ClientList
        {
            get { return clientList; }
            set  { Set(ref clientList, value); }
        }

        private ObservableCollection<TreeViewItem> groupTree;

        public ObservableCollection<TreeViewItem> GroupTree
        {
            get { return groupTree; }
            set { Set(ref groupTree, value); }
        }


        public RelayCommand AddClientGroup { get; set; }
        public RelayCommand ChangeClientGroup { get; set; }
        public RelayCommand DeleteClientGroup { get; set; }
        public RelayCommand AddClient { get; set; }
        public RelayCommand<Client> ChangeClient { get; set; }
        public RelayCommand DeleteClient { get; set; }
        public RelayCommand Filter { get; set; }
        public RelayCommand Print { get; set; }
        public RelayCommand Refresh { get; set; }

        public ClientViewModel(IClientRepository clientRepository, IGroupRepository groupRepository)
        {
            this.clientRepository = clientRepository;
            this.groupRepository = groupRepository;
            ClientList = new ObservableCollection<Client>(clientRepository.GetAll());
            TreeViewItem rootGroup = new TreeViewItem();
            rootGroup.Header = "Клиенты";
            FillGroupTree(rootGroup, 1);
            GroupTree = new ObservableCollection<TreeViewItem>();
            GroupTree.Add(rootGroup);

            this.AddClient = new RelayCommand(AddClientAction);
            this.ChangeClient = new RelayCommand<Client>(ChangeClientAction);
            Messenger.Default.Register<SendClient>(this, (msg) =>
            {
                client = msg.Client;
            });

        }

        private void HandleClient(Client obj)
        {
            client = obj;
        }

        void AddClientAction()
        {
            Dialogs.ClientDialog clientDlg = new Dialogs.ClientDialog();
            if (clientDlg.ShowDialog() == true)
            {
                if (client != null)
                {
                    clientRepository.AddItem(client);
                }
            }
        }
        void ChangeClientAction(Client client)
        {
            Dialogs.ClientDialog clientDlg = new Dialogs.ClientDialog();
            Messenger.Default.Send<SendClient>(new SendClient(client));
            if (clientDlg.ShowDialog() == true)
            {
                if (client != null)
                {
                    clientRepository.ChangeItem(client);
                }
            }
        }

        void FillGroupTree(TreeViewItem item, int parentId)
        {
            int i = 0;
            IEnumerable<Group> items = groupRepository.GetByParentId(parentId);
            ObservableCollection<TreeViewItem> itemSource = new ObservableCollection<TreeViewItem>();
            foreach (var group in items)
            {
                i = 1;
                TreeViewItem newItem = new TreeViewItem();
                itemSource.Add(newItem);
                FillGroupTree(newItem, group.Id);
                newItem.ItemsSource = items;
            }
            
        }

        /*
        void AddGroupAction()
        {
            Dialogs.GroupDialog clientDlg = new Dialogs.ClientDialog();
            if (clientDlg.ShowDialog() == true)
            {
                if (client != null)
                {
                    clientRepository.AddItem(client);
                }
            }
        }
        
        void ChangeGroupAction()
        {
            Dialogs.ClientDialog clientDlg = new Dialogs.ClientDialog();
            if (clientDlg.ShowDialog() == true)
            {
                if (client != null)
                {
                    clientRepository.AddItem(client);
                }
            }
        }
        */
    }
}
