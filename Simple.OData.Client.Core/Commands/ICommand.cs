﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Simple.OData.Client
{
    public interface ICommand
    {
        IClientWithCommand As(string derivedCollectionName);
        IClientWithCommand As(ODataExpression expression);
        IClientWithCommand Key(params object[] entryKey);
        IClientWithCommand Key(IEnumerable<object> entryKey);
        IClientWithCommand Key(IDictionary<string, object> entryKey);
        IClientWithCommand Filter(string filter);
        IClientWithCommand Filter(ODataExpression expression);
        IClientWithCommand Skip(int count);
        IClientWithCommand Top(int count);
        IClientWithCommand Expand(IEnumerable<string> associations);
        IClientWithCommand Expand(params string[] associations);
        IClientWithCommand Expand(params ODataExpression[] associations);
        IClientWithCommand Select(IEnumerable<string> columns);
        IClientWithCommand Select(params string[] columns);
        IClientWithCommand Select(params ODataExpression[] columns);
        IClientWithCommand OrderBy(IEnumerable<KeyValuePair<string, bool>> columns);
        IClientWithCommand OrderBy(params string[] columns);
        IClientWithCommand OrderBy(params ODataExpression[] columns);
        IClientWithCommand ThenBy(params string[] columns);
        IClientWithCommand ThenBy(params ODataExpression[] columns);
        IClientWithCommand OrderByDescending(params string[] columns);
        IClientWithCommand OrderByDescending(params ODataExpression[] columns);
        IClientWithCommand ThenByDescending(params string[] columns);
        IClientWithCommand ThenByDescending(params ODataExpression[] columns);
        IClientWithCommand Count();
        IClientWithCommand NavigateTo(string linkName);
        IClientWithCommand NavigateTo(ODataExpression expression);
        IClientWithCommand Set(object value);
        IClientWithCommand Set(IDictionary<string, object> value);
        IClientWithCommand Set(params ODataExpression[] value);
        IClientWithCommand Function(string functionName);
        IClientWithCommand Parameters(IDictionary<string, object> parameters);
        bool FilterIsKey { get; }
        IDictionary<string, object> FilterAsKey { get; }
    }
}