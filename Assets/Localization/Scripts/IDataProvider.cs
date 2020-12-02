using Cysharp.Threading.Tasks;

namespace Zitga.LocalizeTools
{
    public interface IDataProvider
    {
        void ClearData();

        void Load();

        UniTask<string> Get(string category, string key);
    }
}