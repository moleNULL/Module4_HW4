/*
                                                      Задача

                        Необхідно додати міграції до проекту домашнього завдання Module4_HW3

Критерії:
    ● Повинна бути обов'язково InitialCreate міграція
    ● Додати ще одну міграцію, яка включає:
        ● створення таблиці Client (Мінімум 5 полів)
        ● заповнення таблиці Client даними (Мінімум 5 записів)
        ● заповнення таблиці Project (Мінімум 5 полів)
        ● додати до таблиці Project Foreign Key ClientId NOT NULL

 */

namespace EFCore_AddMigrations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Starter.Run();

            Console.Write("\nPress any key to continue . . .");
            Console.ReadLine();
        }
    }
}