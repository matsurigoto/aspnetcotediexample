using System;
using DIExample.Interfaces;
using System.Collections.Generic;

namespace DIExample.Services
{
    public class TestQueries : ITestQueries
    {
        public string GetName(string id)
        {
            throw new NotImplementedException();
        }

        public List<string> GetNames(string depId)
        {
            throw new NotImplementedException();
        }
    }
}
