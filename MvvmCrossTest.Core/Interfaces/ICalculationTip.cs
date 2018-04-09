using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossTest.Core.Interfaces
{
    public interface ICalculationService
    {
        double TipAmount(double subTotal, int generosity);
    }
}
