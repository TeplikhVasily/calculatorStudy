using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDB.Models
{
    public interface IEntity
    {
        long Id { get; set; }
    }
}
