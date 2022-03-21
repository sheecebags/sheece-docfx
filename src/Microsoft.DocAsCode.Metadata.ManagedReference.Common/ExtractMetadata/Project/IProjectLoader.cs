﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DocAsCode.Metadata.ManagedReference
{
    public interface IProjectLoader
    {
        AbstractProject TryLoad(string path, AbstractProjectLoader loader);
    }
}
