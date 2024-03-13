using System;
namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
		public MongoDataAccess()
		{
		}

        public void LoadData()
        {
           Console.WriteLine("I am reading data from mongo database.");
            List<Product> products = new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from mongo database.");
        }
    }
}

