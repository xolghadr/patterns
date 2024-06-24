namespace ObserverPattern.Concretes
{
    public class UserNameChangedSubject : Subject
    {
        public string NewName { get; set; }
        public string OldName { get; set; }
    }
}