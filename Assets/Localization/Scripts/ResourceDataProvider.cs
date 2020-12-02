using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace Zitga.LocalizeTools
{
    public class ResourceDataProvider : IDataProvider
    {
        private Dictionary<string, string> data;

        public ResourceDataProvider()
        {
            data = new Dictionary<string, string>();
        }
        public void ClearData()
        {
            throw new System.NotImplementedException();
        }

        public void Load()
        {
            throw new System.NotImplementedException();
        }

        public UniTask<string> Get(string category, string key)
        {
            throw new System.NotImplementedException();
        }
    }
}