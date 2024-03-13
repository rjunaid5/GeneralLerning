using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLEarning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //neeed of abstract class
            var customer = new Customer();
            //some can implement this 
            customer.CalculateProfiltInt(5);// it will throw an error that it is not 
            //for this we introduce abstract method so that base class doesnot have implementaion

            var silvercustomer = new SilverCustomer();
            silvercustomer.CalculateProfit();
        }
    }


}

public abstract class SimpleCustomer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public abstract void CalculateProfit();
    // Abstract class can have no abstract method

}
public class Customer : ICustomer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNo { get; set; }

    public virtual void CalculateProfiltInt(int a)
    {
        throw new NotImplementedException();
    }

    public virtual void CalculateProfit()
    {
        throw new NotImplementedException();
    }
}


public class GoldCustomer : Customer
{
    //Child Class must implement abstract methods
    public override void CalculateProfiltInt( int a)
    {
        Console.WriteLine(nameof(GoldCustomer.CalculateProfiltInt));
    }

    public override void CalculateProfit()
    {
        Console.WriteLine(nameof(GoldCustomer.CalculateProfiltInt));
    }
}


public class SilverCustomer :  ICustomerWithInterface
{
    public string PhoneNo { get ; set ; }
    public string Name { get; set; }
    public string Address { get; set; }

    //Child Class must implement abstract methods

    public void CalculateProfitWithInterest()
    {
        Console.WriteLine(nameof(SilverCustomer.CalculateProfitWithInterest));
    }

    public void CalculateProfit()
    {
        Console.WriteLine(nameof(SilverCustomer.CalculateProfit));
    }
}



public interface ICustomer
{
    // All members are public by default
    string Name { get; set; }
    string Address { get; set; }
    string PhoneNo { get; set; }
    void CalculateProfit();
}

public interface ICustomerWithInterface : ICustomer
{
    void CalculateProfitWithInterest();
}