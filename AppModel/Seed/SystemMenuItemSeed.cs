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
    internal class SystemMenuItemSeed
    {
        public static void CreateSystemMenuItemSeed(Entities1 context)
        {
            context.SystemMenuItems.AddOrUpdate(p => p.Id,
                new SystemMenuItem1 { Id = 1, NameEn = "OrderManagement", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "" },
                new SystemMenuItem1 { Id = 2, NameEn = "Entry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "" },
                new SystemMenuItem1 { Id = 3, NameEn = "OrderEntry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "/OrderManagement/Entry/OrderEntry.xaml" },
                new SystemMenuItem1 { Id = 4, NameEn = "MasterManagement", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "" },
                new SystemMenuItem1 { Id = 5, NameEn = "Entry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "" },
                new SystemMenuItem1 { Id = 6, NameEn = "CategorieEntry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "/MasterManagement/Entry/CategorieEntry.xaml" },
                new SystemMenuItem1 { Id = 7, NameEn = "DepartmentEntry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "" },
                new SystemMenuItem1 { Id = 8, NameEn = "CustomerEntry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "/MasterManagement/Entry/CustomerEntry.xaml" },
                new SystemMenuItem1 { Id = 9, NameEn = "EmployeeEntry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "/MasterManagement/Entry/EmployeeEntry.xaml" },
                new SystemMenuItem1 { Id = 10, NameEn = "ProductsEntry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "/MasterManagement/Entry/ProductsEntry.xaml" },
                new SystemMenuItem1 { Id = 11, NameEn = "RegionEntry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "/MasterManagement/Entry/RegionEntry.xaml" },
                new SystemMenuItem1 { Id = 12, NameEn = "ShippersEntry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "/MasterManagement/Entry/ShippersEntry.xaml" },
                new SystemMenuItem1 { Id = 13, NameEn = "SuppliersEntry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "/MasterManagement/Entry/SuppliersEntry.xaml" },
                new SystemMenuItem1 { Id = 14, NameEn = "TerritoriesEntry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "/MasterManagement/Entry/TerritoriesEntry.xaml" },
                new SystemMenuItem1 { Id = 15, NameEn = "UserEntry", NameJa = "joby", NameCh = "adas", NameTh = "fgdgdf", NameClass = "fdgdfg", NameMy = "Hello joby", ImageIcon = new byte[1], PageUri = "/MasterManagement/Entry/UserEntry.xaml" }
                );

        }
    }
}
