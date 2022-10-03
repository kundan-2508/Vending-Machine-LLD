namespace Vending_Machine_LLD.State
{
    public interface IState
    {
        public void clickOnInsertCoinButton(VendingMachine vendingMachine);
        public void insertCoin(VendingMachine vendingMachine, Coin coin);
        public void clickOnSelectProductButon(VendingMachine vendingMachine);
        public void chooseProduct(VendingMachine vendingMachine, int codeNumber);
        public int getChange(int returnChangeMoney);
        public void dispenseProduct(VendingMachine vendingMachine, int codeNumber);
        public List<Coin> getFullRefund(VendingMachine vendingMachine);
        public void updateInenvtory(VendingMachine vendingMachine, Item item, int codeNumber);

    }
}
