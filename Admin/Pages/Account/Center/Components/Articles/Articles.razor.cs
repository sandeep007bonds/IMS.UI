using System.Collections.Generic;
using Admin.Models;
using Microsoft.AspNetCore.Components;

namespace Admin.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}