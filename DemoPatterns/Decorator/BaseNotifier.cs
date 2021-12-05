namespace DemoPatterns.Decorator
{
    public class BaseNotifier : INotifier
    {
        private readonly INotifier _notifier;
        public BaseNotifier(INotifier notifier)
        {
            _notifier = notifier; 
        }

        public virtual void Notify(string message)
        {
            _notifier.Notify(message);
        }
    }
}
