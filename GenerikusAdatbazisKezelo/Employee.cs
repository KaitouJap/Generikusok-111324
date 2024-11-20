using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikusAdatbazisKezelo
{
    public class Employee : IRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Position}";
        }
    }
}
