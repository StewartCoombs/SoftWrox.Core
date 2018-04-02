using System;
using System.Collections.Generic;

using SoftWrox.Core.Model;

namespace SoftWrox.Core.Pattern
{
    public interface IRepository<T> where T : IModel
    {
        T Create(T instance);
        IEnumerable<T> Read();
        T Update(T instance);
        void Delete(T instance);
    }
}
