using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace APBDTUT2.Models
{
    public class Student
    {
        private string _firstname;
        private string _lastname;
        private string _email;
        private string _studentno;
        [XmlElement(elementName: "email")]
        public string Email {
            get { return _email; }
            set
            {
                _email = value ?? throw new ArgumentNullException();
            }
        }
        [XmlElement(elementName: "fname")]
        public string FirstName {
            get { return _firstname; }
            set
            {
                _firstname = value ?? throw new ArgumentNullException();
            }
        }
        [XmlElement(elementName: "lname")]
        public string LastName {
            get { return _lastname; }
            set
            {
                _lastname = value ?? throw new ArgumentNullException();
            }
        }
        [XmlAttribute(attributeName: "IndexNumber")]
        public string StudentNo {
            get { return _studentno; }
            set
            {
                _studentno = value ?? throw new ArgumentNullException();
            }
        }
        private DateTime _birthdate;
        public DateTime Birthdate {
            get { return _birthdate; }
            set {
                if (value == null) throw new ArgumentNullException();
                _birthdate = value;
            } }
        private string _mothersname;
        public string Mothersname {
            get { return _mothersname; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                _mothersname = value;
            }
        }
        private string _fathersname;
        public string Fathersname {
            get { return _fathersname; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                _fathersname = value;
            }
        }

        
    }
}
