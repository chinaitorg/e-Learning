namespace MyfirstProgram
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyForm form = new MyForm();

            Application.Run(form);
        }
    }
}