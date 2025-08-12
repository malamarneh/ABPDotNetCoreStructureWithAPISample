using System.Threading.Tasks;
using ABPAPISimple.Web.Controllers;
using Shouldly;
using Xunit;

namespace ABPAPISimple.Web.Tests.Controllers
{
    public class HomeController_Tests: ABPAPISimpleWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
