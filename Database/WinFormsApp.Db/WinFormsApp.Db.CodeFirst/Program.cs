namespace WinFormsApp.Db.CodeFirst
{
    internal static class Program
    {
        public static LoginForm login = new LoginForm();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(login);
        }
    }
}