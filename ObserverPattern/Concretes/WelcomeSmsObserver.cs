namespace ObserverPattern.Concretes
{
    public class SendSmsToUserObserver : IObserver
    {
        public void Update(Subject subject)
        {
            if (subject is UserNameChangedSubject nameChangedSubject)
                Console.WriteLine($"sending sms: your name changed from {nameChangedSubject.OldName} to {nameChangedSubject.NewName}");
        }
    }
}