using EmployeeDALirary;
using EmployeeDALirary.Models;

namespace EmployeeAPI.Services
{
    public class EmpolyeeRepository : IRepo
    {
        EmployeeRepo _ERepo;

        public EmpolyeeRepository()
        {
            _ERepo = new EmployeeRepo();
        }
        /*public TblProfile Add( TblProfile user)
        {
            return _ERepo.Add(user);
        }
        public TblProfile Delete( int id)
        {
            return (_ERepo.Delete(id));
        }*/
        public ICollection<TblProfile> Get()
        {
            throw new NotImplementedException();
        }

        public ICollection<TblProfile> GetAll()
        {
            return _ERepo.Get();
        }
        public TblProfile GetById(int id)
        {
            return _ERepo.GetById(id);
        }
        public TblProfile Add(TblProfile product)
        {
            return _ERepo.Add(product);
        }

        public TblProfile Delete(int id)
        {
            return (_ERepo.Delete(id));
        }

        public TblProfile update(TblProfile product)
        {
            return _ERepo.Update(product);
        }
    }
}
