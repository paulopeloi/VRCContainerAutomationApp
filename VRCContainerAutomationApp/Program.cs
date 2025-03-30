using System.Diagnostics;

namespace VRCContainerAutomationApp
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
            Application.Run(new MainForm());

            //var sql = "SELECT * FROM warehouse_locations";
            //var result = Database.SQLiteService.ExecuteQuery(sql);
            //for (int i = 0; i < result.Count; i++)
            //{
            //    Debug.WriteLine($"SIM ----->> {result[i]["zone"]}");
            //}
        }
    }
}