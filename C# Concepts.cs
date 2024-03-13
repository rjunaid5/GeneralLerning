// Using key word
/*
when Using statement, at the end of using statement date base connection is automatically closed. suppose by using .net framework
if im performing a database operation and exception occurs, database connection will be closed by calling IDispose.Dispose() context
here's no need to call the connection Close() method explicitly.


*/

using (var dataAccess = ResolveDependency<IPersonDao>())
{
    var person = dataAccess.Select(personId));
}

// Connection Pooling 
/*
Another important factor is that it helps in Connection Pooling.
Connection Pooling in .NET helps to eliminate the closing of a database connection multiple times.
It sends the connection object to a pool for future use (next database call).
The next time a database connection is called from your application the connection pool fetches the objects available in the pool. So it helps to improve the performance of the application.
*/

/*
Sample 2(Connection Pooling is disabled):
Run the application, on my machine the difference in time is:  937626 ticks
 
Sample 2(Connection Pooling is disabled):
 
Just add Pooling=false in the connection string.
*/



///---------REF Vs OUT
//ref variable need to be intialized before passing into function and no need to initialize afterwords
// out variable need not to be initialized before passing into
int i1;
int i3= 12;
GetNextNameOut(out i1);
GetNextNameRef(ref i3);
public static string GetNextName123(ref int id)
{
    string returnText = "Next-" + id.ToString();
    id += 1;
    return returnText;
}
public static string GetNextName(out int id)
{
    id = 1;
    string returnText = "Next-" + id.ToString();
    return returnText;
}

//.NET vs .CORE

// - .NET only works for Windows , .NET core works on windows, linux , mac. NET 6.0 is combination of both of these
// .NET has winforms and desktop apps while .net core doesnot have desktop app
// .NET core is fast because .NET framework has big big dlls like System.Collection but .NET core has broken them into smaller dlls
// .NET core application can be accessed through windows command prompt which makes it easier for other IDEs to work with this applciation whereas
// .NET frameworks only work on VisualStudio


/*- Garbage Collector
it is a background process which runs to see any unused objects in the program and put them into memory heap
.e.g


*/
foreach(var items in Collection){
     var x = new Customer();
}
// customer is unused so it will be thrown into heap

/*Heap vs stack in stack datatypes like int,double,bool are stored whereas in HEap objects and member variables valuse are stored by ref*/
// Reference Types are of classes where pointer are stored at stack and values are stored in heap

/*Boxing: when vlaue type like int i = 10 is stored into refernce type object than it is boxing*/
int i = 10;
object y = int(i); //boxing
int z = int(y); // unboxing
// as a result of boxing and unboxing there will be a performance issue


/*CASTING
when moving from high to low data type or low to high data type
*/
int i = 6;
double d = i; // implicit casting from low data type to high data type

int x = d; // there will be error , we need explicit casting
int x = int(d);


var model = new RoleTest() ?? SecurityRoleTest;
public static implicit operator RoleGroupEditViewModel(SecurityRoleTest roleGroup)
{
    return new RoleTest
    {
        Id = roleGroup.Id,
        Name = roleGroup.Name,
        Description = roleGroup.Description
        
    };
}


/*Thread vs Task(TPL Task Processing Library)
Task is parallel processing, it checks which processor(core) is free and assign job to it and executes job in parallel
Thread utilizes one core only and do time adjustment between tasks
 */