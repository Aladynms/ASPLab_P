using ASPLab_P.Mappers;
using Data;
using Data.Entities;

namespace ASPLab_P.Models
{
    public class EFEmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;

        public EFEmployeeService(AppDbContext employeeService)
        {
            _context = employeeService;
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(EmployeeMapper.ToEntity(employee));
            _context.SaveChanges();
        }

        public List<Employee> FindAll()
        {
            return _context
                .Employees
                .Select(e => EmployeeMapper.FromEntity(e))
                .ToList();
        }

        public Employee? FindById(int id)
        {
            var entity = _context.Employees.Find(id);
            if (entity is not null)
            {
                return EmployeeMapper.FromEntity(entity);
            }
            return null;
        }

        public void DeleteById(int id)
        {
            var entity = _context.Employees.Find(id);
            if (entity != null)
            {
                _context.Employees.Remove(entity);
                _context.SaveChanges();
            }
        }

        public void Edit(Employee employee)
        {
            _context.Employees.Update(EmployeeMapper.ToEntity(employee));
            _context.SaveChanges();
        }
    }
}
