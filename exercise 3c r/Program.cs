using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3c_r
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a new Console project and name it Exercise3.C 
            //2.Find the entry point in the Main method. 
            //3.In the main method, add code that asks the user to input the product’s name. 
            //4.Add code that asks the user for the product’s price. 
            //5.Add code that asks the user for the quantity bought. 
            //6.Finally, ask the user if the item is food or not. 
            //7.Calculate the price of the product pre-tax, the amount of tax, and the total including tax. 
            //8.Output the data in a format similar to that above. 
            //---RECEIPT--
            //    - Product: AAA Batteries 
            //    Total amount to pay, excluding tax: 20
            //    Total amount to pay, including tax: 25
            //    Of which is tax: 5
            //    -------------- -

      

            Console.WriteLine("Enter the name of the product");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter the price of the product");
            double productPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the QTY of the product");
            int productQty = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the product food? (y/n)");
            string productType = Console.ReadLine();

            double sum = productQty * productPrice;
            double taxOfTotalSum = sum * 0.25;
            double taxOfProduct = productPrice * 0.25;
            double productWithTax = productPrice * 1.25;
            double totalTaxIncluded = sum * 1.25;
            double taxFood = productPrice * 0.10;
            double taxAllFoodSum = sum * 1.10;
            double taxAllFood = sum * 0.10;
            double taxIncludedFood = productPrice * 1.10;
            switch (productType)
            {
                case "y":
                    Console.WriteLine("-------RECIEPT--------");
                    Console.WriteLine("Product: " + productName);
                    Console.WriteLine("Price:" + productPrice);
                    Console.WriteLine("QTY: " + productQty);
                    Console.WriteLine("Total amount to pay, excluding tax: " + sum);
                    Console.WriteLine("Total amount to pay including tax: " + taxAllFoodSum);
                    Console.WriteLine("Of which is tax: " + taxAllFood);
                    Console.ReadLine();

                    break;

                case "n":
                    Console.Clear();

                    Console.WriteLine("-------RECIEPT--------");
                    Console.WriteLine("Product: " + productName);
                    Console.WriteLine("Price:" + productPrice);
                    Console.WriteLine("QTY: " + productQty);
                    Console.WriteLine("Total amount to pay, excluding tax: " + sum);
                    Console.WriteLine("Total amount to pay including tax: " + totalTaxIncluded);
                    Console.WriteLine("Of which is tax: " + taxOfTotalSum);
                    Console.ReadLine();
                    break;


            }

         
           

        }
    }
}
