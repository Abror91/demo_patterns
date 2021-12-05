using System;

namespace DemoPatterns.State
{
    public class ModerationState : IDocumentState
    {
        private User _user { get; set; }
        public ModerationState(User user)
        {
            _user = user;
        }

        public void Publish()
        {
            if (_user.Role != "Admin")
                throw new Exception("User role should be admin");

            Console.WriteLine("Changing document state to published.");
        }
    }
}
