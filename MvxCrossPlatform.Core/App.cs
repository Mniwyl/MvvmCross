using MvvmCross.ViewModels;
using System;
using MvxCrossPlatform.Core.ViewModels;

namespace MvxCrossPlatform.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
