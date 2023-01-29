using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_17._6._6;

public class SalaryAccount : Account, IInterestCalculator
{
    double factor = 0.5;
    public SalaryAccount(string type, double balance) : base(type, balance)
    { }

    public double Calculate()
    {
        this.Interest = this.Balance * factor;
        return this.Interest;
    }
}
