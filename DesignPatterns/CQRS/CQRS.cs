/*
 CQRS means suppose for a person when we want to save the data we dont need all the fields,
we want to use only FirstName, LastName, Email

So we will create Something like this PersonCommand
 
Now if we want to get the data we will execute PersonQuery because we can get person by name, Number , Id

 */


public class PersonCommand
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Id { get; set; }
    public string Email { get; set; }
}

public class PersonQuery
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string PersonNumber { get; set; }

}