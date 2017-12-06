using AppModel.Model;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModel.Seed
{
    internal class SystemMenuTreeSeed
    {
        public static void CreateSystemMenuTreeSeed(Entities1 context)
        {
            context.SystemMenuTrees.AddOrUpdate(p => p.Id,
                new SystemMenuTree1 { Id = 1, PId = 0, DisplayIndex = 0, SystemMenuItemId = 1 },
                new SystemMenuTree1 { Id = 2, PId = 1, DisplayIndex = 1, SystemMenuItemId = 2 },
                new SystemMenuTree1 { Id = 3, PId = 2, DisplayIndex = 2, SystemMenuItemId = 3 },
                new SystemMenuTree1 { Id = 4, PId = 0, DisplayIndex = 3, SystemMenuItemId = 4 },
                new SystemMenuTree1 { Id = 5, PId = 4, DisplayIndex = 4, SystemMenuItemId = 5 },
                new SystemMenuTree1 { Id = 6, PId = 5, DisplayIndex = 5, SystemMenuItemId = 6 },
                new SystemMenuTree1 { Id = 7, PId = 0, DisplayIndex = 14, SystemMenuItemId = 7 },
                new SystemMenuTree1 { Id = 8, PId = 5, DisplayIndex = 6, SystemMenuItemId = 8 },
                new SystemMenuTree1 { Id = 9, PId = 5, DisplayIndex = 7, SystemMenuItemId = 9 },
                new SystemMenuTree1 { Id = 10, PId = 5, DisplayIndex = 8, SystemMenuItemId = 10 },
                new SystemMenuTree1 { Id = 11, PId = 5, DisplayIndex = 9, SystemMenuItemId = 11 },
                new SystemMenuTree1 { Id = 12, PId = 5, DisplayIndex = 10, SystemMenuItemId = 12 },
                new SystemMenuTree1 { Id = 13, PId = 5, DisplayIndex = 11, SystemMenuItemId = 13 },
                new SystemMenuTree1 { Id = 14, PId = 5, DisplayIndex = 12, SystemMenuItemId = 14 },
                new SystemMenuTree1 { Id = 15, PId = 5, DisplayIndex = 13, SystemMenuItemId = 15 }
                );
        }
    }
}
