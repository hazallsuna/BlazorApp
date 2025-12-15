using BlazorApp.DataAccess;
using BlazorApp.DataAccess.Entities;
using BlazorApp.Services.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Services
{
    public class EmployeeService
    {
        private readonly AppDbContext dbContext;

        public EmployeeService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            return await dbContext.Employees
                .OrderBy(x => x.FirstName)
                .Select(x => new EmployeeViewModel
                {
                    EmployeeId = x.EmployeeId,
                    Title = x.Title,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    BirthDate = x.BirthDate,
                    Position = x.Position,
                    HireDate = x.HireDate,
                    State = x.State,
                }).ToListAsync();
        }
        public bool CreateNewEmployee(EmployeeViewModel model)
        {
            try
            {
                Employee employee = new Employee
                {
                    Title = model.Title,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    BirthDate = model.BirthDate,
                    Position = model.Position,
                    HireDate = model.HireDate,
                    State = model.State,
                };

                dbContext.Employees.Add(employee);

                var result = dbContext.SaveChanges();
                return result > 0;
            }
            catch (Exception ex) { return false; }
        }

        public EmployeeViewModel FindEmployee(int employeeId)
        {
            var employee = dbContext.Employees.Find(employeeId);
            if (employee == null) return null;

            EmployeeViewModel result = new EmployeeViewModel
            {
                EmployeeId = employee.EmployeeId,
                Title = employee.Title,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                Position = employee.Position,
                HireDate = employee.HireDate,
                State = employee.State,
            };
            return result;
        }
        
        public bool UpdateEmployee(EmployeeViewModel model)
        {
            try
            {
                var employee = dbContext.Employees.Find(model.EmployeeId);
                if (employee == null) return false;
                employee.Title = model.Title;
                employee.FirstName = model.FirstName;
                employee.LastName = model.LastName;
                employee.BirthDate = model.BirthDate;
                employee.Position = model.Position;
                employee.HireDate = model.HireDate;
                employee.State = model.State;

                var result = dbContext.SaveChanges();
                return result > 0;
            }
            catch ( Exception ex)
            {
                return false;
            }
        }

        public bool DeleteEmployee(int employeeId)
        {
            try
            {
                var employee = dbContext.Employees.Find(employeeId);
                if (employee == null) return false;
                dbContext.Employees.Remove(employee);
                var result = dbContext.SaveChanges();
                return result > 0;
            }
            catch (Exception ex) 
            {
                return false;
            }
            
        }
    }
}
