// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Storage.Files.DataLake.Perf.Options
{
    public interface IDataLakeClientOptionsProvider
    {
        DataLakeClientOptions ClientOptions { get; }
    }
}
