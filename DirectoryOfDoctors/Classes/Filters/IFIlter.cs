using System.Collections;

namespace DirectoryOfDoctors.Classes.Filters
{
    internal interface IFIlter
    {
        IEnumerable Filter(IEnumerable items, ISpecification spec);
    }
}
