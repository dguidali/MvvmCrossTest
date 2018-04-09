using MvvmCross.Core.ViewModels;
using MvvmCrossTest.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MvvmCrossTest.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        readonly ICalculationService _calculation;

        public TipViewModel(ICalculationService calculation)
        {
            _calculation = calculation;
        }

        public override void Start()
        {
            _subTotal = 100;
            _generosity = 10;
            Recalculate();
            base.Start();
        }

        double _subTotal;

        public double SubTotal
        {
            get
            {
                return _subTotal;
            }
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalculate();
            }
        }

        int _generosity;

        public int Generosity
        {
            get
            {
                return _generosity;
            }
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);
                Recalculate();
            }
        }

        double _tip;

        public double Tip
        {
            get
            {
                return _tip;
            }
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        public ICommand ClickCommand
        {
            get
            {
                // Navigation Note:
                // Must add following value to Assembly.cs for any Windows projects
                // [assembly: InternalsVisibleTo("Cirrious.MvvmCross")]
                return new MvxCommand(() => Console.WriteLine("Button clicked!"));
            }
        }

        void Recalculate()
        {
            Tip = _calculation.TipAmount(SubTotal, Generosity);
        }
    }
}
