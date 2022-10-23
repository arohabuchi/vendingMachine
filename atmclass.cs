namespace VendingMachine
{
    class atmclass
    {
        public int DepositedAmount { get; set; }
        
        public atmclass()
        {
            DepositedAmount = 0;
        }
        public void DepositCoin(int coinAmount)
        {
            DepositedAmount += coinAmount;
        }
        public void GetDrink()
        {
            if (DepositedAmount<75 )
            {
                Console.WriteLine("insuficient fund, try adding more coin.");
            }else
            {
                Console.WriteLine("Your Change is {0} cent", DepositedAmount-75);
                DepositedAmount =0;
            }
        }
        public void GetRefund()
        {
            Console.WriteLine("Take Your fund {0}", DepositedAmount);
            DepositedAmount =0;
        }
    }
}