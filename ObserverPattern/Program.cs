// See https://aka.ms/new-console-template for more information
using ObserverPattern.Concretes;
var user = new User("sadegh@example.com","XoL");

user.EmailChanged.Attach(new NewsSubscriptionEmailObserver());
user.EmailChanged.Attach(new NotifyAdminObserver());

user.NameChanged.Attach(new SendSmsToUserObserver());
user.NameChanged.Attach(new NotifyAdminObserver());

user.UpdateUserEmail("sadegh@xol.dev");
user.UpdateUserName("Sadegh Xolghadr");