using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lemonaidstand
{
    public class Wallet
    {
            private double amountInWallet;

            public double AmountInWallet
            {
                get
                {
                    return amountInWallet;
                }
                set
                {
                    amountInWallet = value;

                }
            }
        public Wallet()
            {
            amountInWallet = 150;
            }
        public void withdrawCostOfInventory(double price)
        {
            amountInWallet = amountInWallet - price;
        }
    }
}