using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW_17._6._6;

public class OrdinaryAccount : Account, IInterestCalculator
{
    double lowRestFactor = 0.2;
    double highRestFactor = 0.4;
    double commonInterestFactor = 0.4;

    public OrdinaryAccount(string type, double balance) : base(type, balance)
    { }

    public double Calculate()
    {
        this.Interest = this.Balance * commonInterestFactor;

        if (this.Balance < 1000)
            this.Interest -= this.Balance * lowRestFactor;

        if (this.Balance < 50000)
            this.Interest -= this.Balance * highRestFactor;

        return this.Interest;
    }
}
