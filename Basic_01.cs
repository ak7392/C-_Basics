using System; 

namespace AbhinavKannojia {
    class Basics {
        
        public static string title = "C# essential training";
        public static int whichpart;
        
        static void Main(string[] args)
        {
            whichpart = 20; 
            var message = string.Format("Welcome to {0} containing Part {1}", title, whichpart);
            Console.WriteLine(message);
            Console.WriteLine("Press enter to exit"); 
            Console.ReadLine();

        }
    }
}