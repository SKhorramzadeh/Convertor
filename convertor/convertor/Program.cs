namespace convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str_age;
            int int_age;
            Console.WriteLine("Please enter your age ...");
            str_age = Console.ReadLine();
            int_age = int.Parse(str_age);


            string str_age2;
            str_age2 = int_age.ToString();


            int? small_no = null;
            long? long_no = null;
            long_no = small_no;

            small_no = (int)long_no;



        }

    }
}
