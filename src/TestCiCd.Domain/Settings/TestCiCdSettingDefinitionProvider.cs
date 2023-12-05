using Volo.Abp.Settings;

namespace TestCiCd.Settings;

public class TestCiCdSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TestCiCdSettings.MySetting1));
    }
}
