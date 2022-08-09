using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Operations.Shared.Models
{
 

    public class Operationss
    {
        public int OperationID { get; set; }
        public string Name { get; set; }
        public int OrderToPerform { get; set; } 
        public byte[] ImageData { get; set; }
        public string Device { get; set; }
    }
}
