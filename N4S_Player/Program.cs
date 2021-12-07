namespace N4S_Player
{
    public struct Details
    {
        public string name;
        public string pathdetails;
    }
    internal static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new A7_Music());
        }
    }
}