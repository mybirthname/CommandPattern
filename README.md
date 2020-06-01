# CommandPattern
Consist abstract command, concrete command, receiver and invoker.


Command(ICommand)
	- declares an interface for executing an operation
ConcreteCommand(ProductIncreateAmountCommand, ProductDeacreaseAmountCommand)
	- defines a binding between a Receiver object and an action
	- implements Execute/Undo action by invoking the corresponding operations on receiver
Invoker (ModifyPrice)
	- ask the command to carry out the request
Receiver (Product)
	- knows how to perform the operation associated with carring out the request