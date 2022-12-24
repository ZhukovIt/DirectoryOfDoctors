namespace DirectoryOfDoctors.Classes.Filters
{
    internal interface ISpecification
    {
        bool IsSatisfied(Doctor doctor);
    }
}
