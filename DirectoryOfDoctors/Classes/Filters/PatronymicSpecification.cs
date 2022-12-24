namespace DirectoryOfDoctors.Classes.Filters
{
    internal class PatronymicSpecification : ISpecification
    {
        private readonly string patronymic;

        public PatronymicSpecification(string patronymic)
        {
            this.patronymic = patronymic;
        }

        public bool IsSatisfied(Doctor doctor)
        {
            if (doctor.Patronymic == null)
            {
                return false;
            }
            return doctor.Patronymic.ToLower().Contains(patronymic.ToLower());
        }
    }
}
