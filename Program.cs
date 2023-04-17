namespace tråd2
{
    internal class Program
    {
        static char ch = '*';
        static void Main(string[] args)
        {
            Thread p = new Thread(output);
            p.Name = "Print";
            p.Start();


            Thread r = new Thread(input);
            r.Name = "Reader";
            r.Start();

            p.Join();
            r.Join();

            Console.ReadKey();

        }

        static void input()
        {
            while (true)
            {
                ch = Console.ReadKey().KeyChar;
            }
        }

        static void output()
        {
            while (true)
            {
                Thread.Sleep(500);
                Console.Write(ch);
            }
        }
    }
}