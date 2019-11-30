using System;
using System.Collections.Generic;
using System.Text;

namespace WpfLABA
{
    class Threats
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public int ViolationOfConfidentiality { get; set; }
        public int ViolationOfIntegrity { get; set; }
        public int ViolationOfAccess { get; set; }

        public object this[int index]
        {
            //The get accessor is used for returning a value
            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Description;
                else if (index == 3)
                    return Source;
                else if (index == 4)
                    return Target;
                else if (index == 5)
                    return ViolationOfConfidentiality;
                else if (index == 6)
                    return ViolationOfIntegrity;
                else if (index == 7)
                    return ViolationOfAccess;
                else
                    return null;
            }

            // The set accessor is used to assigning a value
            set
            {
                if (index == 0)
                    Id = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Description = value.ToString();
                else if (index == 3)
                    Source = Convert.ToString(value);
                else if (index == 4)
                    Target = Convert.ToString(value);
                else if (index == 5)
                    ViolationOfConfidentiality = Convert.ToInt32(value);
                else if (index == 6)
                    ViolationOfIntegrity = Convert.ToInt32(value);
                else if (index == 7)
                    ViolationOfAccess = Convert.ToInt32(value);
            }
        }
    }
}
