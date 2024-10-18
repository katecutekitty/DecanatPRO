using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EntityRepository : IRepository<Student>
    {

     public DataContext _context;

        public EntityRepository(DataContext context) {
            _context = context;
        }

        public void Create(Student obj)
        {
            _context.Set<Student>().Add(obj);
            _context.SaveChanges();
        }

        public void Delete(Student obj)
        {
            _context.Set<Student>().Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Student> ReadAll()
        {
            return new List<Student>(_context.Set<Student>());
        }

        public Student ReadById(int id)
        {
            throw new NotImplementedException();
        }

        //public void Update(Student obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
