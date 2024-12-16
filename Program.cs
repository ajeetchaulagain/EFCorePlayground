using System.ComponentModel;
using EFGettingStarted.Data;
using EFGettingStarted.Models;
using Microsoft.IdentityModel.Tokens;

using ContosoPizzaContext context = new ContosoPizzaContext();


/* Product Insert

Product veggieSpecial = new Product()
                        {
                            Name = "Veggies Special Pizza",
                            Price = 9.9M
                        };
context.Products.Add(veggieSpecial);

Product deluxMeat = new Product()
{
    Name = "Deluxe Meat Pizza",
    Price = 12.99M
};

context.Add(deluxMeat);

context.SaveChanges();

*/



/* Fluent API - Quering the Products Table
var products = context.Products.Where(p => p.Price > 10.00M).OrderBy(p => p.Name); 
*/


/* LINQ Syntax - Quering the Products Table
var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;


foreach (var product in products)
{
    Console.WriteLine($"{product.Name} - {product.Id} - {product.Price}");
}
*/

/* Product Update
var veggieSpecialProduct = context.Products.Where(p => p.Name == "Veggies Special Pizza").FirstOrDefault();

if(veggieSpecialProduct is Product)
{
    Console.WriteLine("veggieSpecialProduct is of type product");
    veggieSpecialProduct.Price = 10.99M;
}

context.SaveChanges();

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;


foreach (var product in products)
{
    Console.WriteLine($"{product.Name} - {product.Id} - {product.Price}");
}
*/


/* Product Delete
var veggieSpecialProduct = context.Products.Where(p => p.Name == "Veggies Special Pizza").FirstOrDefault();

if (veggieSpecialProduct is Product)
{
    context.Remove(veggieSpecialProduct);
}

context.SaveChanges();

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;


foreach (var product in products)
{
    Console.WriteLine($"{product.Name} - {product.Id} - {product.Price}");
}
*/
