using System;

 public class Restaurant
 {
    // variables
    private string name;
    private string address;
    private double discountRate;

    //properties
    public string Name
    {
        get { return name;}
        set { name = value;}
    }
    public string Address
    {
        get { return address;}
        set { address = value;}
    }

    public double DiscountRate
    {
        get { return discountRate;}
        set 
        { 
            if (value > 0 )
             {
                discountRate = value;
            }
        }
    }
        // constructors
    public Restaurant( string name, string address, double discountRate)
    {
        Name = name;
        Address = address;
        DiscountRate = discountRate;
    }

    public void MakeSalesReciept()
    {
        double price = 0;
        double subtotal = 0;
        double discountAmount = 0;
        double finalTotal = 0;
        int people = 0;

        while( price != -1)
        {
           subtotal = subtotal + price;
            Console.Write("What is the price of the item bought?: [press -1 to quite]  ");
            price = Convert.ToDouble(Console.ReadLine());
            
        }
        Console.Write("How many people have attended?:  ");
        people = Convert.ToInt32(Console.ReadLine());

        if ( people >= 4)
        {
            discountAmount = subtotal * discountRate;
        }
        finalTotal = subtotal + discountAmount;

        Console.WriteLine( " Subtotal: {0: c}", subtotal);
        Console.WriteLine( " {0:P} Discount: {1:c}", discountRate, discountAmount);
        Console.WriteLine( " Fine Total : {0:c}", finalTotal);

    }




 }

