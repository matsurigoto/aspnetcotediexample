using System.Collections.Generic;

namespace DIExample.Interfaces
{
    public interface ITestQueries
    {
        string GetName(string id);

        List<string> GetNames(string depId);
    }
}
