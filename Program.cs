namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> zadachi = new List<string>();
            while (true)
            {
               
                Console.WriteLine("=== TaskManager ===\n1) Добави \n2) Покажи \n3) Изход");
                string option = Console.ReadLine();
                switch (option)              
                {
                    case "1":
                        Console.WriteLine("Въведи задачата:");
                        string zadacha = Console.ReadLine();
                        zadachi.Add(zadacha);
                        Console.Clear();
                        break;

                    case "2":
                        foreach (string zadachavspisuk in zadachi)
                            Console.WriteLine(zadachavspisuk);                        
                        break;

                    case "3":
                        Console.WriteLine("Изход");                      
                        break;

                    default:
                        Console.WriteLine("Error!");                        
                        break;
                               }
            }
            /*Console.Write("Заглавие:");
            string title = Console.ReadLine();

            Console.Write("Описание:");
            string discription = Console.ReadLine();

            Console.Write("Приоритет 1=Low/2=Medium/3=High:");
            string strpriority = Console.ReadLine();
            int priority = int.Parse(strpriority);

            Console.Write("Спешна ли е задачата yes/no  :");
            string strstatus = Console.ReadLine();
            bool isUrgent = false;

            if (strstatus.ToLower() == "yes")
                isUrgent = true;
            

            Console.Write("Колко часа ще отнеме:");
            string strnumber = Console.ReadLine();
            int number =  int.Parse(strnumber);
            int grade = number * 60;

            string priorityName = "";
            string strisUrgent = "";
            switch (priority)
            {
                case 1:
                    priorityName = "Low";
                    break;
                case 2:
                    priorityName = "Medium";
                    break;
                case 3:
                    priorityName = "High";
                    break;
                default:
                    priorityName = "Грешка: приоритетът е число от 1 до 3!";
                                break;
            }
            switch (isUrgent)
            {
                case true:
                    strisUrgent = "True";
                    break;
                case false:
                    strisUrgent = "False";    
                    break;               
            }

            Console.WriteLine($"Задача: {title}");
            Console.WriteLine($"Описание: {discription}");
            Console.WriteLine($"Приоритет: {priorityName}");
            Console.WriteLine($"Статус: {strisUrgent}");
            Console.WriteLine($"Число: {number}часа");
            Console.WriteLine($"Оценка: {grade}минути");

            if (priorityName == "High" && isUrgent == true)
            {
                Console.WriteLine("Зарежи всичко и почвай СЕГА!");
            }
            else if (priorityName == "Low" && isUrgent != true)
            {
                Console.WriteLine("Тази може да почака до уикенда.");
            }
            else
            { 
                Console.WriteLine("Сложи я в плана за тази седмица.");
            } */
        }
           
    }
}
    