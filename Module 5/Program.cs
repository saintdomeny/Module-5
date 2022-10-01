namespace Module_5
{
    internal class Program
    {
        class MainClass 
        {  
            static void Main(string[] args)
            {

                var arr = new int[] { 1, 2, 4, 3, 5 };
                var data = 5;
                SortArray(in arr,out int[] outputdesc,out int[] outputasc);

                Console.WriteLine("Desc:");

                foreach(int item in outputdesc)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("ASC:");

                foreach(int item in outputasc)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("FIN");
		        BigDataOperation(arr, ref data);

		        Console.WriteLine(data);
                Console.ReadKey();
                /*var someName = "Евгения";
                Console.WriteLine(someName);

                GetName(ref someName);

                Console.WriteLine(someName);

                Console.ReadKey();
                */
                /*var (name, age) = ("Евгения", 27);

		        Console.WriteLine("Мое имя: {0}", name);
		        Console.WriteLine("Мой возраст: {0}", age);

		        Console.Write("Введите имя: ");
		        name = Console.ReadLine();
		        Console.Write("Введите возрас с цифрами:");
		        age = Convert.ToInt32(Console.ReadLine());

		        Console.WriteLine("Ваше имя: {0}", name);
		        Console.WriteLine("Ваш возраст: {0}", age);

                var array = GetArrayFromConsole(10);//5.2.18
                ShowArray(array, true);

                foreach(var item in array)
                {
                    Console.WriteLine(item);
                }
                var sortedarray = SortArray(array);

                var favcolors = new string[3];//string[] favcolors = new string[3];
                for(int i = 0; i < favcolors.Length; i++)
                {
                    favcolors[i] = ShowColor(name, age);
                }

                ShowColors(favcolors[0],favcolors[2]);
                Console.ReadKey();*/
            }
	        static void BigDataOperation(int[] array, ref int data)
	        {
                data = 4;
		        array[0] = 4;
	        }
            static void GetName(ref string name)
            {
                Console.WriteLine("Введите имя:");
                name = Console.ReadLine();
            }
            /*static void ShowArray(int[] array, bool IsSort = false)//5.2.17
            {
                var temp = array;
                if(IsSort)
                {
                    temp = SortArray(array);
                }
                foreach(int item in temp)
                {
                    Console.WriteLine(item);
                }    
            }*/
            static int[] GetArrayFromConsole(int num = 5) 
            {
                var result = new int[num];

                for (int i = 0; i < result.Length; i++) 
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }
                return result;
            }
            static int[] SortArrayAsc(int[] array)
            {
                for(int i = 0; i < array.Length;i++)
                {
                    for(int j = i + 1; j < array.Length;j++)
                    {
                        if (array[i] > array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                return array;
            }
            static int[] SortArrayDesc(int[] array)
            {
                for(int i = 0; i < array.Length;i++)
                {
                    for(int j = i + 1; j < array.Length;j++)
                    {
                        if (array[i] < array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                return array;
            }
            static void SortArray(in int[] arr, out int[] sorteddesc, out int[] sortedasc)
            {
                int[] array2 = new int[5];
                Array.Copy(arr,array2, 5);

                sortedasc = SortArrayAsc(arr);
                sorteddesc = SortArrayDesc(array2);
            }
            static void ShowColors(string username, params string[] favcolors) 
            {
                Console.WriteLine("Ваши любимые цвета:");
                foreach(var color in favcolors) 
                {
                Console.WriteLine(color);
                }
            }
 	        static string ShowColor(string username, int userage)
	        {
                Console.WriteLine("{0}, {1} лет\nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
                var color = Console.ReadLine();

                switch (color) {
                case "red":
                  Console.BackgroundColor = ConsoleColor.Red;
                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.WriteLine("Your color is red!");
                  break;

                case "green":
                  Console.BackgroundColor = ConsoleColor.Green;
                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.WriteLine("Your color is green!");
                  break;
                case "cyan":
                  Console.BackgroundColor = ConsoleColor.Cyan;
                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.WriteLine("Your color is cyan!");
                  break;
                default:
                  Console.BackgroundColor = ConsoleColor.Yellow;
                  Console.ForegroundColor = ConsoleColor.Red;

                  Console.WriteLine("Your color is yellow!");
                  break;
                }    

                return color;        
            }    

        }
    }
}

               /* (string Name, string[] Dishes) User;//4.5.1
                Console.WriteLine("Введите имя:");
                User.Name = Console.ReadLine();

                User.Dishes = new string[5];
                for(int i = 0; i < User.Dishes.Length; i++)
                {
                    Console.WriteLine("Ваше любимое блюдо номер {0}:", i + 1);
                    User.Dishes[i] = Console.ReadLine();
                }

                Console.ReadKey();*/
            //4.5
            /*
            (string Name, string LastName, string Login, int LoginLength, bool HasAPet, double Age, string[] favcolors) User;//4.5.1

            for (int j = 0; j < 3; j++)//4.5.6
            {
                Console.WriteLine("Введите имя:");//4.5.2
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию:");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин:");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;//4.5.3

                Console.WriteLine("Есть ли у вас животные? Да или Нет");//4.5.4
                var result = Console.ReadLine();

                if (result == "Да")
                {
                    User.HasAPet = true;
                }
                else
                {
                    User.HasAPet = false;
                }

                Console.WriteLine("Ведите ваш возраст:");//4.5.5
                User.Age = Convert.ToDouble(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }
            */        