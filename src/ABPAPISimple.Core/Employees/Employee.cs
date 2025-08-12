using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace ABPAPISimple.Employees
{
    public class Employee : Entity<int>//FullAuditedEntity<int> (Full Audited Entity is to automatically full details of the creater, modifier user)
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public decimal Salary { get; set; }
    }
}
