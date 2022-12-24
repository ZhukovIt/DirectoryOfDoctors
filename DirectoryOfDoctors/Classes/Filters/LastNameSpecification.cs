namespace DirectoryOfDoctors.Classes.Filters
{
    internal class LastNameSpecification : ISpecification
    {
        private readonly string lastName;

        public LastNameSpecification(string last_name)
        {
            lastName = last_name;
        }

        public bool IsSatisfied(Doctor doctor)
        {
            return doctor.LastName.ToLower().Contains(lastName.ToLower());
        }
    }
}
