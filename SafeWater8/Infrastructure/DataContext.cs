using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SafeWater8.Domain.Models;
using SafeWater8.Models;
using System.Data.Entity;

namespace SafeWater8.Infrastructure {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false) {
        }

        public static ApplicationDbContext Create() {
            return new ApplicationDbContext();

        }
        public IDbSet<Contaminant> Contaminants { get; set; }

        public IDbSet<Address> Addresses { get; set; }
    }
}