namespace ObserverPattern.Concretes
{
    public class User
    {
        public User(string email, string name)
        {
            Email = email;
            Name = name;
            NameChanged = new UserNameChangedSubject();
            EmailChanged = new UserEmailChangedSubject();
        }
        public string Email { get; private set; }
        public string Name { get; private set; }

        public UserNameChangedSubject NameChanged { get; }
        public UserEmailChangedSubject EmailChanged { get; }

        public void UpdateUserName(string name)
        {
            NameChanged.OldName = Name;
            Name = name;
            NameChanged.NewName = name;
            NameChanged.Notify();
        }

        public void UpdateUserEmail(string email)
        {
            EmailChanged.OldEmail = Email;
            Email = email;
            EmailChanged.NewEmail = email;
            EmailChanged.Notify();
        }
    }
}