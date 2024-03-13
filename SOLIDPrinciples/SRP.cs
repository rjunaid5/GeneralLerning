using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    //SRP Single Responsibility Principle
    // Class must have only one reason to change and one responsibility
    public partial class Card
    {
        public int CardNumber { get; set; }
        public string CardType { get; set; }
    }
    public partial class Person
    {
        private List<Card> _cards = new List<Card>();
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int display(int a) { return 0; }
        public string display(string a) { return ""; }

        public Person(List<Card> cards)
        {
            this._cards = cards;
        }
        // now there are three functions which can be changed in the future
        // For example if we want to print only Active cards than we have to change {Print Card}
        // If we want to change method of Save ToDb than another change so class has more than one reason to change
        public int GetPersonActiveCards()
        {
            return _cards.Where(x => x.CardType == "Active").ToList().Count;
        }

        public void PrintCards()
        {

        }

        public void SaveToDb()
        {

        }
    }

}
namespace SolutionSRP
{
    public partial class Card
    {
        public string CardType { get; set; }
        public string CardNumber { get; set; }
    }
    
    public partial class Person
    {
        public string PersonName { get; set; }
        private List<Card> Cards = new List<Card>();

    }

    public class CardRetrievel
    {
        private List<Card> Cards = new List<Card>();
        public CardRetrievel(List<Card> cards)
        {
            Cards = cards;
        }

        public List<Card> GetCardsByType(string CardType)
        {
            return Cards.Where(x => x.CardType == CardType).ToList();
        }
    }

    public class PersonDao { 
    }
}