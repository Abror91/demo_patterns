namespace DemoPatterns.State
{
    public class User
    {
        public User(string name, string role)
        {
            Name = name;
            Role = role;
        }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
