using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_shop
{
    internal class Buyer
    {
        private string _name;
        private string _day;
        private string _location;
        private string _mail;
        private string _number;

        public Buyer(string name, string day, string location, string mail, string number)
        {
            this._name = name;
            this._day = day;
            this._location = location;
            this._mail = mail;
            this._number = number;
        }

        public string GetName() { return _name; }
        public string GetDay() { return _day; }
        public string GetLocation() { return _location; }
        public string GetMail() { return _mail; }
        public string GetNumber() { return _number;}
    }
}
