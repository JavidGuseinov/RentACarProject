using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetByIdTest();


            //GetAllTest();


        
        }


        private static void GetAllTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " " + car.ModelYear);
            }
        }

        private static void GetByIdTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetById())
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}
