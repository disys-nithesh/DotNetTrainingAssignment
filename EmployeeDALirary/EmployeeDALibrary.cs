using EmployeeDALirary.Models;
using System.Diagnostics;

namespace EmployeeDALirary
{
    public class EmployeeRepo
    {
        dbRecruitContext context;
        public EmployeeRepo()
        {
            context = new dbRecruitContext();

        }
        public ICollection<TblProfile> Get()
        {
            try
            {
                List<TblProfile> products = context.TblProfiles.ToList();
                if (products.Count == 0)
                    return null;
                return products;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + " " + DateTime.Today);
            }
            return null;
        }
        public TblProfile GetById(int id)
        {
            try
            {
                var user = context.TblProfiles.FirstOrDefault(p => p.Id == id);
                return user;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + " " + DateTime.Today);
            }
            return null;
        }
        public TblProfile Add(TblProfile user)
        {
            try
            {
                context.TblProfiles.Add(user);
                context.SaveChanges();       
                return user;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + " " + DateTime.Today);
            }
            return null;
        }
        public TblProfile Delete(int id)
        {
            try
            {
                var _product = GetById(id);
                if (_product == null)
                    return null;
                context.TblProfiles.Remove(_product);
                context.SaveChanges();
                return _product;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + " " + DateTime.Today);
            }
            return null;



        }
        public TblProfile Update(TblProfile user)
        {
            try
            {
                var _user = GetById(user.Id);
                if (_user == null)
                    return null;
                _user.Name = user.Name;
                _user.Age = user.Age;
                _user.Qualification = user.Qualification;
                _user.IsEmployed = user.IsEmployed;
                _user.NoticePeriod = user.NoticePeriod;
                _user.CurrentCtc = user.CurrentCtc;
                _user.Username = user.Username;
                context.SaveChanges();
                return _user;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + " " + DateTime.Today);
            }
            return null;
        }
    }
}
