using TestCiCd.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TestCiCd.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TestCiCdController : AbpControllerBase
{
    protected TestCiCdController()
    {
        LocalizationResource = typeof(TestCiCdResource);
    }
}
