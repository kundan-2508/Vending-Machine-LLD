using Vending_Machine_LLD.State;

namespace Vending_Machine_LLD
{
    public  class VendingMachine
    {
        IState vendingMachineState;
        Inventory inventory;
        List<Coin> coinList;
        public VendingMachine()
        {
            vendingMachineState = new IdleState();
            inventory = new Inventory(10);
            coinList = new List<Coin>();
        }

        public IState getVendingMachineState()
        {
            return this.vendingMachineState;
        }

        public void setVendingMachineState(IState vendingMachineState)
        {
            this.vendingMachineState = vendingMachineState;
        }

        public Inventory getInventory()
        {
            return this.inventory;
        }

        public void setInventory(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public List<Coin> getCoinList()
        {
            return this.coinList;
        }

        public void setCoinList(List<Coin> coinList)
        {
            this.coinList = coinList;
        }
    }
}
