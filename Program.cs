namespace oop_final_game
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            while (true)
            {
                // Show the Start Screen using Application.Run
                var startForm = new StartForm();
                Application.Run(startForm);

                if (startForm.DialogResult != System.Windows.Forms.DialogResult.OK)
                    break; // User closed or exited

                string playerName = startForm.PlayerName;

                // Run the main game
                var gameForm = new Form1(playerName);
                Application.Run(gameForm);

                // If the user didn't ask to restart, break
                if (gameForm.ShouldRestart != true)
                    break;
            }
        }
    }
}