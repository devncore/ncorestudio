using System;

namespace NcoreStudio
{
    class Startup
    {
        [STAThread]
        public static void Main()
        {
            _ = new App().Run();
        }
    }
}
