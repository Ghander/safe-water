using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SafeWater8.Services.Models {
    public class AddressDTO {
        public int Id { get; set; }

        public string Zip { get; set; }

        public IList<ContaminantDTO> Cantaminants { get; set; }
    }
}