using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatterns.State
{
    public class DocumentContext
    {
        private IDocumentState _state { get; set; }
        public DocumentContext(IDocumentState state)
        {
            _state = state;
        }

        public void SetState(IDocumentState state)
        {
            _state = state;
        }

        public void Publish()
        {
            _state.Publish();
        }
    }
}
