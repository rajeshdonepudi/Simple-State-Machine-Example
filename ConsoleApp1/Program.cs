public enum OrderStateEnum
{
    Created = 1,
    Shipped,
    InTransit,
    OutForDelivery,
    Delivered
}

class Order
{
    public OrderStateEnum State { get; private set; } = OrderStateEnum.Created;
    public List<string> ActivityLogs { get; private set; } = new List<string>();

    public void Ship()
    {
        if (State == OrderStateEnum.Created)
        {
            State = OrderStateEnum.Shipped;

            LogActivity(State);
        }
    }

    public void InTransit()
    {
        if (State == OrderStateEnum.Shipped)
        {
            State = OrderStateEnum.InTransit;

            LogActivity(State);
        }
    }

    public void OutForDelivery()
    {
        if (State == OrderStateEnum.InTransit)
        {
            State = OrderStateEnum.OutForDelivery;

            LogActivity(State);
        }
    }

    public void Delivered()
    {
        if (State == OrderStateEnum.OutForDelivery)
        {
            State = OrderStateEnum.Delivered;

            LogActivity(State);
        }
    }

    private void LogActivity(OrderStateEnum state)
    {
        ActivityLogs.Add($"Order moved to state {state} Time: {DateTime.UtcNow.ToLongTimeString()}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var members = Type.GetType(nameof(OrderStateEnum))!.GetEnumNames();

        var phoneOrder = new Order();

        Console.WriteLine("Order created.");

        phoneOrder.Ship();

        Thread.Sleep(1000);

        phoneOrder.InTransit();

        Thread.Sleep(1000);

        phoneOrder.OutForDelivery();

        Thread.Sleep(1000);

        phoneOrder.Delivered();

        foreach (var log in phoneOrder.ActivityLogs)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(log);

            Console.ResetColor();

            for (int i = 0; i < log.Length; i++)
            {
                Console.Write("_");
            }

            Console.WriteLine();
        }
    }
}

