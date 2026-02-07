using BlazorExperiments.Client.Models;

namespace BlazorExperiments.Client.Pages;

public partial class QuickGridExample
{
    private List<Person> Family= new List<Person>
    {
        new Person { Id = 1, FirstName = "John", LastName = "Doe", Age = 40 },
        new Person { Id = 2, FirstName = "Jane", LastName = "Doe", Age = 39 },
        new Person { Id = 3, FirstName = "Sam", LastName = "Smith", Age = 10 },
        new Person { Id = 4, FirstName = "Emily", LastName = "Johnson", Age = 8 },
    };
}
