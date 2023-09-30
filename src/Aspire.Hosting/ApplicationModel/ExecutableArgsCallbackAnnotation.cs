// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Aspire.Hosting.ApplicationModel;

public class ExecutableArgsCallbackAnnotation : IDistributedApplicationComponentAnnotation
{
    public ExecutableArgsCallbackAnnotation(Action<IList<string>> callback)
    {
        Callback = callback;
    }

    public Action<IList<string>> Callback { get; private set; }
}