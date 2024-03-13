using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAggregation
{
    // whenever there is "is a" in requirements it means its parent child like Manager is an employee 
    /* 1- A person can be Visitor or Employee(Inheritance: Person is Base Class)
       2- Person (has a) card to enter premises : 
        has a -> means association relationship both object can live without eachother, withou card there can be Person its not mandatory field
       3- Manager has many employee under him :
        has many -> one owner and many objects, many employees work under manager but they can live independently
        Aggregation
       4- Compostion: Both Objects cannot live without each other 
        e.g project and manager depends on one another if project is successful manager gets salary
           if manager is not successful than project will not succeed
    */
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var manager = new Manager();
            var card = new Card(); // these two exist seperately so its association
            card.UseCard(manager); // for this function they need each other


        }
    }

    public class Manager
    {
        //Aggregation Relations
        private List<Workers> workers = new List<Workers>();
        public double Salary;
        public void SwipeCard(Card card)
        {

        }
        
    }
    public class Card
    {
        public int Id { get; set; }
        public void UseCard(Manager manager)
        {

        }
    }

    public class Workers
    {
        public string Name { get; set; }
        public void Work()
        {

        }
    }
}
