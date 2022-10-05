namespace Module_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var User = GetData();//Запрос ввода данных с клавиатуры.
            ShowData(User);//Выведение данных на экран.
            Console.ReadKey();//Чтобы не закрывалось.
        }

        private static (string Name, string LastName, int Age, bool HasAPet, int PetsCount, string[] Pets, int FavColorsCount, string[] FavColorsList) GetData()	//Метод, возвращающий кортеж
        {
            (string Name, string LastName, int Age, bool HasAPet, int PetsCount, string[] Pets, int FavColorsCount, string[] FavColorsList) User;//кортеж User

            Console.WriteLine("Введите Ваше имя:");
            User.Name = Console.ReadLine();

            int number;
            while(User.Name.Length == 0 || int.TryParse(User.Name, out number) == true)//Проверка: пустое поле или число?
            {
                Console.WriteLine("Некорректные данные, введите имя:");
                User.Name = Console.ReadLine();
            }

            Console.WriteLine("Введите фамилию:");
            User.LastName = Console.ReadLine();

            while(User.LastName.Length == 0 || int.TryParse(User.LastName, out number) == true)//Проверка: пустое поле или число?
            {
                Console.WriteLine("Некорректные данные, введите фамилию:");
                User.LastName = Console.ReadLine();
            }
          
            string result;//проверяемая строка
            do
            {

                Console.WriteLine("Введите Ваш возраст цифрами:");
                result = Console.ReadLine();

            } while(CheckNum(result, out number));//число?

            User.Age = number;//присваивание в кортеж
            User.PetsCount = 0;//присваивание в кортеж по-умолчанию
            do
            {

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                result = Console.ReadLine();

            } while (result != "Да" && result != "Нет" && result != "да" && result != "нет");

            int ammount = 0;
            if (result == "Да" || result == "да")
            {
                User.HasAPet = true;

                do
                {

                    Console.WriteLine("Введите количество питомцев:");
                    result = Console.ReadLine();

                } while(CheckNum(result, out ammount));//число?
                User.PetsCount = ammount;
            }
            else
            {
                User.HasAPet = false;
            }

            User.Pets = GetPetNames(ammount);//Метод, запрашивающий клички животных. Если ammount 0 - идем дальше.
            do
            {

                Console.WriteLine("Введите количество любимых цветов:");
                result = Console.ReadLine();

            } while(CheckNum(result, out ammount));//число?

            User.FavColorsCount = ammount;

            User.FavColorsList = GetFavColors(ammount);//Метод, запрашивающий список любимых цветов.

            var tuple = (Name: User.Name, LastName: User.LastName, Age: User.Age, HasAPet: User.HasAPet, PetsCount: User.PetsCount, Pets: User.Pets, FavColorsCount: User.FavColorsCount, User.FavColorsList);//кортеж
            return tuple;
        }

        static bool CheckNum(string number, out int corrnumber)
        {
            if(int.TryParse(number, out int intnum))
            {
                if(intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            corrnumber = 0;
            return true;

        }

        static string[] GetFavColors(int ammount)//GetFavColors и GetPetNames можно объединить в один метод с доп. параметром определяющим цвета или клички спрашиваются.
        {
            var result = new string[ammount];
            for(int i = 0; i < result.Length; i++)
            {
                do
                { 
                    Console.WriteLine("Ваш любимый цвет номер {0}:", i + 1);
                    result[i] = Console.ReadLine();
                }while (result[i].Length == 0);
            }
            return result;
        }

        static string[] GetPetNames(int ammount)
        {
            var result = new string[ammount];
            for(int i = 0; i < result.Length; i++)
            {
                do
                { 
                    Console.WriteLine("Кличка Вашего питомца номер {0}:", i + 1);
                    result[i] = Console.ReadLine();
                }while (result[i].Length == 0);
            }
            return result;
        }

        static void ShowData((string Name, string LastName, int Age, bool HasAPet, int PetsCount, string[] Pets, int FavColorsCount, string[] FavColorsList)tuple)
        {
            Console.WriteLine("Имя: " + tuple.Name);
            Console.WriteLine("Фамилия: " + tuple.LastName);
            Console.WriteLine("Возраст: " + tuple.Age);
            if(tuple.HasAPet)
            {
                Console.WriteLine("Наличие животных: да");
            }
            else
            {
                Console.WriteLine("Наличие животных: нет");
            }
            for(int i = 0; i <=  tuple.Pets.GetUpperBound(0); i++)
            {
                Console.WriteLine("Животное номер {0}: {1}", i + 1, tuple.Pets[i]);
            }
            for(int i = 0; i <=  tuple.FavColorsList.GetUpperBound(0); i++)
            {
                Console.WriteLine("Ваш любимый цвет номер {0}: {1}", i + 1, tuple.FavColorsList[i]);
            }
        }
    }
}

