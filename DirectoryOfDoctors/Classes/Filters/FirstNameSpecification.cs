namespace DirectoryOfDoctors.Classes.Filters
{
    internal class FirstNameSpecification :ISpecification
    {
        private readonly string firstName;

        public FirstNameSpecification(string first_name)
        {
            firstName = first_name;
        }

        public bool IsSatisfied(Doctor doctor)
        {
            return doctor.FirstName.ToLower().Contains(firstName.ToLower());
        }
    }
}
