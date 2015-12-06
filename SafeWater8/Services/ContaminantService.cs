using AutoMapper;
using CoderCamps.Data.Repository;
using SafeWater8.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SafeWater8.Services.Models {
    public class ContaminantService {
        private IRepository _repo;

        public ContaminantService(IRepository repo) {
            _repo = repo;
        }
        public IList<ContaminantDTO> List() {
            return Mapper.Map<List<ContaminantDTO>>((from m in _repo.Query<Contaminant>()
                                                     select m).ToList());
        }
        public void Add(ContaminantDTO ctmnt) {
            _repo.Add(Mapper.Map<Contaminant>(ctmnt));
            _repo.SaveChanges();
        }
        public ContaminantDTO Find(int id) {
            return Mapper.Map<ContaminantDTO>(FindInternal(id));
        }
        private Contaminant FindInternal(int id) {
            return (from c in _repo.Query<Contaminant>()
                    where c.Id == id
                    select c).FirstOrDefault();
        }
        public void Update(ContaminantDTO ctmnt) {
            var dbCtmnt = FindInternal(ctmnt.Id);
            Mapper.Map(ctmnt, dbCtmnt);
            _repo.SaveChanges();
        }
        public void Delete(int id) {
            var dbContaminant = FindInternal(id);

            _repo.Delete(Mapper.Map<Contaminant>(dbContaminant));
            _repo.SaveChanges();
        }
    }
}