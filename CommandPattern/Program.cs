using System;

namespace CommandPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var invoiker = new ModifyPrice();
            var receiver = new Product("Bike", 200);

            ICommand increaseCommand = new ProductIncreateAmountCommand(receiver, 50);
            ICommand decreaseCommand = new ProductDeacreaseAmountCommand(receiver, 20);

            invoiker.Invoike(increaseCommand);
            invoiker.Invoike(decreaseCommand);
            invoiker.Undo(increaseCommand);

            Console.WriteLine(receiver.ToString()); 
        }
    }
}
