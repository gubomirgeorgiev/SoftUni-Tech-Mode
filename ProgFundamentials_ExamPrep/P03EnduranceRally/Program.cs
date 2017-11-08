using System;
using System.Collections.Generic;
using System.Linq;


class P03EnduranceRally
{
    static void Main()
    {
        string[] drivers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double [] zones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        int[] checkPoint = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        List<Driver> driversResult = new List<Driver>();
        drivers = drivers.Distinct().ToArray();
        foreach (string name in drivers)
        {
            driversResult.Add(new Driver()
            {
                DriverName = name,
                Fuel = name[0],
                Index = 0,
                Gas = 0
            });
        }
        foreach (Driver driver in driversResult)
        {
            for (int i = 0; i < zones.Length; i++)
            {
                if (!checkPoint.Contains(i))
                {
                    driver.Index = i;
                    if (driver.Fuel == 0)
                    {
                        driver.Index = i;
                        break;
                    }
                    else if (driver.Fuel > 0)
                    {
                        driver.Gas = zones[i];
                        driver.Fuel = driver.FuelLeft();
                    }
                    if (driver.Fuel <= 0)
                    {
                        driver.Index = i;
                        break;
                    }
                }
                else
                {
                    driver.Gas = -zones[i];
                    driver.Fuel = driver.FuelLeft();
                }
            }
            if(driver.Fuel <= 0)
            {
                Console.WriteLine($"{driver.DriverName} - reached {driver.Index}");
            }
            else
            {
                Console.WriteLine($"{driver.DriverName} - fuel left {driver.Fuel:F2}");
            }
        } 
    }

    class Driver
    {
        public double Fuel { get; set; }
        public double Gas { get; set; }
        public int Index { get; set; }
        public string DriverName { get; set; }
        public double FuelLeft()
        {
            return Fuel - Gas;
        }
    }
}








