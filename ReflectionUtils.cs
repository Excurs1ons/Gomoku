using System;
using System.Collections.Generic;
using System.Linq;

namespace Gomoku
{
    public static class ReflectionUtils
    {
        public static void EnumerateSubclasses<T>(Action<T> onInstanceCreated) where T:class
        {
            var types = GetSubclasses<T>();
            foreach (var type in types)
            {
                onInstanceCreated.Invoke((T)Activator.CreateInstance(type));
            }
        }

        public static IEnumerable<Type> GetSubclasses<T>() =>
            AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => typeof(T).IsAssignableFrom(type) && type.IsClass && !type.IsAbstract);
    }
}