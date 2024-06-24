namespace ObserverPattern.Concretes
{
    public class NewsSubscriptionEmailObserver : IObserver
    {
        public void Update(Subject subject)
        {
            if(subject is UserEmailChangedSubject emailChangedSubject)
            Console.WriteLine($"sending invitation email to {emailChangedSubject.NewEmail}");
        }
    }
}