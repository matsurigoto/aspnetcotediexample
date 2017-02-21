using System;
using DIExample.Interfaces;
using System.Collections.Generic;

namespace DIExample.Services
{
    public class TestQueries : ITestQueries
    {
        public string GetName(string id)
        {
            return "Duran";
        }

        public List<string> GetNames(string depId)
        {
            List<string> result = new List<string>();
            result.Add("Pete");
            result.Add("Michael");
            result.Add("Maze");
            result.Add("Luke");
            result.Add("Casey");
            result.Add("Duran");

            return result;
        }
    }
}
