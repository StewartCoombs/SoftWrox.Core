using System;

using SoftWrox.Core.Model;

namespace SoftWrox.Core.Pattern
{
    public interface IProcess<T> where T : IModel
    {
        T Run();
    }
}
