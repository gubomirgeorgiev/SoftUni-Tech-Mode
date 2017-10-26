using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07AndreyAndBilliard
{
    class Entity
    {
        public string Product { get; set; }
        public double Price { get; set; }
    }

    class Orders
    {
        public string Person { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int amountOfEntities = int.Parse(Console.ReadLine());
            List<Entity> menu = new List<Entity>();
            while (amountOfEntities-- > 0)
            {
                Entity chech = ProductInfo();
                if (menu.Select(x => x.Product).Contains(chech.Product))
                {
                    foreach (var item in menu)
                    {
                        if(item.Product== chech.Product)
                        {
                            item.Price = chech.Price;
                        }
                    }
                        }
                        else
                        {
                            menu.Add(chech);
                        }

            }
            string order = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> orderList = new SortedDictionary<string, Dictionary<string, int>>();
            List<Orders> listOfOrders = new List<Orders>();
            while (order!="end of clients")
            {
                listOfOrders.Add(OrderType(order));
                foreach (var item in listOfOrders)
                {
                    if (!orderList.ContainsKey(item.Person))
                    {
                        foreach (var itemM in menu)
                        {
                            if (item.Product == itemM.Product)
                            {
                                orderList[item.Person]=new Dictionary<string, int>();
                                orderList[item.Person].Add(item.Product, item.Quantity);
                            }
                        }
                    }
                    else
                    {
                        foreach (var itemM in menu)
                        {
                            if (itemM.Product.Contains(item.Product))
                            {
                                if (orderList[item.Person].ContainsKey(item.Product))
                                {
                                    orderList[item.Person][item.Product] += item.Quantity;
                                }
                                else
                                {
                                    orderList[item.Person].Add(item.Product, item.Quantity);
                                }
                            }
                        }
                    }
                    
                }
                listOfOrders.Clear();
                order = Console.ReadLine();
            }
            double total = 0;
            foreach (string name in orderList.Keys)
            {
                Console.WriteLine(name);
                double sum = 0.0;
                foreach (var oredrs in orderList[name])
                {
                    Console.WriteLine($"-- {oredrs.Key} - {oredrs.Value}");
                    double[] doubleParse = menu.Where(x => x.Product.Equals(oredrs.Key)).Select(y =>  y.Price ).OfType<double>().ToArray();
                    sum += oredrs.Value * doubleParse[0];
                }
                Console.WriteLine($"Bill: {sum:F2}");
                total += sum;
                sum = 0.0;
            }
            Console.WriteLine($"Total bill: {total:F2}");
        }

        static Entity ProductInfo()
        {
            string[] info = Console.ReadLine().Split('-').ToArray();
            Entity entityOutput = new Entity()
            {
                Product = info.First(),
                Price = double.Parse(info.Skip(1).First())
            };
            return entityOutput;
        }

        static Orders OrderType(string input)
        {
            string[] PersonOrder = input.Split('-');
            string[] info = new string[3]
            {
                PersonOrder[0],
                PersonOrder[1].Split(',').First(),
                PersonOrder[1].Split(',').Skip(1).First()
            };
            Orders orderInfo = new Orders()
            {
                Person = info[0],
                Product = info[1],
                Quantity = int.Parse(info[2])
            };
            return orderInfo;
        }
    }
}
