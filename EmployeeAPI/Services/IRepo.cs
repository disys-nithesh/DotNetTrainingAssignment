using EmployeeDALirary.Models;

namespace EmployeeAPI.Services
{
    public interface IRepo
    {
        //Create
        public TblProfile Add(TblProfile user);



        //Read
        public ICollection<TblProfile> GetAll();



        //Update
        public TblProfile update(TblProfile user);



        //GetById
        public TblProfile GetById(int id);



        //Delete
         public TblProfile Delete(int id);
    }
}
