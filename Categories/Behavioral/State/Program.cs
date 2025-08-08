 StateOrder order = new StateOrder();
 Console.WriteLine($"Current order state: {order.GetState()}");

 order.SetState(new ShippedState());
 Console.WriteLine($"Current order state: {order.GetState()}");