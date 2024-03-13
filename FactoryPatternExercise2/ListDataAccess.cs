using System;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
		public ListDataAccess()
		{
		}

        void IDataAccess.LoadData()
        {
            Console.WriteLine("I am reading data from list data access.");
            List<Product> products = new List<Product>();
        }

        void IDataAccess.SaveData()
        {
            Console.WriteLine("I am saving data from list data access.");
        }
    }
}

