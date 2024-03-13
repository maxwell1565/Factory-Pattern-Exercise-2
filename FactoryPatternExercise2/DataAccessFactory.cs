using System;
namespace FactoryPatternExercise2
{
	public static class DataAccessFactory
	{
   

        public static IDataAccess GetDataAccessType(string databaseType)
		{
			switch (databaseType)
			{
				case "List":
					return new ListDataAccess();
				case "Mongo":
					return new MongoDataAccess();
				case "SQL":
					return new SQLDataAccess();
				default:
					return new ListDataAccess();
			}
		}

    }
}

