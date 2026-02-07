using BlazorExperiments.Client.Models;

namespace BlazorExperiments.Client.Pages;

public partial class QuickGridExample
{
    private IQueryable<Person> Family= new List<Person>
    {
        new Person { Id = 1, FirstName = "John", LastName = "Doe", Age = 40 },
        new Person { Id = 2, FirstName = "Jane", LastName = "Doe", Age = 39 },
        new Person { Id = 3, FirstName = "Sam", LastName = "Doe", Age = 10 },
        new Person { Id = 4, FirstName = "Emily", LastName = "Doe", Age = 8 }
    }.AsQueryable();
}
