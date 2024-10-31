using System.Windows.Input;
using Bogus;
using CommunityToolkit.Mvvm.ComponentModel;
using DotNetCommunityToolkit.MVVM.Models;

namespace DotNetCommunityToolkit.MVVM.ViewModels
{

    public partial class DemoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _password;
        public FakePerson Person { get; set; }

        /*public string Password
        {
            get => _password;
            set => _password = value;
        }*/

        public ICommand GenerateData =>
             new Command(() =>
             {
                 var faker = new Faker<FakePerson>()
                   .RuleFor(p => p.FirstName, f => f.Person.FirstName)
                   .RuleFor(p => p.LastName, f => f.Person.LastName)
                   .Generate();

                 Person.FirstName = faker.FirstName;
                 Person.LastName = faker.LastName;

                 Password = new Faker().Internet.Password(5, true);
             });

        public DemoViewModel()
        {
            Person = new FakePerson
            {
                FirstName = "Héctor",
                LastName = "Pérez",
            };

            Password = new Faker().Internet.Password(5, true);
        }
    }
}
