﻿#nullable enable
using System.IO;
using System.Threading.Tasks;

namespace Avalonia.Platform.Storage
{
    public interface IStorageFile : IStorageItem
    {
        bool CanOpenRead { get; }
        Task<Stream> OpenRead();

        bool CanOpenWrite { get; }
        Task<Stream> OpenWrite();
    }
}
