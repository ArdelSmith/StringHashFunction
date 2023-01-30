namespace StringHashFunction
{
    public static class Program
    {
        public static void Main()
        {
            HashGenerator h = new HashGenerator() { Password  = "1ываdcr343"};
            Console.WriteLine(h.GenerateHash("C5"));
            Console.WriteLine(h.GenerateHash("zk.,k.fkbye"));
            Console.WriteLine(h.GenerateHash("cnfcvjkjltw"));
            Console.WriteLine(h.GenerateHash("dctvGhbDTTTTN!!!D"));
            Console.WriteLine(h.GenerateHash("C524uhyc67qwhu jqtp,wr9m-f0iej4h204um "));
        }
    }
}