/*using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrival._Common
{
    public class AsyncLazy<T>
    {
        readonly Lazy<Task<T>> instance;


        public AsyncLazy(Func<T> factory)
        {
            instance = new Lazy<Task<T>>(() => CreateTask1(factory));
        }

        public AsyncLazy(Func<Task<T>> factory)
        {
            instance = new Lazy<Task<T>>(() => CreateTask2(factory));
        }

        public TaskAwaiter<T> GetAwaiter()
        {
            return instance.Value.GetAwaiter();
        }

        private Task<T> CreateTask1(Func<T> factory)
        {
            return Task.Run(factory);
        }

        private Task<T> CreateTask2(Func<Task<T>> factory)
        {
            return Task.Run(factory);
        }
    }
}
/**/