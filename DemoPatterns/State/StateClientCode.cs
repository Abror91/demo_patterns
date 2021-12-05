using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.State
{
    public class StateClientCode
    {
        public static void Test()
        {
            var user = new User("Jason", "User");
            IDocumentState draftState = new DraftState(user);
            var document = new DocumentContext(draftState);
            document.Publish();

            var adminUser = new User("Simon", "Admin");
            IDocumentState moderationState = new ModerationState(adminUser);
            document.SetState(moderationState);
            document.Publish();

            IDocumentState publishedState = new PublishedState();
            document.SetState(publishedState);
            document.Publish();

        }
    }
}
