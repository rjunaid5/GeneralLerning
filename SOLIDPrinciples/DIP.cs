using SolutionISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    // Dependency inversion principle means depend on interfaces rather than classes

    // Now this is violation if i need additional changes, instead of Person there should be
    // visitor than 
    public class DIPViolation
    {
        private Person person;
        private Card card;
        public DIPViolation(Person person, Card card)
        {
            this.person = person;
            this.card = card;
        }
    }

    public class DIP
    {
        private IWorkerNew worker;
        private IWorkerNew worker1;

        public DIP(IWorkerNew worker, IWorkerNew worker1)
        {
            this.worker = worker;
            this.worker1 = worker1;
        }
    }

    public class DIPImp
    {
        public void Implement()
        {
            var mechanic = new Mechanic();
            Waiter waiter = new Waiter();
            var waitorAndMachworker = new DIP(mechanic, waiter);
        }
    }
}

