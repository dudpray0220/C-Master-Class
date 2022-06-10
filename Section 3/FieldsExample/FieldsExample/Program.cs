class Sample
{
    static void Main()
    {
        // create reference variable
        Product product1, product2, product3;

        // create Objecs
        product1 = new Product();
        product2 = new Product();
        product3 = new Product();

        // initialize fields
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;
        
        product2.productID = 1002;
        product2.productName = "LapTop";
        product2.cost = 45000;
        product2.quantityInStock = 3400; 
        
        product3.productID = 1003;
        product3.productName = "Speakers";
        product3.cost = 30000;
        product3.quantityInStock = 2200;

        // print fields
        System.Console.WriteLine("Product1");
        System.Console.WriteLine("productID: " + product1.productID);
        System.Console.WriteLine("productName: " + product1.productName);
        System.Console.WriteLine("cost: " + product1.cost);
        System.Console.WriteLine("quantityInStock: " + product1.quantityInStock);

        System.Console.WriteLine("\nProduct2");
        System.Console.WriteLine("productID: " + product2.productID);
        System.Console.WriteLine("productName: " + product2.productName);
        System.Console.WriteLine("cost: " + product2.cost);
        System.Console.WriteLine("quantityInStock: " + product2.quantityInStock);

        System.Console.WriteLine("\nProduct3");
        System.Console.WriteLine("productID: " + product3.productID);
        System.Console.WriteLine("productName: " + product3.productName);
        System.Console.WriteLine("cost: " + product3.cost);
        System.Console.WriteLine("quantityInStock: " + product3.quantityInStock);

        System.Console.ReadKey();
    }
}