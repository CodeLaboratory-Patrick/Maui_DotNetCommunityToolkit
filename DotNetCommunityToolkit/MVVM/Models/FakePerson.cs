using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DotNetCommunityToolkit.MVVM.Models
{
    public partial class FakePerson : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string _firstName;

        [ObservableProperty]
        private string _lastName;

        partial void OnFirstNameChanged(string value)
        {
            Console.WriteLine(value);
        }

        /*public string FirstName
        {
            get => _firstName;
            set
            {
                //_firstName = value;
                SetProperty(ref _firstName, value);
            }
        }*/

        /*public string LastName
        {
            get => _lastName;
            set
            {
                //_lastName = value;
                SetProperty(ref _lastName, value);
            }
        }*/

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
