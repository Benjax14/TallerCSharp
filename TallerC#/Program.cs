namespace TallerC_
{
    public class Program
    {
        static void Main(string[] args)
        {

            var data = new Data();

            data.Poblate();

            //data.Show();

            Person person = Exercises.AgedRut(data.Persons);

            Console.WriteLine($"Oldest Rut is for {person.Name}, {person.Rut} ");
        }
    }
}