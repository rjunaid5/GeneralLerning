using SOLIDPrinciples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    // Open Closed Principle 
    // It means open for Extension and closed for Modification
    // meaning class which is in production or tested must not be changed
    // rather it must be Extended
    public class OCP
    {
    }

    // now this class in production, new requirement comes that save person
    // to file also now if we wrtie new method save to file than we are violating
    public class PersonDao
    {
        //Save To Db
        public void Save(Person person)
        {

        }

        //xxxxxxxx
        public void SaveToFile(Person person)
        {

        }
    }
}

namespace SolutionOCP
{
    public interface IPersonDao
    {
        void Save(Person person);

    }

    //we cannot modify this personDbDao becoz its in production
    public class PersonDBDao : IPersonDao
    {
        public void Save(Person person)
        {

        }
    }

    public class PersonFileDao : IPersonDao
    {
        public void Save(Person person)
        {

        }
    }

}
