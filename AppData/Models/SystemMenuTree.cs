using System;
using System.Collections.Generic;

namespace AppData.Models
{
    public partial class SystemMenuTree
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int DisplayIndex { get; set; }
        public int SystemMenuItemId { get; set; }
    }
}
