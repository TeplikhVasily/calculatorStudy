using CalculatorDB.Models;

namespace CalculatorDB.Models
{
    public class Operation : IEntity 
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long OwnerId { get; set; }

    }

}
