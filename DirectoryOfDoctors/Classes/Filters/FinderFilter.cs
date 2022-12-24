using System.Collections;
using System.Collections.Generic;

namespace DirectoryOfDoctors.Classes.Filters
{
    internal class FinderFilter : IFIlter
    {
        public IEnumerable Filter(IEnumerable items, ISpecification spec)
        {
            List<Doctor> doctors = new List<Doctor>();

            foreach (Doctor item in items)
            {
                if (spec.IsSatisfied(item))
                {
                    doctors.Add(item);
                }
            }
            return doctors;
        }
    }
}
