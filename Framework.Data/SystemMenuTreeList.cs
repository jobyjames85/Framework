using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Data
{
    public class SystemMenuTreeList
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public string NameEn { get; set; }
        public string NameJa { get; set; }
        public string NameTh { get; set; }
        public string NameCh { get; set; }
        public string NameClass { get; set; }
        public int DisplayIndex { get; set; }
        public byte[] ImageIcon { get; set; }
        public string PageUri { get; set; }

        public SystemMenuTreeList() { }

        public SystemMenuTreeList(int id, int pid, string nameen, string nameja, string nameth, string namezn, string nameclass, int displayindex, byte[] imageicon, string pageuri)
        {
            Id = id;
            PId = pid;
            NameEn = nameen;
            NameJa = nameja;
            NameTh = nameth;
            NameCh = namezn;
            NameClass = nameclass;
            DisplayIndex = displayindex;
            ImageIcon = imageicon;
            PageUri = pageuri;
        }
    }
}
