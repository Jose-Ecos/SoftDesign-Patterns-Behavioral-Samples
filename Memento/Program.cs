using Memento.GUI;

namespace Memento
{    
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeGUI());
        }
    }
}
