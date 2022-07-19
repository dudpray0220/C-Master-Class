public class Customer
{
    private int customerID;
    protected string customerName;
    private protected double cost;
}

public class Child : Customer
{
    public void Method1()
    {
        customerID = 1;
        customerName = "God bless you";
        cost = 1000;
    }
}

public class Employee
{
    public int employeeID;
    public string employeeName;

    public void Method1()
    {
        customerID = 1;
        cost = 1000;
    }
}