using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace APBDTUT2.Models
{
    class Studies
    {
        private string _sname;

        [XmlElement(elementName:"name")]
        public string Sname {
            get { return _sname; }
            set
            {
                _sname = value ?? throw new ArgumentNullException();
            }
        }

        private string _smode;

        [XmlElement(elementName: "mode")]
        public string Smode
        {
            get { return _smode; }
            set
            {
                _smode = value ?? throw new ArgumentNullException();
            }
        }
    }
}
