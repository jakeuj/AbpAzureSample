using TestCiCd.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TestCiCd.Permissions;

public class TestCiCdPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TestCiCdPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TestCiCdPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TestCiCdResource>(name);
    }
}
