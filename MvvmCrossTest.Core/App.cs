using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCrossTest.Core.Interfaces;
using MvvmCrossTest.Core.Services;
using MvvmCrossTest.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossTest.Core
{
    public class App : MvxApplication
    {        public App()
        {
            Mvx.RegisterType<ICalculationService, CalculationService>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
        }
    }
}
