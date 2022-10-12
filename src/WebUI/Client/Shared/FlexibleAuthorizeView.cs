using Microsoft.AspNetCore.Components;
using RapidBlazor21.WebUI.Shared.Authorization;

namespace RapidBlazor21.WebUI.Client.Shared;

public class FlexibleAuthorizeView : Microsoft.AspNetCore.Components.Authorization.AuthorizeView
{
    [Parameter]
    public Permissions Permissions
    {
        get
        {
            return string.IsNullOrEmpty(Policy) ? Permissions.None : PolicyNameHelper.GetPermissionsFrom(Policy);
        }
        set
        {
            Policy = PolicyNameHelper.GeneratePolicyNameFor(value);
        }
    }
}
