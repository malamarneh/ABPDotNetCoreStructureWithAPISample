using ABPAPISimple.EntityFrameworkCore;

namespace ABPAPISimple.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly ABPAPISimpleDbContext _context;

        public TestDataBuilder(ABPAPISimpleDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}