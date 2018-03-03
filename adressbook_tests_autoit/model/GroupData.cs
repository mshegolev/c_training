﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_tests_autoit
{
    public class GroupData : IComparable<GroupData>, IEquatable<GroupData>
    {
        public string Name { get; set; }

        int IComparable<GroupData>.CompareTo(GroupData other)
        {
            return this.Name.CompareTo(other.Name);
        }

        bool IEquatable<GroupData>.Equals(GroupData other)
        {
            return this.Name.Equals(other.Name);
        }
    }
}