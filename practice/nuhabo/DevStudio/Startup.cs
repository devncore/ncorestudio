using System;

namespace DevStudio
{
    public class Startup
    {
        [STAThread]
        public static void Main(string [] args)
        {
            _ = new App().Run();
            Environment.Exit(0);
        }

    }
}
