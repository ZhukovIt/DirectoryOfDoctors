namespace DirectoryOfDoctors.Classes.Filters
{
    internal class PostSpecification : ISpecification
    {
        private readonly string post;

        public PostSpecification(string post)
        {
            this.post = post;
        }

        public bool IsSatisfied(Doctor doctor)
        {
            return doctor.Post.ToLower().Contains(post.ToLower());
        }
    }
}
