using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Record
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Record()  {}

        public Record(string Name, string PhoneNumber)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
        }

        public override string ToString()
        {
            return String.Format($"{Name}:   {PhoneNumber}");
        }

        public override bool Equals(object obj)
        {
            Record record = (Record)obj;
            return record.Name == Name && record.PhoneNumber == PhoneNumber;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ PhoneNumber.GetHashCode();
        }
    }
}
