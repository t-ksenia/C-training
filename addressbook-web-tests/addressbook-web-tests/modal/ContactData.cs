using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
   public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string firstname;
        private string lastname;
        private string address = "";
        private string phonehome = "";
        private string email = "";
        private string text;

        public ContactData (string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;

        }

        public ContactData(string text)
        {
            this.text = text;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }

        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }

        }
        public string Phonehome
        {
            get
            {
                return phonehome;
            }
            set
            {
                phonehome = value;
            }

        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }

        }

        public bool Equals(ContactData other)
        {

            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Firstname == other.Firstname && Lastname == other.Lastname;
            
        }

        public override int GetHashCode()
        {
            return (Firstname + Lastname).GetHashCode();
        }
        
        public override string ToString()
        {
            return "firstname" + Firstname;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            return Firstname.CompareTo(other.Firstname);
        }
    }
}
