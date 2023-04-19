namespace TowersOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TowersOfHanoi(5, "A", "B", "C");
            Console.ReadKey();
        }



        //static void TowersOfHanoi(int adet, string kaynak, string ara, string hedef)
        //{
        //    if (adet == 1)
        //    {
        //        Console.WriteLine($"{kaynak} çubuğundan {hedef} çubuğuna aktar.");
        //        return;
        //    }



        //    TowersOfHanoi(adet - 1, kaynak, hedef, ara);
        //    Console.WriteLine($"{kaynak} çubuğundan {hedef} çubuğuna aktar.");
        //    TowersOfHanoi(adet - 1, ara, kaynak, hedef);
        //}


        static void TowersOfHanoi(int adet, string kaynak, string ara, string hedef)
        {
            if (adet == 1)
            {
                Console.WriteLine($"{kaynak} cubugundan {hedef} cubuga aktar");
                return;
            }

            TowersOfHanoi(adet - 1, kaynak, hedef, ara);
            Console.WriteLine($"{kaynak} cubugundan {hedef} cubuguna aktar");
            TowersOfHanoi(adet - 1, ara, kaynak, hedef);

        }
    }
}
