
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEmployee(int id)
        {
            var employeeDeleted = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (employeeDeleted == null)
            {
                throw new Exception($"Employee with Id:{id} is not found");
            }
            _context.Employees.Remove(employeeDeleted);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetEmployeeById(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }
    }
}
