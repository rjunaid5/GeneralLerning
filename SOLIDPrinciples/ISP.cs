using SolutionISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    
    public interface IWorker
    {
        void DoCharity();
        void DoLabourWork();
        void DoResturantWork();
        void DoMechanicWork();
    }
    /*
     Now this is Labour he doesnot have to implement DoMechanicWork and DoResturnatWork
     */
    public class Labour : IWorker
    {
        public void DoCharity()
        {
            //This Method will be implemented
        }

        public void DoLabourWork()
        {
            //This Method will be implemented
        }

        public void DoMechanicWork()
        {
            throw new NotImplementedException();
        }

        public void DoResturantWork()
        {
            throw new NotImplementedException();
        }
    }

    public class Waiter : IWorkerNew
    {
        public void DoCharity()
        {
            //This Method will be implemented
        }
        public void DoLabourWork()
        {
            throw new NotImplementedException();
        }

        public void DoMechanicWork()
        {
           
        }

        public void DoResturantWork()
        {
            throw new NotImplementedException();
        }
    }
}

namespace SolutionISP
{
    public interface IWorkerNew
    {
        void DoCharity();
    }

    public interface IResturantWorker : IWorkerNew
    {
        void DoResturantWork();
    }
    public interface ILabourWorker : IWorkerNew
    {
        void DoLabourWork();
    }
    public interface IMechanicWorker: IWorkerNew
    {
        void DoMechanicWork();
    }

    public class Mechanic : IMechanicWorker
    {
        public void DoCharity()
        {
            // Implement Do Charity
        }

        public void DoMechanicWork()
        {
            // Implement 
        }
    }

}