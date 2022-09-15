using EmployeeAPI.Services;
using EmployeeDALirary.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCors")]
    public class EmployeeController : Controller
    {
        IRepo _repo;
        public EmployeeController (IRepo Repo)
        {
            _repo = Repo;
        }
    
        [HttpGet]
        [Route("allDetails")]

        [HttpGet]
        public ActionResult<ICollection<TblProfile>> Get()
        {
            var user = _repo.GetAll();
            if (user == null)
                return NotFound();
            return Ok(user);
        }
        [HttpGet]
        [Route("GetByEmpId")]
        public ActionResult<TblProfile> GetByEmpId(int Eid)
        {
            var user = _repo.GetById(Eid);
            if (user == null)
                return null;
            return Ok(user);
        }

        [HttpPost]
        [Route("CreateRecord")]
        public ActionResult<TblProfile> Post(TblProfile prod)
        {
            var product = _repo.Add(prod);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpDelete]
        [Route("Delete")]

        public ActionResult<TblProfile> Delete(int Eid)
        {
            var product = _repo.GetById(Eid);
            if (product == null)
                return NotFound("No product with the id given is present");
            product = _repo.Delete(Eid);
            return Ok(product);
        }

        [HttpPut]
        [Route("Edit")]

        public ActionResult<TblProfile> Edit(int Eid, TblProfile user)
        {
            var product = _repo.GetById(Eid);
            if (product == null)
                return NotFound("No product with the id given is present");
            product = _repo.update(user);
            return Ok(product);
        }
    }
}
