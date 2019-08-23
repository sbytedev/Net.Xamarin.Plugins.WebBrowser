using System;
using System.Threading;

// ReSharper disable once CheckNamespace

namespace SByteDev.Xamarin.Plugins.WebBrowser
{
    public sealed class Plugin<T> where T : class
    {
        private readonly Func<T> _factory;
        private readonly Lazy<T> _lazy;

        public bool IsSupported => _lazy.Value != null;

        public T Instance => _lazy.Value ?? throw CreateNotImplementedException();

        public Plugin(Func<T> factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

            _lazy = new Lazy<T>(CreateInstance, LazyThreadSafetyMode.PublicationOnly);
        }

        private T CreateInstance()
        {
#if NETSTANDARD2_0
            return null;
#else
            return _factory();
#endif
        }

        private static Exception CreateNotImplementedException()
        {
            return new NotImplementedException(
                "This functionality is not implemented in the portable version of this assembly." +
                "You should reference the NuGet package from your main application project " +
                "in order to reference the platform-specific implementation.");
        }
    }
}