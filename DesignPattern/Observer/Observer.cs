// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        // Your code goes here... make sure to add this features:
        //1. Allow to hold the observer's name (e.g. when user Adam wants to observe the subject)
        public string UserName { get; set; } = userName;
        private ISubject _subject { get; set; }
        
        //2. Creating the Observer
        //3. Registering the Observer with the Subject
        public void AddSubscriber(Subject subject)
        {
            subject.RegisterObserver(this);
            _subject = subject;
            Console.WriteLine($"{userName} subscribed to Notifications");
        }

        //4. Removing the Observer from the Subject
        public void RemoveSubscriber(Subject subject)
        {
            subject.RemoveObserver(this);
            Console.WriteLine($"{userName} unsubscribed from Notifications");
        }

        //5. Observer will get a notification from the Subject using the following Method
        public void Update(string availability)
        {
            Console.WriteLine($"Hey {userName}! The products are {availability} now at the shop! You should def take a glance!");
        }
    }
}
