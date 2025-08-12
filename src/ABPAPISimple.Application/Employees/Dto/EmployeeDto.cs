using Abp.Application.Services.Dto;

namespace ABPAPISimple.Employees.Dto
{
    public class EmployeeDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public decimal Salary { get; set; }
    }
}
