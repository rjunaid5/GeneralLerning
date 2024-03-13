using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConcepts
{
    public class PersonL
    {
        public int CardId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonNumber { get; set; }
        public PersonType PersonType { get; set; }

    }

    public class PersonType
    {
        public int Id { get; set; }
        public string Type { get; set; } 
    }

    public class CardType
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }

    public class Card
    {
        public int CardId { get; set; } 
        public string CardNumber { get; set; }
        public CardType CardType { get; set; }
    }

    internal class LinqAdvConcepts
    {

        private static PersonType empType = new PersonType() { Type = "EMP" };
        private static PersonType cwrType = new PersonType() { Type = "CWR" };
        private static CardType dcgCardType = new CardType() { Type = "DCG" };
        private static CardType empCardType = new CardType() { Type = "EMP" };


        public static List<Card> cards = new List<Card>()
        {
            new Card() {CardId = 1,CardNumber = "012456634" , CardType = dcgCardType},
            new Card() {CardId = 2,CardNumber = "012456635" , CardType = dcgCardType},
            new Card() {CardId = 3,CardNumber = "012456636" , CardType = dcgCardType},
            new Card() {CardId = 4,CardNumber = "EA2456636" , CardType = empCardType},
            new Card() {CardId = 5,CardNumber = "EA2456637" , CardType = empCardType},
            new Card() {CardId = 6,CardNumber = "EA2456638" , CardType = empCardType},
            new Card() {CardId = 7,CardNumber = "EA2456639" , CardType = empCardType}
        };



        //Field Initializer like if we initalized PersonL.PersonType than we must declare those PersonType cwr or emp as Static
        // otherwise there will be an error
        public List<PersonL> PersonL = new List<PersonL> { 
                                                            new PersonL() { FirstName = "Test" , LastName = "User1" ,PersonNumber ="01245" , PersonType = empType, CardId = cards.FirstOrDefault().CardId},  
                                                            new PersonL() { FirstName = "Test" , LastName = "User2" ,PersonNumber ="01246" , PersonType = empType, CardId = cards[1].CardId},  
                                                            new PersonL() { FirstName = "Test" , LastName = "User3" ,PersonNumber ="01247" , PersonType = empType, CardId = cards[2].CardId},  
                                                            new PersonL() { FirstName = "Test" , LastName = "User4" ,PersonNumber ="01248" , PersonType = cwrType, CardId = cards[3].CardId},  
                                                            new PersonL() { FirstName = "Test" , LastName = "User5" ,PersonNumber ="01249" , PersonType = cwrType, CardId = 1245},  
                                                            new PersonL() { FirstName = "Test" , LastName = "User6" ,PersonNumber ="01250" , PersonType = cwrType, CardId = 3333},  
                                                            new PersonL() { FirstName = "Test" , LastName = "User7" ,PersonNumber ="01251" , PersonType = empType, CardId = 23423234}, 
        
                                                        };



        public void CheckLinqConcepts()
        {
            var personsQ = PersonL.Where(x => x.FirstName == "Test"); //IEnumerable

            var personsFirst = PersonL.First(x => x.PersonNumber == "0124458");//If records not found it will throw an error
            var personsFirstmatch = PersonL.First(x => x.PersonNumber == "01248");// will get single record;
            var personsFirstmatch1 = PersonL.First();// will get first record

            var personsFrstDefault = PersonL.FirstOrDefault(x => x.PersonNumber == "0124921");// will return null if dont have any record
            var personsFrstDefaultmatch = PersonL.FirstOrDefault(x => x.PersonNumber == "01248");//matching records
            var personsFrstDefaultmatch1 = PersonL.FirstOrDefault();// First record


            var personsSingle = PersonL.Single(x => x.PersonNumber == "0124921");// will throw an error if no records found
            var personsSingle1 = PersonL.Single(x => x.PersonNumber == "01248");// will return the matching record
            var personsSingle2 = PersonL.Single();//will throw an error if sequence have more than one elements,


            var personsSingleDef = PersonL.SingleOrDefault(x => x.PersonNumber == "0124921");// will return null if no records found
            var personsSingleDef1 = PersonL.SingleOrDefault(x => x.PersonNumber == "01248");// will return matching records
            var personsSingleDef2 = PersonL.SingleOrDefault();//will throw an error if sequence have more than one elements,


        }

        public void CheckLinqAdvConcepts()
        {
            var personsQ = PersonL.OrderByDescending(x => x.PersonType.Type == "CWR")?.ToList();// Order by CWR rsult will be IOrderedIEnumerable, with CWR first

            var personOrder = PersonL.OrderByDescending(x => x.PersonType.Type == "CWR")
                                     .GroupBy(x => x.PersonType.Type == "EMP")
                                     ?.ToList();
        }

        public void CheckJoins()
        {
            var studentObj = new Student();
            var studentList = Student.studentList;
            var standardList = Student.standardList;
            var innerJoin = studentList.Join(// outer sequence 
                      standardList,  // inner sequence 
                      student => student.StandardID,    // outerKeySelector
                      standard => standard.StandardID,  // innerKeySelector
                      (student, standard) => new  // result selector
                      {
                          StudentName = student.StudentName,
                          StandardName = standard.StandardName
                      });

            var StudentNames = innerJoin.Select(x => x.StudentName);
            var StandardNames = innerJoin.Select(x => x.StandardName);
        }

        public void CheckPersonJoins()
        {
            var persons = PersonL;
            var cardLst = cards;
            var innerJoin = persons.Join(// outer sequence 
                      cardLst,  // inner sequence 
                      person => person.CardId,    // outerKeySelector
                      card => card.CardId,  // innerKeySelector
                      (person, card) => new  // result selector
                      {
                          PersonLastName = person.LastName,
                          PersonNumber = person.PersonNumber,
                          CardNumber = card.CardNumber
                      });

            var Person = innerJoin.Select(x => x.PersonNumber + "---" + x.PersonLastName + "----" + x.CardNumber);

        }
    }
}
