public class Product
{
    // fields
    private int productID;
    protected string productName;
    public double cost;
    public int quantityInStock;
}

public class DomesticProduct : Product
{
    public void Method1 ()
    {
        productID = 1; // not valid
        productName = "god bless you";            
    }
}

public class OtherClass
{
    public void Method1()
    {
        Product product = new Product();
        product.productID = 1; // not valid
        product.productName = "god bless you";
        product.cost = 100;
    }
}