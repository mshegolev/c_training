using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_tests_autoit
{
    public class ContactData 
        //: IComparable<GroupData>, IEquatable<GroupData>
    {
        public string Identifire { get; set; }
        public string Title{ get; set; }
        public string FirstName{ get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

    }
}
