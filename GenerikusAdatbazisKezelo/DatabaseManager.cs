using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikusAdatbazisKezelo
{
    public class DatabaseManager<V> where V : IRecord
    {
        Dictionary<int, V> database = new Dictionary<int, V>();

        public void AddRecord(V record)
        {
            database.Add(record.Id,record);
        }

        public void RemoveRecord(int recordId)
        {
            
            if (!database.Remove(recordId))
            {
                throw new KeyNotFoundException();
            }
        }

        public V GetRecord(int recordId)
        {
            if(database.TryGetValue(recordId, out V value))
            {
                return value;
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public void PrintDatabase()
        {
            foreach (KeyValuePair<int, V> record in database)
            {
                Console.WriteLine(record.Value.ToString());
            }
        }
    }
}
