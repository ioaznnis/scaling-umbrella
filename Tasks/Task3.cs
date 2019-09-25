using System;
using System.Collections.Generic;

namespace Tasks
{
    public static class Task3
    {
        /// <summary>
        /// Демонстрация работы
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("Задача 3");

            Dictionary<string, List<string>> someData = new Dictionary<string, List<string>>();
            someData["Петр Иванович"] = new List<string>();
            someData["Петр Иванович"].Add("Анна Петровна");
//            someData["Петр Иванович"].Add("Анна Ивановна");
            someData["Петр Иванович"].Add("Максим Петровна");
//            someData["Петр Иванович"].Add("Максим Иванович");
            someData["Максим Иванович"] = new List<string>();
            someData["Максим Иванович"].Add("Андрей Максимович");
            someData["Максим Иванович"].Add("Миша Максимович");
            someData["Максим Иванович"].Add("Николай Максимович");
            someData["Анна Ивановна"] = new List<string>();
            someData["Анна Ивановна"].Add("Артем");
            someData["Николай Максимович"] = new List<string>();
            someData["Николай Максимович"].Add("Катя");
            someData["Николай Максимович"].Add("Маша");
            someData["Анна Ивановна"].Add("Саша");


            Console.WriteLine("Рекурсивно:");

            List<string> lastChilds = new List<string>();
            RecursFillLastChilds("Петр Иванович", someData, lastChilds);
            foreach (var child in lastChilds)
            {
                Console.WriteLine(child);
            }

            Console.WriteLine("Итерационно:");

            foreach (var child in IterationFillLastChilds("Петр Иванович", someData))
            {
                Console.WriteLine(child);
            }
        }

        /// <summary>
        /// Эталонная реализация через рекурсию
        /// </summary>
        /// <param name="parentName"></param>
        /// <param name="someData"></param>
        /// <param name="lastChilds"></param>
        private static void RecursFillLastChilds(string parentName, Dictionary<string, List<string>> someData,
            List<string> lastChilds)
        {
            if (!someData.ContainsKey(parentName))
            {
                lastChilds.Add(parentName);
                return;
            }

            foreach (string child in someData[parentName])
            {
                RecursFillLastChilds(child, someData, lastChilds);
            }
        }

        /// <summary>
        /// Итерационный обход дерева
        /// </summary>
        /// <param name="parentName"></param>
        /// <param name="someData"></param>
        /// <returns></returns>
        private static IEnumerable<string> IterationFillLastChilds(
            string parentName,
            IReadOnlyDictionary<string, List<string>> someData)
        {
            var stack = new Queue<string>(new[] {parentName});

            while (stack.Count > 0)
            {
                var taken = stack.Dequeue();

                if (!someData.ContainsKey(taken))
                {
                    yield return taken;
                }
                else
                {
                    foreach (var child in someData[taken])
                        stack.Enqueue(child);
                }
            }
        }
    }
}