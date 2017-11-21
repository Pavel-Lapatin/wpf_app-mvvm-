﻿using GalaSoft.MvvmLight.Messaging;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CoursePaper.Dialogs
{
    /// <summary>
    /// Interaction logic for ClientDialog.xaml
    /// </summary>
    public partial class ClientDialog : Window
    {
        public ClientDialog()
        {
            InitializeComponent();
            Messenger.Default.Register<Messages.CloseClientDialog>(this, (msg) =>
            {
                if(DialogResult == null)
                {
                    this.DialogResult = true;
                }
                
            });
        }
    }
}