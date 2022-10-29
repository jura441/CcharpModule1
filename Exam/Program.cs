using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {

        string _name;
        string _password;
        DateTime _birthDate;
        public string Name { get; set; }
        public string Login { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
        public DateTime DateOfBirth { get => _birthDate; set => _birthDate = value; }
        public string ToString();
    }
}
