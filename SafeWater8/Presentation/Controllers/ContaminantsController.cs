using SafeWater8.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SafeWater8.Presentation.Controllers {
    public class ContaminantsController : ApiController {
        private ContaminantService _contaminantService;

        public ContaminantsController(ContaminantService cServe) {
            _contaminantService = cServe;
        }

        public IList<ContaminantDTO> Get() {
            return _contaminantService.List();
        }

        public ContaminantDTO Get(int id) {
            return _contaminantService.Find(id);
        }

        public HttpResponseMessage Post(ContaminantDTO ctmnt) {
            if (ModelState.IsValid) {
                _contaminantService.Add(ctmnt);
                return Request.CreateResponse(HttpStatusCode.Created, ctmnt);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }

        public void Put(ContaminantDTO ctmnt) {
            _contaminantService.Update(ctmnt);
        }
        public void Delete(int id) {
            _contaminantService.Delete(id);
        }
    }
}
