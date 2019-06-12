using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Factory Object
            ElectronicsFactoryAbstract factory = new ElectronicsFactory();
            Mobile mobile = factory.GetMobile();
            Television television = factory.GetTelevision();

            Console.WriteLine("\nYour details are below : \n");
            Console.WriteLine(" Type: {0}\n Name: {1}\n Qauntity: {2}",
                mobile.Name, mobile.Type, mobile.Qauntity);

            Console.WriteLine("\nYour details are below : \n");
            Console.WriteLine(" Type: {0}\n Name: {1}\n ScreenSize: {2}",
                television.Name, television.Type, television.ScreenSize);

            ///Electronic factory object
            ElectronicHandler electronicHandler = new ElectronicHandler();
            ElectronicDetail electronicDetail = electronicHandler.GetElectronicDetail("MOBILE");
            string device = electronicDetail.GetDeviceDetail();

            Console.WriteLine("\nYour details are below : \n");
            Console.WriteLine(" Device Detail : {0}\n", device);

            Console.ReadKey();
        }
    }
}
