namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database will you be using List, SQL or Mongo");
            var databaseType = Console.ReadLine();
            var myNewListType = DataAccessFactory.GetDataAccessType(databaseType);

            myNewListType.LoadData();
            myNewListType.SaveData();
            

          
        }
    }
}