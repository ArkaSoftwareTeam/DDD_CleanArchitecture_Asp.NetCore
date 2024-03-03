﻿namespace Hesabdari.Core.Contracts.ApplicationServices.Common
{
    public class ApplicationServiceResult : IApplicationServiceResult
    {
        protected readonly List<string> _messages = new();
        public IEnumerable<string> Messages => _messages;
        public ApplicationServiceStatus Status { get; set; }
        public void AddMessage(string error) => _messages.Add(error);
        public void AddMessage(IEnumerable<string> errors) => _messages.AddRange(errors);
        public void ClearMessages() => _messages.Clear();
        
    }
}
