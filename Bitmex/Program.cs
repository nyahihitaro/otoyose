using BitMEX;
using System;


namespace Test
{
    internal class Program1
    {
        private static string bitmexKeyX = "HgvxdCY0u0JiX-bTa8onkqiT";
        private static string bitmexSecretX = "-4KYHaZ31iLbzS28ErvS5V63LkzAoYxvtZm8j3Y9L0MUTEtb";

        private static string bitmexKeyY = "Kxfc2-V1RLHj35JDNYIUVufo";
        private static string bitmexSecretY = "JPh6z0R1qFI_NxcblKz7eIj2HwW8ofaDLgLUIBDlIvD39zI0";



        private static void Main(string[] args)
        {
            Program1 p = new Program1();
            p.Run(args);
        }

        private void Run(string[] args)
        {
            BitMEXApi bitmexx = new BitMEXApi(bitmexKeyX, bitmexSecretX);
            // var orderBook = bitmex.GetOrderBook("XBTUSD", 3);
            var orders = bitmexx.GetOrders();
            // var orders = bitmex.DeleteOrders();
            Console.WriteLine(orders);
            Buy(bitmexx);
            Read(bitmexx);
            Order(bitmexx);
            Trade(bitmexx);

            var quotex = bitmexx.CurrentQuote();
            Console.WriteLine("Current bidPrice " + quotex[0]["bidPrice"]);


            BitMEXApi bitmexy = new BitMEXApi(bitmexKeyY, bitmexSecretY);

            var quotey = bitmexy.CurrentQuote();
            Console.WriteLine("Current askPrice " + quotey[0]["askPrice"]);
            double a = double.Parse(quotey[0]["askPrice"]);
            double b = a + 10.0;
            int c = 20;

            bitmexx.OrderX(a,b,c);

        }

        private void Buy(BitMEXApi api)
        {
            Console.WriteLine(api.Readprice());
        }

        private void Read(BitMEXApi liquidation)
        {
            Console.WriteLine(liquidation.Currentprice());
        }

        private void Order(BitMEXApi order)
        {
            Console.WriteLine(order.Order());
        }

        private void Trade(BitMEXApi trade)
        {
            Console.WriteLine(trade.Trade());
        }

    }

}
