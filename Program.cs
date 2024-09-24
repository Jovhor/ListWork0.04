using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWork0._04
{
    class Program
    {
        static void Main()
        {
            // Запрашиваем данные о контакте у пользователя
            Console.WriteLine("Введите данные о контакте:");

            Console.Write("ФИО: ");
            string name = Console.ReadLine();

            Console.Write("Улица: ");
            string street = Console.ReadLine();

            Console.Write("Номер дома: ");
            string houseNumber = Console.ReadLine();

            Console.Write("Номер квартиры: ");
            string flatNumber = Console.ReadLine();

            Console.Write("Мобильный телефон: ");
            string mobilePhone = Console.ReadLine();

            Console.Write("Домашний телефон: ");
            string homePhone = Console.ReadLine();

            // Создаем XML с помощью XElement
            XElement contactElement = new XElement("Person",
                new XAttribute("name", name),
                new XElement("Address",
                    new XElement("Street", street),
                    new XElement("HouseNumber", houseNumber),
                    new XElement("FlatNumber", flatNumber)
                ),
                new XElement("Phones",
                    new XElement("MobilePhone", mobilePhone),
                    new XElement("HomePhone", homePhone)
                )
            );

            // Сохраняем XML в файл
            contactElement.Save("contact.xml");

            Console.WriteLine("Данные успешно сохранены в файл contact.xml.");
            Console.ReadKey();
        }
    }
}
