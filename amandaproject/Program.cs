using System;

namespace amandaproject
{
    class Program
    {
     
        static void Main(string[] args)
        {
            //Основые типы: int, uint | float| char | string |
            //Целочисленные
            byte b; //0 до 255
            sbyte sb; // -128 до 127 
            short sh; //-32768 до 32767
            ushort us; //0 до 65535
           // int i;   //-2147483648 до 2147483647
            uint ui;//0 до 4294967295
            long ln; //
            ulong ul;
            //числа с плавающей точкой
            float fl = 5.7f;  //7 знаков
            double db = 5.7; //15 знаков
            //символьный тип
            char ch = '!';
            //строковые
            string str = "Привет, как дела?";
            //логические
            bool bl = false;

            //int age;
            //age = 5;
           // age = 3;
           // age = 6;




            //арифметические операторы
            // + - * / %
            //float itog;
            //int x = 5, y = 2;
            //itog = Convert.ToSingle(x) / y;    //Tosingle  for  float

            //Console.WriteLine(itog);
            //expected outputa 2.5


            //%
            //int time = 130;
            //int chas = time / 60;
            //int min = time % 60;
            //Console.WriteLine(chas);
            //Console.WriteLine(min);
            //expected outputa 2chas  10min



           // int age = 18;
            //age /= 1;

            //int itog;
            //itog = 5 + (5 + 2) * 2 - 2 + 2 / 2;



            /////////////логические операторы
            // == != > >=  <= <
            int ages = 18;
            bool isDoorOpen = ages >= 18;
            Console.WriteLine(isDoorOpen);
            //expected output: true






            ///////////// Конкатенация
            string str1 = "Привет!";
            string name = "Бакай";
            string str2 = str1 + name;
            Console.WriteLine(str2 + "!  Рад тебя видеть.");
            //expected output: Привет!Бакай!  Рад тебя видеть.





            int agea = 5;
            Console.WriteLine(5 + 5 + "Привет! Тебе завтра испольнится " + (agea + 1));
            //expected output: 10Привет! Тебе завтра испольнится 6





            /////////  интерполяция
            string names = "Bakai";
            int agess = 19;
            Console.WriteLine("Ваше имя " + names + ". Вам " + agess + " Лет");
            Console.WriteLine($"Ваше имя {names} . Вам {agess} лет");
            //expected output: Ваше имя Bakai . Вам 19 лет











            ///////////////     Конвертация
          //  int agee;
            //string strrr = "15";
            //agee = Convert.ToInt32(strrr);
            //Console.WriteLine(agee);


            bool a = Convert.ToBoolean(1);
            Console.WriteLine(a);
            int j = Convert.ToInt32(a);
            Console.WriteLine(j);





            //// робота с консолью
            string namme;
            int ageee;
            Console.Write("Введите ваше имя:");
            //namme = Console.ReadLine();
            Console.Write("Введите ваш возраст:");
         //   ageee = Convert.ToInt32(Console.ReadLine());

          //  Console.WriteLine("Вас завут " + namme + ", вам - " + ageee + " лет.");
            //expected outputa: Вас завет Бакай, вам - 19 лет.





            //// 11 11 инкремент и декремент
            int f = 0;
            Console.WriteLine(f++);
            Console.WriteLine(f--);


            int A = 0;
            //                 1    + 2 + 1 +  1    + "1" +  3    * 2
            Console.WriteLine((++A) + 2 + 1 + (A++) + "1" + (++A) * 2);
            //expected outputa: 516



            //12lesson практика

            //float health;
            //int armor;
            //int damage;

            //Console.Write("Введите кол-во жизней:");
            //health = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во брони");
            //armor = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во урона");
            //damage = Convert.ToInt32(Console.ReadLine());


            //health -= Convert.ToSingle(damage) / 100 * armor;

            //Console.WriteLine("После атака в " + damage + " урона, у вас осталось " +
            //    health + " жизней");




            //практика2 магазин

            int money; 
            int eatCount;
            int eatPrice = 10;
            bool enoughtMoney;


            //Console.WriteLine("Добро пожаловать в пекарню! Сегодня еда по " + eatPrice + " Монет.");
            //Console.Write("Сколько у вас золото:");
            //money = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Сколько еда вам нужна:");
            //eatCount = Convert.ToInt32(Console.ReadLine());

            //enoughtMoney = money >= eatCount * eatPrice;

            //eatCount *= Convert.ToInt32(enoughtMoney);

            //money -= eatCount * eatPrice;

            //Console.WriteLine("У вас в сумке - " + eatCount + " еды и " + money + " Монет.");



            //  Lesson13/1   условный оператор
            //int aaage;
            //Console.Write("Введите ваш возраст:");
            //aaage = Convert.ToInt32(Console.ReadLine());
            //if(aaage >= 18){
            //    Console.WriteLine("Добро пожаловать в наш клуб.");
            //    Console.WriteLine("Что бутеде пить");
            //}
            //else
            //{
            //    Console.WriteLine("Вы слишком юны");
            //    Console.WriteLine("Приходиты сюда через" + (18 - aaage) + " лет.");
            //}


            //string day;

            //Console.WriteLine("Введите день недели");
            //day = Console.ReadLine();


            //if (day == "понедельник")
            //{
            //    Console.WriteLine("Приходим курсы");
            //}
            //else if(day == "Вторник") {
            //    Console.WriteLine("Делаем дз на курсах");
            //}



            //Lesson 14/2   Логическое И и ИЛИ

            //     &&
            // X | Y | X&&Y        //умножить
            // 1 | 1 |  1
            // 1 | 0 |  0
            // 0 | 1 |  0
            // 0 | 0 |  0

            //    ||
            // X | Y | X||Y       //добавить +
            // 1 | 1 |  1
            // 1 | 0 |  1
            // 0 | 1 |  1
            // 0 | 0 |  0



            ///Lesson 15/3 Услорный оператор switch


            //string day;
            //day = Console.ReadLine();

            //switch (day)
            //{
            //    case "субота":
            //    case "воскрисение":
            //    case "понедельник":
            //        Console.WriteLine("Eдем в кино");
            //        Console.WriteLine("Едем попкоры"); 
            //        break;
            //    case "вторник":
            //        Console.WriteLine("Пройди курс");
            //        break;

            //    case "Среда":
            //        Console.WriteLine("Пройди курс");
            //        break;
            //    case "Четверг":
            //        Console.WriteLine("Едем в бар");
            //        break;

            //    default:
            //        Console.WriteLine("Я такого дня не знаю");
            //        break;
            //}
            //if (day == "понеделник" ||  day == "Воскрисение"  || day == "субота")
            //{

            //}





            //Lesson 16/4   практика с условными операторами

            //string password = "spr-120";
            //string Input;

            //Console.Write("Введите пароль: ");
            //Input = Console.ReadLine();

            //if(Input == password)
            //{
            //    Console.WriteLine("Информация о процедуре 110-монтук");
            //}
            //else
            //{
            //    Console.WriteLine("Летальный момагент запущен");
            //}





            //практика 2

            //int rubToUsd = 56, usdToRub = 66;

            //float rub;
            //float usd;
            //string userInput;
            //float currencyCount;

           

            //Console.WriteLine("Добро пожаловать в обменник валют. У нас вы можете обменять рубли в доллары и доллары в рубли");

            //Console.Write("Введите баланс рублей:");
            //rub = Convert.ToSingle(Console.ReadLine());
            //Console.Write("Введите баланс доллар:");
            //usd = Convert.ToSingle(Console.ReadLine());


            //Console.WriteLine("1 - обменять рубли на доллары");
            //Console.WriteLine("2 - Обменять доллары на рубли");
            //userInput = Console.ReadLine(); 


            //switch (userInput)
            //{
            //    case "1":
            //        Console.WriteLine("Обменять рублей на доллары");
            //        Console.Write("Сколько вы хотите обмнять?;");
            //        currencyCount = Convert.ToSingle(Console.ReadLine());
            //        if (rub >= currencyCount)
            //        {
            //            rub -= currencyCount;
            //            usd += currencyCount / rubToUsd;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Недопустумое кол-во рублей");
            //        }
            //        break;

            //    case "2":
            //        Console.WriteLine("Обмен доллары на рбули");
            //        Console.Write("Сколько вы хотите обменять");
            //        currencyCount = Convert.ToSingle(Console.ReadLine());
            //        if(usd >= currencyCount)
            //        {
            //            usd -= currencyCount;
            //            usd += currencyCount * usdToRub;
            //        }
               
            //        break;
            //}
            //Console.WriteLine("Ваш баланс  " + rub + " рублей и " + usd + " долларов.");



            //lesson 17/5   цикл while


            //int age = 10;

            //while(age-- > 0)
            //{
            //    if(age == 5)
            //    {
            //        break;  //5
            //        //continue;   10
            //     }
            //    Console.WriteLine("Hypy birthday to you!");
                 
            // }





            ///////???????  Lesson 18 / 6    цикл for
           
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


       }
    }
} 
