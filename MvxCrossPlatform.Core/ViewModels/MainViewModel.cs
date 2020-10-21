using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace MvxCrossPlatform.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel()
        {
            
        }
        private string _userName = "admin";
        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }
    }
}
