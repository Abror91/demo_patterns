using System;

namespace DemoPatterns.State
{
    public class PublishedState : IDocumentState
    {
        public void Publish()
        {
            Console.WriteLine("Document is in published state, so do nothing.");
        }
    }
}
