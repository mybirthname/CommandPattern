using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class ProductDeacreaseAmountCommand : ICommand
    {
        public Guid ID { get; }
        private readonly Product _product;
        private readonly decimal _amount;

        public ProductDeacreaseAmountCommand(Product product, decimal amount)
        {
            _product = product;
            _amount = amount;
            ID = Guid.NewGuid();
        }


        public void ExecuteAction()
        {
            _product.DecreasePrice(_amount);
        }

        public void UndoAction()
        {
            _product.IncreasePrice(_amount);
        }
    }
}
