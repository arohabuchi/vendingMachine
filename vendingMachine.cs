namespace VendingMachine
{
    class vendingMachine
    {
        public static void Main(string[] args)
        {
            atmclass vend = new atmclass();
            vend.DepositCoin(20);
            vend.DepositCoin(60);
            vend.GetDrink();
            vend.GetRefund();
        }
    }
}