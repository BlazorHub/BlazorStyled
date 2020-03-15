﻿using BlazorStyled.Internal;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorStyled.Stylesheets
{
    internal interface IStyleSheet
    {
        int Count { get; }
        void AddClass(IRule rule, string id);
        void ClearStyles(string id);
        IEnumerator<IRule> GetEnumerator();
        string GetHashCodes();
        IEnumerable<string> GetImportRules();
        IList<IRule> GetRules(string id, string selector);
        IEnumerable<IRule> GetRulesWithoutImport();
        IDisposable Subscribe(IObserver<RuleContext> observer);
        void SetThemeValue(string id, string name, string value);
        IEnumerable<KeyValuePair<string, string>> GetThemeValues(string id);
        bool ScriptRendered { get; }
        ValueTask<bool> BecomeScriptTag();
        void UnbecomeScriptTag();
        bool ScriptRendering { get; }
        ValueTask<bool> BecomingScriptTag();
        void UnbecomingScriptTag();
        Queue<RuleContext> Storage { get; set; }
        string GlobalStyle(string id, string globalClassName);
        void AddOrUpdateGlobalStyle(string id, string globalClassName, string className);
    }
}