using System;

public class RestaurantTest
{
    public static void Main(string[] args)
    {
        RestaurantAndBar objt = new RestaurantAndBar("moonstar", " 8787 Kampala rd", .12);
       
       Console.WriteLine("{0}",objt.Name);
       Console.WriteLine("{0}",objt.Address);

        objt.MakeSalesReciept();
    }
}