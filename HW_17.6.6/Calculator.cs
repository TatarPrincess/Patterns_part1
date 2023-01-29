using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_17._6._6;

public static class Calculator
{
    // Метод для расчета процентной ставки
    public static double CalculateInterest(IInterestCalculator account)
    {
        return account.Calculate();
    }
}
