using System;
using System.Collections.Generic;
using System.Text;
using APBDTUT2.Models;

namespace APBDTUT2
{
    public class CustomComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return StringComparer
                        .InvariantCultureIgnoreCase
                        .Equals($"{x.StudentNo} {x.Email} {x.FirstName} {x.LastName}",
                                $"{y.StudentNo} {y.Email} {y.FirstName} {y.LastName}");
        }

        public int GetHashCode(Student obj)
        {
            return StringComparer.
                    CurrentCultureIgnoreCase
                    .GetHashCode($"{obj.StudentNo} {obj.Email} {obj.FirstName} {obj.LastName}");
        }
    }
}
