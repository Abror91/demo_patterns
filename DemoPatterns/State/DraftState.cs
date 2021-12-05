using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.State
{
    public class DraftState : IDocumentState
    {
        private User _user { get; set; }
        public DraftState(User user)
        {
            _user = user;
        }
        public void Publish()
        {
            if (_user.Role != "User")
                throw new Exception("User role should be user");

            Console.WriteLine("Change document state to moderation");
        }
    }
}
