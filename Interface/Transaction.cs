using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Icustomer
    {
        string Print();
    }
    public interface Iorder
    {
        string Print();
    }
    public class Transaction : Icustomer, Iorder
    {
        string Icustomer.Print()
        {
            return "Customer detals";
        }

        string Iorder.Print()
        {
            return "Order details";
        }
    }
}
