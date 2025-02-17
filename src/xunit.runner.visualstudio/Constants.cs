﻿namespace Xunit.Runner.VisualStudio
{
    public static class Constants
    {
#if NETFRAMEWORK
        public const string ExecutorUri = "executor://xunit/VsTestRunner2/net";
#elif WINDOWS_UAP
        public const string ExecutorUri = "executor://xunit/VsTestRunner2/uap";
#elif NETCOREAPP
        public const string ExecutorUri = "executor://xunit/VsTestRunner2/netcoreapp";
#else
#error Unknown target platform
#endif
    }
}
