namespace ObserverPattern.Concretes
{
    public class UserEmailChangedSubject : Subject
    {
        public string NewEmail { get; set; }
        public string OldEmail { get; set; }
    }
}