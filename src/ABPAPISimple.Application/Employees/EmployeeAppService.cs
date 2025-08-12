using Abp.Application.Services;
using ABPAPISimple.Employees.Dto;
using System.Collections.Generic;

namespace ABPAPISimple.Employees
{
    public class EmployeeAppService : ABPAPISimpleAppServiceBase, IApplicationService
    {
        public List<EmployeeDto> GetAllEmployees()
        {
            //Call here from the database
            return new List<EmployeeDto>
            {
                new EmployeeDto { Id = 1, Name = "Mohammad ALASA'AD", Email = "malasaad@example.com", Number = "627802408", Salary = 3000 },
                new EmployeeDto { Id = 2, Name = "Roberto Carlos", Email = "rcarlos@example.com", Number = "123456789", Salary = 5000 },
                new EmployeeDto { Id = 3, Name = "karim Benzema", Email = "kbenzema@example.com", Number = "987654321", Salary = 5500 }
            };
        }
    }
}
