using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SafeWater8.Domain.Models {
    public class Contaminant {
        public int Id { get; set; }

        public string Name { get; set; }
        public string HealthEffects { get; set; }
        public string Source { get; set; }

        public IList<Address> Addresses { get; set; }

    }
}