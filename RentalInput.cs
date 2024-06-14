using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project291
{
    public class RentalInput
    {
        public Branch PickUpLocation { get; set; } = new Branch();
        public Branch ReturnLocation { get; set; } = new Branch();
        public DateTime PickupDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public string VehicleType { get; set; } = "";

    }
}
