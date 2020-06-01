using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class ProductIncreateAmountCommand : ICommand
    {
        private readonly Product _product;
        private readonly decimal _amount;

        public ProductIncreateAmountCommand(Product product, decimal amount)
        {
            _product = product;
            _amount = amount;
            ID = Guid.NewGuid();
        }

        public Guid ID { get; }

        public void ExecuteAction()
        {
            _product.IncreasePrice(_amount);
        }

        public void UndoAction()
        {
            _product.DecreasePrice(_amount);
        }

    }
}
