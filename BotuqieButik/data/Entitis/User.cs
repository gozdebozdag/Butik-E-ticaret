namespace BotuqieButik.data.Entitis
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? Birthday { get; set; }

        public List<Role> roles { get; set; }
    }
}
