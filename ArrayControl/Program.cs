namespace ArrayControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Array Section.");
            //string[] cars = {"Volvo", "BMW","Ferrari","Audi","Honda","Chevrolet" };
            //cars[2] = "Tata";
            Console.WriteLine("Enter the numbers you wish to create an array of");
            int input = int.Parse(Console.ReadLine());

            int[] nums = new int[input];

            for (int i = 0; i < nums.Length; i++)
            {
                bool validInput = false;

                while (!validInput) 
                {
                    Console.WriteLine("Enter {0} value of Array", i);
                    try
                    {
                        nums[i] = int.Parse(Console.ReadLine());
                        validInput = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter only Numeric Value");
                        Console.WriteLine("Please provide a valid input to continue: ");

                    }
                }
                    
            }

            Console.WriteLine("Given array -> ");
            foreach (int i in nums)
            {
                Console.Write(i+ " ");
            }

            Console.WriteLine("\n");
            ArrayLength(nums);
            ArraySort(nums);

            Console.Write("\n------------------------------------------------------------------------------------------");


            //OddArray(nums);
            //EvenArray(nums);

            //foreach (string car in cars)
            //{
            //    Console.Write("{0} ",car); // to print in same line
            //    //Console.WriteLine(car); // to print in multiple line
            //}

            //ArrayLoop();



            

            Console.Read();
        }

        public static void ArrayLoop()
        {
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i * i;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Elements-{0} = {1}", j, nums[j]);
            }

            Console.Read();
        }

        public static void OddArray(int[] array)
        {
            Console.WriteLine("Odd numbers");
            for(int z=0; z<array.Length;  z++)
            { 
                if (array[z]%2!=0)
                {
                    Console.WriteLine(array[z]);
                }
            }
        }
        
        public static void EvenArray(int[] array)
        {
            Console.WriteLine("Even  numbers");
            for(int y=0; y<array.Length; y++)
            {
                if (array[y]%2==0)
                {
                    Console.WriteLine(array[y]);
                }
            }
        }

        public static void ArrayLength(int[] array)
        {
            int count = 0;
            foreach(int c in array)
            {
                count++;

            }
            Console.WriteLine("Length of array is ->{0}",count);
        }
        
        public static void ArraySort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j=0; j<array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("array sorted");
            foreach(int c in array)
            {
                Console.Write(c + " ");
            }

        }
    }
}
