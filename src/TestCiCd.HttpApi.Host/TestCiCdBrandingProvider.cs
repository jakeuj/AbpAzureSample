using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TestCiCd;

[Dependency(ReplaceServices = true)]
public class TestCiCdBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestCiCd";
}
