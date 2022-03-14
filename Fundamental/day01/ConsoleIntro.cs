namespace day01
{
    class ConsoleIntro
    {
        public static void ShowMultiConsole()
        {
            Console.WriteLine("Hello, World!");

            Console.Write(" Code id bootcamp ");

            //02. concat
            Console.WriteLine("Code Academy" + " Bootcamp.Net");

            Console.WriteLine("Code Academy \nC");

            //04 quote
            Console.WriteLine("I love ProgramingC \"C\"");
            //05 verbatim 
            Console.WriteLine(@"I love u Programing
with Bootcamp 
Code Id");
            //formating number parameter
            Console.WriteLine("Tanggal {0} Suhu {1}", DateTime.Now, 73.2);
        }
    }
}