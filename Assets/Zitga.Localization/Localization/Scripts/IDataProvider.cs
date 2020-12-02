﻿using Cysharp.Threading.Tasks;
using Zitga.LocalizeTools.Tutorials;

namespace Zitga.LocalizeTools
{
    public interface IDataProvider
    {
        void ClearData();

        UniTask<LanguageData> Load(string category);

        UniTask<string> Get(string category, string key);
    }
}