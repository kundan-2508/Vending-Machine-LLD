using Vending_Machine_LLD;
using Vending_Machine_LLD.State;

public class HasMoneyState : IState
{
    public HasMoneyState()
    {
        Console.WriteLine("Vending machine is in HAS MONEY state");
    }
    public void clickOnInsertCoinButton(VendingMachine vendingMachine)
    {
        throw new NotImplementedException();
    }

    public void insertCoin(VendingMachine vendingMachine, Coin coin)
    {
        throw new NotImplementedException();
    }

    public void clickOnSelectProductButon(VendingMachine vendingMachine)
    {
        throw new NotImplementedException();
    }

    public void chooseProduct(VendingMachine vendingMachine, int codeNumber)
    {
        throw new NotImplementedException();
    }

    public int getChange(int returnChangeMoney)
    {
        throw new NotImplementedException();
    }

    public void dispenseProduct(VendingMachine vendingMachine, int codeNumber)
    {
        throw new NotImplementedException();
    }

    public List<Coin> getFullRefund(VendingMachine vendingMachine)
    {
        throw new NotImplementedException();
    }

    public void updateInenvtory(VendingMachine vendingMachine, Item item, int codeNumber)
    {
        throw new NotImplementedException();
    }
}