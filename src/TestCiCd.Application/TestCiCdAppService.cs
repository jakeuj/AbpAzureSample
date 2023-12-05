using System;
using System.Collections.Generic;
using System.Text;
using TestCiCd.Localization;
using Volo.Abp.Application.Services;

namespace TestCiCd;

/* Inherit your application services from this class.
 */
public abstract class TestCiCdAppService : ApplicationService
{
    protected TestCiCdAppService()
    {
        LocalizationResource = typeof(TestCiCdResource);
    }
}
