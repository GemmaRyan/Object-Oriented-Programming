namespace Part_1_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Name = "gemma";
            employee.HourlyRate = 26;
            employee.Gender = "female";
            employee.Nationality = "American";

            Console.WriteLine(employee.ToString());

            //Employee employee2 = new Employee();

            Console.WriteLine(employee.Nationality);

        }
    }
}
