using System;
namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
		public SQLDataAccess()
		{
		}

        void IDataAccess.LoadData()
        {
            Console.WriteLine("I am reading data from sql data access.");
            List<Product> products = new List<Product>();
        }

        void IDataAccess.SaveData()
        {
            Console.WriteLine("I am saving data from sql data access.");
        }

    }

}

