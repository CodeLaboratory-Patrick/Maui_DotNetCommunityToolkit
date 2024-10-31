using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DotNetCommunityToolkit.MVVM.Models
{
    public class FakePerson : ObservableObject
    {
        private string _firstName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                //_firstName = value;
                SetProperty(ref _firstName, value);
            }
        }

        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
