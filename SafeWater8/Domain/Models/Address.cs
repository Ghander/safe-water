using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SafeWater8.Domain.Models {
    public class Address {
        public int Id { get; set; }

        public string Zip { get; set; }

        public IList<Contaminant> Cantaminants { get; set; }
    }
}