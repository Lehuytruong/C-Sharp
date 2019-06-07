using System;
using System.Collections.Generic;

namespace Lab.Session3
{
    public class Cart
    {
        private int id;
        private string customer;
        private decimal grand_total;
        private List<Product> productList;
        private string city;
        private string country;


        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public decimal GrandTotal
        {
            get => grand_total;
            set => grand_total = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public void AddProduct(Product p)
        {
            if (productList == null)
            {
                productList = new List<Product>();
            }
            if(p.CheckStock())
            {
                productList.Add(p);
                GrandTotal += p.Price;
                p.Qty--;
                Console.WriteLine("Add product success");
                return;
            }
            Console.WriteLine("Het hang..");
        }

        public void RemoveProduct(Product p)
        {
            productList.Remove(p);
            GrandTotal -= p.Price;
            p.Qty++;
            Console.WriteLine("Remove product success");
        }

        public void getTotal()
        {
            if (Country == "VN")
            {
                if (City == "HN" || City == "HCM")
                {
                    GrandTotal += (GrandTotal * 1 / 100);
                }
                else
                {
                    GrandTotal += (GrandTotal * 2 / 100);
                }
            }
            else
            {
                GrandTotal += (GrandTotal * 5 / 100);
            }
            
            Console.WriteLine("Tong tien: "+GrandTotal);
        }    

        public static void main (string[]args)
        {
            Product p1 = new Product(1,"sp 01", 12000, 1, "haha", "desciription..");
            Product p2 = new Product(2,"sp 02", 10000, 3, "hoho", "desc..");
            
            Cart c1 = new Cart();
            c1.AddProduct(p1);
            c1.AddProduct(p2);
            c1.getTotal();
        
            Cart c2 = new Cart();
            c2.AddProduct(p1);
            c2.AddProduct(p2);
            c2.getTotal();
        }
    }
}