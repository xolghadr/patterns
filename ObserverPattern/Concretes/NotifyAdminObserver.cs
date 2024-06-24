namespace ObserverPattern.Concretes
{
    public class NotifyAdminObserver : IObserver
    {
        public void Update(Subject subject)
        {
            if (subject is UserEmailChangedSubject emailChangedSubject)
                Console.WriteLine($"user email changed from {emailChangedSubject.OldEmail} to {emailChangedSubject.NewEmail}");
            if (subject is UserNameChangedSubject nameChangedSubject)
                Console.WriteLine($"user name changed from {nameChangedSubject.OldName} to {nameChangedSubject.NewName}");
        }
    }
}