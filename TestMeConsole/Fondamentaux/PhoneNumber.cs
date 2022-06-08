using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMeConsole.Fondamentaux
{
    public class PhoneNumber
    {
        public string Area { get; }
        public string Major { get; }
        public string Minor { get; }

        public PhoneNumber()
        {
    
        }
        private PhoneNumber(string area, string major, string minor)
        {
            Area = area;
            Major = major;
            Minor = minor;
        }

        public  PhoneNumber Parse(string number)
        {
            if (String.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Le numéro de téléphone ne peut pas être vide.");

            if (number.Length != 11)
                throw new ArgumentException("Le numéro de téléphone doit comporter 11 chiffres.");

            var area = number.Substring(0, 3);
            var major = number.Substring(3, 2);
            var minor = number.Substring(5);

            return new PhoneNumber(area, major, minor);
        }

        public override string ToString()
        {
            return String.Format($"({Area}){Major}-{Minor}");
        }
    }
}
