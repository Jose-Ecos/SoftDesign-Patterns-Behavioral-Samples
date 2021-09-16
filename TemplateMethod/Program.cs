namespace TemplateMethod
{
    using System;
    using System.IO;
    using System.Timers;
    using TemplateMethod.Template;

    class Program
    {
        private static readonly string[] PATHS = new string[] { "C:/files/drugstore", "C:/files/grocery" };
        private static readonly string LOG_DIR = "C:/files/logs";
        private static readonly string PROCESS_DIR = "C:/files/process";

        static void Main(string[] args)
        {
            try
            {                
                System.Timers.Timer aTimer = new System.Timers.Timer();
                aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                
                // Set the Interval to 5 seconds.
                aTimer.Interval = 10000;
                aTimer.Enabled = true;

                while (Console.Read() != 'q') ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs eea)
        {
            Console.WriteLine("> Monitoring start");
            if (!Directory.Exists(PATHS[0]))
            {
                throw new SystemException("El path '" + PATHS[0] + "' no existe");
            }
            Console.WriteLine("> Read Path " + PATHS[0]);

            string[] drugstoreFiles = Directory.GetFiles(PATHS[0]);
            foreach (string file in drugstoreFiles)
            {
                try
                {
                    Console.WriteLine("> File found > " + file);
                    FileInfo fileInfo = new FileInfo(file);
                    new DrugstoreFileProcess(fileInfo, LOG_DIR, PROCESS_DIR).Execute();
                    Console.WriteLine("Processed file > " + file);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            if (!Directory.Exists(PATHS[1]))
            {
                throw new SystemException("El path '" + PATHS[1] + "' no existe");
            }
            Console.WriteLine("> Read Path " + PATHS[1]);

            string[] groceryFiles = Directory.GetFiles(PATHS[1]);
            foreach (string file in groceryFiles)
            {
                try
                {
                    Console.WriteLine("> File found > " + file);
                    FileInfo fileInfo = new FileInfo(file);
                    new GroceryFileProcess(fileInfo, LOG_DIR, PROCESS_DIR).Execute();
                    Console.WriteLine("Processed file > " + file);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
