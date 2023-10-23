namespace getTotalX
{
    public class ElectronicsShop
    {
        public static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {

            int maxPurchaseValue = -1;

            for(int i = 0; i < keyboards.Length; i++)
            {
                for(int j = 0; j < drives.Length; j++)
                {
                    int actualPurchase = keyboards[i] + drives[j];
                    if(actualPurchase <= b && actualPurchase > maxPurchaseValue)
                    {
                        maxPurchaseValue = actualPurchase;
                    }
                }
            }

            return maxPurchaseValue;

        }
    }
}
